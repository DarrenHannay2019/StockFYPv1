﻿namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsWarehouse : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 00/02/2020       
        private int Users;
        public int UserID { get; set; }
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
        public string WarehouseRef;       
        public string WarehouseName;
        public string WarehouseType;
        public clsWarehouse(int User)
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
            Users = User;
        }
        ~clsWarehouse()
        {
            UserID = 0;
        }
        public void LoadNewRecord()
        {
            // loading the new form and setting the properties of the form
            FrmWarehouse oWarehouse = new FrmWarehouse
            {
                UserIDs = Users,
                Modeform = "New"
            };
            oWarehouse.ShowDialog();
        }
        public void LoadSelectedRecord()
        {
            // loading an old record into the form and displaying it
            FrmWarehouse oWarehouse = new FrmWarehouse
            {
                UserIDs = Users,
                Modeform = "Old"
            };
            oWarehouse.TxtWarehouseRef.Text = WarehouseRef;
            oWarehouse.ShowDialog();
        }
        public bool SaveWarehouseToDB()
        {
            // Saving the entered data into the database
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
                        InsertCmd.CommandText = "INSERT INTO tblWarehouses (WarehouseRef, WarehouseName, Address1, Address2, Address3, Address4 ,PostCode, ContactName, Telephone, WebSite, Fax, eMail, WarehouseType, Memo, CreatedBy, CreatedDate) VALUES (@WarehouseRef, @WarehouseName, @Address1, @Address2, @Address3, @Address4 , @PostCode, @ContactName, @Telephone, @WebSite, @Fax, @eMail, @WarehouseType, @Memo, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        InsertCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                        InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        InsertCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        InsertCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                        InsertCmd.Parameters.AddWithValue("@eMail", eMail);
                        InsertCmd.Parameters.AddWithValue("@WarehouseType", WarehouseType);
                        InsertCmd.Parameters.AddWithValue("@Memo", Memo);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", Users);
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
        public bool UpdateWarehouseToDB()
        {
            // Updating selected warehouse record in the database
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
                        UpdateCmd.CommandText = "UPDATE tblWarehouses SET WarehouseName = @WarehouseName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, ContactName = @ContactName, Telephone = Telephone, WebSite = @WebSite, Fax = @Fax, eMail = @eMail, Memo = @Memo, WarehouseType = @WarehouseType WHERE WarehouseRef = @WarehouseRef";
                        UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        UpdateCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                        UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        UpdateCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);
                        UpdateCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                        UpdateCmd.Parameters.AddWithValue("@eMail", eMail);
                        UpdateCmd.Parameters.AddWithValue("@WarehouseType", WarehouseType);
                        UpdateCmd.Parameters.AddWithValue("@Memo", Memo);
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
        public string GetWarehouseName()
        {        
            // getting the name of a specific warehouse from the database
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
                        SelectCmd.CommandText = "SELECT WarehouseName FROM tblWarehouses WHERE WarehouseRef = @WarehouseRef";
                        SelectCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        WarehouseName = (string)SelectCmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return WarehouseName;
        }
        public int TotalWarehouseRecords()
        {
            // check to see if there are any transactions in the database before deleting the warehouse record
            NoRecords = 0;
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblStockMovements WHERE LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        Result = (int)SelectCmd.ExecuteNonQuery();
                    }
                }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return NoRecords;
        }
        public bool DeleteWarehouseRecord()
        {
            // delete the warehouse record from the database
            DeleteFromDB = false;
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using(SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblWarehouses where WarehouseRef = @WarehouseRef";
                        DeleteCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if(Result == 1)
                {
                    DeleteFromDB = true;
                }
                else
                {
                    DeleteFromDB = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
    }
}
