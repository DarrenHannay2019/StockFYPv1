namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsShop : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 19/02/2020
        public string ShopType;
        public string ShopName;
        public string ShopRef;
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string AddressLine4;
        public string PostCode;
        public string Telephone;
        public string ContactName;
        public string Fax;
        public string eMail;
        public string WebsiteAddress;
        public string Memo;
        public int UserID;
        public clsShop()
        {

        }
        ~clsShop() 
        {
        
        }
        public void LoadNewRecord()
        {
            // load new shop form.
            frmShop shop = new frmShop
            {
                FormMode = "New"
            };
            shop.UserIDs = UserID;
            shop.ShowDialog();
        }
        public void LoadSelectedRecord()
        {
            // load old shop form
            frmShop shop = new frmShop
            {
                FormMode = "Old"
            };
            shop.UserIDs = UserID;
            shop.TxtShopRef.Text = ShopRef;
            shop.ShowDialog();
        }
        // get shop name for the selected shop in all forms
        public string GetShopName()
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
                        sqlCommand.CommandText = "SELECT ShopName FROM tblShops WHERE ShopRef = @ShopRef";
                        sqlCommand.Parameters.AddWithValue("@ShopRef", ShopRef);
                        ShopName = (string)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return ShopName;
        }
        // Save shop record to the database
        public bool SaveShopToDB()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblShops (ShopRef, ShopName, Address1, Address2, Address3, Address4, PostCode, Telephone, Fax, eMail, ShopType, Memo, ContactName, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @Address1, @Address2, @Address3, @Address4, @PostCode, @Telephone, @Fax, @eMail, @ShopType, @Memo, @ContactName, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                        InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                        InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        InsertCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                        InsertCmd.Parameters.AddWithValue("@eMail", eMail);
                        InsertCmd.Parameters.AddWithValue("@ShopType", ShopType);
                        InsertCmd.Parameters.AddWithValue("@Memo", Memo);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
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
        // Update shop record to the database
        public bool UpdateShopToDB()
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
                        UpdateCmd.CommandText = "UPDATE tblShops SET ShopName = @ShopName, Address1 = @Address1, Address2 = @Address2, Address3 =@Address3, Address4 = @Address4, PostCode = @PostCode, ContactName = @ContactName, Telephone = Telephone, Fax = @Fax, eMail = @eMail, Memo = @Memo, ShopType = @ShopType WHERE ShopRef = @ShopRef";
                        UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                        UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                        UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        UpdateCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                        UpdateCmd.Parameters.AddWithValue("@eMail", eMail);
                        UpdateCmd.Parameters.AddWithValue("@ShopType", ShopType);
                        UpdateCmd.Parameters.AddWithValue("@Memo", Memo);
                        UpdateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                UpdateToDB = false;
                throw;
            }
            return UpdateToDB;
        }
        // get the total number of transactions before deleting the shop record
        public int TotalShopRecords()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.CommandText = "SELECT * FROM tblStockMovements WHERE LocationRef = @LocationRef";
                        SelectCmd.Parameters.AddWithValue("@LocationRef", ShopRef);
                        Result = (int)SelectCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);                
                throw;
            }
            return Result;
        }
        // delete the shop record from the database
        public bool DeleteShopRecord()
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
                        DeleteCmd.CommandText = "DELETE FROM tblShops WHERE ShopRef = @ShopRef";
                        DeleteCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
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
    }
}
