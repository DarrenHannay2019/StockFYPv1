using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopReturn : clsUtils
    {
    }
    public class clsShopReturnHead : clsShopReturn
    {
        public bool SaveShopReturnHead()
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using(SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblReturns(ShopRef, WarehouseRef, Reference, TotalItems, TransactionDate, CreatedBy, CreatedDate) VALUES (@ShopRef, @WarehouseRef, @Reference, @TotalItems, @TransactionDate, @CreatedBy, @CreatedDate)";
                    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                    InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                    InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopReturnHead()
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using(SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblReturns SET ShopRef = @ShopRef, WarehouseRef = @WarehouseRef, Reference = @Reference, TotalItems = @TotalItems,TransactionDate = @TransactionDate WHERE ReturnsID = @ReturnsID";
                    UpdateCmd.Parameters.AddWithValue("@ReturnsID", ID);
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                    UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopReturnHead()
        {
            using(SqlConnection conn = new SqlConnection())
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
    public class clsShopReturnLine : clsShopReturn
    {
        public bool SaveShopReturnLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblReturnLines (ReturnID, StockCode, Qty, Value) VALUES (@ReturnID, @StockCode, @Qty, @Value)";
                    InsertCmd.Parameters.AddWithValue("@ReturnID", ID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                    InsertCmd.Parameters.AddWithValue("@Value", Value);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopReturnLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblReturnLines SET Qty = @Qty,Value = @Value WHERE ReturnID = @ReturnID AND StockCode = @StockCode";
                    UpdateCmd.Parameters.AddWithValue("@ReturnID", ID);
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                    UpdateCmd.Parameters.AddWithValue("@Value", Value);
                    UpdateCmd.ExecuteNonQuery();
                }
            }                     
            return UpdateToDB;
        }
        public bool DeleteShopReturnLine()
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
}
