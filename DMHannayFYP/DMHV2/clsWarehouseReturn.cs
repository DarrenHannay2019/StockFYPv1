namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsWarehouseReturn : clsUtils
    {
        public string WarehouseReturnID { get; set; }
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
            warehouseReturn.txtReturnID.Text = WarehouseReturnID.ToString();
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
        public string Reference;
        public DateTime MovementDate;
        public string SupplierRef;
        public int TotalItems;
        public string WarehouseRef;
        public int UserID;
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
                        MessageBox.Show(ex.Message);

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
                MessageBox.Show(ex.Message);

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
                            UpdateCmd.Parameters.AddWithValue("@ReturnsID", WarehouseReturnID);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", SupplierRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show(ex.Message);

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
                            DeleteCmd.Parameters.AddWithValue("@ReturnsID", WarehouseReturnID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        DeleteFromDB = false;
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

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
        public string StockCode;
        public int ReturnQty;
        public int ReturnValue;
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
                            InsertCmd.Parameters.AddWithValue("@ReturnID", WarehouseReturnID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@Qty", ReturnQty);
                            InsertCmd.Parameters.AddWithValue("@Value", ReturnValue);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

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
                            UpdateCmd.Parameters.AddWithValue("@ReturnID", WarehouseReturnID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@Qty", ReturnQty);
                            UpdateCmd.Parameters.AddWithValue("@Value", ReturnValue);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
                        MessageBox.Show(ex.Message);

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
                MessageBox.Show(ex.Message);

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
                            DeleteCmd.Parameters.AddWithValue("@ReturnID", WarehouseReturnID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        MessageBox.Show(ex.Message);

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
                MessageBox.Show(ex.Message);

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
