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
    public partial class frmShopTransfer : Form
    {
        public string FormMode { get; set; }
        public int LogggedInUser { get; set; }
        public DateTime olddate { get; set; }
        public frmShopTransfer()
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
            clsShopTransferHead transferHead = new clsShopTransferHead();
            clsShopTransferLine transferLine = new clsShopTransferLine();
           
            int SavedID = 0;
            transferHead.ShopRef = TxtFromShopRef.Text.TrimEnd();
            transferHead.ToShopRef = TxtToShopRef.Text.TrimEnd();

            transferHead.Qty = Convert.ToInt32(txtTotalTransferTo.Text.TrimEnd());
            transferHead.UserID = LogggedInUser;
            transferHead.Reference = TxtTFNote.Text.TrimEnd();
            // Saving / updating the master table into the database
            if (FormMode == "New")
            {
                transferHead.SaveShopTransferHead();
                SavedID = transferHead.GetLastShopTransferHead();
            }
            else
            {
                clsLogs Dlogs = new clsLogs();  // Delete old StockMovements details for current transfer
                Dlogs.TransferReference = SavedID;
                Dlogs.MovementDate = olddate;
                Dlogs.MovementType = 2;
                Dlogs.DeleteFromStockMovemmentsTable();
                transferHead.ShopTransferID = Convert.ToInt32(TxtTransferID.Text.TrimEnd());
                transferHead.UpdateShopTransferHead();
            }
           
            clsLogs logs = new clsLogs();
            logs.TransferReference = SavedID;
            transferLine.ShopTransferID = SavedID;
            logs.MovementDate = transferHead.MovementDate;
            logs.LocationType = 2;
            logs.MovementType = 4;
            logs.DeliveredQtyGarments = 0;
            logs.DeliveredQtyBoxes = 0;
            logs.SupplierRef = "N/A";
            logs.Reference = transferHead.Reference;
            logs.UserID = transferHead.UserID;
            logs.StringMovementType = "WarehouseTransfer";
            logs.RecordType = "WarehouseTransfer-Item";
            for (int index = 0; index < DgvRecords.Rows.Count - 1; index++)
            {
                transferLine.StockCode = DgvRecords.Rows[index].Cells[0].Value.ToString();
                transferLine.CurrQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[1]);
                transferLine.TOQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[2]) * -1;
                transferLine.TIQty = Convert.ToInt32(DgvRecords.Rows[index].Cells[2]);
                if (FormMode == "New")
                {
                    logs.Qty = transferLine.TOQty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    transferLine.SaveShopTransferLine();
                    logs.Qty = transferLine.TIQty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
                else
                {
                    logs.Qty = transferLine.TOQty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    transferLine.UpdateShopTransferLine();
                    logs.Qty = transferLine.TIQty;
                    logs.DeliveredQtyHangers = logs.Qty;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
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
            TxtFromShopRef.Clear();
            TxtToShopRef.Clear();
            txtToShopName.Clear();
            TxtStockCode.Clear();
            TxtTFNote.Clear();
            DgvRecords.Rows.Clear();
            DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
        }

        private void frmShopTransfer_Load(object sender, EventArgs e)
        {
            LoadShopsIntoForm_FromBox();
            LoadStockIntoForm();
            if (FormMode == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Shop Transfer";
            }
            else
            {
                CmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadShopsIntoForm_FromBox()
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
            TxtToShopRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtToShopRef.AutoCompleteCustomSource = ACSC;
            TxtToShopRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadShopsIntoForm_ToBox()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT ShopRef from tblShops WHERE ShopRef !='" + TxtFromShopRef.Text.TrimEnd()+ "'", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtToShopRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtToShopRef.AutoCompleteCustomSource = ACSC;
            TxtToShopRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        private void LoadData()
        {
            int ShopTransferID = Convert.ToInt32(TxtTransferID.Text.TrimEnd());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopTransferHead = new DataTable();
                SqlDataAdapter ShopTransferDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblShopTransfers WHERE ShopTransferID = @ShopTransferID";
                    SelectCmd.Parameters.AddWithValue("@ShopTransferID", ShopTransferID);
                    ShopTransferDataAdapter.SelectCommand = SelectCmd;
                    ShopTransferDataAdapter.Fill(ShopTransferHead);
                }
                TxtTFNote.Text = ShopTransferHead.Rows[0][1].ToString();
                DtpDate.Value = Convert.ToDateTime(ShopTransferHead.Rows[0][2]);
                olddate = DtpDate.Value;
                TxtFromShopRef.Text = ShopTransferHead.Rows[0][3].ToString();
                clsShop shop = new clsShop();
                shop.ShopRef = TxtFromShopRef.Text.TrimEnd();
                txtFromShopName.Text = shop.GetShopName();
                TxtToShopRef.Text = ShopTransferHead.Rows[0][4].ToString();
                shop.ShopRef = TxtToShopRef.Text.TrimEnd();
                txtToShopName.Text = shop.GetShopName();
                txtTotalTransferTo.Text = ShopTransferHead.Rows[0][6].ToString();
            }
            DgvRecords.Columns.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable ShopAdjustLine = new DataTable();
                SqlDataAdapter ShopAdjustLineDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,CurrentQty,Qty from tblShopTranferLines WHERE ShopTransferID = @ShopTransferID";
                    SelectCmd.Parameters.AddWithValue("@ShopTransferID", ShopTransferID);
                    ShopAdjustLineDataAdapter.SelectCommand = SelectCmd;
                    ShopAdjustLineDataAdapter.Fill(ShopAdjustLine);
                    DgvRecords.DataSource = ShopAdjustLine;
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

        private void TxtFromShopRef_Leave(object sender, EventArgs e)
        {
            TxtFromShopRef.Text = clsShop.ChangeCase(TxtFromShopRef.Text, 1);
            clsShop Shop = new clsShop()
            {
                ShopRef = TxtFromShopRef.Text.TrimEnd()
            };
            txtFromShopName.Text = Shop.GetShopName();
            LoadShopsIntoForm_ToBox();
        }

        private void TxtToShopRef_Leave(object sender, EventArgs e)
        {
            TxtToShopRef.Text = clsShop.ChangeCase(TxtToShopRef.Text, 1);
            clsShop Shop = new clsShop()
            {
                ShopRef = TxtToShopRef.Text.TrimEnd()
            };
            txtToShopName.Text = Shop.GetShopName();
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {
            TxtStockCode.Text = clsUtils.ChangeCase(TxtStockCode.Text, 1);
            clsStock stock = new clsStock();
            stock.StockCode = TxtStockCode.Text.TrimEnd();
            stock.SupplierRef = TxtFromShopRef.Text.TrimEnd();
            TxtCurrentQty.Text = stock.GetWarehouseStockQty().ToString();
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
