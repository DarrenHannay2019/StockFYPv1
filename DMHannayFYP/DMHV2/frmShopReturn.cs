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
    public partial class frmShopReturn : Form
    {
        public string FormMode { get; set; }
        public DateTime oldDate { get; set; }
        public int LoggedInUser { get; set; }
        public frmShopReturn()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvRecords.Rows.Add();
            DgvRecords.Rows[rownum].Cells[0].Value = txtStockCode.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[1].Value = txtTransferQty.Text.TrimEnd();
            Totals();
            txtTransferQty.Clear();
            txtCurrentQty.Clear();
            txtStockCode.Clear();
        }

        private void cmdClearGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvRecords.SelectedRows)
            {
                DgvRecords.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            clsShopReturnHead returnHead = new clsShopReturnHead();
            clsShopReturnLine returnLine = new clsShopReturnLine();
            clsLogs logs = new clsLogs();
            int SavedID = 0;
            // Header of both adjustments and log file
            returnHead.WarehouseRef = txtWarehouseRef.Text.TrimEnd();
            returnHead.Reference = txtReference.Text.TrimEnd();
            returnHead.ShopRef = txtShopRef.Text.TrimEnd();
            returnHead.TotalItems = Convert.ToInt32(txtTotalItems.Text.TrimEnd());
            returnHead.MovementDate = Convert.ToDateTime(DtpDate.Value);
            returnHead.UserID = LoggedInUser;
            if (FormMode == "New")
            {
                returnHead.SaveShopReturnHead();
                SavedID = returnHead.GetLastShopReturnHead();
            }
            else
            {
                clsLogs Dlogs = new clsLogs();  // Delete old StockMovements Data from Table
                Dlogs.TransferReference = Convert.ToInt32(txtReturnID.Text.TrimEnd());
                Dlogs.MovementDate = oldDate;
                Dlogs.MovementType = 9;
                Dlogs.DeleteFromStockMovemmentsTable();
                returnHead.ShopReturnID = Convert.ToInt32(txtReturnID.Text.TrimEnd());
                returnHead.UpdateShopReturnHead();
            }
            logs.TransferReference = SavedID;
            returnLine.ShopReturnID = SavedID;
            logs.MovementDate = returnHead.MovementDate;
            logs.UserID = returnHead.UserID;
            logs.MovementType = 8;
            logs.StringMovementType = "Shop Return Item";
            for (int index = 0; index < DgvRecords.Rows.Count; index++)
            {
                logs.LocationRef = returnHead.WarehouseRef;
                returnLine.StockCode = DgvRecords.Rows[index].Cells[0].Value.ToString();
                returnLine.Qty = Convert.ToInt32(DgvRecords.Rows[index].Cells[1].Value);
                logs.StockCode = returnLine.StockCode;
                logs.RecordType = "Shop Return";
                logs.Reference = logs.StringMovementType;
                logs.SupplierRef = "N/A";
                if (FormMode == "New")
                { 
                    logs.LocationType = 2;
                    logs.LocationRef = returnHead.ShopRef;
                    logs.Qty = returnLine.Qty * -1;
                    logs.DeliveredQtyHangers = returnLine.Qty *-1;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    returnLine.SaveShopReturnLine();
                    logs.LocationRef = returnHead.WarehouseRef;
                    logs.LocationType = 1;
                    logs.Qty = returnLine.Qty;
                    logs.DeliveredQtyHangers = returnLine.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
                else
                {
                    logs.LocationRef = returnHead.ShopRef;
                    logs.Qty = returnLine.Qty * -1;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    returnLine.UpdateShopReturnLine();
                    logs.LocationRef = returnHead.WarehouseRef;
                    logs.Qty = returnLine.Qty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
            }
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtTotalItems.Clear();
            txtStockCode.Clear();
            DgvRecords.Rows.Clear();
            txtWarehouseRef.Clear();
            txtWarehouseName.Clear();
            txtShopRef.Clear();
            txtShopName.Clear();
            txtReference.Clear();
            DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
        }

        private void txtShopRef_Leave(object sender, EventArgs e)
        {
            txtShopRef.Text = clsShop.ChangeCase(txtShopRef.Text, 1);
            clsShop Shop = new clsShop()
            {
                ShopRef = txtShopRef.Text.TrimEnd()
            };
            txtShopName.Text = Shop.GetShopName();
        }

        private void txtStockCode_Leave(object sender, EventArgs e)
        {
            txtStockCode.Text = clsUtils.ChangeCase(txtStockCode.Text, 1);
            clsStock stock = new clsStock();
            stock.StockCode = txtStockCode.Text.TrimEnd();
            stock.SupplierRef = txtShopRef.Text.TrimEnd();
            txtCurrentQty.Text = stock.GetShopStockQty().ToString();
        }

        private void txtWarehouseRef_Leave(object sender, EventArgs e)
        {
            txtWarehouseRef.Text = clsWarehouse.ChangeCase(txtWarehouseRef.Text, 1);
            clsWarehouse warehouse = new clsWarehouse(0)
            {
                WarehouseRef = txtWarehouseRef.Text.TrimEnd()
            };
            txtWarehouseName.Text = warehouse.GetWarehouseName();
        }

        private void frmShopReturn_Load(object sender, EventArgs e)
        {
            LoadShopsIntoForm();
            LoadStockIntoForm();
            LoadWarehouseIntoForm();
            if (FormMode == "New")
            {
                cmdAdd.Text = "Save";
                this.Text = "New Shop Delivery";
            }
            else
            {
                cmdAdd.Text = "OK";
                LoadData();
            }
        }
        private void LoadData()
        {
            int ShopReturnID = Convert.ToInt32(txtReturnID.Text.TrimEnd());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopReturnHead = new DataTable();
                SqlDataAdapter ShopReturnDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblShopReturns WHERE ShopReturnsID = @ShopReturnsID";
                    SelectCmd.Parameters.AddWithValue("@ShopReturnsID", ShopReturnID);
                    ShopReturnDataAdapter.SelectCommand = SelectCmd;
                    ShopReturnDataAdapter.Fill(ShopReturnHead);
                }
                txtShopRef.Text = ShopReturnHead.Rows[0][1].ToString();
                clsShop Shop = new clsShop();
                Shop.ShopRef = txtShopRef.Text;
                txtShopName.Text = Shop.GetShopName();
                txtWarehouseRef.Text = ShopReturnHead.Rows[0][2].ToString();
                clsWarehouse warehouse = new clsWarehouse(0);
                warehouse.WarehouseRef = txtWarehouseRef.Text.TrimEnd();
                txtWarehouseName.Text = warehouse.GetWarehouseName();
                txtReference.Text = ShopReturnHead.Rows[0][3].ToString();
                txtTotalItems.Text = ShopReturnHead.Rows[0][4].ToString();
                DtpDate.Value = Convert.ToDateTime(ShopReturnHead.Rows[0][5]);
                oldDate = DtpDate.Value;
            }
            DgvRecords.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopReturnLine = new DataTable();
                SqlDataAdapter ShopReturnLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,Qty from tblShopReturnLines WHERE ShopReturnID = @ShopReturnID";
                    SelectCmd.Parameters.AddWithValue("@ShopReturnID", ShopReturnID);
                    ShopReturnLineDataAdapter.SelectCommand = SelectCmd;
                    ShopReturnLineDataAdapter.Fill(ShopReturnLine);
                    DgvRecords.DataSource = ShopReturnLine;
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
                    DgvRecords.Columns[1].HeaderText = "Qty";
                }
                Totals();
            }
        }
        private void LoadWarehouseIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT WarehouseRef from tblWarehouses", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            txtWarehouseRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtWarehouseRef.AutoCompleteCustomSource = ACSC;
            txtWarehouseRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            txtStockCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStockCode.AutoCompleteCustomSource = ACSC;
            txtStockCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        public void Totals()
        {
            int lngqtyhangers = 0;

            for (int i = 0; i < DgvRecords.Rows.Count; i++)
            {
                lngqtyhangers += Convert.ToInt32(DgvRecords.Rows[i].Cells[1].Value);
            }
            txtTotalItems.Text = lngqtyhangers.ToString();
            

        }

        private void txtShopRef_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
