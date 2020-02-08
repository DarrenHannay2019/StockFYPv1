using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        }
        #region DataLoading
        private void LoadData()
        { 
            // To Load Data from the database based on the function selected
            using (SqlConnection conn = new SqlConnection())
            {
                clsUtils clsUtils = new clsUtils();
                conn.ConnectionString = clsUtils.GetConnString(1);
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = GetFunctionSelectString();
                }
            }
        }
        private void CustomiseDataGrid()
        {

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
            return SqlCmdString;
        }
        #endregion
    }
}
