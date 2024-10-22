﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class FrmWarehouse : Form
    {
        // Properties of the form to be used when creating the form from the class object
        public int UserIDs;
        public string Modeform { get; set; }
        public string WarehouseRef { get; set; }     
     
        public FrmWarehouse()
        {
            InitializeComponent();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            // Saving the record to the database tblWarehouses and tblSysLog tables
            // New form = Save 
            // old form = update
            clsWarehouse objWarehouse = new clsWarehouse(UserIDs);
            clsLogs logs = new clsLogs();
            logs.StockCode = "NULL";
            logs.SupplierRef = "NULL";
            logs.LocationRef = TxtWarehouseRef.Text.TrimEnd();
            logs.Qty = 0;
            logs.MovementDate =DateTime.Today;
            logs.UserID = UserIDs;
            if (Modeform == "New")
            {
                logs.StringMovementType = "New Warehouse";
                logs.RecordType = "New Warehouse Record";
                logs.Reference = "New Waerhouse Record";
            }
            else
            {
                logs.StringMovementType = "Update Warehouse";
                logs.RecordType = "Update-Item-Warehouse";
                logs.Reference = "Update Warehouse Record";
            }
            if (Modeform == "New")
            {
                objWarehouse.WarehouseRef = TxtWarehouseRef.Text.TrimEnd();
                objWarehouse.WarehouseName = TxtWarehouseName.Text.TrimEnd();
                objWarehouse.AddressLine1 = TxtAddress1.Text.TrimEnd();
                objWarehouse.AddressLine2 = TxtAddress2.Text.TrimEnd();
                objWarehouse.AddressLine3 = TxtAddress3.Text.TrimEnd();
                objWarehouse.AddressLine4 = TxtAddress4.Text.TrimEnd();
                objWarehouse.PostCode = TxtPostCode.Text.TrimEnd();
                objWarehouse.Telephone = TxtTelephone1.Text.TrimEnd();
                objWarehouse.ContactName = TxtContactName.Text.TrimEnd();
                objWarehouse.eMail = TxteMail.Text.TrimEnd();
                objWarehouse.Fax = TxtFax.Text.TrimEnd();
                objWarehouse.Memo = TxtMemo.Text.TrimEnd();
                objWarehouse.WarehouseType = cboWType.Text.TrimEnd();
                objWarehouse.WebsiteAddress = TxtWebsite.Text.TrimEnd();
                objWarehouse.SaveWarehouseToDB();
            }
            else
            {
                objWarehouse.WarehouseRef = TxtWarehouseRef.Text.TrimEnd();
                objWarehouse.WarehouseName = TxtWarehouseName.Text.TrimEnd();
                objWarehouse.AddressLine1 = TxtAddress1.Text.TrimEnd();
                objWarehouse.AddressLine2 = TxtAddress2.Text.TrimEnd();
                objWarehouse.AddressLine3 = TxtAddress3.Text.TrimEnd();
                objWarehouse.AddressLine4 = TxtAddress4.Text.TrimEnd();
                objWarehouse.PostCode = TxtPostCode.Text.TrimEnd();
                objWarehouse.Telephone = TxtTelephone1.Text.TrimEnd();
                objWarehouse.ContactName = TxtContactName.Text.TrimEnd();
                objWarehouse.eMail = TxteMail.Text.TrimEnd();
                objWarehouse.Fax = TxtFax.Text.TrimEnd();
                objWarehouse.Memo = TxtMemo.Text.TrimEnd();
                objWarehouse.WarehouseType = cboWType.Text.TrimEnd();
                objWarehouse.WebsiteAddress = TxtWebsite.Text.TrimEnd();
                objWarehouse.UpdateWarehouseToDB();
            }
            logs.SaveToSysLogTable();
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close the form.
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            // Code from https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
            ClearTextBoxes(this); // removes all text from each of the boxes on the form
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            // Setups the form ready for new record or updating old record
            if (Modeform == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Warehouse";
            }
            else
            {
                CmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadData()
        {
            // properties used for loading the data into the form.
            int QtyInStock = 0;
            decimal ValueInStock = 0.0m;
            // Loading the head table tblWarehouses into the form
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dtk = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT * from tblWarehouses Where WarehouseRef = @WarehouseRef";
                    SelectCmd.Parameters.AddWithValue("@WarehouseRef", TxtWarehouseRef.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dtk);
                }
                TxtWarehouseRef.Text = dtk.Rows[0][0].ToString();
                TxtWarehouseName.Text = dtk.Rows[0][1].ToString();               
                TxtAddress1.Text = dtk.Rows[0][2].ToString();
                TxtAddress2.Text = dtk.Rows[0][3].ToString();
                TxtAddress3.Text = dtk.Rows[0][4].ToString();
                TxtAddress4.Text = dtk.Rows[0][5].ToString();
                TxtPostCode.Text = dtk.Rows[0][6].ToString();
                TxtTelephone1.Text = dtk.Rows[0][7].ToString();
                TxtFax.Text = dtk.Rows[0][8].ToString();
                TxteMail.Text = dtk.Rows[0][9].ToString();
                TxtWebsite.Text = dtk.Rows[0][10].ToString();
                cboWType.Text = dtk.Rows[0][11].ToString();
                TxtMemo.Text = dtk.Rows[0][12].ToString();     
                TxtContactName.Text = dtk.Rows[0][13].ToString(); 
            }
            // Loading all the stock items for the selected warehouse
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, QtyHangers, Value From QryWarehouseStock Where LocationRef = @LocationRef AND QtyHangers <> '0' ORDER BY StockCode";
                    SelectCmd.Parameters.AddWithValue("@LocationRef", TxtWarehouseRef.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dt);
                }
                gridStock.DataSource = dt;
                gridStock.AutoGenerateColumns = true;
                gridStock.CellBorderStyle = DataGridViewCellBorderStyle.None;
                gridStock.BackgroundColor = Color.LightCoral;
                gridStock.DefaultCellStyle.SelectionBackColor = Color.Red;
                gridStock.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                gridStock.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gridStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gridStock.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                gridStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridStock.AllowUserToResizeColumns = false;
                gridStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridStock.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                gridStock.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                gridStock.Columns[0].HeaderText = "Stock Code";
                gridStock.Columns[1].HeaderText = "Qty";
                gridStock.Columns[2].HeaderText = "Value";
                gridStock.Columns[2].DefaultCellStyle.Format = "C2";
            }
            // Loading all the transactions for the selected warehouse
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, MovementType, MovementQtyHangers, MovementDate, MovementReference from qryWarehouseTransactions WHERE LocationRef = @LocationRef Order By MovementDate";
                    SelectCmd.Parameters.AddWithValue("@LocationRef", TxtWarehouseRef.Text.TrimEnd());
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
            // Calculating the value and qty of products in the selected warehouse
            for (int i = 0; i < gridStock.Rows.Count; i++)
            {
                QtyInStock += Convert.ToInt32(gridStock.Rows[i].Cells[1].Value);
                ValueInStock += Convert.ToDecimal(gridStock.Rows[i].Cells[2].Value);
            }            
            label9.Text = QtyInStock.ToString();
            TxtTotalValue.Text = ValueInStock.ToString("C2");
            // Changing the title of the form to the details of the warehouse
            this.Text = "Warehouse Details for [" + TxtWarehouseRef.Text.TrimEnd() + "] " + TxtWarehouseName.Text.TrimEnd();
        }
        private void ClearTextBoxes(Control control)
        {
            // empty all the text from the text boxes in the form.
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
        // applying the proper case to each of the text boxes in the form
        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {
            TxtWarehouseRef.Text = clsUtils.ChangeCase(TxtWarehouseRef.Text,1);
        }

        private void TxtWarehouseName_Leave(object sender, EventArgs e)
        {
            TxtWarehouseName.Text = clsUtils.ChangeCase(TxtWarehouseName.Text, 0);
        }

        private void TxtContactName_Leave(object sender, EventArgs e)
        {
            TxtContactName.Text = clsUtils.ChangeCase(TxtContactName.Text,0);
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
        // validating that a properly formatted website address has been entered.
        private void TxtWebsite_Leave(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/3228984/a-better-way-to-validate-url-in-c-sharp-than-try-catch 
            // User https://stackoverflow.com/users/626273/stema
            string regular = @"^(ht|f|sf)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";
            string regular123 = @"^(www.)[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";

            string myString = TxtWebsite.Text.Trim();
            if (Regex.IsMatch(myString, regular))
            {
                MessageBox.Show("It is valid url  " + myString);
            }
            else if (Regex.IsMatch(myString, regular123))
            {
                MessageBox.Show("Valid url with www. " + myString);
            }
            else
            {
                MessageBox.Show("InValid URL  " + myString);
            }
        }
        // checking to see if the format of the email address is correct.
        private void TxteMail_Leave(object sender, EventArgs e)
        {          
            if(clsUtils.IsValidEmail(TxteMail.Text))
                TxteMail.Text = clsUtils.ChangeCase(TxteMail.Text, 2);
            else
            { TxteMail.Text = "Please Try Again"; }
        }
    }
}
