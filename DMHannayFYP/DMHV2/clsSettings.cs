using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DMHV2
{
    public class clsSettings : clsUtils
    {
        public string VATRegistration { get; set; }
        public decimal VATRate { get; set; }
        public clsSettings()
        {

        }
        ~clsSettings()
        {

        }
        public void LoadSettings()
        {
            Result = CheckDB();
            if(Result == 1)
            {
                LoadOldForm();
            }
            else
            {
                LoadNewForm();
            }
        }
        private void LoadOldForm()
        {
            frmSettings settings = new frmSettings
            {
                FormMode = "Old"
            };
            settings.ShowDialog();
        }
        private void LoadNewForm()
        {
            frmSettings settings = new frmSettings
            {
                FormMode = "New"
            };
            settings.ShowDialog();
        }
        public bool SaveSettings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand InsertCmd = new SqlCommand())
                        {
                            InsertCmd.Connection = conn;
                            InsertCmd.Connection.Open();
                            InsertCmd.CommandType = CommandType.Text;
                            InsertCmd.CommandText = "INSERT INTO tblCompanyDetails (CompanyName, Address1, Address2, Address3, Address4, PostCode, Telephone, Fax, VATRegistrationNo, Email, Website, VATRate) VALUES (@CompanyName, @Address1, @Address2, @Address3, @Address4, @PostCode, @Telephone, @Fax, @VATRegistrationNo, @Email, @Website, @VATRate)";
                            InsertCmd.Parameters.AddWithValue("@CompanyName", WarehouseName);
                            InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                            InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                            InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                            InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                            InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                            InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                            InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                            InsertCmd.Parameters.AddWithValue("@VATRegistration", VATRegistration);
                            InsertCmd.Parameters.AddWithValue("@Email", eMail);
                            InsertCmd.Parameters.AddWithValue("@Website", WebsiteAddress);
                            InsertCmd.Parameters.AddWithValue("@VATRate", VATRate);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        MessageBox.Show("Error in adding to database\n" + ex.Message);
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;            
        }
        public bool UpdateSettings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.Connection.Open();
                            UpdateCmd.CommandType = CommandType.Text;
                            UpdateCmd.CommandText = "UPDATE tblCompanyDetails SET CompanyName =  @CompanyName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, Telephone = @Telephone, Fax = @Fax, VATRegistrationNo = @VATRegistrationNo, Email = @Email, Website = @Website, VATRate = @VATRate WHERE CompanyID = @CompanyID";
                            UpdateCmd.Parameters.AddWithValue("@CompanyID", ID);
                            UpdateCmd.Parameters.AddWithValue("@CompanyName", WarehouseName);
                            UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                            UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                            UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                            UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                            UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                            UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                            UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                            UpdateCmd.Parameters.AddWithValue("@VATRegistration", VATRegistration);
                            UpdateCmd.Parameters.AddWithValue("@Email", eMail);
                            UpdateCmd.Parameters.AddWithValue("@Website", WebsiteAddress);
                            UpdateCmd.Parameters.AddWithValue("@VATRate", VATRate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error in adding to database\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in adding to database\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public string Backup()
        {
            string UniqueIdenity;
            string time;
            string day;
            string month;
            string year;
            time = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            day = DateTime.Now.Day.ToString();
            month = DateTime.Now.Month.ToString();
            year = DateTime.Now.Year.ToString();
            UniqueIdenity = year + month + day + time;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(3);
                using (SqlCommand BackupCmd = new SqlCommand())
                {
                    BackupCmd.Connection = conn;
                    BackupCmd.Connection.Open();
                    BackupCmd.CommandText = "Backup database " + Reference + " to disk = 'C:\\DBBackup\\'"+ Reference + "_"+UniqueIdenity +"'.bak'";
                    BackupCmd.ExecuteNonQuery();
                }
            }
            return "Backup Completed";
        }
        public string Restore()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(3);
                conn.Open();
                // Set Database to single mode
                using (SqlCommand RestoreCMD = new SqlCommand())
                {
                    RestoreCMD.Connection = conn;
                    RestoreCMD.CommandText = "ALTER DATABASE " + Reference + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    RestoreCMD.ExecuteNonQuery();
                }
                // Restore The Database
                using (SqlCommand RestoreCMD = new SqlCommand())
                {
                    RestoreCMD.Connection = conn;
                    RestoreCMD.CommandText = "Restore Database " + Reference + " FROM DISK ='C:\\DBBackup\\" + AddressLine1 + ".bak'";

                    RestoreCMD.ExecuteNonQuery();
                }
                // Change Database back to multi user
                using (SqlCommand RestoreCMD = new SqlCommand())
                {
                    RestoreCMD.Connection = conn;
                    RestoreCMD.CommandText = "ALTER DATABASE " + Reference + " SET Multi_User";

                    RestoreCMD.ExecuteNonQuery();
                }
            }
            return "Restore to the file name Required!";
        }
        public int CheckDB()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand selectCmd = new SqlCommand())
                {
                    selectCmd.Connection = conn;
                    selectCmd.CommandText = "Select COUNT(*) from tblCompanyDetails";
                    return (int)selectCmd.ExecuteScalar();
                }
            }
        }
    }
}
