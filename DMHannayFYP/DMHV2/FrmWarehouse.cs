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
    public partial class FrmWarehouse : Form
    {
        public int UserID { get; set; }
        public string Modeform { get; set; }
        public string WarehouseRef { get; set; }
        public FrmWarehouse()
        {
            InitializeComponent();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            clsWarehouse clsWarehouse = new clsWarehouse(UserID);
            if(Modeform == "New")
            {
                clsWarehouse.
                clsWarehouse.SaveWarehouseToDB(TxtWarehouseRef.Text.TrimEnd(),TxtWarehouseName.Text.TrimEnd(),TxtAddress1.Text.TrimEnd(),TxtAddress2.Text.TrimEnd(),)
            }
            else
            {

            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close the form.
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            // Code from https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
            ClearTextBoxes(this);
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            if (Modeform == "New")
            {
                CmdOK.Text = "Save";
            }
            else
            {
                CmdOK.Text = "OK";

            }
        }
        private void ClearTextBoxes(Control control)
        {
            // Code from https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }              
               
            }
        }
    }
}
