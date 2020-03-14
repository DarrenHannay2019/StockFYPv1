using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
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
            if(FunctionID == 1)
            {
                clsWarehouse objWarehouse = new clsWarehouse(UserID);
                objWarehouse.LoadNewRecord();
            }
            if(FunctionID == 2)
            {
                clsShop objShop = new clsShop();
                objShop.LoadNewRecord();                
            }
            if (FunctionID == 3)
            {
                clsSupplier objSupplier = new clsSupplier(UserID);
                objSupplier.LoadNewRecord();
            }
            if (FunctionID == 4)
            {
                clsStock objStock = new clsStock();
                objStock.LoadNewForm();
            }
            if (FunctionID == 5)
            {
                clsStock objStock = new clsStock();
                objStock.LoadNewForm();
            }
            if (FunctionID == 6)
            {
                clsSeason objSeason = new clsSeason();
                objSeason.LoadNewSeasonForm();
            }
            if (FunctionID == 7)
            {
                clsPurchaseOrder objPurchaseOrder = new clsPurchaseOrder(UserID);
                objPurchaseOrder.LoadNewPurchaseOrder();
            }
            if (FunctionID == 8)
            {
                clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment();                
            }
            if (FunctionID == 9)
            {
                clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer();
            }
            if (FunctionID == 10)
            {
                clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn();
            }
            if (FunctionID == 11)
            {
                clsShopDelivery oShopDelivery = new clsShopDelivery();
            }
            if (FunctionID == 12)
            {
                clsShopAdjustment oShopAdjustment = new clsShopAdjustment();
            }
            if (FunctionID == 13)
            {
                clsShopTransfer oShopTransfer = new clsShopTransfer();
            }
            if (FunctionID == 14)
            {
                clsShopSale oShopSale = new clsShopSale();
            }
            if (FunctionID == 15)
            {
                clsShopReturn oShopReturn = new clsShopReturn();
            }
            TsbRefresh.PerformClick();
        }

        private void TsbRecord_Click(object sender, EventArgs e)
        {
            int selectid;
            selectid = DataGridView1.CurrentRow.Index;
            string i;
            i = DataGridView1.Rows[selectid].Cells[0].Value.ToString();
            if (FunctionID == 1)
            {
                clsWarehouse oWarehouse = new clsWarehouse(UserID)
                {
                    WarehouseRef = i
                };
                oWarehouse.LoadSelectedRecord();
            }
            if (FunctionID == 2)
            {
                clsShop oShop = new clsShop
                {
                    ShopRef = i
                };
                oShop.LoadSelectedRecord();
            }
            if (FunctionID == 3)
            {
                clsSupplier oSupplier = new clsSupplier(UserID)
                {
                    SupplierRef = i
                };
                oSupplier.LoadSelectedRecord();
            }
            if (FunctionID == 4)
            {
                clsStock oStock = new clsStock
                {
                    StockCode = i
                };
                oStock.LoadSelectedForm();
            }
            if (FunctionID == 5)
            {
                clsStock oStock = new clsStock
                {
                    StockCode = i
                };
                oStock.LoadSelectedForm();
            }
            if (FunctionID == 6)
            {
                clsSeason oSeason = new clsSeason
                {
                    SeasonID = Convert.ToInt32(i)
                };
                oSeason.LoadSelectedSeasonForm();
            }
            if (FunctionID == 7)
            {
                clsPurchaseOrder oPurchaseOrder = new clsPurchaseOrder(UserID)
                {
                    PurchaseOrderID = Convert.ToInt32(i)
                };
                oPurchaseOrder.LoadSelectedPurchaseOrder();               
            }
            if (FunctionID == 8)
            {
                clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment();
            }
            if (FunctionID == 9)
            {
                clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer();
            }
            if (FunctionID == 10)
            {
                clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn();
            }
            if (FunctionID == 11)
            {
                clsShopDelivery oShopDelivery = new clsShopDelivery();
            }
            if (FunctionID == 12)
            {
                clsShopAdjustment oShopAdjustment = new clsShopAdjustment();
            }
            if (FunctionID == 13)
            {
                clsShopTransfer oShopTransfer = new clsShopTransfer();
            }
            if (FunctionID == 14)
            {
                clsShopSale oShopSale = new clsShopSale();
            }
            if (FunctionID == 15)
            {
                clsShopReturn oShopReturn = new clsShopReturn();
            }
            TsbRefresh.PerformClick();
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            int selectid;
            int NoRecords = 0;
            selectid = DataGridView1.CurrentRow.Index;
            string i;
            i = DataGridView1[0, selectid].Value.ToString();
            if (FunctionID == 1)
            {
                clsWarehouse oWarehouse = new clsWarehouse(UserID)
                {
                    WarehouseRef = i
                };
                NoRecords = oWarehouse.TotalWarehouseRecords();
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                   
                    oWarehouse.DeleteWarehouseRecord();
                }
            }
            if (FunctionID == 2)
            {
                clsShop oShop = new clsShop
                {
                    ShopRef = i
                };
                NoRecords = oShop.TotalShopRecords();
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Shop Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                    
                    oShop.DeleteShopRecord();
                }
            }
            if (FunctionID == 3)
            {
                clsSupplier oSupplier = new clsSupplier(UserID)
                {
                    SupplierRef = i
                };
                
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oSupplier.DeleteSupplierRecord();                 
                }
            }
            if (FunctionID == 4)
            {
                clsStock oStock = new clsStock
                {
                    StockCode = i
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oStock.DeleteStockCode();
                }

            }
            if (FunctionID == 5)
            {
                clsStock oStock = new clsStock
                {
                    StockCode = i
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oStock.DeleteStockCode();
                }
            }
            if (FunctionID == 6)
            {
                clsSeason oSeason = new clsSeason
                {
                    SeasonID = Convert.ToInt32(i)
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oSeason.DeleteSeasonName();
                }
            }
            if (FunctionID == 7)
            {
                clsPurchaseOrder oPurchaseOrder = new clsPurchaseOrder
                {
                    PurchaseOrderID = Convert.ToInt32(i)
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    clsPurchaseOrderLine orderLine = new clsPurchaseOrderLine
                    {
                        PurchaseOrderID = oPurchaseOrder.PurchaseOrderID
                    };
                    clsPurchaseOrderHead orderHead = new clsPurchaseOrderHead(UserID)
                    {
                        PurchaseOrderID = oPurchaseOrder.PurchaseOrderID
                    };
                    orderLine.DeletePurchaseOrderLineRecord();
                    orderHead.DeletePurchaseOrderHeadRecord();
                }

            }
            if (FunctionID == 8)
            {
                clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment();
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                }
            }
            if (FunctionID == 9)
            {
                clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer();
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                }
            }
            if (FunctionID == 10)
            {
                clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn();
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                }
            }
            if (FunctionID == 11)
            {
                clsShopDelivery oShopDelivery = new clsShopDelivery();
            }
            if (FunctionID == 12)
            {
                clsShopAdjustment oShopAdjustment = new clsShopAdjustment();
            }
            if (FunctionID == 13)
            {
                clsShopTransfer oShopTransfer = new clsShopTransfer();
            }
            if (FunctionID == 14)
            {
                clsShopSale oShopSale = new clsShopSale();
            }
            if (FunctionID == 15)
            {
                clsShopReturn oShopReturn = new clsShopReturn();
            }
            if (NoRecords != 0)
            {
                MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TsbRefresh.PerformClick();
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            BindingSource1.DataSource = "";
            LoadData();
            CustomiseDataGrid();
        }

        private void TsbPrint_Click(object sender, EventArgs e)
        {
            if (FunctionID == 1)
            {
                // Warehouses
            }
            if (FunctionID == 2)
            {
                // Shops
            }
            if (FunctionID == 3)
            {
                //Suppliers
            }
            if (FunctionID == 4)
            {
                //Stock
            }
            if (FunctionID == 5)
            {
                //Stock
            }
            if (FunctionID == 6)
            {
                // season

            }
            if (FunctionID == 7)
            {
                // Purchase Orders

            }
            if (FunctionID == 8)
            {
                // clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment();
            }
            if (FunctionID == 9)
            {
                // clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer();
            }
            if (FunctionID == 10)
            {
                // clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn();
            }
            if (FunctionID == 11)
            {
                // clsShopDelivery oShopDelivery = new clsShopDelivery();
            }
            if (FunctionID == 12)
            {
                // clsShopAdjustment oShopAdjustment = new clsShopAdjustment();
            }
            if (FunctionID == 13)
            {
                // clsShopTransfer oShopTransfer = new clsShopTransfer();
            }
            if (FunctionID == 14)
            {
                // clsShopSale oShopSale = new clsShopSale();
            }
            if (FunctionID == 15)
            {
                //  clsShopReturn oShopReturn = new clsShopReturn();
            }
        }

        private void TsbFind_Click(object sender, EventArgs e)
        {           
            if (FunctionID == 1)
            {
                // Warehouses
                BindingSource1.Filter = "WarehouseRef Like '%" + Interaction.InputBox("Please Enter a Warehouse Reference Code",Application.ProductName) +"'";
            }
            if (FunctionID == 2)
            {
                // Shops
                BindingSource1.Filter = "ShopRef Like '%" + Interaction.InputBox("Please Enter a Shop Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 3)
            {
                //Suppliers
                BindingSource1.Filter = "SupplierRef Like '%" + Interaction.InputBox("Please Enter a Supplier Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 4)
            {
                //Stock
                BindingSource1.Filter = "SupplierRef Like '%" + Interaction.InputBox("Please Enter a Supplier Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 5)
            {
                //Stock
                BindingSource1.Filter = "SupplierRef Like '%" + Interaction.InputBox("Please Enter a Supplier Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 6)
            {
                // season
                BindingSource1.Filter = "SeasonName Like '%" + Interaction.InputBox("Please Enter a Season Name", Application.ProductName) + "'";

            }
            if (FunctionID == 7)
            {
                // Purchase Orders
                BindingSource1.Filter = "LocationRef Like '%" + Interaction.InputBox("Please Enter a Warehouse / Shop Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 8)
            {
                // clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment();
                BindingSource1.Filter = "WarehouseRef Like '%" + Interaction.InputBox("Please Enter a Warehouse Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 9)
            {
                // clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer();
                BindingSource1.Filter = "WarehouseRef Like '%" + Interaction.InputBox("Please Enter a Warehouse Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 10)
            {
                // clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn();
                BindingSource1.Filter = "WarehouseRef Like '%" + Interaction.InputBox("Please Enter a Warehouse Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 11)
            {
                // clsShopDelivery oShopDelivery = new clsShopDelivery();
                BindingSource1.Filter = "WarehouseRef Like '%" + Interaction.InputBox("Please Enter a Warehouse Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 12)
            {
                // clsShopAdjustment oShopAdjustment = new clsShopAdjustment();
                BindingSource1.Filter = "ShopRef Like '%" + Interaction.InputBox("Please Enter a Shop Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 13)
            {
                // clsShopTransfer oShopTransfer = new clsShopTransfer();
                BindingSource1.Filter = "FromShopRef Like '%" + Interaction.InputBox("Please Enter a Shop Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 14)
            {
                // clsShopSale oShopSale = new clsShopSale();
                BindingSource1.Filter = "ShopRef Like '%" + Interaction.InputBox("Please Enter a Shop Reference Code", Application.ProductName) + "'";
            }
            if (FunctionID == 15)
            {
                //  clsShopReturn oShopReturn = new clsShopReturn();
                BindingSource1.Filter = "WarehouseRef Like '%" + Interaction.InputBox("Please Enter a Warehouse Reference Code", Application.ProductName) + "'";
            }
            TSSCount.Text = DataGridView1.Rows.Count.ToString();
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
            // To give all functions a default look to the datagrids
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
                TSSLFunction.Text = "Warehouses";
            }
            if(FunctionID == 2)
            {
                // ShopRef
                DataGridView1.Columns[0].Width = 70;
                DataGridView1.Columns[0].HeaderText = "Shop Ref";
                // ShopName
                DataGridView1.Columns[1].Width = 220;
                DataGridView1.Columns[1].HeaderText = "Shop Name";
                // ShopType
                DataGridView1.Columns[2].Width = 120;
                DataGridView1.Columns[2].HeaderText = "Shop Type";
                TSSLFunction.Text = "Shops";
            }
            if(FunctionID == 3)
            {
                // SupplierRef
                DataGridView1.Columns[0].Width = 70;
                DataGridView1.Columns[0].HeaderText = "Supplier Ref";
                // SupplierName
                DataGridView1.Columns[1].Width = 220;
                DataGridView1.Columns[1].HeaderText = "Supplier Name";
                // ContactName
                DataGridView1.Columns[2].Width = 120;
                DataGridView1.Columns[2].HeaderText = "Contact Name";
                // Telephone
                DataGridView1.Columns[3].Width = 120;
                DataGridView1.Columns[3].HeaderText = "Telephone Number";
                TSSLFunction.Text = "Suppliers";
            }
            if(FunctionID == 4)
            {
                TSSLFunction.Text = "Current Stock";
            }
            if(FunctionID == 5)
            {
                TSSLFunction.Text = "All Stock";
            }
            if (FunctionID == 6)
            {
                // WarehouseRef
                DataGridView1.Columns[0].Width = 70;
                DataGridView1.Columns[0].HeaderText = "Season ID";
                // WarehouseName
                DataGridView1.Columns[1].Width = 220;
                DataGridView1.Columns[1].HeaderText = "Season Name";
                TSSLFunction.Text = "Seasons";
            }
            if (FunctionID == 7)
            {
                TSSLFunction.Text = "Purchase Orders";
            }
            if (FunctionID == 8)
            {
                TSSLFunction.Text = "Warehouse Adjustments";
            }
            if (FunctionID == 9)
            {
                TSSLFunction.Text = "Warehouse Transfers";
            }
            if (FunctionID == 10)
            {
                TSSLFunction.Text = "Warehouse Returns";
            }
            if (FunctionID == 11)
            {
                TSSLFunction.Text = "Shop Deliveries";
            }
            if (FunctionID == 12)
            {
                TSSLFunction.Text = "Shop Adjustments";
            }
            if (FunctionID == 13)
            {
                TSSLFunction.Text = "Shop Transfers";
            }
            if (FunctionID == 14)
            {
                TSSLFunction.Text = "Shop Sales";
            }
            if (FunctionID == 15)
            {
                TSSLFunction.Text = "Shop Returns";
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
            if (FunctionID == 8)
            {

            }
            if (FunctionID == 9)
            {

            }
            if (FunctionID == 10)
            {

            }
            if (FunctionID == 11)
            {

            }
            if (FunctionID == 12)
            {

            }
            if (FunctionID == 13)
            {

            }
            if (FunctionID == 14)
            {

            }
            if (FunctionID == 15)
            {

            }
            return SqlCmdString;
        }
        #endregion
    }
}
