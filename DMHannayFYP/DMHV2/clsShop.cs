using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public class clsShop : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 00/02/2020
        public string ShopType;
        public string ShopName;
        public string GetShopName(string ShopRef)
        {
            string ShopName;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT ShopName FROM tblShops WHERE ShopRef = @ShopRef";
                        sqlCommand.Parameters.AddWithValue("@ShopRef", ShopRef);
                        ShopName = (string)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return ShopName;
        }
        public bool SaveShopToDB(string ShopRef, string ShopName, string Street, string Area, string Town, string County, string PostCode, string ContactName, string Telephone, string FaxNumber, string EmailAddress, string ShopType, string Memo, int UserID)
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
                        sqlCommand.CommandText = "INSERT INTO tblShops (ShopRef,ShopName,ContactName,Street,Area,Town,County,PostCode,Telephone,Fax,eMail,ShopType,Memo,CreatedBy,CreatedDate) VALUES (@ShopRef,@ShopName,@ContactName,@Street,@Area,@Town,@County,@PostCode,@Telephone,@Fax,@eMail,@ShopType,@Memo,@CreatedBy,@CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@ShopRef", ShopRef);
                        sqlCommand.Parameters.AddWithValue("@ShopName", ShopName);
                        sqlCommand.Parameters.AddWithValue("@Street", Street);
                        sqlCommand.Parameters.AddWithValue("@Area", Area);
                        sqlCommand.Parameters.AddWithValue("@Town", Town);
                        sqlCommand.Parameters.AddWithValue("@County", County);
                        sqlCommand.Parameters.AddWithValue("@PostCode", PostCode);
                        sqlCommand.Parameters.AddWithValue("@ContactName", ContactName);
                        sqlCommand.Parameters.AddWithValue("@Telephone", Telephone);
                        sqlCommand.Parameters.AddWithValue("@Fax", FaxNumber);
                        sqlCommand.Parameters.AddWithValue("@eMail", EmailAddress);
                        sqlCommand.Parameters.AddWithValue("@ShopType", ShopType);
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
        public bool UpdateShopToDB(string ShopRef, string ShopName, string Street, string Area, string Town, string County, string PostCode, string ContactName, string Telephone, string FaxNumber, string EmailAddress, string ShopType, string Memo)
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
                        sqlCommand.CommandText = "UPDATE tblShops SET ShopName = @ShopName,Street=@Street,Area=@Area,Town=@Town,County = @County,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Fax = @Fax,eMail = @eMail,Memo = @Memo,ShopType = @ShopType WHERE ShopRef = @ShopRef";
                        sqlCommand.Parameters.AddWithValue("@ShopRef", ShopRef);
                        sqlCommand.Parameters.AddWithValue("@ShopName", ShopName);
                        sqlCommand.Parameters.AddWithValue("@Street", Street);
                        sqlCommand.Parameters.AddWithValue("@Area", Area);
                        sqlCommand.Parameters.AddWithValue("@Town", Town);
                        sqlCommand.Parameters.AddWithValue("@County", County);
                        sqlCommand.Parameters.AddWithValue("@PostCode", PostCode);
                        sqlCommand.Parameters.AddWithValue("@ContactName", ContactName);
                        sqlCommand.Parameters.AddWithValue("@Telephone", Telephone);
                        sqlCommand.Parameters.AddWithValue("@Fax", FaxNumber);
                        sqlCommand.Parameters.AddWithValue("@eMail", EmailAddress);
                        sqlCommand.Parameters.AddWithValue("@WarehouseType", ShopType);
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
        public int TotalShopRecords(string ShopRef)
        {
            int NoRecords = 0;

            return NoRecords;
        }
        public bool DeleteShopRecord(string ShopRef)
        {
            DeleteFromDB = false;

            return DeleteFromDB;
        }
    }
}
