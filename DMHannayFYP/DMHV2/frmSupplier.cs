using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class frmSupplier : Form
    {
        public int UserIDs;
        public string FormMode { get; set;}
       
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
            clsSupplier objSupplier = new clsSupplier(UserIDs);
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
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dtk = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblSuppliers Where SupplierRef = @SupplierRef";
                    SelectCmd.Parameters.AddWithValue("@SupplierRef", TxtSupplierRef.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dtk);
                }
                TxtSupplierRef.Text = dtk.Rows[0][0].ToString();
                TxtSupplierName.Text = dtk.Rows[0][1].ToString();
                TxtAddressLine1.Text = dtk.Rows[0][2].ToString();
                TxtAddressLine2.Text = dtk.Rows[0][3].ToString();
                TxtAddressLine3.Text = dtk.Rows[0][4].ToString();
                TxtAddressLine4.Text = dtk.Rows[0][5].ToString();
                TxtPostCode.Text = dtk.Rows[0][6].ToString();
                TxtTelephoneNumber1.Text = dtk.Rows[0][7].ToString();
                TxtFaxNumber.Text = dtk.Rows[0][8].ToString();
                TxtEmailAddress.Text = dtk.Rows[0][9].ToString();
                //TxtWebsiteAddress.Text = dtk.Rows[0][10].ToString();             
                TxtMemo.Text = dtk.Rows[0][10].ToString();
                TxtContactName.Text = dtk.Rows[0][11].ToString();
            }
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, MovementType, MovementQtyHangers, MovementDate, MovementReference from tblStockMovements where SupplierRef = @SupplierRef And LocationType = 1 Order By MovementDate";
                    SelectCmd.Parameters.AddWithValue("@LocationRef", TxtSupplierRef.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dt);
                }
                gridTrans.DataSource = dt;
                gridTrans.AutoGenerateColumns = true;
                gridTrans.CellBorderStyle = DataGridViewCellBorderStyle.None;
                gridTrans.BackgroundColor = Color.LightCoral;
                gridTrans.DefaultCellStyle.SelectionBackColor = Color.Plum;
                gridTrans.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                gridTrans.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gridTrans.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gridTrans.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                gridTrans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridTrans.AllowUserToResizeColumns = false;
                gridTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridTrans.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                gridTrans.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                gridTrans.Columns[0].HeaderText = "Stock Code";
                gridTrans.Columns[1].HeaderText = "Type";
                gridTrans.Columns[2].HeaderText = "Qty";
                gridTrans.Columns[3].HeaderText = "Date";
                gridTrans.Columns[4].HeaderText = "Reference";
            }
        }
    }
}
