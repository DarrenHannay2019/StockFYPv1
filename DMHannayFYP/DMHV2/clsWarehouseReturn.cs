namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class clsWarehouseReturn : clsUtils
    {
        public void LoadNewForm()
        {
            frmWarehouseReturn warehouseReturn = new frmWarehouseReturn()
            {
                FormMode = "New"
            };
            warehouseReturn.Show();
        }
        public void LoadSelectedForm()
        {
            frmWarehouseReturn warehouseReturn = new frmWarehouseReturn()
            {
                FormMode = "Old"
            };
            warehouseReturn.txtReturnID.Text = ID.ToString();
            warehouseReturn.Show();
        }
        public int GetLastWarehouseReturnHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblWarehouseReturns";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            return Result;
        }
    }
    public class clsWarehouseReturnHead : clsWarehouseReturn
    {
        public bool SaveWarehouseReturnHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseReturns (ToWarehouseRef, WarehouseRef, Reference, TotalItems, TransactionDate, CreatedBy, CreatedDate) VALUES (@ToWarehouseRef, @WarehouseRef, @Reference, @TotalItems, @TransactionDate, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ToWarehouseRef", SupplierRef);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
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
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnHead()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseReturns SET ToWarehouseRef = @ToWarehouseRef, WarehouseRef = @WarehouseRef, Reference = @Reference, TotalItems = @TotalItems, TransactionDate = @TransactionDate WHERE ReturnsID = @ReturnsID";
                            UpdateCmd.Parameters.AddWithValue("@ReturnsID", ID);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", SupplierRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        UpdateToDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnHead()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand DeleteCmd = new SqlCommand())
                        {
                            DeleteCmd.Connection = conn;
                            DeleteCmd.Connection.Open();
                            DeleteCmd.CommandType = CommandType.Text;
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseReturns WHERE ReturnsID = @ReturnsID";
                            DeleteCmd.Parameters.AddWithValue("@ReturnsID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
    public class clsWarehouseReturnLine : clsWarehouseReturn
    {
        public bool SaveWarehouseReturnLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseReturnLines (ReturnID, StockCode, Qty, Value) VALUES (@ReturnID, @StockCode, @Qty, @Value)";
                            InsertCmd.Parameters.AddWithValue("@ReturnID", ID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                            InsertCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnLine()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseReturnLines SET Qty = @Qty,Value = @Value WHERE ReturnID = @ReturnID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@ReturnID", ID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
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
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnLine()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using (SqlCommand DeleteCmd = new SqlCommand())
                        {
                            DeleteCmd.Connection = conn;
                            DeleteCmd.Connection.Open();
                            DeleteCmd.CommandType = CommandType.Text;
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseReturnLines WHERE ReturnID = @ReturnID;";
                            DeleteCmd.Parameters.AddWithValue("@ReturnID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
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
                DeleteFromDB = false;
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }

}
