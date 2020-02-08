using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace DMHV2
{
    public partial class frmDataGrid : Form
    {
        public int UserID;
        public int FunctionID { get; set; }
        private string SqlCmdString { get; set; }
        public frmDataGrid()
        {
            InitializeComponent();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {

        }

        private void TsbRecord_Click(object sender, EventArgs e)
        {

        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {

        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void TsbPrint_Click(object sender, EventArgs e)
        {

        }

        private void TsbFind_Click(object sender, EventArgs e)
        {

        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();   // close the data grid view screen
        }

        private void frmDataGrid_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupStyleGrid();
            CustomiseDataGrid();
        }
        #region CustomiseDataGrid
        private void SetupStyleGrid()
        {
            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridView1.BackgroundColor = Color.LightCoral;
            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Plum;
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.AllowUserToResizeColumns = false;
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
        }
        #endregion
        #region DataLoading
        private void LoadData()
        { 
            // To Load Data from the database based on the function selected
            using (SqlConnection conn = new SqlConnection())
            {
                clsUtils clsUtils = new clsUtils();
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = GetFunctionSelectString();                   
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dataTable);
                }
                BindingSource1.DataSource = dataTable;
                DataGridView1.DataSource = BindingSource1;
                TSSCount.Text = DataGridView1.Rows.Count.ToString();
            }
        }
        private void CustomiseDataGrid()
        {
            // This will format the data grid of the right side of the main interface
            // this will also change the function of the stock check icon
            // Suppliers will not have the stock check icon.
            if (FunctionID == 1) // Warehouses
            {
                // WarehouseRef
                DataGridView1.Columns[0].Width = 70;
                DataGridView1.Columns[0].HeaderText = "Warehouse Ref";
                // WarehouseName
                DataGridView1.Columns[1].Width = 220;
                DataGridView1.Columns[1].HeaderText = "Warehouse Name";
                // WarehouseType
                DataGridView1.Columns[2].Width = 120;
                DataGridView1.Columns[2].HeaderText = "Warehouse Type";
            }
        }
        private string GetFunctionSelectString()
        {
            if(FunctionID == 1)
            {
                SqlCmdString = "Select WarehouseRef,WarehouseName,WarehouseType from tblWarehouses";
            }
            else if(FunctionID == 2)
            {
                SqlCmdString = "Select ShopRef, ShopName, ShopType from tblShops";
            }
            else if (FunctionID == 3)
            {
                SqlCmdString = "Select SupplierRef, SupplierName, ContactName, Telephone from tblSuppliers";
            }
            else if (FunctionID == 4)
            {
                SqlCmdString = "Select * from tblStock WHERE deadcode = 0";
            }
            else if (FunctionID == 5)
            {
                SqlCmdString = "Select * from tblStock";
            }
            else if (FunctionID == 6)
            {
                SqlCmdString = "SELECT * from tblSeasons";
            }
            else if (FunctionID == 7)
            {
                SqlCmdString = "SELECT * from tblPurchaseOrders";
            }
            return SqlCmdString;
        }
        #endregion
    }
}
