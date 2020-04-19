namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class clsWarehouseAdjustment : clsUtils
    {
        public int UserID { get; set; }
       public int WarehouseAdjustmentID { get; set; }
        
        public void LoadNewForm()
        {
            frmWarehouseAdjustment warehouseAdjustment = new frmWarehouseAdjustment
            {
                FormMode = "New",
                LoggedInUser = UserID
            };
            warehouseAdjustment.ShowDialog();
        }
        public void LoadSelectedForm()
        {
            frmWarehouseAdjustment warehouseAdjustment = new frmWarehouseAdjustment
            {
                FormMode = "Old",
                LoggedInUser = UserID

            };
            warehouseAdjustment.TxtRecordID.Text = WarehouseAdjustmentID.ToString();
            warehouseAdjustment.Show();
        }
        public int GetLastWarehouseAdjustmentHead()
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
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblWarehouseAdjustments";
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
    public class clsWarehouseAdjustmentHead : clsWarehouseAdjustment
    {
        public string ShopRef;
        public string WarehouseRef;
        public string SupplierRef;
        public DateTime MovementDate;
        //public int WarehouseAdjustmentID;
        public int TotalLossItems;
        public int TotalGainItems;
        public string Reference;
        public string WarehouseName;
        public bool SaveWarehouseAdjustmentHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseAdjustments(WarehouseRef, Reference, TotalLossItems, TotalGainItems, MovementDate, CreatedBy, CreatedDate) VALUES (@WarehouseRef, @Reference, @TotalLossItems, @TotalGainItems, @MovementDate, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            InsertCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                            InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
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
                SaveToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentHead()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseAdjustments SET WarehouseRef = @WarehouseRef, Reference = @Reference, TotalLossItems = @TotalLossItems, TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID";
                            UpdateCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            UpdateCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            UpdateCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                            UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        UpdateToDB = false;
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
                UpdateToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }            
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentHead()
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
                            DeleteCmd.CommandText = "DELETE from tblWarehouseAdjustments where WarehouseAdjustmentID = @WarehouseAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
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
    public class clsWarehouseAdjustmentLine : clsWarehouseAdjustment
    {
     //   public int WarehouseAdjustmentID;
        public string StockCode;
        public int Qty;
        public string MovementType;
        public decimal Value;
        public bool SaveWarehouseAdjustmentLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblWarehouseAdjustmentsLines (WarehouseAdjustmentID, StockCode, MovementType, Qty, Value) VALUES (@WarehouseAdjustmentID, @StockCode, @MovementType, @Qty, @Value)";
                            InsertCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                            InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                            InsertCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)InsertCmd.ExecuteNonQuery();
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
                throw;
            }
            if (Result == 1)
                SaveToDB = true;
            else
                SaveToDB = false;
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentLine()
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
                            UpdateCmd.CommandText = "UPDATE tblWarehouseAdjustmentsLines SET MovementType = @MovementType, Qty = @Qty, Value = @Value WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@MovementType", MovementType);
                            UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@Value", Value);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseAdjustmentID", WarehouseAdjustmentID);
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }            
            if (Result == 1)
                UpdateToDB = true;
            else
                UpdateToDB = false;
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentLine()
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
                            DeleteCmd.CommandText = "DELETE from tblWarehouseAdjustmentsLines WHERE WarehouseAdjustmentID = @WarehouseAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@WHAdjustID", WarehouseAdjustmentID);
                            DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
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
                DeleteFromDB = false;
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
}
