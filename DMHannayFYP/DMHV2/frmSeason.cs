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
    public partial class frmSeason : Form
    {
        public string ModeOfForm { get; set; }
        public int SeasonIDs { get; set; }
        private int UserIDs;
        public frmSeason()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            clsSeason season = new clsSeason();
             clsLogs logs = new clsLogs();
            logs.StockCode = "NULL";
            logs.SupplierRef = "NULL";
            logs.LocationRef = "NULL";
            logs.Qty = 0;
            logs.MovementDate =DateTime.Today;
            logs.UserID = UserIDs;
            if (ModeOfForm == "New")
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
            if(ModeOfForm == "New")
            {
                // Save to the database                
                season.SeasonName = TxtSeasonName.Text.TrimEnd();
                season.SaveSeasonName();
                this.Close();
            }
            else
            {
                season.SeasonID = Convert.ToInt32(LblSeasonID.Text.TrimEnd());
                season.SeasonName = TxtSeasonName.Text.TrimEnd();
                season.UpdateSeasonName();
                this.Close();   // close form
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close the form.
        }

        private void frmSeason_Load(object sender, EventArgs e)
        {
            if(ModeOfForm == "New")
            {
                BtnOK.Text = "Save";
            }
            else
            {
                BtnOK.Text = "Ok";
                LblSeasonID.Text = SeasonIDs.ToString();
                TxtSeasonName.Text = LoadData();
            }
        }
        private string LoadData()
        {
            string SName = "";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = clsUtils.GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT SeasonName from tblSeasons WHERE SeasonID = @SeasonID";
                            SelectCmd.Parameters.AddWithValue("@SeasonID", SeasonIDs);
                            SName = (string)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        conn.Close();
                        conn.Dispose();
                        throw;
                    }
                }
            }
            finally
            {
                //SName = "Unable to Get Data";
            }
            return SName;
        }
    }
}
