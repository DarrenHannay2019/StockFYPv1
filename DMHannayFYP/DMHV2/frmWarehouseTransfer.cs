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
        public DateTime oldDate { get; set; }
        public int LogggedInUser { get; set; }
        public frmWarehouseTransfer()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvRecords.Rows.Add();
            DgvRecords.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[1].Value = TxtCurrentQty.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[2].Value = TxtTransferFromQty.Text.TrimEnd();
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

        private void SaveToDb()
        {
            int SavedID = 0;
            // Transfer Head
            clsWarehouseTransferHead transferHead = new clsWarehouseTransferHead();
            transferHead.WarehouseRef = TxtFromWarehouseRef.Text.TrimEnd();
            transferHead.ToWarehouseRef = TxtToWarehouseRef.Text.TrimEnd();
            transferHead.MovementDate = Convert.ToDateTime(DtpDate.Value);
            transferHead.Qty = Convert.ToInt32(txtTotalTransferTo.Text.TrimEnd());
            transferHead.UserID = LogggedInUser;
            transferHead.Reference = TxtTFNote.Text.TrimEnd();
            transferHead.SaveWarehouseTransferHead();
            SavedID = transferHead.GetLastWarehouseTransferHead();
            // Transfer Lines
            clsWarehouseTransferLine transferLine = new clsWarehouseTransferLine();            
            clsLogs logs = new clsLogs();
            logs.TransferReference = SavedID;
            transferLine.WarehouseTransferID = SavedID;
            logs.MovementDate = transferHead.MovementDate;
            logs.LocationType = 1;
            logs.MovementType = 2;          
            logs.SupplierRef = "N/A";
            logs.Reference = transferHead.Reference;
            logs.UserID = transferHead.UserID;
            logs.StringMovementType = "WarehouseTransfer";
            logs.RecordType = "WarehouseTransfer-Item";
            for (int index = 0; index < DgvRecords.Rows.Count; index++)
            {
                // Save to tblWarehouseTransfer
                transferLine.StockCode = DgvRecords.Rows[index].Cells[0].Value.ToString();                
                transferLine.CurrentQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[1].Value);
                transferLine.TOQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[2].Value) * -1;
                transferLine.TIQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[2].Value);
                logs.StockCode = transferLine.StockCode;
                // Save to tblStockMovements and tblSyslog
                logs.Qty = transferLine.TOQty;
                logs.LocationRef = TxtFromWarehouseRef.Text.TrimEnd();
                logs.DeliveredQtyHangers = logs.Qty;
                logs.DeliveredQtyGarments = logs.Qty;
                logs.DeliveredQtyBoxes = 0;
                logs.SaveToSysLogTable();
                logs.SaveToStockMovementsTable();
                transferLine.SaveWarehouseTransferLine();
                logs.LocationRef = TxtToWarehouseRef.Text.TrimEnd();
                logs.Qty = transferLine.TIQty;
                logs.DeliveredQtyHangers = logs.Qty;
                logs.SaveToSysLogTable();
            }
        }
        private void UpdateToDb()
        {
            clsWarehouseTransferLine transferLine = new clsWarehouseTransferLine();
            clsWarehouseTransferHead transferHead = new clsWarehouseTransferHead();
            clsLogs logs = new clsLogs();
            transferHead.WarehouseTransferID = Convert.ToInt32(TxtTransferID.Text);
            transferHead.WarehouseRef = TxtFromWarehouseRef.Text.TrimEnd();
            transferHead.ToWarehouseRef = TxtToWarehouseRef.Text.TrimEnd();
            transferHead.MovementDate = Convert.ToDateTime(DtpDate.Value);
            transferHead.Qty = Convert.ToInt32(txtTotalTransferTo.Text.TrimEnd());
            transferHead.UserID = LogggedInUser;
            transferHead.Reference = TxtTFNote.Text.TrimEnd();           
            transferHead.WarehouseTransferID = Convert.ToInt32(TxtTransferID.Text.TrimEnd());
            transferHead.UpdateWarehouseTransferHead();
            for (int index = 0; index < DgvRecords.Rows.Count; index++)
            {
                transferLine.StockCode = DgvRecords.Rows[index].Cells[0].Value.ToString();
                transferLine.CurrentQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[1].Value);
                transferLine.TOQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[2].Value) * -1;
                transferLine.TIQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[2].Value);
                transferLine.UpdateWarehouseTransferLine();
                logs.StockCode = transferLine.StockCode;
                logs.LocationRef = transferHead.WarehouseRef;
                logs.LocationType = 1;
                logs.SupplierRef = "N/A";
                logs.DeliveredQtyBoxes = 0;
                logs.DeliveredQtyGarments = transferLine.TOQty;
                logs.DeliveredQtyHangers = transferLine.TOQty;
                logs.MovementType = 2;
                logs.MovementDate = transferHead.MovementDate;
                logs.Qty = transferLine.TOQty;
                logs.StringMovementType = "WarehouseTransfer";
                logs.RecordType = "WarehouseTransfer-Item";
                logs.Reference = transferHead.Reference;
                logs.UserID = LogggedInUser;
                logs.SaveToSysLogTable();
                logs.SaveToStockMovementsTable();
                logs.StockCode = transferLine.StockCode;
                logs.LocationRef = transferHead.ToWarehouseRef;
                logs.LocationType = 1;
                logs.SupplierRef = "N/A";
                logs.DeliveredQtyBoxes = 0;
                logs.DeliveredQtyGarments = transferLine.TIQty;
                logs.DeliveredQtyHangers = transferLine.TIQty;
                logs.MovementType = 2;
                logs.Qty = transferLine.TIQty;
                logs.StringMovementType = "WarehouseTransfer";
                logs.RecordType = "WarehouseTransfer-Item";
                logs.Reference = transferHead.Reference;
                logs.UserID = LogggedInUser;             
                logs.SaveToSysLogTable();
                logs.SaveToStockMovementsTable();
            }
        }
        private void CmdOK_Click(object sender, EventArgs e)
        {             
            // Saving / updating the master table into the database
            if (FormMode == "New")
            {
                SaveToDb();
            }
            else
            {
                clsLogs Dlogs = new clsLogs
                {
                    TransferReference = Convert.ToInt32(TxtTransferID.Text),
                    MovementDate = oldDate,
                    MovementType = 2
                };  // Delete old StockMovements details for current transfer
                Dlogs.DeleteFromStockMovemmentsTable();
                UpdateToDb();
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
                this.Text = "New Warehouse Transfer";
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
            if(TxtStockCode.TextLength != 0)
            {
                TxtStockCode.Text = clsUtils.ChangeCase(TxtStockCode.Text, 1);
                clsStock stock = new clsStock();
                stock.StockCode = TxtStockCode.Text.TrimEnd();
                stock.SupplierRef = TxtFromWarehouseRef.Text.TrimEnd();
                TxtCurrentQty.Text = stock.GetWarehouseStockQty().ToString();
            }
            else
            { }
           
        }
        private void LoadData()
        {
            int WarehouseTransferID = Convert.ToInt32(TxtTransferID.Text.TrimEnd());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable WarehouseTransferHead = new DataTable();
                SqlDataAdapter WarehouseTransferDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblWarehouseTransfers WHERE WarehouseTransferID = @WarehouseTransferID";
                    SelectCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
                    WarehouseTransferDataAdapter.SelectCommand = SelectCmd;
                    WarehouseTransferDataAdapter.Fill(WarehouseTransferHead);
                }
                TxtTFNote.Text = WarehouseTransferHead.Rows[0][1].ToString();
                DtpDate.Value = Convert.ToDateTime(WarehouseTransferHead.Rows[0][2]);
                oldDate = DtpDate.Value;
                TxtFromWarehouseRef.Text = WarehouseTransferHead.Rows[0][3].ToString();
                clsWarehouse warehouse = new clsWarehouse(0);
                warehouse.WarehouseRef = TxtFromWarehouseRef.Text.TrimEnd();
                txtFromShopName.Text = warehouse.GetWarehouseName();
                TxtToWarehouseRef.Text = WarehouseTransferHead.Rows[0][4].ToString();
                warehouse.WarehouseRef = TxtToWarehouseRef.Text.TrimEnd();
                txtToShopName.Text = warehouse.GetWarehouseName();
                txtTotalTransferTo.Text = WarehouseTransferHead.Rows[0][6].ToString();
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
                    SelectCmd.CommandText = "SELECT StockCode,CurrentQty,TOQty from tblWarehouseTransferLines WHERE WarehouseTransferID = @WarehouseTransferID";
                    SelectCmd.Parameters.AddWithValue("@WarehouseTransferID", WarehouseTransferID);
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
                    DgvRecords.Columns[1].HeaderText = "Current Qty";
                    DgvRecords.Columns[2].HeaderText = "Transfer Qty";
                }
            }
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
                lngqtyhangers += Convert.ToInt32(DgvRecords.Rows[i].Cells[2].Value);
            }
            txtTotalTransferTo.Text = lngqtyhangers.ToString();
        }
    }
}
