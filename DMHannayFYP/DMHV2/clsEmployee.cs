namespace DMHV2
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    class clsEmployee : clsUtils
    {
        public int UserID;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginCode { get; set; }
        public string PasswordEntered { get; set; }
        private string PasswordHashed;
        public int ProfileID { get; set; }
        public clsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~clsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public Form RefToGridForm { get; set; }
        public static void LoadNewForm()
        {
            // Load a new instance of the create user form.
        }
        public static void LoadSelectedForm(int EmployeeID)
        {
            // Load a instance of the create user form with the details from the selected user.
            EmployeeID = 1;
        }
        public static string HashingSHA1(string ValueToHash)
        {
            var sha1 = System.Security.Cryptography.SHA512.Create();    // Create the Highest Hash Value
            var inputValueToHash = Encoding.ASCII.GetBytes(ValueToHash);
            var hashing = sha1.ComputeHash(inputValueToHash);
            sha1.Dispose();
            var stringbuilder = new StringBuilder();
            for (var a = 0; a < hashing.Length; a++)
            {
                stringbuilder.Append(hashing[a].ToString("X2"));
            }
            return stringbuilder.ToString();
        }
        public int GetLoginUserID(string LoginName, string Password)
        {
            UserID = 0;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "SELECT EmployeeID,Password,UserGuid from tblEmployees WHERE LoginCode = @LoginCode";
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.AddWithValue("@LoginCode", LoginName);
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            int dbUserId = Convert.ToInt32(dataReader["EmployeeID"]);
                            string dbPassword = Convert.ToString(dataReader["Password"]);
                            string dbUserGuid = Convert.ToString(dataReader["UserGuid"]);
                            string PasswordHash = HashingSHA1(Password + dbUserGuid);
                            if (dbPassword == PasswordHash)
                            {
                                UserID = dbUserId;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username and Password \nPlease try again", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return UserID;
        }
        public int GetAllUserTotal(int connID)
        {
            Result = 0;
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(connID);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT COUNT(*) AS TotalRecords from tblEmployees";
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {                
                return ex.Number;
                throw;
            }
            return Result;
        }
        public bool SaveToEmployeeTable(int connID)
        {           
            SaveToDB = false;
            Guid usergiud = System.Guid.NewGuid();
            PasswordHashed = HashingSHA1(PasswordEntered + usergiud.ToString());
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(connID);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandText = "INSERT INTO tblEmployees (FirstName, LastName, LoginCode, Password, ProfileID, UserGuid) VALUES (@FirstName, @LastName, @LoginCode, @Password, @ProfileID, @UserGuid)";
                        InsertCmd.Parameters.AddWithValue("@FirstName", FirstName);
                        InsertCmd.Parameters.AddWithValue("@LastName", LastName);
                        InsertCmd.Parameters.AddWithValue("@LoginCode", LoginCode);
                        InsertCmd.Parameters.AddWithValue("@Password", PasswordHashed);
                        InsertCmd.Parameters.AddWithValue("@ProfileID", ProfileID);
                        InsertCmd.Parameters.AddWithValue("@UserGuid", usergiud);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                SaveToDB = false;
                return SaveToDB;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateToEmployeeTable()
        {
            PasswordHashed = HashingSHA1(PasswordEntered);
            UpdateToDB = false;
            try
            {

            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show(ex.Message);
                return UpdateToDB;
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteEmployee()
        {
            try
            {
               
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
    }
}
