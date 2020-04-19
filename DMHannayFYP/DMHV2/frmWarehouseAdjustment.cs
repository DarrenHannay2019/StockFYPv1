namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class frmWarehouseAdjustment : Form
    {
        public string FormMode { get; set; }
        public int LoggedInUser { get; set; }
        public DateTime olddate { get; set; }
        public frmWarehouseAdjustment()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)dgvItems.Rows.Add();
            dgvItems.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[3].Value = TxtCurrentHangers.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[1].Value = CboType.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[2].Value = TxtAdjustHangers.Text.TrimEnd();
            Totals();
            TxtAdjustHangers.Clear();
            TxtCurrentHangers.Clear();
            TxtStockCode.Clear();
        }

        private void CmdRemoveFromGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItems.SelectedRows)
            {
                dgvItems.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            if(FormMode == "New")
            {
                SaveToDb();
            }
            else
            {
                UpdateToDb();
            }
            this.Close();
        }
        private void SaveToDb()
        {
            clsWarehouseAdjustmentHead adjustmentHead = new clsWarehouseAdjustmentHead();
            int SavedID = 0;
            // Header of both adjustments and log file
            adjustmentHead.WarehouseRef = TxtWarehouseRef.Text.TrimEnd();
            adjustmentHead.Reference = TxtReference.Text.TrimEnd();
            adjustmentHead.TotalGainItems = Convert.ToInt32(TxtTotalGain.Text.TrimEnd());
            adjustmentHead.TotalLossItems = Convert.ToInt32(TxtTotalLoss.Text.TrimEnd());
            adjustmentHead.MovementDate = Convert.ToDateTime(DateTimePicker1.Value);
            adjustmentHead.UserID = LoggedInUser;
           
                adjustmentHead.SaveWarehouseAdjustmentHead();
                SavedID = adjustmentHead.GetLastWarehouseAdjustmentHead();
           
            clsWarehouseAdjustmentLine adjustmentLine = new clsWarehouseAdjustmentLine();
            clsLogs logs = new clsLogs();  // Save To system Log and StockMovements Table
            logs.TransferReference = SavedID;
            adjustmentLine.WarehouseAdjustmentID = SavedID;
            logs.LocationRef = adjustmentHead.WarehouseRef;
            for (int index = 0; index < dgvItems.Rows.Count; index++)
            {
                // Saving details to tblWarehouseAdjustmentLines Table
                adjustmentLine.StockCode = dgvItems.Rows[index].Cells[0].Value.ToString();
                adjustmentLine.MovementType = dgvItems.Rows[index].Cells[1].Value.ToString();
                adjustmentLine.Qty = Convert.ToInt32(dgvItems.Rows[index].Cells[2].Value);
                adjustmentLine.Value = Convert.ToDecimal(dgvItems.Rows[index].Cells[3].Value);
                // Saving details to tblStockMovements Table
                logs.StockCode = adjustmentLine.StockCode;
                logs.LocationRef = adjustmentHead.WarehouseRef;
                logs.LocationType = 1;
                logs.SupplierRef = "N/A";
                if (adjustmentLine.MovementType == "Loss")
                    logs.DeliveredQtyHangers = Convert.ToInt32(dgvItems.Rows[index].Cells[2].Value) * -1;
                else
                    logs.DeliveredQtyHangers = Convert.ToInt32(dgvItems.Rows[index].Cells[2].Value);
                logs.DeliveredQtyGarments = 0;
                logs.DeliveredQtyBoxes = 0;
                if (adjustmentLine.MovementType == "Loss")
                    logs.MovementType = 7;
                else
                    logs.MovementType = 6;
                logs.MovementDate = adjustmentHead.MovementDate;
                logs.Reference = adjustmentHead.Reference;
                logs.StringMovementType = "WarehouseAdjustment-" + adjustmentLine.MovementType;
                logs.RecordType = "WarehouseAdjustment-Item";
                logs.UserID = LoggedInUser;
                // Save to the relevent data tables on each itteration of the Datagridview control
                logs.SaveToSysLogTable();
                logs.SaveToStockMovementsTable();
                if (FormMode == "New")
                    adjustmentLine.SaveWarehouseAdjustmentLine();
                else
                    adjustmentLine.UpdateWarehouseAdjustmentLine();
            }
        }
        private void UpdateToDb()
        {
            clsWarehouseAdjustmentHead adjustmentHead = new clsWarehouseAdjustmentHead();
            clsLogs logs = new clsLogs();  // Delete old StockMovements Data from Table
            logs.TransferReference = Convert.ToInt32(TxtRecordID.Text.TrimEnd());
            // Header of both adjustments and log file
            adjustmentHead.WarehouseRef = TxtWarehouseRef.Text.TrimEnd();
            adjustmentHead.Reference = TxtReference.Text.TrimEnd();
            adjustmentHead.TotalGainItems = Convert.ToInt32(TxtTotalGain.Text.TrimEnd());
            adjustmentHead.TotalLossItems = Convert.ToInt32(TxtTotalLoss.Text.TrimEnd());
            adjustmentHead.MovementDate = Convert.ToDateTime(DateTimePicker1.Value);
            logs.MovementDate = olddate;
            logs.MovementType = 6;
            logs.DeleteFromStockMovemmentsTable();
            logs.MovementType = 7;
            logs.DeleteFromStockMovemmentsTable();
            adjustmentHead.WarehouseAdjustmentID = Convert.ToInt32(TxtRecordID.Text.TrimEnd());
            adjustmentHead.UpdateWarehouseAdjustmentHead();
            clsWarehouseAdjustmentLine adjustmentLine = new clsWarehouseAdjustmentLine();
            // Save To system Log and StockMovements Table
            adjustmentLine.WarehouseAdjustmentID = logs.TransferReference;
            logs.LocationRef = adjustmentHead.WarehouseRef;
            for (int index = 0; index < dgvItems.Rows.Count; index++)
            {
                // Saving details to tblWarehouseAdjustmentLines Table
                adjustmentLine.StockCode = dgvItems.Rows[index].Cells[0].Value.ToString();
                adjustmentLine.MovementType = dgvItems.Rows[index].Cells[1].Value.ToString();
                adjustmentLine.Qty = Convert.ToInt32(dgvItems.Rows[index].Cells[2].Value);
                //adjustmentLine.Value = Convert.ToDecimal(dgvItems.Rows[index].Cells[3].Value);
                // Saving details to tblStockMovements Table
                logs.StockCode = adjustmentLine.StockCode;
                logs.LocationRef = adjustmentHead.WarehouseRef;
                logs.LocationType = 1;
                logs.SupplierRef = "N/A";
                if (adjustmentLine.MovementType == "Loss")
                    logs.DeliveredQtyHangers = Convert.ToInt32(dgvItems.Rows[index].Cells[2].Value) * -1;
                else
                    logs.DeliveredQtyHangers = Convert.ToInt32(dgvItems.Rows[index].Cells[2].Value);
                logs.DeliveredQtyGarments = 0;
                logs.DeliveredQtyBoxes = 0;
                if (adjustmentLine.MovementType == "Loss")
                    logs.MovementType = 7;
                else
                    logs.MovementType = 6;
                logs.MovementDate = adjustmentHead.MovementDate;
                logs.Reference = adjustmentHead.Reference;
                logs.StringMovementType = "WarehouseAdjustment-" + adjustmentLine.MovementType;
                logs.RecordType = "WarehouseAdjustment-Item";
                logs.UserID = LoggedInUser;
                // Save to the relevent data tables on each itteration of the Datagridview control
                logs.SaveToSysLogTable();
                logs.SaveToStockMovementsTable();
                adjustmentLine.UpdateWarehouseAdjustmentLine();
            }
        }
    
        private void CmdClear_Click(object sender, EventArgs e)
        {
            TxtAdjustHangers.Clear();
            TxtCurrentHangers.Clear();
            TxtStockCode.Clear();
            TxtTotalGain.Text = "00";
            TxtTotalLoss.Text = "00";
            dgvItems.Rows.Clear();
            TxtWarehouseRef.Clear();
            TxtWarehouseName.Clear();
            TxtReference.Clear();
            DateTimePicker1.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close form
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {
            TxtStockCode.Text = clsUtils.ChangeCase(TxtStockCode.Text, 1);
            clsStock stock = new clsStock();
            stock.StockCode = TxtStockCode.Text.TrimEnd();
            stock.SupplierRef = TxtWarehouseRef.Text.TrimEnd();
            if (TxtWarehouseName.Text == "")
                TxtCurrentHangers.Text = "0";
            else
                TxtCurrentHangers.Text = stock.GetWarehouseStockQty().ToString();
        }

        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {
            TxtWarehouseRef.Text = clsWarehouse.ChangeCase(TxtWarehouseRef.Text, 1);
            clsWarehouse warehouse = new clsWarehouse(0)
            {
                WarehouseRef = TxtWarehouseRef.Text.TrimEnd()
            };
            TxtWarehouseName.Text = warehouse.GetWarehouseName();
        }

        private void frmWarehouseAdjustment_Load(object sender, EventArgs e)
        {           
            LoadStockIntoForm();
            LoadWarehouseIntoForm();
            if (FormMode == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Warehouse Adjustments";
                DateTimePicker1.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
            }
            else
            {
                CmdOK.Text = "OK";
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
            TxtWarehouseRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtWarehouseRef.AutoCompleteCustomSource = ACSC;
            TxtWarehouseRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            int lqtyhangers = 0;
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                if (dgvItems.Rows[i].Cells[1].Value.ToString() == "Loss")
                    lqtyhangers += Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value);
                else
                    lngqtyhangers += Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value);
            }
            TxtTotalGain.Text = lngqtyhangers.ToString();
            TxtTotalLoss.Text = lqtyhangers.ToString();

        }
        private void LoadData()
        {
            int WarehouseAdjustID = Convert.ToInt32(TxtRecordID.Text.TrimEnd());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable WarehouseAdjustHead = new DataTable();
                SqlDataAdapter WarehouseAdjustDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblWarehouseAdjustments WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID";
                    SelectCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustID);
                    WarehouseAdjustDataAdapter.SelectCommand = SelectCmd;
                    WarehouseAdjustDataAdapter.Fill(WarehouseAdjustHead);
                }
                TxtWarehouseRef.Text = WarehouseAdjustHead.Rows[0][1].ToString();
                clsWarehouse warehouse = new clsWarehouse(0);
                warehouse.WarehouseRef = TxtWarehouseRef.Text.TrimEnd();
                TxtWarehouseName.Text = warehouse.GetWarehouseName();
                TxtReference.Text = WarehouseAdjustHead.Rows[0][2].ToString();
                TxtTotalGain.Text = WarehouseAdjustHead.Rows[0][4].ToString();
                TxtTotalLoss.Text = WarehouseAdjustHead.Rows[0][3].ToString();
                DateTimePicker1.Value = Convert.ToDateTime(WarehouseAdjustHead.Rows[0][5]);
                olddate = DateTimePicker1.Value;
            }
            dgvItems.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable WarehouseAdjustLine = new DataTable();
                SqlDataAdapter WarehouseAdjustLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,MovementType,Qty from tblWarehouseAdjustmentsLines WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID";
                    SelectCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustID);
                    WarehouseAdjustLineDataAdapter.SelectCommand = SelectCmd;
                    WarehouseAdjustLineDataAdapter.Fill(WarehouseAdjustLine);
                    dgvItems.DataSource = WarehouseAdjustLine;
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

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Totals();
        }
    }
}
