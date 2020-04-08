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
                for (int i = 0; i< DgvItems.Rows.Count - 1;i++)
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
                for (int i = 0; i < DgvItems.Rows.Count - 1; i++)
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

        }
        private void GetAllSeasonData()
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = clsUtils.GetConnString(1)
            };
            conn.Open();
            SqlCommand SelectCmd = new SqlCommand();
            SelectCmd.CommandText = "SELECT SeasonName from tblSeasons";
             SelectCmd.Connection = conn;
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
