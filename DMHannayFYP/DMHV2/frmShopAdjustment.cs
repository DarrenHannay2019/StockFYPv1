namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmShopAdjustment : Form
    {
        public string FormMode { get; set; }
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
        //    Using conn As New SqlConnection(ut.GetConnString())
        //    Dim dt As New DataTable
        //    Dim adp As New SqlDataAdapter With {
        //        .SelectCommand = New SqlCommand("SELECT * from qryShopAdjustNew WHERE ID = '" + TxtSID.Text.ToString() + "'", conn)}
        //    conn.Open()
        //    adp.Fill(dt)
        //    With Me
        //        .CmdOK.Text = "OK"
        //        .txtWarehouseRef.Text = dt.Rows(0).Item("ShopRef")
        //        .txtReference.Text = dt.Rows(0).Item("Reference")
        //        .txtWarehouseName.Text = dt.Rows(0).Item("ShopName")
        //        .txtTotalGain.Text = dt.Rows(0).Item("TotalGainItems")
        //        .txtTotalLoss.Text = dt.Rows(0).Item("TotalLossItems")
        //        .DateTimePicker1.Value = dt.Rows(0).Item("MovementDate")
        //    End With
        //End Using
        //With Me
        //    .DataGridView1.Columns.Clear()
        //    Using conn As New SqlConnection(ut.GetConnString())
        //        Dim dgd As New SqlDataAdapter("SELECT * from tblShopAdjustmentsLines WHERE ShopAdjustID = '" + TxtSID.Text.ToString() + "'", conn)
        //        Dim ds As New DataTable
        //        dgd.Fill(ds)
        //        With.DataGridView1
        //            .DataSource = ds
        //            .AutoGenerateColumns = True
        //            .EditMode = DataGridViewEditMode.EditOnF2
        //            .CellBorderStyle = DataGridViewCellBorderStyle.None
        //            .BackgroundColor = Color.LightCoral
        //            .DefaultCellStyle.SelectionBackColor = Color.Red
        //            .DefaultCellStyle.SelectionForeColor = Color.Yellow
        //            .ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        //            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        //            .DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
        //            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        //            .AllowUserToResizeColumns = False
        //            .RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        //            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
        //            With.Columns
        //                .Item(0).Visible = False
        //                .Item(1).Visible = False
        //                .Item(2).Visible = True
        //                .Item(2).HeaderText = "Stock Code"
        //                .Item(2).Width = 80
        //                .Item(3).Visible = True
        //                .Item(3).HeaderText = "Movement Type"
        //                .Item(4).Visible = True
        //                .Item(4).HeaderText = "Qty"
        //                .Item(4).Width = 80
        //                .Item(5).Visible = False
        //            End With
        //        End With
        //    End Using
        //End With
        }
    }
}
