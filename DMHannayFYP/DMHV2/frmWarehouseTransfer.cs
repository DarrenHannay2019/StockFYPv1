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
    public partial class frmWarehouseTransfer : Form
    {
        public string FormMode { get; set; }
        public frmWarehouseTransfer()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvRecords.Rows.Add();
            DgvRecords.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[1].Value = TxtTransferFromQty.Text.TrimEnd();
            Totals();
            TxtCurrentQty.Clear();
            TxtTransferFromQty.Clear();
            TxtStockCode.Clear();
        }

        private void CmdDeleteFromGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvRecords.SelectedRows)
            {
                DgvRecords.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            clsWarehouseTransferHead transferHead = new clsWarehouseTransferHead();
            clsWarehouseTransferLine transferLine = new clsWarehouseTransferLine();
            clsLogs logs = new clsLogs();
            // Header of both adjustments and log file
            if (FormMode == "New")
            {

            }
            else
            {

            }
            // Body and lines
            if (FormMode == "New")
            {

            }
            else
            {

            }
            // End of Saving
            if (FormMode == "New")
            {

            }
            else
            {

            }
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtTotalTransferTo.Clear();
            TxtCurrentQty.Clear();
            TxtTransferFromQty.Clear();
            txtFromShopName.Clear();
            TxtFromWarehouseRef.Clear();
            TxtToWarehouseRef.Clear();
            txtToShopName.Clear();
            TxtStockCode.Clear();
            TxtTFNote.Clear();
            DgvRecords.Rows.Clear();
            DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
        }

        private void frmWarehouseTransfer_Load(object sender, EventArgs e)
        {
            LoadWarehousesIntoForm_FromBox();
            LoadStockIntoForm();      
            if (FormMode == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Shop Delivery";
                DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
            }
            else
            {
                CmdOK.Text = "OK";
                LoadData();
            }
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {
            TxtStockCode.Text = clsUtils.ChangeCase(TxtStockCode.Text, 1);
            clsStock stock = new clsStock();
            stock.StockCode = TxtStockCode.Text.TrimEnd();
            stock.SupplierRef = TxtFromWarehouseRef.Text.TrimEnd();
            TxtCurrentQty.Text = stock.GetWarehouseStockQty().ToString();
        }
        private void LoadData()
        {

        }

        private void TxtToWarehouseRef_Leave(object sender, EventArgs e)
        {
            TxtToWarehouseRef.Text = clsShop.ChangeCase(TxtToWarehouseRef.Text, 1);
            clsWarehouse warehouse = new clsWarehouse(0)
            {
                WarehouseRef = TxtToWarehouseRef.Text.TrimEnd()
            };
            txtToShopName.Text = warehouse.GetWarehouseName();
        }

        private void TxtFromWarehouseRef_Leave(object sender, EventArgs e)
        {
            TxtFromWarehouseRef.Text = clsShop.ChangeCase(TxtFromWarehouseRef.Text, 1);
            clsWarehouse warehouse = new clsWarehouse(0)
            {
                WarehouseRef = TxtFromWarehouseRef.Text.TrimEnd()
            };
            txtFromShopName.Text = warehouse.GetWarehouseName();
            LoadWarehouseIntoForm_ToBox();
        }       
        private void LoadWarehousesIntoForm_FromBox()
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
            TxtFromWarehouseRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtFromWarehouseRef.AutoCompleteCustomSource = ACSC;
            TxtFromWarehouseRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadWarehouseIntoForm_ToBox()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT WarehouseRef from tblWarehouses WHERE WarehouseRef !='" + TxtFromWarehouseRef.Text.TrimEnd() + "'", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtToWarehouseRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtToWarehouseRef.AutoCompleteCustomSource = ACSC;
            TxtToWarehouseRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            txtTotalTransferTo.Text = lngqtyhangers.ToString();
        }
    }
}
