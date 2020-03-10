namespace DMHV2
{
    using System;
    using System.Data.SqlClient;
    using System.Data;

    public class clsShopDelivery : clsUtils
    {
        public int ID;
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
                FormMode = "New"                
            };
            shopAdjustment.TxtSID.Text = ID.ToString();
            shopAdjustment.Show();
        }
        public int GetLastShopDelivery()
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
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopDelivery";
                            Result = (int)SelectCmd.ExecuteScalar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        Result = 0;
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
    public class clsShopDeliveryHead : clsShopDelivery
    {
        public string ShopRef;
        public string ShopName;
        public string WarehouseRef;
        public string WarehouseName;
        public string Reference;
        public DateTime MovementDate;
        public int UserID;
        public int TotalItems;
        public int ID;
        public string ShopDelID;
        public bool SaveShopDeliveryHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopDeliveries(ShopRef, ShopName, WarehouseRef, WarehouseName, Reference, TotalItems, DeliveryDate, DeliveryType, ConfirmedDate, Notes, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @WarehouseRef, @WarehouseName, @Reference, @TotalItems, @DeliveryDate, @DeliveryType, @ConfirmedDate, @Notes, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            InsertCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                            InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                            InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@DeliveryType", "Confirmed");
                            InsertCmd.Parameters.AddWithValue("@ConfirmedDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@Notes", "");
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
        public bool UpdateShopDeliveryHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopDeliveries SET ShopRef = @ShopRef, ShopName = @ShopName, WarehouseRef = @WarehouseRef, WarehouseName = @WarehouseName, Reference = @Reference, TotalItems = @TotalItems, DeliveryDate = @DeliveryDate, DeliveryType = @DeliveryType, ConfirmedDate = @ConfirmedDate, Notes = @Notes WHERE DeliveriesID = @DeliveriesID";
                            UpdateCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                            UpdateCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                            UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                            UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                            UpdateCmd.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@DeliveryType", "Confirmed");
                            UpdateCmd.Parameters.AddWithValue("@ConfirmedDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@Notes", "");
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
        public bool DeleteShopDeliveryHead()
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
                            DeleteCmd.CommandText = "DELETE from tblShopDeliveries where DeliveriesID = @DeliveriesID;";
                            DeleteCmd.Parameters.AddWithValue("@DeliveriesID", ID);
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
    public class clsShopDeliveryLine : clsShopDelivery
    {
        public string StockCode;
        public int Qty;
        public string ShopDelID;
        public bool SaveShopDeliveryLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopDeliveryLines (DeliveriesID, StockCode, DeliveredQty) VALUES (@DeliveriesID, @StockCode, @DeliveredQty)";
                            InsertCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@DeliveredQty", Qty);
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
        public bool UpdateShopDeliveryLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopDeliveryLines SET DeliveredQty = @DeliveredQty WHERE DeliveriesID = @DeliveriesID AND StockCode = StockCode";
                            UpdateCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@DeliveredQty", Qty);
                            Result = (int)UpdateCmd.ExecuteNonQuery();
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
        public bool DeleteShopDeliveryLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopDeliveryLines WHERE DeliveriesID = @DeliveriesID;";
                            DeleteCmd.Parameters.AddWithValue("@DeliveriesID", ID);
                            Result = (int)DeleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        DeleteFromDB = false;
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        throw;
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
