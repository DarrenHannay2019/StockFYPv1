namespace DMHV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

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
                    InsertCmd.Parameters.AddWithValue("@TotalLossItems", CInt(TotalLossItems));
                    InsertCmd.Parameters.AddWithValue("@TotalGainItems", CInt(TotalGainItems));
                    InsertCmd.Parameters.AddWithValue("@MovementDate", CDate(MovementDate));
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", username);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", Date.Now);
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
                    UpdateCmd.Parameters.AddWithValue("@MovementDate", CDate(MovementDate));
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
                    InsertCmd.Parameters.AddWithValue("@WarehouseAdjustID", CInt(WarehouseAdjustID));
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                    InsertCmd.Parameters.AddWithValue("@Qty", CInt(qty));
                    InsertCmd.Parameters.AddWithValue("@Value", CDec(Value));
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
                    UpdateCmd.Parameters.AddWithValue("@Qty", CInt(Qty));
                    UpdateCmd.Parameters.AddWithValue("@Value", CDec(Value));
                    UpdateCmd.Parameters.AddWithValue("@WarehouseAdjustID", CInt(ID));
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
