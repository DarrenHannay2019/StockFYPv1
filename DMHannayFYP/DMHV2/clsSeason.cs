namespace DMHV2
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsSeason : clsUtils
    {
        public int SeasonID { get; set; }
        public void LoadNewSeasonForm()
        {
            frmSeason season = new frmSeason
            {
                ModeOfForm = "New"
            };
            season.ShowDialog();
        }
        public void LoadSelectedSeasonForm()
        {
            frmSeason frm = new frmSeason()
            {
                ModeOfForm = "Old",
                SeasonIDs = SeasonID
            };
            frm.ShowDialog();
        }
        public bool DeleteSeasonName()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblSeasons WHERE SeasonID = @SeasonID";
                        DeleteCmd.Parameters.AddWithValue("@SeasonID", SeasonID);
                        DeleteCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DeleteFromDB = false;
                throw;
            }
            return DeleteFromDB;
        }
        public bool UpdateSeasonName()
        {
            UpdateToDB = true;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand UpdateCmd = new SqlCommand())
                    {
                        UpdateCmd.Connection = conn;
                        UpdateCmd.CommandType = CommandType.Text;
                        UpdateCmd.CommandText = "UPDATE tblSeasons SET SeasonName = @SeasonName WHERE SeasonID = @SeasonID";
                        UpdateCmd.Parameters.AddWithValue("@SeasonID", SeasonID);
                        UpdateCmd.Parameters.AddWithValue("@SeasonName", SeasonName);
                        UpdateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;     
        }
        public bool SaveSeasonName()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using(SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblSeasons (SeasonName) VALUES (@SeasonName)";
                        InsertCmd.Parameters.AddWithValue("@SeasonName", SeasonName);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Unable to Open connection to Database\nBecause : " + ex.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            if(Result != 1)
            {
                SaveToDB = false;
            }
            else
            { 
                SaveToDB = true;
            }
            return SaveToDB;
        }
    }
}
