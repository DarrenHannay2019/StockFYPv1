namespace DMHV2
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsSeason : clsUtils
    { 
        // properties for the class
        public int SeasonID { get; set; }
        public string SeasonName;
        public clsSeason()
        {

        }
        ~clsSeason()
        {

        }
       // load new season form
        public void LoadNewSeasonForm()
        {
            frmSeason season = new frmSeason
            {
                ModeOfForm = "New",
                Text = "New Season"
            };
            season.ShowDialog();
        }
        // load old season form
        public void LoadSelectedSeasonForm()
        {
            frmSeason season = new frmSeason()
            {
                ModeOfForm = "Old",
                Text = "Update Season",
                SeasonIDs = SeasonID
            };            
            season.ShowDialog();
        }
        // delete season name from database
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
        // update season name in database
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
        // save season name to database
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
