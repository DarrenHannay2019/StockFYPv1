using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public class clsSupplier : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 00/02/2020
       
        public string SupplierName;
        private int user;
        public clsSupplier(int users)
        {
            user = users;
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~clsSupplier()
        {
            user = 0;
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public bool DeleteSupplierRecord()
        {
            return DeleteFromDB;
        }
        public bool SaveSupplierRecord()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblSuppliers (SupplierRef,SupplierName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,Memo,CreatedBy,CreatedDate) VALUES (@SupplierRef,@SupplierName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@Memo,@CreatedBy,@CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@SupplierName", SupplierName);
                        sqlCommand.Parameters.AddWithValue("@Street", Street);
                        sqlCommand.Parameters.AddWithValue("@Area", Area);
                        sqlCommand.Parameters.AddWithValue("@Town", Town);
                        sqlCommand.Parameters.AddWithValue("@County", County);
                        sqlCommand.Parameters.AddWithValue("@PostCode", PostCode);
                        sqlCommand.Parameters.AddWithValue("@ContactName", ContactName);
                        sqlCommand.Parameters.AddWithValue("@Telephone", Telephone);
                        sqlCommand.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        sqlCommand.Parameters.AddWithValue("@Fax", FaxNumber);
                        sqlCommand.Parameters.AddWithValue("@eMail", EmailAddress);
                        sqlCommand.Parameters.AddWithValue("@Memo", Memo);
                        sqlCommand.Parameters.AddWithValue("@CreatedBy", UserID);
                        sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);

            }
            return SaveToDB;
        }
        public bool UpdateSupplierRecord()
        {
            return UpdateToDB;
        }
        public string GetSupplierName()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT SupplierName FROM tblSuppliers WHERE SupplierRef = @SupplierRef";
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        SupplierName = (string)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return SupplierName;
        }
    }
}
