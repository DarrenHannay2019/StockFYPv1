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
    public partial class frmShopDelivery : Form
    {
        public string FormMode { get; set; }
        public frmShopDelivery()
        {
            InitializeComponent();
        }

        private void cmdAddItem_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DataGridView1.Rows.Add();
            DataGridView1.Rows[rownum].Cells[0].Value = txtStockCode.Text.TrimEnd();
            DataGridView1.Rows[rownum].Cells[1].Value = txtQtyHangers.Text.TrimEnd();
            Totals();
            txtQtyHangers.Clear();
            txtQty.Clear();
            txtStockCode.Clear();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView1.SelectedRows)
            {
                DataGridView1.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            clsShopDeliveryHead deliveryHead = new clsShopDeliveryHead();
            clsShopDeliveryLine deliveryLine = new clsShopDeliveryLine();
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
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClearForm_Click(object sender, EventArgs e)
        {
            txtDelNoteNumber.Clear();
            txtQty.Clear();
            txtQtyHangers.Clear();
            txtTotalGarments.Clear();
            txtStockCode.Clear();
            DataGridView1.Rows.Clear();
            txtWarehouseRef.Clear();
            txtWarehouseName.Clear();
            txtShopRef.Clear();
            txtShopName.Clear();
            txtReference.Clear();
            DateTimePicker1.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
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

        private void txtShopRef_Leave(object sender, EventArgs e)
        {
            txtWarehouseRef.Text = clsShop.ChangeCase(txtWarehouseRef.Text, 1);
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
            stock.SupplierRef = txtWarehouseRef.Text.TrimEnd();
            txtQty.Text = stock.GetWarehouseStockQty().ToString();
        }

        private void frmShopDelivery_Load(object sender, EventArgs e)
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
            txtWarehouseRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtWarehouseRef.AutoCompleteCustomSource = ACSC;
            txtWarehouseRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
           
            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                    lngqtyhangers += Convert.ToInt32(DataGridView1.Rows[i].Cells[1].Value);
            }           
            txtTotalGarments.Text = lngqtyhangers.ToString();
            Deliverlabel.Text = DataGridView1.Rows.Count.ToString();

        }
        private void LoadData()
        {

        }
    }
}
