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
    public partial class frmWarehouseAdjustment : Form
    {
        public string FormMode { get; set; }
        public frmWarehouseAdjustment()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {

        }

        private void CmdRemoveFromGrid_Click(object sender, EventArgs e)
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
            this.Close();   // close form
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {

        }

        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {

        }

        private void frmWarehouseAdjustment_Load(object sender, EventArgs e)
        {
            if(FormMode == "New")
            {
                CmdOK.Text = "Save";
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
