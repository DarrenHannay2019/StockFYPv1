namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class frmWarehouseReturn : Form
    {
        public string FormMode { get; set; }
        public DateTime oldDate { get; set; }
        public int LoggedInUser { get; set; }
        public frmWarehouseReturn()
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
            clsWarehouseReturnHead returnHead = new clsWarehouseReturnHead();
            clsWarehouseReturnLine returnLine = new clsWarehouseReturnLine();
            clsLogs logs = new clsLogs();
            int SavedID = 0;
            // Header of both adjustments and log file
            returnHead.WarehouseRef = txtWarehouseRef.Text.TrimEnd();
            returnHead.Reference = txtReference.Text.TrimEnd();
            returnHead.SupplierRef = txtSupplierRef.Text.TrimEnd();
            returnHead.TotalItems = Convert.ToInt32(txtTotalItems.Text.TrimEnd());
            returnHead.MovementDate = Convert.ToDateTime(DtpDate.Value);
            returnHead.UserID = LoggedInUser;
            if (FormMode == "New")
            {
                returnHead.SaveWarehouseReturnHead();
                SavedID = returnHead.GetLastWarehouseReturnHead();
            }
            else
            {
                clsLogs Dlogs = new clsLogs();  // Delete old StockMovements Data from Table
                Dlogs.TransferReference = Convert.ToInt32(txtReturnID.Text.TrimEnd());
                Dlogs.MovementDate = oldDate;
                Dlogs.MovementType = 9;
                Dlogs.DeleteFromStockMovemmentsTable();
                returnHead.WarehouseReturnID = Convert.ToInt32(txtReturnID.Text.TrimEnd());
                returnHead.UpdateWarehouseReturnHead();
            }
            logs.TransferReference = SavedID;
            returnLine.WarehouseReturnID = SavedID;
            logs.LocationType = 1;
            logs.MovementType = 9;
            logs.StringMovementType = "Warehouse Return Item";
            for (int index = 0; index < DgvRecords.Rows.Count; index++)
            {
                logs.LocationRef = returnHead.WarehouseRef;
                returnLine.StockCode = DgvRecords.Rows[index].Cells[0].Value.ToString();                
                returnLine.ReturnQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[1]);               
                if (FormMode == "New")
                {
                    logs.LocationRef = returnHead.WarehouseRef;
                    logs.Qty = returnLine.ReturnQty * -1;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    returnLine.SaveWarehouseReturnLine();
                    logs.LocationRef = returnHead.SupplierRef;
                    logs.Qty = returnLine.ReturnQty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
                else
                {
                    logs.LocationRef = returnHead.WarehouseRef;
                    logs.Qty = returnLine.ReturnQty * -1;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    returnLine.UpdateWarehouseReturnLine();
                    logs.LocationRef = returnHead.SupplierRef;
                    logs.Qty = returnLine.ReturnQty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
            }
            this.Close();
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
            txtSupplierRef.Clear();
            txtSupplierName.Clear();
            txtWarehouseRef.Clear();
            txtWarehouseName.Clear();
            txtReference.Clear();
            DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
        }

        private void txtStockCode_Leave(object sender, EventArgs e)
        {
            txtStockCode.Text = clsUtils.ChangeCase(txtStockCode.Text, 1);
            clsStock stock = new clsStock();
            stock.StockCode = txtStockCode.Text.TrimEnd();
            stock.SupplierRef = txtWarehouseRef.Text.TrimEnd();
            txtCurrentQty.Text = stock.GetWarehouseStockQty().ToString();
        }

        private void txtWarehouseRef_Leave(object sender, EventArgs e)
        {
            txtWarehouseRef.Text = clsWarehouse.ChangeCase(txtSupplierRef.Text, 1);
            clsWarehouse warehouse = new clsWarehouse(0)
            {
                WarehouseRef = txtWarehouseRef.Text.TrimEnd()
            };
            txtWarehouseName.Text = warehouse.GetWarehouseName();
        }

        private void frmWarehouseReturn_Load(object sender, EventArgs e)
        {
            LoadWarehouseIntoForm();
            LoadStockIntoForm();
            LoadSupplierIntoForm();
            if (FormMode == "New")
            {
                cmdAdd.Text = "Save";
                this.Text = "New Warehouse Return";
                DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
            }
            else
            {
                cmdAdd.Text = "OK";
                LoadData();
            }
        }
        private void LoadSupplierIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT SupplierRef from tblSuppliers", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            txtSupplierRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSupplierRef.AutoCompleteCustomSource = ACSC;
            txtSupplierRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            txtSupplierRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSupplierRef.AutoCompleteCustomSource = ACSC;
            txtSupplierRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
        private void LoadData()
        {            
            int WarehouseReturnID = Convert.ToInt32(txtReturnID.Text.TrimEnd());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable WarehouseReturnHead = new DataTable();
                SqlDataAdapter WarehouseReturnDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblWarehouseReturns WHERE WarehouseReturnsID = @WarehouseReturnsID";
                    SelectCmd.Parameters.AddWithValue("@WarehouseReturnsID", WarehouseReturnID);
                    WarehouseReturnDataAdapter.SelectCommand = SelectCmd;
                    WarehouseReturnDataAdapter.Fill(WarehouseReturnHead);
                }
                txtWarehouseRef.Text = WarehouseReturnHead.Rows[0][1].ToString();
                clsWarehouse warehouse = new clsWarehouse(0);
                warehouse.WarehouseRef = txtWarehouseRef.Text;
                txtWarehouseName.Text = warehouse.GetWarehouseName();
                txtSupplierRef.Text = WarehouseReturnHead.Rows[0][2].ToString();
                clsSupplier supplier = new clsSupplier(0);
                supplier.SupplierRef = txtSupplierRef.Text.TrimEnd();
                txtSupplierName.Text = supplier.GetSupplierName();
                txtReference.Text = WarehouseReturnHead.Rows[0][3].ToString();
                txtTotalItems.Text = WarehouseReturnHead.Rows[0][4].ToString();
                DtpDate.Value = Convert.ToDateTime(WarehouseReturnHead.Rows[0][5]);
                oldDate = DtpDate.Value;
            }
            DgvRecords.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable WarehouseReturnLine = new DataTable();
                SqlDataAdapter WarehouseReturnLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,Qty from tblWarehouseReturnLines WHERE WarehouseReturnID = @WarehouseReturnID";
                    SelectCmd.Parameters.AddWithValue("@WarehouseReturnID", WarehouseReturnID);
                    WarehouseReturnLineDataAdapter.SelectCommand = SelectCmd;
                    WarehouseReturnLineDataAdapter.Fill(WarehouseReturnLine);
                    DgvRecords.DataSource = WarehouseReturnLine;
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

        private void txtSupplierRef_Leave(object sender, EventArgs e)
        {
            txtSupplierRef.Text = clsSupplier.ChangeCase(txtSupplierRef.Text, 1);
            clsSupplier warehouse = new clsSupplier(0)
            {
                SupplierRef = txtSupplierRef.Text.TrimEnd()
            };
            txtSupplierName.Text = warehouse.GetSupplierName();
        }
    }
}
