// Darren Hannay
// Started Date: 02/02/2020
// Completed Date: ??/0?/2020
namespace DMHannayFYP
{
    using System.Windows.Forms;
    using System.Data;
    using System.Data.SqlClient;
    using System;
    using System.Text;

    public class ClsEmployee : ClsUtilities
    {
        public ClsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~ClsEmployee()
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
            for(var a = 0; a<hashing.Length; a++)
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
    }
}
