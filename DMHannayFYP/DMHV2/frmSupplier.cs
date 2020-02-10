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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
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

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close the form.
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {

        }
    }
}
