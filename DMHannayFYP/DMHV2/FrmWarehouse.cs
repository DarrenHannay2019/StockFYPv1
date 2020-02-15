using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class FrmWarehouse : Form
    {
        clsWarehouse objWarehouse = new clsWarehouse(0);
        public int UserID { get; set; }
        public string Modeform { get; set; }
        public string WarehouseRef { get; set; }
        public FrmWarehouse()
        {
            InitializeComponent();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {           
            if(Modeform == "New")
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
            this.Close();
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
                LoadData();
            }
        }
        private void LoadData()
        {
            int QtyInStock = 0;
            decimal ValueInStock = 0.0m;
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
                TxtWarehouseRef.Text = dtk.Rows[0][1].ToString();
                TxtWarehouseName.Text = dtk.Rows[0][2].ToString();
                TxtContactName.Text = dtk.Rows[0][2].ToString();
                TxtAddress1.Text = dtk.Rows[0][2].ToString();
                TxtAddress2.Text = dtk.Rows[0][2].ToString();
                TxtAddress3.Text = dtk.Rows[0][2].ToString();
                TxtAddress4.Text = dtk.Rows[0][2].ToString();
                TxtPostCode.Text = dtk.Rows[0][2].ToString();
                TxtTelephone1.Text = dtk.Rows[0][2].ToString();
                TxtFax.Text = dtk.Rows[0][2].ToString();
                TxteMail.Text = dtk.Rows[0][2].ToString();
                TxtMemo.Text = dtk.Rows[0][2].ToString();
                cboWType.Text = dtk.Rows[0][2].ToString();
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
                    SelectCmd.CommandText = "SELECT StockCode, QtyHangers, Value From QryWarehouseStockDisplay Where LocationRef = @LocationRef AND QtyHangers <> '0' ORDER BY StockCode";
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

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT StockCode, MovementType, MovementQtyHangers, MovementDate, Reference from tblStockMovements where LocationRef= @LocationRef And LocationType='Warehouse' Order By MovementDate";
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
            }
            for (int i = 0; i < gridStock.Rows.Count; i++)
            {
                QtyInStock += Convert.ToInt32(gridStock.Rows[i].Cells[1].Value);
                ValueInStock += Convert.ToDecimal(gridStock.Rows[i].Cells[2].Value);
            }            
            label9.Text = QtyInStock.ToString();
            TxtTotalValue.Text = ValueInStock.ToString("C2");
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

        private void TxtWarehouseRef_Leave(object sender, EventArgs e)
        {

        }

        private void TxtWarehouseName_Leave(object sender, EventArgs e)
        {

        }

        private void TxtContactName_Leave(object sender, EventArgs e)
        {

        }

        private void TxtAddress1_Leave(object sender, EventArgs e)
        {

        }

        private void TxtAddress2_Leave(object sender, EventArgs e)
        {

        }

        private void TxtAddress3_Leave(object sender, EventArgs e)
        {

        }

        private void TxtAddress4_Leave(object sender, EventArgs e)
        {

        }

        private void TxtPostCode_Leave(object sender, EventArgs e)
        {

        }

        private void TxtWebsite_Leave(object sender, EventArgs e)
        {

        }

        private void TxteMail_Leave(object sender, EventArgs e)
        {

        }
    }
}
