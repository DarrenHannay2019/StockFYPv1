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
        #region Functions
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
                objShop.UserID = UserID;
                objShop.LoadNewRecord();                
            }
            if (FunctionID == 3)
            {
                clsSupplier objSupplier = new clsSupplier(UserID);
                objSupplier.LoadNewRecord();
            }
            if (FunctionID == 4)
            {
                clsStock objStock = new clsStock
                {
                    UserID = UserID
                };
                objStock.LoadNewForm();
            }
            if (FunctionID == 5)
            {
                clsStock objStock = new clsStock
                {
                    UserID = UserID
                };
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
                oWarehouseAdjustment.UserID = UserID;
                oWarehouseAdjustment.LoadNewForm();
            }
            if (FunctionID == 9)
            {
                clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer
                {
                    UserID = UserID                    
                };
                oWarehouseTransfer.LoadNewForm();
            }
            if (FunctionID == 10)
            {
                clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn
                {
                    UserID = UserID
                };
                oWarehouseReturn.LoadNewForm();
            }
            if (FunctionID == 11)
            {
                clsShopDelivery oShopDelivery = new clsShopDelivery
                {
                    UserID = UserID
                };
                oShopDelivery.LoadNewForm();
            }
            if (FunctionID == 12)
            {
                clsShopAdjustment oShopAdjustment = new clsShopAdjustment
                {
                    UserID = UserID
                };
                oShopAdjustment.LoadNewForm();
            }
            if (FunctionID == 13)
            {
                clsShopTransfer oShopTransfer = new clsShopTransfer()
                {
                    UserID = UserID
                };
                oShopTransfer.LoadNewForm();
            }
            if (FunctionID == 14)
            {
                clsShopSale oShopSale = new clsShopSale
                {
                    UserID = UserID
                };
                oShopSale.LoadNewForm();
            }
            if (FunctionID == 15)
            {
                clsShopReturn oShopReturn = new clsShopReturn
                {
                    UserID = UserID
                };
                oShopReturn.LoadNewForm();
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
                clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment
                {
                    UserID = UserID,
                    WarehouseAdjustmentID = Convert.ToInt32(i)
                };
                oWarehouseAdjustment.LoadSelectedForm();

            }
            if (FunctionID == 9)
            {
                clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer
                {
                    WarehouseTransferID = Convert.ToInt32(i),
                    UserID = UserID
                };
                oWarehouseTransfer.LoadSelectedForm();
            }
            if (FunctionID == 10)
            {
                clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn
                {
                    WarehouseReturnID = Convert.ToInt32(i),
                    UserID = UserID
                };
            }
            if (FunctionID == 11)
            {
                clsShopDelivery oShopDelivery = new clsShopDelivery();
                oShopDelivery.ShopDelID = Convert.ToInt32(i);
                oShopDelivery.UserID = UserID;
            }
            if (FunctionID == 12)
            {
                clsShopAdjustment oShopAdjustment = new clsShopAdjustment
                {
                    UserID = UserID,
                    ID = Convert.ToInt32(i)
                };
                oShopAdjustment.LoadSelectedForm();
            }
            if (FunctionID == 13)
            {
                clsShopTransfer oShopTransfer = new clsShopTransfer
                {
                    UserID = UserID,
                    ShopTransferID = Convert.ToInt32(i)
                };
                oShopTransfer.LoadSelectedForm();
            }
            if (FunctionID == 14)
            {
                clsShopSale oShopSale = new clsShopSale
                {
                    SalesID = Convert.ToInt32(i),
                    UserID = UserID
                };
                oShopSale.LoadSelectedForm();
            }
            if (FunctionID == 15)
            {
                clsShopReturn oShopReturn = new clsShopReturn
                {
                    ShopReturnID = Convert.ToInt32(i),
                    UserID = UserID
                };
                oShopReturn.LoadSelectedForm();
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
                clsWarehouseAdjustment oWarehouseAdjustment = new clsWarehouseAdjustment
                {
                    WarehouseAdjustmentID = Convert.ToInt32(selectid)
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    clsWarehouseAdjustmentHead adjustmentHead = new clsWarehouseAdjustmentHead
                    {
                        WarehouseAdjustmentID = oWarehouseAdjustment.WarehouseAdjustmentID
                    };
                    clsWarehouseAdjustmentLine adjustmentLine = new clsWarehouseAdjustmentLine
                    {
                        WarehouseAdjustmentID = oWarehouseAdjustment.WarehouseAdjustmentID
                    };
                    adjustmentLine.DeleteWarehouseAdjustmentLine();
                    adjustmentHead.DeleteWarehouseAdjustmentHead();
                }
            }
            if (FunctionID == 9)
            {
                clsWarehouseTransfer oWarehouseTransfer = new clsWarehouseTransfer
                {
                    WarehouseTransferID = Convert.ToInt32(selectid)
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    clsWarehouseTransferHead transferHead = new clsWarehouseTransferHead
                    {
                        WarehouseTransferID = oWarehouseTransfer.WarehouseTransferID
                    };
                    clsWarehouseTransferLine transferLine = new clsWarehouseTransferLine
                    {
                        WarehouseTransferID = oWarehouseTransfer.WarehouseTransferID
                    };
                    transferLine.DeleteWarehouseTransferLine();
                    transferHead.DeleteWarehouseTransferHead();
                }
            }
            if (FunctionID == 10)
            {
                clsWarehouseReturn oWarehouseReturn = new clsWarehouseReturn
                {
                    WarehouseReturnID = Convert.ToInt32(selectid)
                };
                if (NoRecords != 0)
                {
                    MessageBox.Show("Unable to remove Warehouse Record from the database!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    clsWarehouseReturnHead returnHead = new clsWarehouseReturnHead
                    {
                        WarehouseReturnID = oWarehouseReturn.WarehouseReturnID
                    };
                    clsWarehouseReturnLine returnLine = new clsWarehouseReturnLine
                    {
                        WarehouseReturnID = oWarehouseReturn.WarehouseReturnID
                    };
                    returnLine.DeleteWarehouseReturnLine();
                    returnHead.DeleteWarehouseReturnHead();
                }
            }
            if (FunctionID == 11)
            {
                clsShopDelivery oShopDelivery = new clsShopDelivery
                {
                    ShopDelID = Convert.ToInt32(selectid)
                };
                clsShopDeliveryHead deliveryHead = new clsShopDeliveryHead
                { 
                    ShopDelID = oShopDelivery.ShopDelID
                };
                clsShopDeliveryLine deliveryLine = new clsShopDeliveryLine
                {
                    ShopDelID = oShopDelivery.ShopDelID
                };
                deliveryLine.DeleteShopDeliveryLine();
                deliveryHead.DeleteShopDeliveryHead();
            }
            if (FunctionID == 12)
            {
                clsShopAdjustment oShopAdjustment = new clsShopAdjustment
                {
                    ID = Convert.ToInt32(selectid)
                };
                clsShopAdjustmentHead adjustmentHead = new clsShopAdjustmentHead
                {
                    ID = oShopAdjustment.ID
                };
                clsShopAdjustmentLine adjustmentLine = new clsShopAdjustmentLine
                {
                    ID = oShopAdjustment.ID
                };
                adjustmentLine.DeleteShopAdjustLine();
                adjustmentHead.DeleteShopAdjustHead();

            }
            if (FunctionID == 13)
            {
                clsShopTransfer oShopTransfer = new clsShopTransfer
                {
                    ShopTransferID = Convert.ToInt32(selectid)
                };
                clsShopTransferHead transferHead = new clsShopTransferHead
                {
                    ShopTransferID = oShopTransfer.ShopTransferID
                };
                clsShopTransferLine transferLine = new clsShopTransferLine
                {
                    ShopTransferID = oShopTransfer.ShopTransferID
                };
                transferLine.DeleteShopTransferLine();
                transferHead.DeleteShopTransferHead();
            }
            if (FunctionID == 14)
            {
                clsShopSale oShopSale = new clsShopSale
                {
                    SalesID = Convert.ToInt32(selectid)
                };
                clsShopSaleHead saleHead = new clsShopSaleHead
                {
                    SalesID = oShopSale.SalesID
                };
                clsShopSaleLine saleLine = new clsShopSaleLine
                {
                    SalesID = oShopSale.SalesID
                };
                saleLine.DeleteShopSaleLine();
                saleHead.DeleteShopSaleHead();
            }
            if (FunctionID == 15)
            {
                clsShopReturn oShopReturn = new clsShopReturn
                {
                    ShopReturnID = Convert.ToInt32(selectid)
                };
                clsShopReturnHead returnHead = new clsShopReturnHead
                {
                    ShopReturnID = oShopReturn.ShopReturnID
                };
                clsShopReturnLine returnLine = new clsShopReturnLine
                {
                    ShopReturnID = oShopReturn.ShopReturnID
                };
                returnLine.DeleteShopReturnLine();
                returnHead.DeleteShopReturnHead();
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
        #endregion Function
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
            if (FunctionID == 2)
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
            if (FunctionID == 3)
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
            if (FunctionID == 4)
            {
                // Stock Code
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // SupplierRef
                DataGridView1.Columns[1].HeaderText = "Supplier Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // SeasonName
                DataGridView1.Columns[2].HeaderText = "Season Name";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // DeadCode
                DataGridView1.Columns[3].HeaderText = "Dead Code";
                DataGridView1.Columns[3].Width = 50;
                DataGridView1.Columns[3].Visible = true;
                // AmountTaken
                DataGridView1.Columns[4].HeaderText = "Sales Amount";
                DataGridView1.Columns[4].Width = 100;
                DataGridView1.Columns[4].Visible = true;
                DataGridView1.Columns[4].DefaultCellStyle.Format = "C2";
                // DeliveredQtyHangers
                DataGridView1.Columns[5].HeaderText = "Qty Hangers";
                DataGridView1.Columns[5].Width = 50;
                DataGridView1.Columns[5].Visible = true;
                // DeliveredQtyBoxes
                DataGridView1.Columns[6].HeaderText = "Qty Boxes";
                DataGridView1.Columns[6].Width = 80;
                DataGridView1.Columns[6].Visible = true;
                // DeliveredQtyGarments
                DataGridView1.Columns[7].HeaderText = "Qty Garments";
                DataGridView1.Columns[7].Width = 80;
                DataGridView1.Columns[7].Visible = true;
                // CostValue
                DataGridView1.Columns[8].HeaderText = "Purchase Value";
                DataGridView1.Columns[8].Width = 100;
                DataGridView1.Columns[8].Visible = true;
                DataGridView1.Columns[8].DefaultCellStyle.Format = "C2";
                // PCMarkup
                DataGridView1.Columns[9].HeaderText = "Profit";
                DataGridView1.Columns[9].Width = 100;
                DataGridView1.Columns[9].Visible = true;
                DataGridView1.Columns[9].DefaultCellStyle.Format = "P2";
                // ZeroQty
                DataGridView1.Columns[10].HeaderText = "Zero Qty";
                DataGridView1.Columns[10].Width = 50;
                DataGridView1.Columns[10].Visible = true;
                // CreatedBy
                DataGridView1.Columns[11].HeaderText = "Created By";
                DataGridView1.Columns[11].Width = 80;
                DataGridView1.Columns[11].Visible = true;
                // CreatedDate
                DataGridView1.Columns[12].HeaderText = "Created Date";
                DataGridView1.Columns[12].Width = 100;
                DataGridView1.Columns[12].Visible = true;
                TSSLFunction.Text = "Current Stock";
            }
            if (FunctionID == 5)
            {
                // Stock Code
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // SupplierRef
                DataGridView1.Columns[1].HeaderText = "Supplier Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // SeasonName
                DataGridView1.Columns[2].HeaderText = "Season Name";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // DeadCode
                DataGridView1.Columns[3].HeaderText = "Dead Code";
                DataGridView1.Columns[3].Width = 50;
                DataGridView1.Columns[3].Visible = true;
                // AmountTaken
                DataGridView1.Columns[4].HeaderText = "Sales Amount";
                DataGridView1.Columns[4].Width = 100;
                DataGridView1.Columns[4].Visible = true;
                DataGridView1.Columns[4].DefaultCellStyle.Format = "C2";
                // DeliveredQtyHangers
                DataGridView1.Columns[5].HeaderText = "Qty Hangers";
                DataGridView1.Columns[5].Width = 50;
                DataGridView1.Columns[5].Visible = true;
                // DeliveredQtyBoxes
                DataGridView1.Columns[6].HeaderText = "Qty Boxes";
                DataGridView1.Columns[6].Width = 80;
                DataGridView1.Columns[6].Visible = true;
                // DeliveredQtyGarments
                DataGridView1.Columns[7].HeaderText = "Qty Garments";
                DataGridView1.Columns[7].Width = 80;
                DataGridView1.Columns[7].Visible = true;
                // CostValue
                DataGridView1.Columns[8].HeaderText = "Purchase Value";
                DataGridView1.Columns[8].Width = 100;
                DataGridView1.Columns[8].Visible = true;
                DataGridView1.Columns[8].DefaultCellStyle.Format = "C2";
                // PCMarkup
                DataGridView1.Columns[9].HeaderText = "Profit";
                DataGridView1.Columns[9].Width = 100;
                DataGridView1.Columns[9].Visible = true;
                DataGridView1.Columns[9].DefaultCellStyle.Format = "P2";
                // ZeroQty
                DataGridView1.Columns[10].HeaderText = "Zero Qty";
                DataGridView1.Columns[10].Width = 50;
                DataGridView1.Columns[10].Visible = true;
                // CreatedBy
                DataGridView1.Columns[11].HeaderText = "Created By";
                DataGridView1.Columns[11].Width = 80;
                DataGridView1.Columns[11].Visible = true;
                // CreatedDate
                DataGridView1.Columns[12].HeaderText = "Created Date";
                DataGridView1.Columns[12].Width = 100;
                DataGridView1.Columns[12].Visible = true;
                TSSLFunction.Text = "All Stock";
            }
            if (FunctionID == 6)
            {
                // Season ID
                DataGridView1.Columns[0].Width = 70;
                DataGridView1.Columns[0].HeaderText = "Season ID";
                // Season Name
                DataGridView1.Columns[1].Width = 220;
                DataGridView1.Columns[1].HeaderText = "Season Name";
                TSSLFunction.Text = "Seasons";
            }
            if (FunctionID == 7)
            {
                // Purchase Order ID
                DataGridView1.Columns[0].HeaderText = "Order ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Our Ref
                DataGridView1.Columns[1].HeaderText = "Our Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Supplier Ref
                DataGridView1.Columns[2].HeaderText = "Supplier Ref";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // Location Ref
                DataGridView1.Columns[3].HeaderText = "Location Ref";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // Season Name
                DataGridView1.Columns[4].HeaderText = "Season Name";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Total Items
                DataGridView1.Columns[5].HeaderText = "Total Items";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // Total Boxes
                DataGridView1.Columns[6].HeaderText = "Total Boxes";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Total Loose
                DataGridView1.Columns[7].HeaderText = "Total Loose";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                // Net Amount
                DataGridView1.Columns[8].HeaderText = "Net Amount";
                DataGridView1.Columns[8].Width = 150;
                DataGridView1.Columns[8].Visible = true;
                DataGridView1.Columns[8].DefaultCellStyle.Format = "C2";
                // Delivery Charage
                DataGridView1.Columns[9].HeaderText = "Delivery Charge";
                DataGridView1.Columns[9].Width = 150;
                DataGridView1.Columns[9].Visible = true;
                DataGridView1.Columns[9].DefaultCellStyle.Format = "C2";
                // Commission
                DataGridView1.Columns[10].HeaderText = "Commission";
                DataGridView1.Columns[10].Width = 150;
                DataGridView1.Columns[10].Visible = true;
                DataGridView1.Columns[10].DefaultCellStyle.Format = "C2";
                // VAT Amount
                DataGridView1.Columns[11].HeaderText = "VAT Amount";
                DataGridView1.Columns[11].Width = 150;
                DataGridView1.Columns[11].Visible = true;
                DataGridView1.Columns[11].DefaultCellStyle.Format = "C2";
                // Total Amount
                DataGridView1.Columns[12].HeaderText = "Total Amount";
                DataGridView1.Columns[12].Width = 150;
                DataGridView1.Columns[12].Visible = true;
                DataGridView1.Columns[12].DefaultCellStyle.Format = "C2";
                // Delivery Date
                DataGridView1.Columns[13].HeaderText = "Delivery Date";
                DataGridView1.Columns[13].Width = 150;
                DataGridView1.Columns[13].Visible = true;
                // Delivery Type
                DataGridView1.Columns[14].HeaderText = "Delivery Type";
                DataGridView1.Columns[14].Width = 150;
                DataGridView1.Columns[14].Visible = true;
                // Notes
                DataGridView1.Columns[15].HeaderText = "Notes";
                DataGridView1.Columns[15].Width = 150;
                DataGridView1.Columns[15].Visible = true;
                // Invoice Number
                DataGridView1.Columns[16].HeaderText = "Invoice";
                DataGridView1.Columns[16].Width = 150;
                DataGridView1.Columns[16].Visible = true;
                // Shipper Name
                DataGridView1.Columns[17].HeaderText = "Shipper";
                DataGridView1.Columns[17].Width = 150;
                DataGridView1.Columns[17].Visible = true;
                // Shipper Invoice
                DataGridView1.Columns[18].HeaderText = "Shipper Invoice";
                DataGridView1.Columns[18].Width = 150;
                DataGridView1.Columns[18].Visible = true;
                // Created By
                DataGridView1.Columns[19].HeaderText = "Created By";
                DataGridView1.Columns[19].Width = 150;
                DataGridView1.Columns[19].Visible = true;
                // Created Date
                DataGridView1.Columns[20].HeaderText = "Created Date";
                DataGridView1.Columns[20].Width = 150;
                DataGridView1.Columns[20].Visible = true;
                TSSLFunction.Text = "Purchase Orders";
            }
            if (FunctionID == 8)
            {
                // Warehouse Adjustment ID
                DataGridView1.Columns[0].HeaderText = "WH Adjust ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Warehouse Reference
                DataGridView1.Columns[1].HeaderText = "Warehouse Reference";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Reference
                DataGridView1.Columns[2].HeaderText = "Transaction Reference";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // Total Loss Items
                DataGridView1.Columns[3].HeaderText = "Total Loss Items";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // Total Gain Items
                DataGridView1.Columns[4].HeaderText = "Total Gain Items";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Movement Date
                DataGridView1.Columns[5].HeaderText = "Transaction Date";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // Created By
                DataGridView1.Columns[6].HeaderText = "Created By";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Created Date
                DataGridView1.Columns[7].HeaderText = "Created Date";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                TSSLFunction.Text = "Warehouse Adjustments";
            }
            if (FunctionID == 9)
            {
                // Warehouse Transfer ID
                DataGridView1.Columns[0].HeaderText = "WH Transfer ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Reference 
                DataGridView1.Columns[1].HeaderText = "Reference";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Transfer Date
                DataGridView1.Columns[2].HeaderText = "Transfer Date";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // From Warehouse Ref
                DataGridView1.Columns[3].HeaderText = "From Warehouse";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // To Warehouse Ref
                DataGridView1.Columns[4].HeaderText = "To Warehouse";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Total Qty In
                DataGridView1.Columns[5].HeaderText = "Qty In";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // Total Qty Out
                DataGridView1.Columns[6].HeaderText = "Qty Out";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Created By
                DataGridView1.Columns[7].HeaderText = "Created By";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                // Created Date
                DataGridView1.Columns[8].HeaderText = "Created Date";
                DataGridView1.Columns[8].Width = 150;
                DataGridView1.Columns[8].Visible = true;
                TSSLFunction.Text = "Warehouse Transfers";
            }
            if (FunctionID == 10)
            {
                // Warehouse Returns ID
                DataGridView1.Columns[0].HeaderText = "WH Return ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Warehouse Ref
                DataGridView1.Columns[1].HeaderText = "Warehouse Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Supplier Ref
                DataGridView1.Columns[2].HeaderText = "Supplier Ref";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // Reference
                DataGridView1.Columns[3].HeaderText = "Reference";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // Total items
                DataGridView1.Columns[4].HeaderText = "Total Items";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Transaction Date
                DataGridView1.Columns[5].HeaderText = "Transaction Date";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // Created By
                DataGridView1.Columns[6].HeaderText = "Created By";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Created Date
                DataGridView1.Columns[7].HeaderText = "Created Date";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                TSSLFunction.Text = "Warehouse Returns";
            }
            if (FunctionID == 11)
            {
                // Shop Deliveries ID
                DataGridView1.Columns[0].HeaderText = "Shop Delivery ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[9].DefaultCellStyle.Format = "00000000";
                // Shop Ref
                DataGridView1.Columns[1].HeaderText = "Shop Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Warehouse Ref
                DataGridView1.Columns[2].HeaderText = "Warehouse Ref";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // Reference
                DataGridView1.Columns[3].HeaderText = "Reference";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // Total Items
                DataGridView1.Columns[4].HeaderText = "Total Items";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Delivery Date
                DataGridView1.Columns[5].HeaderText = "Delivery Date";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // Delivery Type
                DataGridView1.Columns[6].HeaderText = "Delivery Type";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Confirmed Date
                DataGridView1.Columns[7].HeaderText = "Confirmed Date";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                // Notes
                DataGridView1.Columns[8].HeaderText = "Notes";
                DataGridView1.Columns[8].Width = 150;
                DataGridView1.Columns[8].Visible = true;
                // Created By
                DataGridView1.Columns[9].HeaderText = "Created By";
                DataGridView1.Columns[9].Width = 150;
                DataGridView1.Columns[9].Visible = true;
                // Created Date
                DataGridView1.Columns[10].HeaderText = "Created Date";
                DataGridView1.Columns[10].Width = 150;
                DataGridView1.Columns[10].Visible = true;
                TSSLFunction.Text = "Shop Deliveries";
            }
            if (FunctionID == 12)
            {
                // Shop Adjustment ID
                DataGridView1.Columns[0].HeaderText = "Shop Adjustment ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Shop Reference
                DataGridView1.Columns[1].HeaderText = "Shop Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Reference
                DataGridView1.Columns[2].HeaderText = "Reference";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // Total Loss Items
                DataGridView1.Columns[3].HeaderText = "Total Loss";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // Total Gain Items
                DataGridView1.Columns[4].HeaderText = "Total Gain";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Movement Date
                DataGridView1.Columns[5].HeaderText = "Movement Date";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // Created By
                DataGridView1.Columns[6].HeaderText = "Created By";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Created Date
                DataGridView1.Columns[7].HeaderText = "Created Date";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                TSSLFunction.Text = "Shop Adjustments";
            }
            if (FunctionID == 13)
            {
                // Shop Transfer ID
                DataGridView1.Columns[0].HeaderText = "SH Transfer ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Reference 
                DataGridView1.Columns[1].HeaderText = "Reference";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Transfer Date
                DataGridView1.Columns[2].HeaderText = "Transfer Date";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // From Shop Ref
                DataGridView1.Columns[3].HeaderText = "From Shop Ref";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // From Shop Name
                DataGridView1.Columns[4].HeaderText = "From Shop Name";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // To Shop Ref
                DataGridView1.Columns[5].HeaderText = "To Shop Ref";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                // To Shop Name
                DataGridView1.Columns[6].HeaderText = "To Shop Name";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                // Total Qty In
                DataGridView1.Columns[7].HeaderText = "Qty In";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                // Total Qty Out
                DataGridView1.Columns[8].HeaderText = "Qty Out";
                DataGridView1.Columns[8].Width = 150;
                DataGridView1.Columns[8].Visible = true;
                // Created By
                DataGridView1.Columns[9].HeaderText = "Created By";
                DataGridView1.Columns[9].Width = 150;
                DataGridView1.Columns[9].Visible = true;
                // Created Date
                DataGridView1.Columns[10].HeaderText = "Created Date";
                DataGridView1.Columns[10].Width = 150;
                DataGridView1.Columns[10].Visible = true;
                TSSLFunction.Text = "Shop Transfers";
            }
            if (FunctionID == 14)
            {
                // Sales ID
                DataGridView1.Columns[0].HeaderText = "Sales ID";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[0].DefaultCellStyle.Format = "000000";
                // Shop Ref
                DataGridView1.Columns[1].HeaderText = "Shop Ref";
                DataGridView1.Columns[1].Width = 150;
                DataGridView1.Columns[1].Visible = true;
                // Shop Name
                DataGridView1.Columns[2].HeaderText = "Shop Name";
                DataGridView1.Columns[2].Width = 150;
                DataGridView1.Columns[2].Visible = true;
                // Transaction Date
                DataGridView1.Columns[3].HeaderText = "Sales Date";
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[3].Visible = true;
                // Total Items
                DataGridView1.Columns[4].HeaderText = "Total Items";
                DataGridView1.Columns[4].Width = 150;
                DataGridView1.Columns[4].Visible = true;
                // Total VAT
                DataGridView1.Columns[5].HeaderText = "Total VAT";
                DataGridView1.Columns[5].Width = 150;
                DataGridView1.Columns[5].Visible = true;
                DataGridView1.Columns[5].DefaultCellStyle.Format = "P2";
                // Total Value
                DataGridView1.Columns[6].HeaderText = "Total Value";
                DataGridView1.Columns[6].Width = 150;
                DataGridView1.Columns[6].Visible = true;
                DataGridView1.Columns[6].DefaultCellStyle.Format = "P2";
                // Created By
                DataGridView1.Columns[7].HeaderText = "Created By";
                DataGridView1.Columns[7].Width = 150;
                DataGridView1.Columns[7].Visible = true;
                // Created Date
                DataGridView1.Columns[8].HeaderText = "Created Date";
                DataGridView1.Columns[8].Width = 150;
                DataGridView1.Columns[8].Visible = true;
                TSSLFunction.Text = "Shop Sales";
            }
            if (FunctionID == 15)
            {
                // Shop Returns ID
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[9].DefaultCellStyle.Format = "P2";
                // Shop Ref
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // Warehouse Ref
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // Reference
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // Total Items
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // Transaction Date
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // Created By
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
                // Created Date
                DataGridView1.Columns[0].HeaderText = "Stock Code";
                DataGridView1.Columns[0].Width = 150;
                DataGridView1.Columns[0].Visible = true;
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
