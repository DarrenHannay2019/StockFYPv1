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
                    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    InsertCmd.Parameters.AddWithValue("@Reference", "0");
                    InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@TotalQty", Qty);
                    InsertCmd.Parameters.AddWithValue("@TotalValue", Value);
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
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
                    UpdateCmd.Parameters.AddWithValue("@SalesID", SalesID);
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                    UpdateCmd.Parameters.AddWithValue("@TotalQty", Qty);
                    UpdateCmd.Parameters.AddWithValue("@TotalValue", Value);
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
                    DeleteCmd.CommandText = "DELETE from tblSales WHERE SalesID =@SalesID;";
                    DeleteCmd.Parameters.AddWithValue("@SalesID", ID);
                    DeleteCmd.ExecuteNonQuery();
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
                    InsertCmd.Parameters.AddWithValue("@SalesID", SalesID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                    InsertCmd.Parameters.AddWithValue("@QtySold", Qty);
                    InsertCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                    InsertCmd.Parameters.AddWithValue("@StockMovementID", smtoid);
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
                    UpdateCmd.Parameters.AddWithValue("@SalesID", SalesID);
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@CurrentQty", CurrentQty);
                    UpdateCmd.Parameters.AddWithValue("@QtySold", Qty);
                    UpdateCmd.Parameters.AddWithValue("@SalesAmount", SalesAmount);
                    UpdateCmd.Parameters.AddWithValue("@StockMovementID", smtoid);
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
                    DeleteCmd.CommandText = "DELETE from tblSalesLines WHERE SalesID = @SalesID;";
                    DeleteCmd.Parameters.AddWithValue("@SalesID", ID);
                    DeleteCmd.ExecuteNonQuery();
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
                    DeleteCmd.Parameters.AddWithValue("@SalesID", SalesID);
                    DeleteCmd.Parameters.AddWithValue("@QtySold", "0");
                    DeleteCmd.Parameters.AddWithValue("@SalesAmount", "0.00");
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
}
