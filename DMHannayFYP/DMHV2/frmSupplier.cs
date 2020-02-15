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
        public string FormMode { get; set;}
        clsSupplier objSupplier = new clsSupplier(0);
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
            if (FormMode == "New")
            {
                objSupplier.SupplierRef = TxtSupplierRef.Text.TrimEnd();
                objSupplier.SupplierName = TxtSupplierName.Text.TrimEnd();
                objSupplier.AddressLine1 = TxtAddressLine1.Text.TrimEnd();
                objSupplier.AddressLine2 = TxtAddressLine2.Text.TrimEnd();
                objSupplier.AddressLine3 = TxtAddressLine3.Text.TrimEnd();
                objSupplier.AddressLine4 = TxtAddressLine4.Text.TrimEnd();
                objSupplier.PostCode = TxtPostCode.Text.TrimEnd();
                objSupplier.Telephone = TxtTelephoneNumber1.Text.TrimEnd();
                objSupplier.ContactName = TxtContactName.Text.TrimEnd();
                objSupplier.eMail = TxtEmailAddress.Text.TrimEnd();
                objSupplier.Fax = TxtFaxNumber.Text.TrimEnd();
                objSupplier.Memo = TxtMemo.Text.TrimEnd();               
                objSupplier.WebsiteAddress = TxtWebsiteAddress.Text.TrimEnd();
                objSupplier.SaveSupplierRecord();
            }
            else
            {
                objSupplier.SupplierRef = TxtSupplierRef.Text.TrimEnd();
                objSupplier.SupplierName = TxtSupplierName.Text.TrimEnd();
                objSupplier.AddressLine1 = TxtAddressLine1.Text.TrimEnd();
                objSupplier.AddressLine2 = TxtAddressLine2.Text.TrimEnd();
                objSupplier.AddressLine3 = TxtAddressLine3.Text.TrimEnd();
                objSupplier.AddressLine4 = TxtAddressLine4.Text.TrimEnd();
                objSupplier.PostCode = TxtPostCode.Text.TrimEnd();
                objSupplier.Telephone = TxtTelephoneNumber1.Text.TrimEnd();
                objSupplier.ContactName = TxtContactName.Text.TrimEnd();
                objSupplier.eMail = TxtEmailAddress.Text.TrimEnd();
                objSupplier.Fax = TxtFaxNumber.Text.TrimEnd();
                objSupplier.Memo = TxtMemo.Text.TrimEnd();
                objSupplier.WebsiteAddress = TxtWebsiteAddress.Text.TrimEnd();
                objSupplier.UpdateSupplierRecord();
            }
            this.Close();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            if (FormMode == "New")
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
