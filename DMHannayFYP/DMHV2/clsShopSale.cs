using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopSale : clsUtils
    {
        public int UserID { get; set; }
        public int SalesID { get; set; }
        public void LoadNewForm()
        {
            frmShopSale shopSale = new frmShopSale()
            {
                FormMode = "New",
               LoggedInUser = UserID
            };
            shopSale.Show();
        }
        public void LoadSelectedForm()
        {
            frmShopSale shopSale = new frmShopSale()
            {
                FormMode = "Old"
            };
            shopSale.Show();
        }
        public int GetLastShopSaleHead()
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
                            SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblShopSales";
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
    public class clsShopSaleHead : clsShopSale
    {
        public string ShopRef;
        public string ShopName;
        public DateTime MovementDate;
        public int Qty;
        public decimal VATRate;
        public decimal Value;
      //  public int UserID;
     //   public int SalesID;
        public bool SaveShopSaleHead()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopSales (ShopRef, ShopName, TransactionDate, TotalQty, TotalVAT, TotalValue, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @TransactionDate, @TotalQty, @TotalVAT, @TotalValue, @CreatedBy, @CreatedDate)";
                            InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);                            
                            InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            InsertCmd.Parameters.AddWithValue("@TotalQty", Qty);
                            InsertCmd.Parameters.AddWithValue("@TotalVAT", VATRate);
                            InsertCmd.Parameters.AddWithValue("@TotalValue", Value);
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
        public bool UpdateShopSaleHead()
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
                            UpdateCmd.CommandText = "UPDATE tblShopSales SET ShopRef = @ShopRef, ShopName = @ShopName,  TransactionDate = @TransactionDate, TotalQty = @TotalQty, TotalVAT = @TotalVAT, TotalValue = @TotalValue WHERE SalesID = @SalesID";
                            UpdateCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                            UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                            UpdateCmd.Parameters.AddWithValue("@TotalVAT", VATRate);
                            UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                            UpdateCmd.Parameters.AddWithValue("@TotalQty", Qty);
                            UpdateCmd.Parameters.AddWithValue("@TotalValue", Value);
                            UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
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
        public bool DeleteShopSaleHead()
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
                            DeleteCmd.CommandText = "DELETE from tblShopSales WHERE SalesID =@SalesID;";
                            DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
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
    public class clsShopSaleLine : clsShopSale
    {
     //   public int SalesID;
        public string StockCode;
        public int DeliveredQtyGarments;
        public int CurrentQty;
        public int TotalItems;
        public int Qty;
        public decimal SalesAmount;
        public bool SaveShopSaleLine()
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
                            InsertCmd.CommandText = "INSERT INTO tblShopSalesLines (SalesID, StockCode, DeliveredQty, CurrentQty, TotalSoldQty, QtySold, SalesAmount) VALUES (@SalesID, @StockCode, @DeliveredQty, @CurrentQty, @TotalSoldQty, @QtySold, @SalesAmount)";
                            InsertCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            InsertCmd.Parameters.AddWithValue("@DeliveredQty", DeliveredQtyGarments);
                            InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                            InsertCmd.Parameters.AddWithValue("@TotalSoldQty", TotalItems);
                            InsertCmd.Parameters.AddWithValue("@QtySold", Qty);
                            InsertCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);                            
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
        public bool UpdateShopSaleLine()
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
                            UpdateCmd.CommandText = "UPDATE tblShopSalesLines SET CurrentQty = @CurrentQty, QtySold = @QtySold, SalesAmount = @SalesAmount, StockMovementID = @StockMovementID WHERE SalesID = @SalesID AND StockCode = @StockCode";
                            UpdateCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                            UpdateCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                            UpdateCmd.Parameters.AddWithValue("@QtySold", Qty);
                            UpdateCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                        }
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error in Saving\n" + ex.Message);
                        UpdateToDB = false;
                        throw;
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
        public bool DeleteShopSaleLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopSalesLines WHERE SalesID = @SalesID;";
                            DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
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
                DeleteFromDB = false;
                throw;
            }
            if (Result == 1)
                DeleteFromDB = true;
            else
                DeleteFromDB = false;
            return DeleteFromDB;
        }
        public bool DeleteShopZeroSaleLine()
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
                            DeleteCmd.CommandText = "DELETE from tblShopSalesLines WHERE SalesID = @SalesID AND QtySold = @QtySold AND SalesAmount = @SalesAmount;";
                            DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
                            DeleteCmd.Parameters.AddWithValue("@QtySold", "0");
                            DeleteCmd.Parameters.AddWithValue("@SalesAmount", "0.00");
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
