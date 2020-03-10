namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class clsWarehouseTransfer : clsUtils
    {
        public int WarehouseTransferID;
        public string ToWarehouseRef { get; set; }
        public string ToWarehouseName { get; set; }
        public void LoadNewForm()
        {
            frmWarehouseTransfer warehouseTransfer = new frmWarehouseTransfer()
            { 
                FormMode = "New"
            };
            warehouseTransfer.Show();
        }
        public void LoadSelectedForm()
        {
            frmWarehouseTransfer warehouseTransfer = new frmWarehouseTransfer()
            {
                FormMode = "Old"
            };
            warehouseTransfer.Show();
        }
        public int GetLastWarehouseTransferHead()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        using(SqlCommand SelectCmd = new SqlCommand())
                        {
                            SelectCmd.Connection = conn;
                            SelectCmd.Connection.Open();
                            SelectCmd.CommandType = CommandType.Text;
                            SelectCmd.CommandText = "SELECT COUNT(*) as MaxRows FROM tblWarehouseTransfers";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
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
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                Result = 0;
                throw;
            }
            return Result;
        }
    }
    public class clsWarehouseTransferHead : clsWarehouseTransfer
    {
        public string Reference;
        public string WarehouseRef;
        public string WarehouseName;
        public int Qty;
        public DateTime MovementDate;
        public int UserID;
       
        public bool SaveWarehouseTransferHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseTransfers (Reference, TransferDate, WharehouseRef, WarehouseName, ToWarehouseRef, ToWarehouseName, TotalQtyOut, TotalQtyIn, CreatedBy, CreatedDate) VALUES (@Reference, @TransferDate, @WarehouseRef, @WarehouseName, @ToWarehouseRef, @ToWarehouseName, @TotalQtyOut, @TotalQtyIn, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                            InsertCmd.Parameters.AddWithValue("@ToWarehouseRef", ToWarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@ToWarehouseName", ToWarehouseName);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                            InsertCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        SaveToDB = false;
                        throw;
                    }                    
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                SaveToDB = false;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferHead()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseTransfers SET Reference = @Reference, TransferDate = @TransferDate, WarehouseRef = @WarehouseRef, WarehouseName = @WarehouseName, ToWarehouseRef = @ToWarehouseRef, ToWarehouseName = @ToShopName, TotalQtyOut = @TotalQtyOut, TotalQtyOut = @TotalQtyOut WHERE TransferID = @TransferID";
                            UpdateCmd.Parameters.AddWithValue("@TransferID", WarehouseTransferID);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                            UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", ToWarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@ToWarehouseName", ToWarehouseName);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                            UpdateCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
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
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferHead()
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
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseTransfers WHERE TransferID = @TransferID";
                            DeleteCmd.Parameters.AddWithValue("@TransferID", WarehouseTransferID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }                    
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
    }
    public class clsWarehouseTransferLine : clsWarehouseTransfer
    {
        public string StockCode;
        public int CurrentQty;
        public int TOQty;
        public int TIQty;
        public bool SaveWarehouseTransferLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseTransferLines (TransferID, StockCode, CurrentQty, TOQty, TIQty) VALUES (@TransferID,  @StockCode, @CurrentQty, @TOQty, @TIQty)";
                            InsertCmd.Parameters.AddWithValue("@TransferID", WarehouseTransferID);                            
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                            InsertCmd.Parameters.AddWithValue("@TOQty", TOQty);
                            InsertCmd.Parameters.AddWithValue("@TIQty", TIQty);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
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
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                SaveToDB = false;
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferLine()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseTransferLines SET CurrentQty = @CurrentQty, TOQty = @TOQty, TIQty = @TIQty WHERE TransferID = @TransferID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@TransferID", WarehouseTransferID);
                           
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                            UpdateCmd.Parameters.AddWithValue("@TOQty", TOQty);
                            UpdateCmd.Parameters.AddWithValue("@TIQty", TIQty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
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
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferLine()
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
                            DeleteCmd.CommandText = "DELETE FROM tblWarehouseTransferLines WHERE TransferID = @TransferID;";
                            DeleteCmd.Parameters.AddWithValue("@TransferID", WarehouseTransferID);
                            DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
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
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
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
