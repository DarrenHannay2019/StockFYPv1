using System;
using System.Collections.Generic;
using System.Data;
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
        public void LoadNewRecord()
        {
            frmSupplier objSupplier = new frmSupplier
            {
                FormMode = "New"
            };
            objSupplier.ShowDialog();
        }
        public void LoadSelectedRecord()
        {
            frmSupplier objSupplier = new frmSupplier
            {
                FormMode = "Old"
            };
            objSupplier.ShowDialog();
        }
        public bool DeleteSupplierRecord()
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
                        DeleteCmd.CommandText = "DELETE FROM tblSuppliers where SupplierRef = @SupplierRef";
                        DeleteCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result == 1)
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
        public bool SaveSupplierRecord()
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
                        InsertCmd.CommandText = "INSERT INTO tblSuppliers (SupplierRef, SupplierName, Address1, Address2, Address3, Address4, PostCode, ContactName, Telephone, Fax, eMail, Memo, WebSite, CreatedBy, CreatedDate) VALUES (@SupplierRef, @SupplierName, @Address1, @Address2, @Address3, @Address4, @PostCode, @ContactName, @Telephone, @Fax, @eMail, @Memo, @Website, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        InsertCmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                        InsertCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        InsertCmd.Parameters.AddWithValue("@Address2", AddressLine2);
                        InsertCmd.Parameters.AddWithValue("@Address3", AddressLine3);
                        InsertCmd.Parameters.AddWithValue("@Address4", AddressLine4);
                        InsertCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        InsertCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        InsertCmd.Parameters.AddWithValue("@Telephone", Telephone);                       
                        InsertCmd.Parameters.AddWithValue("@Fax", Fax);
                        InsertCmd.Parameters.AddWithValue("@eMail", eMail);                       
                        InsertCmd.Parameters.AddWithValue("@Memo", Memo);
                        InsertCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
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
        public bool UpdateSupplierRecord()
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
                        UpdateCmd.CommandText = "UPDATE tblSuppliers SET SupplierName = @SupplierName, Address1 = @Address1, Address2 = @Address2, Address3 = @Address3, Address4 = @Address4, PostCode = @PostCode, ContactName = @ContactName, Telephone = @Telephone, Fax = @Fax, eMail = @eMail, Memo = @Memo, WebSite = @WebSite WHERE SupplierRef = @SupplierRef";
                        UpdateCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        UpdateCmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                        UpdateCmd.Parameters.AddWithValue("@Address1", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address2", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address3", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@Address4", AddressLine1);
                        UpdateCmd.Parameters.AddWithValue("@PostCode", PostCode);
                        UpdateCmd.Parameters.AddWithValue("@ContactName", ContactName);
                        UpdateCmd.Parameters.AddWithValue("@Telephone", Telephone);                       
                        UpdateCmd.Parameters.AddWithValue("@Fax", Fax);
                        UpdateCmd.Parameters.AddWithValue("@eMail", eMail);                        
                        UpdateCmd.Parameters.AddWithValue("@Memo", Memo); 
                        UpdateCmd.Parameters.AddWithValue("@WebSite", WebsiteAddress);
                        Result = (int)UpdateCmd.ExecuteNonQuery();
                    }
                }
                if(Result != 1)
                {
                    UpdateToDB = false;
                }
                else
                {
                    UpdateToDB = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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
