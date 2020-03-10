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
            if (FormMode == "New")
            {
                for (int a = 0; a< DgvRecords.Rows.Count-1; a++)
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
                    logs.StringMovementType = "Shop Sale Add";
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
            }
            else
            {
                logs.MovementType = 5;
                logs.TransferReference = Convert.ToInt32(txtSalesID.Text.TrimEnd());
                logs.MovementDate = OldDate;
                logs.DeleteFromStockMovemmentsTable();
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
                    logs.Reference = "Sale-Add-Item";
                    logs.TransferReference = saleLine.SalesID;
                    logs.DeliveredQtyGarments = logs.Qty;
                    logs.DeliveredQtyBoxes = 0;
                    logs.DeliveredQtyHangers = logs.DeliveredQtyBoxes;
                    logs.SupplierRef = "";  // Add function to clsStock to get the supplier Ref from the table.
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

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

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
            int lngqtyhangers = 0;

            for (int i = 0; i < DgvRecords.Rows.Count; i++)
            {
                lngqtyhangers += Convert.ToInt32(DgvRecords.Rows[i].Cells[1].Value);
            }
            //txtTotalItems.Text = lngqtyhangers.ToString();


        }
        private void LoadData()
        {

        }
        private void LoadSalesGrid()
        {

        }
    }
}
