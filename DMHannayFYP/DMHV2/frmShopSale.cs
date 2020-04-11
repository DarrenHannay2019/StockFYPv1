using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class frmShopSale : Form
    {
        public string FormMode { get; set; }
        public int LoggedInUser { get; set; }
        private DateTime OldDate { get; set; }
        public frmShopSale()
        {
            InitializeComponent();
        }

        private void cmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvRecords.Rows.Add();
            DgvRecords.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[1].Value = txtDelivered.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[2].Value = txtSoldToDate.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[3].Value = txtCurrentQty.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[4].Value = txtQty.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[5].Value = txtNetSale.Text.TrimEnd();
            Totals();
            TxtStockCode.Clear();
            txtDelivered.Clear();
            txtSoldToDate.Clear();
            txtCurrentQty.Clear();
            txtQty.Clear();
            txtNetSale.Clear();
        }

        private void cmdDelToGrid_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in DgvRecords.SelectedRows)
            {
                DgvRecords.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            clsShopSaleHead saleHead = new clsShopSaleHead();
            clsShopSaleLine saleLine = new clsShopSaleLine();
            clsLogs logs = new clsLogs();
            
            saleHead.ShopRef = txtShopRef.Text.TrimEnd();
            saleHead.ShopName = lblShopName.Text.TrimEnd();
            saleHead.MovementDate = Convert.ToDateTime(DateTimePicker1.Value);
            saleHead.Value = Convert.ToDecimal(txtTotal.Text);
            saleHead.Qty = Convert.ToInt32(txtTotalGarments.Text.TrimEnd());
            saleHead.VATRate = Convert.ToDecimal(txtVAT.Text);
            saleHead.UserID = LoggedInUser;
            saleLine.SalesID = saleHead.GetLastShopSaleHead();
            logs.StockCode = "ALL";
            logs.SupplierRef = "ALL";
            logs.LocationRef = saleHead.ShopRef;
            logs.Qty = saleHead.Qty;
            logs.RecordType = "Sales Add-Start";
            logs.MovementDate = saleHead.MovementDate;
            logs.StringMovementType = "Sales Add";
            logs.UserID = saleHead.UserID;
            logs.Reference = "Sales ID: [" + saleHead.SalesID.ToString() + "]";
            logs.SaveToSysLogTable();
            if (FormMode == "New")
            {
                for (int a = 0; a< DgvRecords.Rows.Count; a++)
                {
                    saleLine.StockCode = DgvRecords.Rows[a].Cells[0].Value.ToString();
                    saleLine.DeliveredQtyGarments = Convert.ToInt32(DgvRecords.Rows[a].Cells[1].Value.ToString());
                    saleLine.CurrentQty = Convert.ToInt32(DgvRecords.Rows[a].Cells[2].Value.ToString());                    
                    saleLine.TotalItems = Convert.ToInt32(DgvRecords.Rows[a].Cells[3].Value.ToString());
                    saleLine.Qty = Convert.ToInt32(DgvRecords.Rows[a].Cells[4].Value.ToString());
                    saleLine.SalesAmount = Convert.ToDecimal(DgvRecords.Rows[a].Cells[5].Value.ToString());
                    saleLine.SaveShopSaleLine();    // Save to database
                    logs.LocationRef = saleHead.ShopRef;
                    logs.MovementDate = saleHead.MovementDate;
                    logs.StockCode = saleLine.StockCode;
                    logs.Qty = saleLine.Qty;
                    logs.StringMovementType = "Shop Sale Add-Item";
                    logs.RecordType = "Sale Record [" + logs.StockCode + "]";
                    logs.MovementDate = saleHead.MovementDate;
                    logs.UserID = saleHead.UserID;
                    logs.MovementType = 5;
                    logs.LocationType = 2;
                    logs.Reference = logs.Reference;
                    logs.TransferReference = saleLine.SalesID;
                    logs.DeliveredQtyGarments = logs.Qty;
                    logs.DeliveredQtyBoxes = 0;
                    logs.DeliveredQtyHangers = logs.DeliveredQtyBoxes;
                    logs.SupplierRef = "";  // Add function to clsStock to get the supplier Ref from the table.
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();                  
                } 
                logs.DeleteZeroQtyFromStockMovementsTable();
                logs.StockCode = "ALL";
                logs.SupplierRef = "ALL";
                logs.LocationRef = saleHead.ShopRef;
                logs.Qty = saleHead.Qty;
                logs.RecordType = "Sales Add-End";
                logs.MovementDate = saleHead.MovementDate;
                logs.StringMovementType = "Sales Add";
                logs.UserID = saleHead.UserID;
                logs.Reference = "Sales ID: [" + saleHead.SalesID.ToString() + "]";
                logs.SaveToSysLogTable();
            }
            else
            {
                logs.MovementType = 5;
                logs.TransferReference = Convert.ToInt32(txtSalesID.Text.TrimEnd());
                logs.MovementDate = OldDate;
                logs.DeleteFromStockMovemmentsTable();
                logs.StockCode = "ALL";
                logs.SupplierRef = "ALL";
                logs.LocationRef = saleHead.ShopRef;
                logs.Qty = saleHead.Qty;
                logs.RecordType = "Sales Update-Start";
                logs.MovementDate = saleHead.MovementDate;
                logs.StringMovementType = "Sales Update";
                logs.UserID = saleHead.UserID;
                logs.Reference = "Sales ID: [" + saleHead.SalesID.ToString() + "]";
                logs.SaveToSysLogTable();
                for (int a = 0; a < DgvRecords.Rows.Count - 1; a++)
                {
                    saleLine.StockCode = DgvRecords.Rows[a].Cells[0].Value.ToString();
                    saleLine.DeliveredQtyGarments = Convert.ToInt32(DgvRecords.Rows[a].Cells[1].Value.ToString());
                    saleLine.CurrentQty = Convert.ToInt32(DgvRecords.Rows[a].Cells[2].Value.ToString());
                    saleLine.TotalItems = Convert.ToInt32(DgvRecords.Rows[a].Cells[3].Value.ToString());
                    saleLine.Qty = Convert.ToInt32(DgvRecords.Rows[a].Cells[4].Value.ToString());
                    saleLine.SalesAmount = Convert.ToDecimal(DgvRecords.Rows[a].Cells[5].Value.ToString());
                    saleLine.UpdateShopSaleLine();    // Save to database
                    logs.LocationRef = saleHead.ShopRef;
                    logs.MovementDate = saleHead.MovementDate;
                    logs.StockCode = saleLine.StockCode;
                    logs.Qty = saleLine.Qty;
                    logs.StringMovementType = "Shop Sale Update";
                    logs.RecordType = "Sale Record [" + logs.StockCode + "]";
                    logs.MovementDate = saleHead.MovementDate;
                    logs.UserID = saleHead.UserID;
                    logs.MovementType = 5;
                    logs.LocationType = 2;
                    logs.Reference = "Sale-Update-Item";
                    logs.TransferReference = saleLine.SalesID;
                    logs.DeliveredQtyGarments = logs.Qty;
                    logs.DeliveredQtyBoxes = 0;
                    logs.DeliveredQtyHangers = logs.DeliveredQtyBoxes;
                    logs.SupplierRef = "";  // Add function to clsStock to get the supplier Ref from the table.
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
                logs.StockCode = "ALL";
                logs.SupplierRef = "ALL";
                logs.LocationRef = saleHead.ShopRef;
                logs.Qty = saleHead.Qty;
                logs.RecordType = "Sales Update-End";
                logs.MovementDate = saleHead.MovementDate;
                logs.StringMovementType = "Sales Update";
                logs.UserID = saleHead.UserID;
                logs.Reference = "Sales ID: [" + saleHead.SalesID.ToString() + "]";
                logs.SaveToSysLogTable();
            }
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtShopRef_Leave(object sender, EventArgs e)
        {
            txtShopRef.Text = clsShop.ChangeCase(txtShopRef.Text, 1);
            clsShop Shop = new clsShop()
            {
                ShopRef = txtShopRef.Text.TrimEnd()
            };
            lblShopName.Text = Shop.GetShopName();
            LoadSalesGrid();
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {
            TxtStockCode.Text = clsUtils.ChangeCase(TxtStockCode.Text, 1);
            txtCurrentQty.Text = "0";
            txtSoldToDate.Text = "0";
            txtDelivered.Text = "0";
            txtQty.Select();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox1.Checked == false)
            {
                txtCurrentQty.Enabled = false;
                TxtStockCode.Enabled = false;
                txtDelivered.Enabled = false;
                txtSoldToDate.Enabled = false;
                txtNetSale.Enabled = false;
                txtQty.Enabled = false;
            }
            else
            {
                TxtStockCode.Enabled = true;
                txtNetSale.Enabled = true;
                txtQty.Enabled = true;
            }
        }

        private void frmShopSale_Load(object sender, EventArgs e)
        {
            LoadShopsIntoForm();
            LoadStockIntoForm();
            if (FormMode == "New")
            {
                cmdOK.Text = "Save";
                this.Text = "New Shop Sale";
            }
            else
            {
                cmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadShopsIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT ShopRef from tblShops", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            txtShopRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtShopRef.AutoCompleteCustomSource = ACSC;
            txtShopRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadStockIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT StockCode from tblStock", conn);
                adp.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtStockCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtStockCode.AutoCompleteCustomSource = ACSC;
            TxtStockCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        public void Totals()
        {
            // 0 = StockCode
            // 1 = Delivered
            // 2 = Sold
            // 3 = CurrentQty
            // 4 = QtySold
            // 5 = SalesAmount
            int Delivered = 0;
            int Sold = 0;
            int CurrentQty = 0;
            int QtySold = 0;
            double SalesAmount = 0.0;   
            for (int i = 0; i < DgvRecords.Rows.Count; i++)
            {
                Delivered += Convert.ToInt32(DgvRecords.Rows[i].Cells[1].Value);
                Sold += Convert.ToInt32(DgvRecords.Rows[i].Cells[2].Value);
                CurrentQty += Convert.ToInt32(DgvRecords.Rows[i].Cells[3].Value);
                QtySold += Convert.ToInt32(DgvRecords.Rows[i].Cells[4].Value);
                SalesAmount += Convert.ToDouble(DgvRecords.Rows[i].Cells[5].Value);
                DgvRecords.Columns[5].DefaultCellStyle.Format = "C2";
            }
            txtTotalDelivered.Text = Delivered.ToString();
            txtTotalSold.Text = Sold.ToString();
            txtTotalCurrQty.Text = CurrentQty.ToString();
            txtTotalGarments.Text = QtySold.ToString();
            double VATAMount = 0.0;
            VATAMount = SalesAmount / 5;
            double PreVAT = 0.0;
            PreVAT = SalesAmount - VATAMount;
            txtNetSale.Text = PreVAT.ToString("C");
            txtVAT.Text = VATAMount.ToString("C");
            txtTotal.Text = SalesAmount.ToString("C");         
        }
        private void LoadData()
        {
            int ShopSalesID = Convert.ToInt32(txtSalesID.Text);
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopSalesHead = new DataTable();
                SqlDataAdapter ShopSalesDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblShopSales WHERE SalesId = @SalesId";
                    SelectCmd.Parameters.AddWithValue("@SalesId", ShopSalesID);
                    ShopSalesDataAdapter.SelectCommand = SelectCmd;
                    ShopSalesDataAdapter.Fill(ShopSalesHead);
                }
                txtShopRef.Text = ShopSalesHead.Rows[0][1].ToString();
                lblShopName.Text = ShopSalesHead.Rows[0][2].ToString(); 
                DateTimePicker1.Value = Convert.ToDateTime(ShopSalesHead.Rows[0][3]);
                OldDate = DateTimePicker1.Value;
                txtTotalSold.Text = ShopSalesHead.Rows[0][4].ToString();
                decimal convert = 0.0m;
                convert = Convert.ToDecimal(ShopSalesHead.Rows[0][6]);
                txtTotal.Text = convert.ToString("C");
                decimal VatConvert = 0.0m;
                VatConvert = Convert.ToDecimal(ShopSalesHead.Rows[0][5]);
                txtVAT.Text = VatConvert.ToString("C");
            }
            DgvRecords.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopSalesLine = new DataTable();
                SqlDataAdapter ShopSalesLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, DeliveredQty, CurrentQty, TotalSoldQty, QtySold, SalesAmount from tblShopSalesLines WHERE SalesID = @SalesID";
                    SelectCmd.Parameters.AddWithValue("@SalesID", ShopSalesID);
                    ShopSalesLineDataAdapter.SelectCommand = SelectCmd;
                    ShopSalesLineDataAdapter.Fill(ShopSalesLine);
                    DgvRecords.DataSource = ShopSalesLine;
                    DgvRecords.AutoGenerateColumns = true;
                    DgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    DgvRecords.BackgroundColor = Color.LightCoral;
                    DgvRecords.DefaultCellStyle.SelectionBackColor = Color.Red;
                    DgvRecords.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                    DgvRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    DgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    DgvRecords.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    DgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DgvRecords.AllowUserToResizeColumns = false;
                    DgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DgvRecords.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                    DgvRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                    DgvRecords.Columns[0].HeaderText = "Stock Code";
                    DgvRecords.Columns[1].HeaderText = "Delivered Qty";
                    DgvRecords.Columns[2].HeaderText = "Current Qty";
                    DgvRecords.Columns[3].HeaderText = "Total Sold Qty";
                    DgvRecords.Columns[4].HeaderText = "Qty";
                    DgvRecords.Columns[5].HeaderText = "Sales Amount";
                    
                }
            }
            Totals();
        }
        private void LoadSalesGrid()
        {
            DgvRecords.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopSalesLine = new DataTable();
                SqlDataAdapter ShopSalesLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, Delivered,TotalSold, CurrentQty, QtySold, SalesAmount from qrySalesGrid WHERE LocationRef = @LocationRef";
                    SelectCmd.Parameters.AddWithValue("@LocationRef", txtShopRef.Text.TrimEnd());
                    ShopSalesLineDataAdapter.SelectCommand = SelectCmd;
                    ShopSalesLineDataAdapter.Fill(ShopSalesLine);
                    DgvRecords.DataSource = ShopSalesLine;
                    DgvRecords.AutoGenerateColumns = true;
                    DgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    DgvRecords.BackgroundColor = Color.LightCoral;
                    DgvRecords.DefaultCellStyle.SelectionBackColor = Color.Red;
                    DgvRecords.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                    DgvRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    DgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    DgvRecords.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    DgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DgvRecords.AllowUserToResizeColumns = false;
                    DgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DgvRecords.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                    DgvRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                    DgvRecords.Columns[0].HeaderText = "Stock Code";
                    DgvRecords.Columns[1].HeaderText = "Delivered Qty";
                    DgvRecords.Columns[3].HeaderText = "Current Qty";
                    DgvRecords.Columns[2].HeaderText = "Total Sold Qty";
                    DgvRecords.Columns[4].HeaderText = "Qty";
                    DgvRecords.Columns[5].HeaderText = "Sales Amount";

                }
            }
            Totals();
        }
    }
}
