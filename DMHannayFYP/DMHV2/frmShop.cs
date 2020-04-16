namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class frmShop : Form
    {
        // extra properties for the form.
        clsShop objShop = new clsShop();
        public int UserIDs;
        public string FormMode { get; set; }
        public frmShop()
        {
            InitializeComponent();
        }
        // Saving = new updating = old to the database
        private void CmdOK_Click(object sender, EventArgs e)
        {
            if (TxteMail.Text != "Please Try Again")
            {
                clsLogs logs = new clsLogs();
                logs.StockCode = "NULL";
                logs.SupplierRef = "NULL";
                logs.LocationRef = TxtShopRef.Text.TrimEnd();
                logs.Qty = 0;
                logs.MovementDate = DateTime.Today;
                logs.UserID = UserIDs;
                if (FormMode == "New")
                {
                    logs.StringMovementType = "New Shop";
                    logs.RecordType = "New Shop Record";
                    logs.Reference = "New Shop Record";
                }
                else
                {
                    logs.StringMovementType = "Update Shop";
                    logs.RecordType = "Update-Item-Shop";
                    logs.Reference = "Update Shop Record";
                }
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
                objShop.UserID = UserIDs;
                if (FormMode == "New")
                {
                    objShop.SaveShopToDB();
                }
                else
                {
                    objShop.UpdateShopToDB();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid email address!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxteMail.SelectAll();
            }
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close the form cleanly
        }
        // clearing all the text
        private void CmdClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }
        // to clear all the textboxes
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
        // giving all the text boxes the correct case for the textbox
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
        // setup the form based on the type.
        private void frmShop_Load(object sender, EventArgs e)
        {
            if(FormMode == "New")
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
            // properties for loading data
            int QtyInStock = 0;
            decimal ValueInStock = 0.0m;
            // get the record for the selected shop
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dtk = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText ="SELECT * from tblShops Where ShopRef = @ShopRef";
                    SelectCmd.Parameters.AddWithValue("@ShopRef", TxtShopRef.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dtk);
                }
                TxtShopRef.Text = dtk.Rows[0][0].ToString();
                TxtShopName.Text = dtk.Rows[0][1].ToString();
                TxtContactName.Text = dtk.Rows[0][12].ToString();
                TxtAddress1.Text = dtk.Rows[0][2].ToString();
                TxtAddress2.Text = dtk.Rows[0][3].ToString();
                TxtAddress3.Text = dtk.Rows[0][4].ToString();
                TxtAddress4.Text = dtk.Rows[0][5].ToString();
                TxtPostCode.Text = dtk.Rows[0][6].ToString();
                TxtTelephone1.Text = dtk.Rows[0][7].ToString();
                TxtFax.Text = dtk.Rows[0][8].ToString();
                TxteMail.Text = dtk.Rows[0][9].ToString();
                TxtMemo.Text = dtk.Rows[0][11].ToString();
                cboWType.Text = dtk.Rows[0][10].ToString();
                this.Text = "Shop Details for [" + TxtShopRef.Text.TrimEnd() + "] " + TxtShopName.Text.TrimEnd();
            }
            // get the stock levels for the selected shop
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, QtyHangers, Value From QryShopStock Where LocationRef = @LocationRef AND QtyHangers <> '0' ORDER BY StockCode";
                    SelectCmd.Parameters.AddWithValue("@LocationRef", TxtShopRef.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dt);
                }
                gridStocks.DataSource = dt;               
                gridStocks.AutoGenerateColumns = true;
                gridStocks.CellBorderStyle = DataGridViewCellBorderStyle.None;
                gridStocks.BackgroundColor = Color.LightCoral;
                gridStocks.DefaultCellStyle.SelectionBackColor = Color.Red;
                gridStocks.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                gridStocks.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gridStocks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gridStocks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                gridStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStocks.AllowUserToResizeColumns = false;
                gridStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridStocks.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                gridStocks.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                gridStocks.Columns[0].HeaderText = "Stock Code";
                gridStocks.Columns[1].HeaderText = "Qty";
                gridStocks.Columns[2].HeaderText = "Value";
                gridStocks.Columns[2].DefaultCellStyle.Format = "C2";
            }
            // get all the transactions for the selected shop
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, MovementType, MovementQtyHangers, MovementDate, MovementReference from tblStockMovements where LocationRef = @LocationRef And LocationType = 2 Order By MovementDate";
                    SelectCmd.Parameters.AddWithValue("@LocationRef", TxtShopRef.Text.TrimEnd());
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
            }           
            for(int i = 0; i < gridStocks.Rows.Count;i++)
            {
                QtyInStock += Convert.ToInt32(gridStocks.Rows[i].Cells[1].Value);
                ValueInStock += Convert.ToDecimal(gridStocks.Rows[i].Cells[2].Value);
            }
            TxtTotalItems.Text = QtyInStock.ToString();
            TxtTotalValue.Text = ValueInStock.ToString("C2");
        }
        // check the email address of the given email address.
        private void TxteMail_Leave(object sender, EventArgs e)
        {
            if (clsUtils.IsValidEmail(TxteMail.Text))
                TxteMail.Text = clsUtils.ChangeCase(TxteMail.Text, 2);
            else
            { TxteMail.Text = "Please Try Again"; }
        }
    }
}
