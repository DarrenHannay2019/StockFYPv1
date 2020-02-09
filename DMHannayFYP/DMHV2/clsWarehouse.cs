using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DMHV2
{
    public class clsWarehouse : clsUtils
    {
        public clsWarehouse(int user)
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
            UserID = user;
        }
        ~clsWarehouse()
        {
            UserID = 0;
        }
        public bool SaveWarehouseToDB(string WarehouseRef, string WarehouseName, string Street, string Area, string Town, string County, string PostCode, string ContactName, string Telephone, string FaxNumber, string EmailAddress, string WebsiteAddress, string WarehouseType, string Memo, int UserID)
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblWarehouses (WarehouseRef,WarehouseName,Street,Area,Town,County,PostCode,ContactName,Telephone,WebSite,Fax,eMail,WarehouseType,Memo,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@WarehouseName,@Street,@Area,@Town,@County,@PostCode,@ContactName,@Telephone,@WebSite,@Fax,@eMail,@WarehouseType,@Memo,@CreatedBy,@CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        sqlCommand.Parameters.AddWithValue("@WarehouseName", WarehouseName);
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
                        sqlCommand.Parameters.AddWithValue("@WarehouseType", WarehouseType);
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
        public bool UpdateWarehouseToDB(string WarehouseRef, string WarehouseName, string Street, string Area, string Town, string County, string PostCode, string ContactName, string Telephone, string FaxNumber, string EmailAddress, string WebsiteAddress, string WarehouseType, string Memo)
        {
            UpdateToDB = true;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblWarehouses SET WarehouseName = @WarehouseName,Street=@Street,Area=@Area,Town=@Town,County = @County,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,WebSite = @WebSite,Fax = @Fax,eMail = @eMail,Memo = @Memo,WarehouseType = @WarehouseType WHERE WarehouseRef = @WarehouseRef";
                        sqlCommand.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        sqlCommand.Parameters.AddWithValue("@WarehouseName", WarehouseName);
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
                        sqlCommand.Parameters.AddWithValue("@WarehouseType", WarehouseType);
                        sqlCommand.Parameters.AddWithValue("@Memo", Memo);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {

                throw;
            }
            return UpdateToDB;
        }
        public string GetWarehouseName(string WarehouseRef)
        {
            string WarehouseName;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT WarehouseName FROM tblWarehouses WHERE WarehouseRef = @WarehouseRef";
                        sqlCommand.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        WarehouseName = (string)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return WarehouseName;
        }
        public int TotalWarehouseRecords(string warehouseRef)
        {
            int NoRecords = 0;

            return NoRecords;
        }
        public bool DeleteWarehouseRecord(string WarehouseRef)
        {
            DeleteFromDB = false;

            return DeleteFromDB;
        }
    }
}
