using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class frmPurchaseOrder : Form
    {
        public string FormMode { get; set; }
        public int LoggedUser { get; set; }
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            clsPurchaseOrderHead orderHead = new clsPurchaseOrderHead(LoggedUser);
            clsPurchaseOrderLine orderLine = new clsPurchaseOrderLine();
            clsStock stock = new clsStock();
            clsLogs logs = new clsLogs();
            logs.StockCode = TxtOurRef.Text.TrimEnd();
            logs.SupplierRef = TxtSupplierRef.Text.TrimEnd();
            logs.LocationRef = TxtWarehouseRef.Text.TrimEnd();
            logs.Qty = Convert.ToInt32(TxtTotalGarments.Text.TrimEnd());
            logs.MovementDate = dateTimePicker1.Value; 
            logs.UserID = LoggedUser;
            if (FormMode == "New")
            {                
                logs.StringMovementType = "New Purchase Order";
                logs.RecordType = "Add-New-Item-Start";               
                logs.Reference = "Add New Purchase Order"; 
            }
            else
            {               
                logs.StringMovementType = "Update Purchase Order";
                logs.RecordType = "Update-Item-Start";              
                logs.Reference = "Update Purchase Order";
            } 
            logs.SaveToSysLogTable();
            if (CheckBox1.Checked == true)
            {
                logs.LocationType = 2;
                logs.MovementType = 3;
                orderHead.DeliveryType = "Direct To Shop";
            }                
            else
            {
                logs.LocationType = 1;
                logs.MovementType = 1;
                orderHead.DeliveryType = "Direct To Warehouse";
            }
            orderHead.OurRef = TxtOurRef.Text.TrimEnd();
            orderHead.SupplierRef = TxtSupplierRef.Text.TrimEnd();           
            orderHead.WarehouseRef = TxtWarehouseRef.Text.TrimEnd();
            orderHead.TotalHangers = Convert.ToInt32(TxtTotalLooseItems.Text.TrimEnd());
            orderHead.TotalBoxes = Convert.ToInt32(TxtTotalBoxes.Text.TrimEnd());
            orderHead.TotalGarments = Convert.ToInt32(TxtTotalGarments.Text.TrimEnd());
            orderHead.NetAmount = Convert.ToDecimal(TxtTotalNet.Text.TrimEnd());
            orderHead.Commission = Convert.ToDecimal(TxtCommission.Text.TrimEnd());
            orderHead.DeliveryCharge = Convert.ToDecimal(TxtDeliveryCharges.Text.TrimEnd());
            orderHead.VATAmount = Convert.ToDecimal(TxtVATAmount.Text.TrimEnd());
            orderHead.TotalAmount = Convert.ToDecimal(TxtTotalOrderPrice.Text.TrimEnd());
            orderHead.DeliveryDate = dateTimePicker1.Value;               
            orderHead.SupplierInvoice = TxtSuppliersInvoiceNumber.Text.TrimEnd();
            orderHead.SeasonName = CboSeasonName.Text.TrimEnd();
            orderHead.Notes = TxtNotes.Text.TrimEnd();
            orderHead.Shipper = TxtShipperName.Text.TrimEnd(); 
            orderHead.ShipperInvoice = TxtShipperInvoiceNumber.Text.TrimEnd();
            orderHead.UserID = LoggedUser;
            if (FormMode == "New")
            {
                orderHead.SaveToPurchaseOrderHeadtbl();
                orderHead.PurchaseOrderID = orderHead.GetLastPurchaseOrderHead();
                logs.TransferReference = orderHead.PurchaseOrderID;
                orderLine.PurchaseOrderID = orderHead.PurchaseOrderID;
                for (int i = 0; i< DgvItems.Rows.Count;i++)
                {
                    orderLine.StockCode = DgvItems.Rows[i].Cells[0].Value.ToString();
                    orderLine.DeliveredQtyGarments = Convert.ToInt32(DgvItems.Rows[i].Cells[1].Value);
                    orderLine.DeliveredQtyBoxes = Convert.ToInt32(DgvItems.Rows[i].Cells[2].Value);
                    orderLine.DeliveredQtyHangers = Convert.ToInt32(DgvItems.Rows[i].Cells[3].Value);
                    orderLine.LineAmount = Convert.ToDecimal(DgvItems.Rows[i].Cells[4].Value);
                    logs.StockCode = DgvItems.Rows[i].Cells[0].Value.ToString();
                    logs.DeliveredQtyBoxes = Convert.ToInt32(DgvItems.Rows[i].Cells[2].Value.ToString());
                    logs.DeliveredQtyGarments =Convert.ToInt32( DgvItems.Rows[i].Cells[1].Value.ToString());
                    logs.DeliveredQtyHangers = Convert.ToInt32( DgvItems.Rows[i].Cells[3].Value.ToString());
                    logs.MovementValue = Convert.ToDecimal(DgvItems.Rows[i].Cells[4].Value);
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                    if(orderLine.SaveToPurchaseOrderLinetbl() == true)
                    {
                        stock.StockCode = orderLine.StockCode;
                        if(stock.CheckStockCodeSave() == false)
                        {
                            stock.StockCode = orderLine.StockCode;
                            stock.SupplierRef = orderHead.SupplierRef;
                            stock.SeasonName = orderHead.SeasonName;
                            stock.DeadCode = false;
                            stock.CostValue = orderLine.LineAmount;
                            stock.DeliveredQtyBoxes = orderLine.DeliveredQtyBoxes;
                            stock.DeliveredQtyGarments = orderLine.DeliveredQtyGarments;
                            stock.DeliveredQtyHangers = orderLine.DeliveredQtyHangers;
                            stock.AmountTaken = 0.00m;
                            stock.PCMarkUp = -1.00m;
                            stock.ZeroQty = false;
                            stock.UserID = LoggedUser;
                            stock.SaveStockCode();
                        }   
                    }
                    else
                    {
                    }                   
                }
            }
            else
            {
                orderHead.PurchaseOrderID = Convert.ToInt32(TxtOrderID.Text.TrimEnd());
                logs.TransferReference = orderHead.PurchaseOrderID;
                orderHead.UpdateToPurchaseOrderHeadtbl();
                for (int i = 0; i < DgvItems.Rows.Count; i++)
                {
                    orderLine.StockCode = DgvItems.Rows[i].Cells[0].Value.ToString();
                    orderLine.DeliveredQtyGarments = Convert.ToInt32(DgvItems.Rows[i].Cells[1].Value);
                    orderLine.DeliveredQtyBoxes = Convert.ToInt32(DgvItems.Rows[i].Cells[2].Value);
                    orderLine.DeliveredQtyHangers = Convert.ToInt32(DgvItems.Rows[i].Cells[3].Value);
                    orderLine.LineAmount = Convert.ToDecimal(DgvItems.Rows[i].Cells[4].Value);
                    orderLine.UpdateToPurchaseOrderLinetbl();
                    logs.StockCode = orderLine.StockCode;
                    logs.DeliveredQtyBoxes = orderLine.DeliveredQtyBoxes;
                    logs.DeliveredQtyGarments = orderLine.DeliveredQtyGarments;
                    logs.DeliveredQtyHangers = orderLine.DeliveredQtyHangers;
                    logs.MovementValue = orderLine.LineAmount;
                    logs.SaveToSysLogTable();
                    logs.SaveToStockMovementsTable();
                }
            }
            logs.StockCode = TxtOurRef.Text.TrimEnd();
            logs.SupplierRef = TxtSupplierRef.Text.TrimEnd();
            logs.LocationRef = TxtWarehouseRef.Text.TrimEnd();
            logs.Qty = Convert.ToInt32(TxtTotalGarments.Text.TrimEnd());           
            if (FormMode == "New")
            {               
                logs.StringMovementType = "New Purchase Order";
                logs.RecordType = "Add-New-Item-Start";                
                logs.Reference = "Add New Purchase Order"; 
            }
            else
            {                
                logs.StringMovementType = "Update Purchase Order";
                logs.RecordType = "Update-Item-Start";               
                logs.Reference = "Update Purchase Order";
            }
            logs.SaveToSysLogTable();
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSupplierRef_Leave(object sender, EventArgs e)
        {
            TxtSupplierRef.Text = clsUtils.ChangeCase(TxtSupplierRef.Text, 1);
            clsSupplier supplier = new clsSupplier(0)
            {
                SupplierRef = TxtSupplierRef.Text.TrimEnd()
            };
            TxtSupplierName.Text = supplier.GetSupplierName();
        }

        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {
            TxtWarehouseRef.Text = clsUtils.ChangeCase(TxtWarehouseRef.Text, 1);
            if (CheckBox1.Checked != true)
            {
                clsWarehouse warehouse = new clsWarehouse(0)
                {
                    WarehouseRef = TxtWarehouseRef.Text
                };
                TxtWarehouseName.Text = warehouse.GetWarehouseName();
            }
            else
            {
                clsShop shop = new clsShop
                {
                    ShopRef = TxtWarehouseRef.Text
                };
                TxtWarehouseName.Text = shop.GetShopName();
            }
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {
            TxtStockCode.Text = clsUtils.ChangeCase(TxtStockCode.Text.TrimEnd(), 1);
            clsStock stock = new clsStock();
            stock.StockCode = TxtStockCode.Text.TrimEnd();
            if(stock.CheckStockCodeSave() == true)
            {
                MessageBox.Show("Already StockCode in Database");
            }
            else
            { }
        }

        private void BtnAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvItems.Rows.Add();
            DgvItems.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            DgvItems.Rows[rownum].Cells[1].Value = TxtQtyItems.Text.TrimEnd();
            DgvItems.Rows[rownum].Cells[2].Value = TxtQtyBoxes.Text.TrimEnd();
            DgvItems.Rows[rownum].Cells[3].Value = TxtQtyLoose.Text.TrimEnd();
            decimal tempvalues;
            tempvalues = Convert.ToDecimal(TxtNetCostLine.Text.TrimEnd());
            DgvItems.Rows[rownum].Cells[4].Value = tempvalues.ToString();
            TxtQtyBoxes.Clear();
            TxtQtyItems.Clear();
            TxtStockCode.Clear();
            TxtQtyLoose.Clear();
            TxtNetCostLine.Clear();
            TotalCalc();
        }
        private void TotalCalc()
        {
            int boxes = 0;
            int items = 0;
            int loose = 0;
            decimal NetCost = 0.0m;
            decimal GrossAmount = 0.0m;
            for (int i = 0; i < DgvItems.Rows.Count; i++)
            {               
                boxes += Convert.ToInt16(DgvItems.Rows[i].Cells[2].Value);
                items += Convert.ToInt16(DgvItems.Rows[i].Cells[1].Value);
                loose += Convert.ToInt16(DgvItems.Rows[i].Cells[3].Value);
                NetCost += Convert.ToDecimal(DgvItems.Rows[i].Cells[4].Value);
            }
            TxtTotalBoxes.Text = boxes.ToString();
            TxtTotalGarments.Text = items.ToString();
            TxtTotalLooseItems.Text = loose.ToString();
            TxtTotalNet.Text = NetCost.ToString();
            
            GrossAmount = (Convert.ToDecimal(TxtTotalNet.Text) + Convert.ToDecimal(TxtCommission.Text) + Convert.ToDecimal(TxtDeliveryCharges.Text) + Convert.ToDecimal(TxtVATAmount.Text));
            TxtTotalOrderPrice.Text = GrossAmount.ToString();
        }
        private void BtnDeleteFromGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvItems.SelectedRows)
            {
                DgvItems.Rows.RemoveAt(row.Index);
            }
            TotalCalc();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            GetAllSeasonData();
            LoadWarehousesIntoForm();
            LoadStockIntoForm();
            if(FormMode == "New")
            {
                cmdOK.Text = "Save";
                dateTimePicker1.Value = clsUtils.GetSundayDate(DateTime.Now, 0);
            }
            else
            {
                cmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadData()
        {
            TxtTotalNet.Clear();
            TxtCommission.Clear();
            TxtDeliveryCharges.Clear();
            TxtTotalOrderPrice.Clear();
            DgvItems.Columns.Clear();
            int PurchaseID;
            PurchaseID = Convert.ToInt32(TxtOrderID.Text.TrimEnd());  
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable PurchaseHead = new DataTable();
                SqlDataAdapter PurchaseDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblPurchaseOrders WHERE PurchaseOrderID = @PurchaseOrderID";
                    SelectCmd.Parameters.AddWithValue("@PurchaseOrderID", PurchaseID);
                    PurchaseDataAdapter.SelectCommand = SelectCmd;
                    PurchaseDataAdapter.Fill(PurchaseHead);
                }
                TxtOurRef.Text = PurchaseHead.Rows[0][1].ToString();
                TxtSupplierRef.Text = PurchaseHead.Rows[0][2].ToString();
                clsSupplier supplier = new clsSupplier(LoggedUser);
                supplier.SupplierRef = TxtSupplierRef.Text;
                TxtSupplierName.Text = supplier.GetSupplierName();
                clsWarehouse warehouse = new clsWarehouse(LoggedUser);
                TxtWarehouseRef.Text = PurchaseHead.Rows[0][3].ToString();
                warehouse.WarehouseRef = TxtWarehouseRef.Text;
                TxtWarehouseName.Text = warehouse.GetWarehouseName();
                CboSeasonName.Text = PurchaseHead.Rows[0][4].ToString();
                TxtTotalGarments.Text = PurchaseHead.Rows[0][5].ToString();
                TxtTotalBoxes.Text = PurchaseHead.Rows[0][6].ToString();
                TxtTotalLooseItems.Text = PurchaseHead.Rows[0][7].ToString();
                decimal TotalNet = Convert.ToDecimal(PurchaseHead.Rows[0][8]);                
                decimal DelCharge = Convert.ToDecimal(PurchaseHead.Rows[0][9]);
                decimal CommissionCharge = Convert.ToDecimal(PurchaseHead.Rows[0][10]);
                decimal VatAmount = Convert.ToDecimal(PurchaseHead.Rows[0][11]);
                decimal TotalOrder = Convert.ToDecimal(PurchaseHead.Rows[0][12]);
                string TotalNetString = TotalNet.ToString("C");
                string CommissionString = CommissionCharge.ToString("C");
                string DeliveryString = DelCharge.ToString("C");
                string VatString = VatAmount.ToString("C");
                string OrderString = TotalOrder.ToString("C");
                TxtTotalNet.Text = TotalNetString;
                TxtCommission.Text = CommissionString;
                TxtDeliveryCharges.Text = DeliveryString;
                TxtVATAmount.Text = VatString;
                TxtTotalOrderPrice.Text = OrderString;
                dateTimePicker1.Value = Convert.ToDateTime(PurchaseHead.Rows[0][13].ToString());
                //deliveryType not on form [14]               
                TxtNotes.Text = PurchaseHead.Rows[0][15].ToString();
                TxtSuppliersInvoiceNumber.Text = PurchaseHead.Rows[0][16].ToString();
                TxtShipperName.Text = PurchaseHead.Rows[0][17].ToString();
                TxtShipperInvoiceNumber.Text = PurchaseHead.Rows[0][18].ToString();
            }
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable PurchaseLines = new DataTable();
                SqlDataAdapter PurchaseLinesDA = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode,DeliveredQtyGarments,DeliveredQtyBoxes,DeliveredQtyHangers,LineAmount FROM tblPurchaseOrderLines WHERE PurchaseOrderID = @PurchaseOrderID";
                    SelectCmd.Parameters.AddWithValue("@PurchaseOrderID", PurchaseID);
                    PurchaseLinesDA.SelectCommand = SelectCmd;
                    PurchaseLinesDA.Fill(PurchaseLines);
                }
                DgvItems.DataSource = PurchaseLines;
                DgvItems.AutoGenerateColumns = true;
                DgvItems.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DgvItems.BackgroundColor = Color.LightCoral;
                DgvItems.DefaultCellStyle.SelectionBackColor = Color.Red;
                DgvItems.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                DgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                DgvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                DgvItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvItems.AllowUserToResizeColumns = false;
                DgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvItems.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                DgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                DgvItems.Columns[0].HeaderText = "Stock Code";
                DgvItems.Columns[1].HeaderText = "Garments";
                DgvItems.Columns[2].HeaderText = "Boxes";
                DgvItems.Columns[3].HeaderText = "Hangers";
                DgvItems.Columns[4].HeaderText = "Value";
                DgvItems.Columns[4].DefaultCellStyle.Format = "C2";
            }
        }
        private void LoadWarehousesIntoForm()
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
        private void GetAllSeasonData()
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = clsUtils.GetConnString(1)
            };
            conn.Open();
            SqlCommand SelectCmd = new SqlCommand
            {
                CommandText = "SELECT SeasonName from tblSeasons",
                Connection = conn
            };
            SqlDataReader dataReader;
            dataReader = SelectCmd.ExecuteReader();
            while (dataReader.Read())
            {
                for(int i = 0; i< dataReader.FieldCount;i++)
                {
                    CboSeasonName.Items.Add(dataReader.GetString(i));
                }
            }
            dataReader.Close();
            conn.Close();
        }
        private void TxtDeliveryCharges_Leave(object sender, EventArgs e)
        {
            TotalCalc();
        }

        private void TxtCommission_Leave(object sender, EventArgs e)
        {
            TotalCalc();
        }

        private void TxtShipperName_Leave(object sender, EventArgs e)
        {
            TxtShipperName.Text = clsUtils.ChangeCase(TxtShipperName.Text.TrimEnd(), 0);
        }

        private void TxtVATAmount_Leave(object sender, EventArgs e)
        {
            TotalCalc();
        }
    }
}
