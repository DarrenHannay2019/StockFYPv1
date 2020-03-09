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
    public partial class frmShopTransfer : Form
    {
        public string FormMode { get; set; }
        public frmShopTransfer()
        {
            InitializeComponent();
        }

        private void CmdAddToGrid_Click(object sender, EventArgs e)
        {
            int rownum;
            rownum = (int)DgvRecords.Rows.Add();
            DgvRecords.Rows[rownum].Cells[0].Value = TxtStockCode.Text.TrimEnd();
            DgvRecords.Rows[rownum].Cells[1].Value = TxtTransferFromQty.Text.TrimEnd();
            Totals();
            TxtCurrentQty.Clear();
            TxtTransferFromQty.Clear();
            TxtStockCode.Clear();
        }

        private void CmdDeleteFromGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvRecords.SelectedRows)
            {
                DgvRecords.Rows.RemoveAt(row.Index);
            }
            Totals();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            if (FormMode == "New")
            {

            }
            else
            {

            }
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtTotalTransferTo.Clear();
            TxtCurrentQty.Clear();
            TxtTransferFromQty.Clear();
            txtFromShopName.Clear();
            TxtFromShopRef.Clear();
            TxtToShopRef.Clear();
            txtToShopName.Clear();
            TxtStockCode.Clear();
            TxtTFNote.Clear();
            DgvRecords.Rows.Clear();
            DtpDate.Value = clsUtils.GetSundayDate(DateTime.Now, 1);
        }

        private void frmShopTransfer_Load(object sender, EventArgs e)
        {
            LoadShopsIntoForm_FromBox();
            LoadStockIntoForm();
            if (FormMode == "New")
            {
                CmdOK.Text = "Save";
                this.Text = "New Shop Transfer";
            }
            else
            {
                CmdOK.Text = "OK";
                LoadData();
            }
        }
        private void LoadShopsIntoForm_FromBox()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT ShopRef from tblShops", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtToShopRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtToShopRef.AutoCompleteCustomSource = ACSC;
            TxtToShopRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadShopsIntoForm_ToBox()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT ShopRef from tblShops WHERE ShopRef !='" + TxtFromShopRef.Text.TrimEnd()+ "'", conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtToShopRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtToShopRef.AutoCompleteCustomSource = ACSC;
            TxtToShopRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void LoadStockIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT StockCode from tblStock", conn);
                adp.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtStockCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtStockCode.AutoCompleteCustomSource = ACSC;
            TxtStockCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void LoadData()
        {

        }

        private void TxtFromShopRef_Leave(object sender, EventArgs e)
        {
            TxtFromShopRef.Text = clsShop.ChangeCase(TxtFromShopRef.Text, 1);
            clsShop Shop = new clsShop()
            {
                ShopRef = TxtFromShopRef.Text.TrimEnd()
            };
            txtFromShopName.Text = Shop.GetShopName();
            LoadShopsIntoForm_ToBox();
        }

        private void TxtToShopRef_Leave(object sender, EventArgs e)
        {
            TxtToShopRef.Text = clsShop.ChangeCase(TxtToShopRef.Text, 1);
            clsShop Shop = new clsShop()
            {
                ShopRef = TxtToShopRef.Text.TrimEnd()
            };
            txtToShopName.Text = Shop.GetShopName();
        }

        private void TxtStockCode_Leave(object sender, EventArgs e)
        {

        }
        public void Totals()
        {
            int lngqtyhangers = 0;

            for (int i = 0; i < DgvRecords.Rows.Count; i++)
            {
                lngqtyhangers += Convert.ToInt32(DgvRecords.Rows[i].Cells[1].Value);
            }            
            txtTotalTransferTo.Text = lngqtyhangers.ToString();

        }
    }
}
