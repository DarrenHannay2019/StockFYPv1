namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class frmShopAdjustment : Form
    {
        public string FormMode { get; set; }
        public int LoggedUser { get; set; }
        public DateTime oldDate { get; set; }
        public frmShopAdjustment()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)dgvItems.Rows.Add();
            dgvItems.Rows[rownum].Cells[0].Value = txtStockCode.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[1].Value = txtCurrentHangers.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[2].Value = cboType.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[3].Value = txtAdjustHangers.Text.TrimEnd();
            Totals();
            txtAdjustHangers.Clear();
            txtCurrentHangers.Clear();
            txtStockCode.Clear();
        }

        private void CmdDeleteFromGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItems.SelectedRows)
            {
                dgvItems.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        public void Totals()
        {
            int lngqtyhangers = 0;
            int lqtyhangers = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {               
                if (dgvItems.Rows[i].Cells[2].Value.ToString() == "Stock Gain")
                    lqtyhangers += Convert.ToInt32(dgvItems.Rows[i].Cells[3].Value);
                else
                    lngqtyhangers += Convert.ToInt32(dgvItems.Rows[i].Cells[3].Value);
            }
            txtTotalGain.Text = lngqtyhangers.ToString();
            txtTotalLoss.Text = lqtyhangers.ToString();
        }
        private void CmdOK_Click(object sender, EventArgs e)
        {
            clsShopAdjustmentHead adjustmentHead = new clsShopAdjustmentHead();
            clsShopAdjustmentLine adjustmentLine = new clsShopAdjustmentLine();
            clsLogs logs = new clsLogs();
            int Total;
            Total = Convert.ToInt32(txtTotalGain.Text.TrimEnd()) + Convert.ToInt32(txtTotalLoss.Text.TrimEnd());
            // Header of both adjustments and log file
            if (FormMode == "New")
            {
                logs.StockCode = "ALL";
                logs.SupplierRef = "";
                logs.LocationRef = txtWarehouseRef.Text.TrimEnd();
                logs.Qty = Total;
                logs.StringMovementType = "New Shop Adjustment";
                logs.RecordType = "Add-New-Item-Start";
                logs.MovementDate = DateTimePicker1.Value;
                logs.Reference = "Add New Shop Adjustment";
                logs.UserID = LoggedUser;
                logs.SaveToSysLogTable();
            }
            else
            {
                logs.StockCode = "ALL";
                logs.SupplierRef = "";
                logs.LocationRef = txtWarehouseRef.Text.TrimEnd();
                logs.Qty = Total;
                logs.StringMovementType = "Update Shop Adjustment";
                logs.RecordType = "Update-Item-Start";
                logs.MovementDate = DateTimePicker1.Value;
                logs.Reference = "Update Shop Adjustment";
                logs.UserID = LoggedUser;
                logs.SaveToSysLogTable();
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
                logs.StockCode = "ALL";
                logs.SupplierRef = "";
                logs.LocationRef = txtWarehouseRef.Text.TrimEnd();
                logs.Qty = Total;
                logs.StringMovementType = "New Shop Adjustment";
                logs.RecordType = "Add-New-Item-End\\";
                logs.MovementDate = DateTimePicker1.Value;
                logs.Reference = "Add New Shop Adjustment";
                logs.UserID = LoggedUser;
                logs.SaveToSysLogTable();
            }
            else
            {
                logs.StockCode = "ALL";
                logs.SupplierRef = "";
                logs.LocationRef = txtWarehouseRef.Text.TrimEnd();
                logs.Qty = Total;
                logs.StringMovementType = "Update Shop Adjustment";
                logs.RecordType = "Update-Item-End";
                logs.MovementDate = DateTimePicker1.Value;
                logs.Reference = "Update Shop Adjustment";
                logs.UserID = LoggedUser;
                logs.SaveToSysLogTable();
            }
            Close();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtAdjustHangers.Clear();
            txtCurrentHangers.Clear();
            txtStockCode.Clear();
            txtTotalGain.Clear();
            txtTotalLoss.Clear();
            dgvItems.Rows.Clear();
            txtWarehouseRef.Clear();
            txtWarehouseName.Clear();
            txtReference.Clear();
            DateTimePicker1.Value = clsUtils.GetSundayDate(DateTime.Now,1);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStockCode_Leave(object sender, EventArgs e)
        {
            txtStockCode.Text = clsUtils.ChangeCase(txtStockCode.Text, 1);
            clsStock stock = new clsStock();
            stock.StockCode = txtStockCode.Text.TrimEnd();
            stock.SupplierRef = txtWarehouseRef.Text.TrimEnd();
            txtCurrentHangers.Text = stock.GetWarehouseStockQty().ToString();
        }

        private void txtWarehouseRef_Leave(object sender, EventArgs e)
        {
            txtWarehouseRef.Text = clsWarehouse.ChangeCase(txtWarehouseRef.Text, 1);
            clsShop warehouse = new clsShop()
            {
                ShopRef = txtWarehouseRef.Text.TrimEnd()
            };
            txtWarehouseName.Text = warehouse.GetShopName();
        }
        private void LoadShopsIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using(SqlConnection conn = new SqlConnection())
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
        private void frmShopAdjustment_Load(object sender, EventArgs e)
        {
            LoadShopsIntoForm();
            LoadStockIntoForm();
            if (FormMode == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Shop Adjustment";
                DateTimePicker1.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
            }
            else
            {
                CmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadData()
        {
            int ShopAdjustID = Convert.ToInt32(TxtSID.Text);
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopAdjustHead = new DataTable();
                SqlDataAdapter ShopAdjustDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblShopAdjustments WHERE ShopAdjustmentID = @ShopAdjustmentID";
                    SelectCmd.Parameters.AddWithValue("@ShopAdjustmentID", ShopAdjustID);
                    ShopAdjustDataAdapter.SelectCommand = SelectCmd;
                    ShopAdjustDataAdapter.Fill(ShopAdjustHead);
                }
                txtWarehouseRef.Text = ShopAdjustHead.Rows[0][1].ToString();
                clsShop Shop = new clsShop();
                Shop.ShopRef = txtWarehouseRef.Text.TrimEnd();
                txtWarehouseName.Text = Shop.GetShopName();
                txtReference.Text = ShopAdjustHead.Rows[0][2].ToString();
                txtTotalGain.Text = ShopAdjustHead.Rows[0][4].ToString();
                txtTotalLoss.Text = ShopAdjustHead.Rows[0][3].ToString();
                DateTimePicker1.Value = Convert.ToDateTime(ShopAdjustHead.Rows[0][5]);
                oldDate = DateTimePicker1.Value;
            }
            dgvItems.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopAdjustLine = new DataTable();
                SqlDataAdapter ShopAdjustLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,MovementType,Qty from tblShopAdjustmentsLines WHERE ShopAdjustmentID = @ShopAdjustmentID";
                    SelectCmd.Parameters.AddWithValue("@ShopAdjustmentID", ShopAdjustID);
                    ShopAdjustLineDataAdapter.SelectCommand = SelectCmd;
                    ShopAdjustLineDataAdapter.Fill(ShopAdjustLine);
                    dgvItems.DataSource = ShopAdjustLine;
                    dgvItems.AutoGenerateColumns = true;
                    dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    dgvItems.BackgroundColor = Color.LightCoral;
                    dgvItems.DefaultCellStyle.SelectionBackColor = Color.Red;
                    dgvItems.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                    dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvItems.AllowUserToResizeColumns = false;
                    dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvItems.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                    dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                    dgvItems.Columns[0].HeaderText = "Stock Code";
                    dgvItems.Columns[1].HeaderText = "Movement Type";
                    dgvItems.Columns[2].HeaderText = "Qty";
                }
            }
        }
    }
}
