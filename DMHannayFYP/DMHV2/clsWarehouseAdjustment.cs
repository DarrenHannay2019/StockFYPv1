namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class clsWarehouseAdjustment : clsUtils
    {

    }
    public class clsWarehouseAdjustmentHead : clsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
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
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblWarehouseAdjustments SET WarehouseRef = @WarehouseRef, Reference = @Reference, TotalLossItems = @TotalLossItems, TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID";
                    UpdateCmd.Parameters.AddWithValue("@ID", ID);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                    UpdateCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                    UpdateCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentHead()
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
    public class clsWarehouseAdjustmentLine : clsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblWarehouseAdjustmentsLines (WarehouseAdjustID, StockCode, MovementType, Qty, Value) VALUES (@WarehouseAdjustID, @StockCode, @MovementType, @Qty, @Value)";
                    InsertCmd.Parameters.AddWithValue("@WarehouseAdjustID", ID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                    InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                    InsertCmd.Parameters.AddWithValue("@Value", Value);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblWarehouseAdjustmentsLines SET MovementType = @MovementType, Qty = @Qty, Value = @Value WHERE WarehouseAdjustID = @WarehouseAdjustID AND StockCode = @StockCode";
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@MovementType", MovementType);
                    UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                    UpdateCmd.Parameters.AddWithValue("@Value", Value);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseAdjustID", ID);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentLine()
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
