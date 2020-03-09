using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (FormMode == "New")
            {

            }
            else
            {

            }
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
            //TxtQtyBoxes.Clear();
            //TxtQtyItems.Clear();
            //TxtStockCode.Clear();
            //TxtQtyLoose.Clear();
            //TxtNetCostLine.Clear();
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
            if(FormMode == "New")
            {
                cmdOK.Text = "Save";
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

        private void TxtDeliveryCharges_Leave(object sender, EventArgs e)
        {
            TotalCalc();
        }

        private void TxtCommission_Leave(object sender, EventArgs e)
        {
            TotalCalc();
        }
    }
}
