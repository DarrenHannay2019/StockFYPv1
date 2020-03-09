namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmWarehouseAdjustment : Form
    {
        public string FormMode { get; set; }
        public frmWarehouseAdjustment()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)dgvItems.Rows.Add();
            dgvItems.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[1].Value = TxtCurrentHangers.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[2].Value = CboType.Text.TrimEnd();
            dgvItems.Rows[rownum].Cells[3].Value = TxtAdjustHangers.Text.TrimEnd();
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
            if (FormMode == "New")
            {

            }
            else
            {

            }
            this.Close();
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
                if (dgvItems.Rows[i].Cells[2].Value.ToString() == "Stock Gain")
                    lqtyhangers += Convert.ToInt32(dgvItems.Rows[i].Cells[3].Value);
                else
                    lngqtyhangers += Convert.ToInt32(dgvItems.Rows[i].Cells[3].Value);
            }
            TxtTotalGain.Text = lngqtyhangers.ToString();
            TxtTotalLoss.Text = lqtyhangers.ToString();

        }
        private void LoadData()
        {

        }
    }
}
