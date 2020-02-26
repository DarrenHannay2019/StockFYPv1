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
    }
    public class clsShopSaleHead : clsShopSale
    {
        public bool SaveShopSaleHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblSales (ShopRef, ShopName, Reference, TransactionDate, TotalQty, TotalValue, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @Reference, @TransactionDate, @TotalQty, @TotalValue, @CreatedBy, @CreatedDate)";
                    InsertCmd.Parameters.AddWithValue("@ShopRef", shopref);
                    InsertCmd.Parameters.AddWithValue("@ShopName", shopname);
                    InsertCmd.Parameters.AddWithValue("@SAReference", "0");
                    InsertCmd.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    InsertCmd.Parameters.AddWithValue("@TotalQty", TotalQty);
                    InsertCmd.Parameters.AddWithValue("@TotalValue", TotalValue);
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", username);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", Date.Now);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopSaleHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblSales SET ShopRef = @ShopRef, ShopName = @ShopName, Reference = @Reference, TransactionDate = @TransactionDate, TotalQty = @TotalQty, TotalValue = @TotalValue WHERE SalesID = @SalesID";
                    UpdateCmd.Parameters.AddWithValue("@SalesID", CInt(SalesID));
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", shopref);
                    UpdateCmd.Parameters.AddWithValue("@ShopName", shopname);
                    UpdateCmd.Parameters.AddWithValue("@Reference", SAReference);
                    UpdateCmd.Parameters.AddWithValue("@TransactionDate", CDate(TransactionDate));
                    UpdateCmd.Parameters.AddWithValue("@TotalQty", CInt(TotalQty));
                    UpdateCmd.Parameters.AddWithValue("@TotalValue", CDec(TotalValue));
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopSaleHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "";
                }
            }
            return DeleteFromDB;
        }
    }
    public class clsShopSaleLine : clsShopSale
    {
        public bool SaveShopSaleLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblSalesLines (SalesID, StockCode, CurrentQty, QtySold, SalesAmount, StockMovementID) VALUES (@SalesID, @StockCode, @CurrentQty, @QtySold, @SalesAmount, @StockMovementID)";
                    InsertCmd.Parameters.AddWithValue("@SalesID", salesID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", stockcode);
                    InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                    InsertCmd.Parameters.AddWithValue("@QtySold", QtySold);
                    InsertCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                    InsertCmd.Parameters.AddWithValue("@StockMovementID", StockID);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopSaleLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblSalesLines SET CurrentQty = @CurrentQty, QtySold = @QtySold, SalesAmount = @SalesAmount, StockMovementID = @StockMovementID WHERE SalesID = @SalesID AND StockCode = @StockCode";
                    UpdateCmd.Parameters.AddWithValue("@SalesID", CInt(salesID));
                    UpdateCmd.Parameters.AddWithValue("@StockCode", stockcode);
                    UpdateCmd.Parameters.AddWithValue("@CurrentQty", CInt(CurrentQty));
                    UpdateCmd.Parameters.AddWithValue("@QtySold", CInt(QtySold));
                    UpdateCmd.Parameters.AddWithValue("@SalesAmount", CDec(SalesAmount));
                    UpdateCmd.Parameters.AddWithValue("@StockMovementID", CInt(StockID));
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopSaleLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "";
                }
            }
            return DeleteFromDB;
        }
        public bool DeleteShopZeroSaleLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE from tblSalesLines WHERE SalesID = @SalesID AND QtySold = @QtySold AND SalesAmount = @SalesAmount;";
                    DeleteCmd.Parameters.AddWithValue("@SalesID", salesID);
                    DeleteCmd.Parameters.AddWithValue("@QtySold", "0");
                    DeleteCmd.Parameters.AddWithValue("@SalesAmount", "0.00");
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
}
