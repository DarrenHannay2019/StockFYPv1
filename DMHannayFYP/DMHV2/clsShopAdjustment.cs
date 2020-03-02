namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class clsShopAdjustment : clsUtils
    {
        public string Reference { get; set; }
        public int TotalLossItems { get; set; }
        public int TotalGainItems { get; set; }
        public void LoadNewForm()
        {
        
        }
        public void LoadSelectedForm()
        {
        
        }
        public int GetLastShopAdjustmentHead()
        {

            return Result;
        }
    }
    public class clsShopAdjustmentHead : clsShopAdjustment
    {
        public bool SaveShopAdjustHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
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
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopAdjustHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblShopAdjustments SET ShopRef = @ShopRef,Reference = @Reference,TotalLossItems = @TotalLossItems,TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID";
                    UpdateCmd.Parameters.AddWithValue("@ID", AdjustmentID);
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TotalLossItems", TotalLossItems);
                    UpdateCmd.Parameters.AddWithValue("@TotalGainItems", TotalGainItems);
                    UpdateCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopAdjustHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE from tblShopAdjustments where ID = @ID;";
                    DeleteCmd.Parameters.AddWithValue("@ID", ID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
    public class clsShopAdjustmentLine : clsUtils
    {
        public bool SaveShopAdjustLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblShopAdjustmentsLines(ShopAdjustID,StockCode,MovementType,Qty,Value) VALUES (@ShopAdjustID,@StockCode,@MovementType,@Qty,@Value)";
                    InsertCmd.Parameters.AddWithValue("@ShopAdjustID", AdjustmentID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                    InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                    InsertCmd.Parameters.AddWithValue("@Value", Value);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopAdjustLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblShopAdjustmentsLines SET MovementType = @MovementType,Qty = @Qty,Value = @Value WHERE ShopAdjustID = @ShopAdjustID AND StockCode = @StockCode";
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@MovementType", MovementType);
                    UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                    UpdateCmd.Parameters.AddWithValue("@Value", Value);
                    UpdateCmd.Parameters.AddWithValue("@ShopAdjustID", AdjustmentID);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopAdjustLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE from tblShopAdjustmentsLines WHERE ShopAdjustID = @ShopAdjustID;";
                    DeleteCmd.Parameters.AddWithValue("@ShopAdjustID", ID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
}
