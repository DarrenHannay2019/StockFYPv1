using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class frmStock : Form
    {
        public string FormMode { get; set; }
        public decimal AmountTaken { get; set; }
        public decimal CostValue { get; set; }
        public decimal PCMarkUp { get; set; }
        public int UserIDs;

        public frmStock()
        {
            InitializeComponent();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            clsStock stock = new clsStock();
            stock.StockCode = TxtStockCode.Text.TrimEnd();
            stock.SupplierRef = TxtSupplierRef.Text.TrimEnd();
            stock.SeasonName = CboSeason.Text.TrimEnd();
            stock.DeadCode = DeadCodeCheckBox.Checked;
            stock.ZeroQty = checkBox1.Checked;
            decimal toConvert;
            decimal.TryParse(TxtAmountTaken.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out toConvert);
            if (toConvert == AmountTaken)
                stock.AmountTaken = AmountTaken;
            else
                stock.AmountTaken = Convert.ToDecimal(TxtAmountTaken.Text.TrimEnd());
            decimal.TryParse(TxtCostValue.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out toConvert);
            if (toConvert == CostValue)
                stock.CostValue = CostValue;
            else
                stock.CostValue = Convert.ToDecimal(TxtCostValue.Text.TrimEnd());     
            stock.PCMarkUp = PCMarkUp;           
            stock.DeliveredQtyHangers = Convert.ToInt32(textBox8.Text.TrimEnd());
            stock.DeliveredQtyBoxes = Convert.ToInt32(textBox6.Text.TrimEnd());
            stock.DeliveredQtyGarments = Convert.ToInt32(textBox7.Text.TrimEnd());
            if (FormMode == "New")
            {
                stock.UserID = UserIDs;
                stock.SaveStockCode();
            }
            else
            {
                stock.UpdateStockCode();
            }
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadSupplierIntoForm()
        {
            AutoCompleteStringCollection ACSC = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = new SqlCommand("SELECT SupplierRef from tblSuppliers", conn);
                adp.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ACSC.Add(Convert.ToString(row[0]));
                }
            }
            TxtSupplierRef.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtSupplierRef.AutoCompleteCustomSource = ACSC;
            TxtSupplierRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            GetAllSeasonData();
            LoadSupplierIntoForm();
            if(FormMode == "New")
            {
                CmdOK.Text = "Save";
            }
            else
            {
                CmdOK.Text = "Ok";
                LoadData();
            }
        }
        private void GetAllSeasonData()
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = clsUtils.GetConnString(1)
            };
            conn.Open();
            SqlCommand SelectCmd = new SqlCommand
            {
                CommandText = "SELECT SeasonName from tblSeasons",
                Connection = conn
            };
            SqlDataReader dataReader;
            dataReader = SelectCmd.ExecuteReader();
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {                   
                    CboSeason.Items.Add(dataReader.GetString(i));
                }
            }
            dataReader.Close();
            conn.Close();
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
                    SelectCmd.CommandText = "SELECT * from tblStock Where StockCode = @StockCode";
                    SelectCmd.Parameters.AddWithValue("@StockCode", TxtStockCode.Text.TrimEnd());
                    sqlDataAdapter.SelectCommand = SelectCmd;
                    sqlDataAdapter.Fill(dtk);
                }
                TxtSupplierRef.Text = dtk.Rows[0][1].ToString();
                CboSeason.Text = dtk.Rows[0][2].ToString();
                DeadCodeCheckBox.Checked = Convert.ToBoolean(dtk.Rows[0][3].ToString());
                AmountTaken = Convert.ToDecimal(dtk.Rows[0][4].ToString());
                TxtAmountTaken.Text = AmountTaken.ToString("C2");
                textBox8.Text = dtk.Rows[0][5].ToString();
                textBox6.Text = dtk.Rows[0][6].ToString();
                textBox7.Text = dtk.Rows[0][7].ToString();
                CostValue = Convert.ToDecimal(dtk.Rows[0][8].ToString());
                TxtCostValue.Text = CostValue.ToString("C2");
                PCMarkUp = Convert.ToDecimal(dtk.Rows[0][9].ToString());
                textBox5.Text = PCMarkUp.ToString("P2");
                checkBox1.Checked = Convert.ToBoolean(dtk.Rows[0][10].ToString());
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
                    SelectCmd.CommandText = "SELECT * from qryStockLevels where StockCode = @StockCode";
                    SelectCmd.Parameters.AddWithValue("@StockCode", TxtStockCode.Text.TrimEnd());
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
                gridTrans.Columns[0].HeaderText = "Location Ref";
                gridTrans.Columns[1].HeaderText = "Type";
                gridTrans.Columns[2].HeaderText = "Hangers";
                gridTrans.Columns[3].HeaderText = "Boxes";
                gridTrans.Columns[4].HeaderText = "Garments";
                gridTrans.Columns[5].Visible = false;
            }
        }
    }
}
