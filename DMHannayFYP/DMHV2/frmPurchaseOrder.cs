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

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSupplierRef_Leave(object sender, EventArgs e)
        {

        }

        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {

        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {

        }

        private void BtnAddToGrid_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteFromGrid_Click(object sender, EventArgs e)
        {

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
    }
}
