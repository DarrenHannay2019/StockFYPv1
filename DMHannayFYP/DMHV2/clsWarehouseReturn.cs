using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsWarehouseReturn : clsUtils
    {
    }
    public class clsWarehouseReturnHead : clsWarehouseReturn
    {
        public bool SaveWarehouseReturnHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblWHReturns (ToWarehouseRef, WarehouseRef, Reference, TotalItems, TransactionDate, CreatedBy, CreatedDate) VALUES (@ToWarehouseRef, @WarehouseRef, @Reference, @TotalItems, @TransactionDate, @CreatedBy, @CreatedDate)";
                    InsertCmd.Parameters.AddWithValue("@ToWarehouseRef", SupplierRef);
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
        public bool UpdateWarehouseReturnHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblWHReturns SET ToWarehouseRef = @ToWarehouseRef, WarehouseRef = @WarehouseRef, Reference = @Reference, TotalItems = @TotalItems, TransactionDate = @TransactionDate WHERE ReturnsID = @ReturnsID";
                    UpdateCmd.Parameters.AddWithValue("@ReturnsID", ID);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", SupplierRef);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                    UpdateCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE FROM tblWReturns WHERE ReturnsID = @ReturnsID";
                }
            }
            return DeleteFromDB;
        }
    }
    public class clsWarehouseReturnLine : clsWarehouseReturn
    {
        public bool SaveWarehouseReturnLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblWHReturnLines (ReturnID, StockCode, Qty, Value) VALUES (@ReturnID, @StockCode, @Qty, @Value)";
                    InsertCmd.Parameters.AddWithValue("@ReturnID", ID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                    InsertCmd.Parameters.AddWithValue("@Value", Value);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblWHReturnLines SET Qty = @Qty,Value = @Value WHERE ReturnID = @ReturnID AND StockCode = @StockCode";
                    UpdateCmd.Parameters.AddWithValue("@ReturnID", ID);
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                    UpdateCmd.Parameters.AddWithValue("@Value", Value);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE From tblStockMovements WHERE TransferReference = @TransferReference AND MovementType = @MovementType AND MovementDate = @MovementDate AND Reference = @Reference;DELETE FROM tblWReturnLines WHERE ReturnID = @ReturnID;";
                    DeleteCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                    DeleteCmd.Parameters.AddWithValue("MovementType", MovementType);
                    DeleteCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                    DeleteCmd.Parameters.AddWithValue("@Reference", Reference);
                }
            }
            return DeleteFromDB;
        }
    }

}
