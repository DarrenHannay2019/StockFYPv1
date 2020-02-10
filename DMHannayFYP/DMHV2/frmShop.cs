namespace DMHV2
{
    using System;
    using System.Windows.Forms;

    public partial class frmShop : Form
    {        
         clsShop objShop = new clsShop();
        public frmShop()
        {
            InitializeComponent();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            objShop.ShopRef = TxtShopRef.Text.TrimEnd();
            objShop.ShopName = TxtShopName.Text.TrimEnd();
            objShop.AddressLine1 = TxtAddress1.Text.TrimEnd();
            objShop.AddressLine2 = TxtAddress2.Text.TrimEnd();
            objShop.AddressLine3 = TxtAddress3.Text.TrimEnd();
            objShop.AddressLine4 = TxtAddress4.Text.TrimEnd();
            objShop.PostCode = TxtPostCode.Text.TrimEnd();
            objShop.ShopType = cboWType.Text.TrimEnd();
            objShop.Telephone = TxtTelephone1.Text.TrimEnd();
            objShop.Fax = TxtFax.Text.TrimEnd();
            objShop.eMail = TxteMail.Text.TrimEnd();
            objShop.ContactName = TxtContactName.Text.TrimEnd();
            objShop.Memo = TxtMemo.Text.TrimEnd();
            objShop.SaveShopToDB();

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void TxtShopRef_Leave(object sender, EventArgs e)
        {
           
            
            TxtShopRef.Text = clsUtils.ChangeCase(Convert.ToString(TxtShopRef.Text), 1);
        }

        private void TxtShopName_Leave(object sender, EventArgs e)
        {
            TxtShopName.Text = clsUtils.ChangeCase(TxtShopName.Text, 0);
        }

        private void TxtContactName_Leave(object sender, EventArgs e)
        {
            TxtContactName.Text = clsUtils.ChangeCase(TxtContactName.Text, 0);
        }

        private void TxtAddress1_Leave(object sender, EventArgs e)
        {
            TxtAddress1.Text = clsUtils.ChangeCase(TxtAddress1.Text, 0);
        }

        private void TxtAddress2_Leave(object sender, EventArgs e)
        {
            TxtAddress2.Text = clsUtils.ChangeCase(TxtAddress2.Text, 0);
        }

        private void TxtAddress3_Leave(object sender, EventArgs e)
        {
            TxtAddress3.Text = clsUtils.ChangeCase(TxtAddress3.Text, 0);
        }

        private void TxtAddress4_Leave(object sender, EventArgs e)
        {
            TxtAddress4.Text = clsUtils.ChangeCase(TxtAddress4.Text, 0);
        }

        private void TxtPostCode_Leave(object sender, EventArgs e)
        {
            TxtPostCode.Text = clsUtils.ChangeCase(TxtPostCode.Text, 1);
        }
    }
}
