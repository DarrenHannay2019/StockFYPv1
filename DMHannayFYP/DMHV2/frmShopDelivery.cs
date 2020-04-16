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
        public DateTime oldDate { get; set; }
        public int LoggedInUser { get; set; }
        public frmShopDelivery()
        {
            InitializeComponent();
        }

        private void cmdAddItem_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvRecords.Rows.Add();
            DgvRecords.Rows[rownum].Cells[0].Value = txtStockCode.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[1].Value = txtQtyHangers.Text.TrimEnd();
            Totals();
            txtQtyHangers.Clear();
            txtQty.Clear();
            txtStockCode.Clear();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvRecords.SelectedRows)
            {
                DgvRecords.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            clsShopDeliveryHead deliveryHead = new clsShopDeliveryHead();
            clsShopDeliveryLine deliveryLine = new clsShopDeliveryLine();
            clsLogs logs = new clsLogs();
            int SavedID = 0;
            // Header of both adjustments and log file
            deliveryHead.WarehouseRef = txtWarehouseRef.Text.TrimEnd();
            deliveryHead.Reference = txtReference.Text.TrimEnd();
            deliveryHead.ShopRef = txtShopRef.Text.TrimEnd();
            deliveryHead.TotalItems = Convert.ToInt32(txtTotalGarments.Text.TrimEnd());
            deliveryHead.MovementDate = Convert.ToDateTime(DateTimePicker1.Value.ToString());
            deliveryHead.UserID = LoggedInUser;
            if (FormMode == "New")
            {
                deliveryHead.SaveShopDeliveryHead();
                SavedID = deliveryHead.GetLastShopDelivery();
            }
            else
            {
                clsLogs Dlogs = new clsLogs();  // Delete old StockMovements Data from Table
                Dlogs.TransferReference = Convert.ToInt32(txtDelNoteNumber.Text.TrimEnd());
                Dlogs.MovementDate = oldDate;
                Dlogs.MovementType = 3;
                Dlogs.DeleteFromStockMovemmentsTable();
                deliveryHead.ShopDelID = Convert.ToInt32(txtDelNoteNumber.Text.TrimEnd());
                deliveryHead.UpdateShopDeliveryHead();
            }
            logs.TransferReference = SavedID;
            deliveryLine.ShopDelID = SavedID;
            logs.MovementDate = deliveryHead.MovementDate;
            logs.RecordType = "Shop Delivery Item Add";
            logs.Reference = logs.RecordType;
            logs.UserID = LoggedInUser;
            logs.SupplierRef = "NULL";
            logs.StringMovementType = "Shop Return Item";
            for (int index = 0; index < DgvRecords.Rows.Count; index++)
            {             
                deliveryLine.StockCode = DgvRecords.Rows[index].Cells[0].Value.ToString();
                logs.StockCode = deliveryLine.StockCode;
                deliveryLine.Qty = Convert.ToInt32(DgvRecords.Rows[index].Cells[1].Value);
                if (FormMode == "New")
                {
                    logs.LocationRef = deliveryHead.WarehouseRef;
                    logs.LocationType = 1;
                    logs.MovementType = 3;
                    logs.Qty = deliveryLine.Qty * -1;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    deliveryLine.SaveShopDeliveryLine();
                    logs.LocationType = 2;
                    logs.MovementType = 3;
                    logs.LocationRef = deliveryHead.ShopRef;
                    logs.Qty = deliveryLine.Qty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
                else
                {
                    logs.LocationRef = deliveryHead.WarehouseRef;
                    logs.LocationType = 1;
                    logs.MovementType = 3;
                    logs.Qty = deliveryLine.Qty * -1;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    deliveryLine.UpdateShopDeliveryLine();
                    logs.LocationType = 2;
                    logs.MovementType = 3;
                    logs.LocationRef = deliveryHead.ShopRef;
                    logs.Qty = deliveryLine.Qty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
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
            DgvRecords.Rows.Clear();
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
           
            for (int i = 0; i < DgvRecords.Rows.Count; i++)
            {
                    lngqtyhangers += Convert.ToInt32(DgvRecords.Rows[i].Cells[1].Value);
            }           
            txtTotalGarments.Text = lngqtyhangers.ToString();
            Deliverlabel.Text = DgvRecords.Rows.Count.ToString();

        }
        private void LoadData()
        {
            int SHDelID = Convert.ToInt32(txtDelNoteNumber.Text.TrimEnd());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopDeliveryHead = new DataTable();
                SqlDataAdapter ShopDeliveryDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblShopDeliveries WHERE ShopDeliveryID = @ShopDeliveryID";
                    SelectCmd.Parameters.AddWithValue("@ShopDeliveryID", SHDelID);
                    ShopDeliveryDataAdapter.SelectCommand = SelectCmd;
                    ShopDeliveryDataAdapter.Fill(ShopDeliveryHead);
                }
                txtShopRef.Text = ShopDeliveryHead.Rows[0][1].ToString();
                clsShop shop = new clsShop();
                shop.ShopRef = txtShopRef.Text.TrimEnd();
                txtShopName.Text = shop.GetShopName();
                clsWarehouse warehouse = new clsWarehouse(0);
                txtWarehouseRef.Text = ShopDeliveryHead.Rows[0][2].ToString();
                warehouse.WarehouseRef = txtWarehouseRef.Text.TrimEnd();
                txtWarehouseName.Text = warehouse.GetWarehouseName();
                txtReference.Text = ShopDeliveryHead.Rows[0][3].ToString();
                txtTotalGarments.Text = ShopDeliveryHead.Rows[0][4].ToString();
                DateTimePicker1.Value= Convert.ToDateTime(ShopDeliveryHead.Rows[0][5]);
                oldDate = DateTimePicker1.Value;                
            }
            DgvRecords.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable WarehouseAdjustLine = new DataTable();
                SqlDataAdapter WarehouseAdjustLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,DeliveredQty from tblShopDeliveryLines WHERE ShopDeliveryID = @ShopDeliveryID";
                    SelectCmd.Parameters.AddWithValue("@ShopDeliveryID", SHDelID);
                    WarehouseAdjustLineDataAdapter.SelectCommand = SelectCmd;
                    WarehouseAdjustLineDataAdapter.Fill(WarehouseAdjustLine);
                    DgvRecords.DataSource = WarehouseAdjustLine;
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
                   
                }
            }
        }
    }
}
