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
    public partial class frmShopAdjustment : Form
    {
        public string FormMode { get; set; }
        public frmShopAdjustment()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {

        }

        private void CmdDeleteFromGrid_Click(object sender, EventArgs e)
        {

        }

        private void CmdOK_Click(object sender, EventArgs e)
        {

        }

        private void CmdClear_Click(object sender, EventArgs e)
        {

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
            txtWarehouseRef.Text =clsWarehouse.ChangeCase(txtWarehouseRef.Text, 1);
            clsWarehouse warehouse = new clsWarehouse(0);
            warehouse.WarehouseRef = txtWarehouseRef.Text.TrimEnd();
            txtWarehouseName.Text = warehouse.GetWarehouseName();
        }

        private void frmShopAdjustment_Load(object sender, EventArgs e)
        {
            if (FormMode == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Shop";
            }
            else
            {
                CmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadData()
        {

        }
    }
}
