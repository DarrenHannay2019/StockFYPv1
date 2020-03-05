namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class clsShopAdjustment : clsUtils
    {
  
        public void LoadNewForm()
        {
            frmShopAdjustment shopAdjustment = new frmShopAdjustment
            {
                FormMode = "New"
            };
            shopAdjustment.Show();
        }
        public void LoadSelectedForm()
        {
            frmShopAdjustment shopAdjustment = new frmShopAdjustment
            {
                FormMode = "Old"
            };
            shopAdjustment.TxtSID.Text = ID.ToString();           
            shopAdjustment.Show();
        }
        public int GetLastShopAdjustmentHead()
        {
            Result = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopAdjustments";
                    Result = (int)SelectCmd.ExecuteScalar();
                }
            }
            return Result;
        }
    }
    public class clsShopAdjustmentHead : clsShopAdjustment
    {
        public bool SaveShopAdjustHead()
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
						    InsertCmd.CommandText = "INSERT INTO tblShopAdjustments(ShopRef, Reference, TotalLossItems, TotalGainItems, MovementDate, CreatedBy, CreatedDate) VALUES (@ShopRef, @Reference, @TotalLossItems, @TotalGainItems, @MovementDate, @CreatedBy, @CreatedDate)";
						    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
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
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        SaveToDB = false;
                        throw;
                    }                    
                }
                if (Result == 1)
                    SaveToDB = true;
                else
                    SaveToDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                SaveToDB = false;
                throw;
            }           
            return SaveToDB;
        }
        public bool UpdateShopAdjustHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopAdjustments SET ShopRef = @ShopRef, Reference = @Reference, TotalLossItems = @TotalLossItems, TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ShopAdjustmentID = @ShopAdjustmentID";
                            UpdateCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                            UpdateCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                            UpdateCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }    
                }
                if (Result == 1)
                    UpdateToDB = true;
                else
                    UpdateToDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }            
            return UpdateToDB;
        }
        public bool DeleteShopAdjustHead()
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
                            DeleteCmd.CommandText = "DELETE from tblShopAdjustments where ShopAdjustmentID = @ShopAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                           Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }
                }
                if (Result == 1)
                    DeleteFromDB = true;
                else
                    DeleteFromDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in connecting\n" + ex.Message);
                DeleteFromDB = false;
                throw;
            }
            return DeleteFromDB;
        }
    }
    public class clsShopAdjustmentLine : clsShopAdjustment
    {
        public bool SaveShopAdjustLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopAdjustmentsLines(ShopAdjustmentID, StockCode, MovementType, Qty, Value) VALUES (@ShopAdjustmentID, @StockCode, @MovementType, @Qty, @Value)";
                            InsertCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                            InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                            InsertCmd.Parameters.AddWithValue("@Value", Value);
                            Result = (int)InsertCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        SaveToDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
                    }                    
                }
                if (Result == 1)
                    SaveToDB = true;
                else
                    SaveToDB = false;
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                throw;
            }            
            return SaveToDB;
        }
        public bool UpdateShopAdjustLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopAdjustmentsLines SET MovementType = @MovementType, Qty = @Qty, Value = @Value WHERE ShopAdjustmentID = @ShopAdjustmentID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@MovementType", MovementType);
                            UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@Value", Value);
                            UpdateCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
                    }
                }
                if (Result == 1)
                    UpdateToDB = true;
                else
                    UpdateToDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Updating\n" + ex.Message);
                UpdateToDB = false;
                throw;
            }
            
            return UpdateToDB;
        }
        public bool DeleteShopAdjustLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopAdjustmentsLines WHERE ShopAdjustmentID = @ShopAdjustmentID;";
                            DeleteCmd.Parameters.AddWithValue("@ShopAdjustmentID", ID);
                           Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Delete\n" + ex.Message);
                        DeleteFromDB = false;
                        throw;
                    }                    
                }
                if (Result == 1)
                    DeleteFromDB = true;
                else
                    DeleteFromDB = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Delete\n" + ex.Message);
                DeleteFromDB = false;
                throw;
            }            
            return DeleteFromDB;
        }
    }
}
