namespace DMHV2
{
    using System.Data;
    using System.Data.SqlClient;

    public class clsShopAdjustment : clsUtils
    {
    }
    public class clsShopAdjustmentHead : clsUtils
    {
        public bool SaveShopAdjustHead()
        {
            //using(SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = GetConnString(1);
            //    using(SqlCommand InsertCmd = new SqlCommand())
            //    {
            //        InsertCmd.Connection = conn;
            //        InsertCmd.Connection.Open();
            //        InsertCmd.CommandType = CommandType.Text;
            //        InsertCmd.CommandText = "INSERT INTO tblShopAdjustments(ShopRef, Reference, TotalLossItems, TotalGainItems, MovementDate, CreatedBy, CreatedDate) VALUES (@ShopRef, @Reference, @TotalLossItems, @TotalGainItems, @MovementDate, @CreatedBy, @CreatedDate)";
            //        InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
            //        InsertCmd.Parameters.AddWithValue("@Reference", Reference);
            //        InsertCmd.Parameters.AddWithValue("@TotalLossItems", CInt(TotalLossItems));
            //        InsertCmd.Parameters.AddWithValue("@TotalGainItems", CInt(TotalGainItems));
            //        InsertCmd.Parameters.AddWithValue("@MovementDate", CDate(MovementDate));
            //        InsertCmd.Parameters.AddWithValue("@CreatedBy", username);
            //        InsertCmd.Parameters.AddWithValue("@CreatedDate", Date.Now);
            //        InsertCmd.ExecuteNonQuery();
            //    }
            //}          
            return SaveToDB;
        }
        public bool UpdateShopAdjustHead()
        {
            //using(SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = GetConnString(1);
            //    using (SqlCommand UpdateCmd = new SqlCommand())
            //    {
            //        UpdateCmd.Connection = conn;
            //        UpdateCmd.Connection.Open();
            //        UpdateCmd.CommandType = CommandType.Text;
            //        UpdateCmd.CommandText = "UPDATE tblShopAdjustments SET ShopRef = @ShopRef,Reference = @Reference,TotalLossItems = @TotalLossItems,TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID";
            //        UpdateCmd.Parameters.AddWithValue("@ID", CInt(ID));
            //        UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
            //        UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
            //        UpdateCmd.Parameters.AddWithValue("@TotalLossItems", CInt(TotalLossItems));
            //        UpdateCmd.Parameters.AddWithValue("@TotalGainItems", CInt(TotalGainItems));
            //        UpdateCmd.Parameters.AddWithValue("@MovementDate", CDate(MovementDate));
            //        UpdateCmd.ExecuteNonQuery();
            //    }
            //}           
            return UpdateToDB;
        }
        public bool DeleteShopAdjustHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopAdjustmentLine : clsUtils
    {
        public bool SaveShopAdjustLine()
        {
            //using(SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = GetConnString(1);
            //    using (SqlCommand InsertCmd = new SqlCommand())
            //    {
            //        InsertCmd.Connection = conn;
            //        InsertCmd.Connection.Open();
            //        InsertCmd.CommandType = CommandType.Text;
            //        InsertCmd.CommandText = "INSERT INTO tblShopAdjustmentsLines(ShopAdjustID,StockCode,MovementType,Qty,Value) VALUES (@ShopAdjustID,@StockCode,@MovementType,@Qty,@Value)";
            //        InsertCmd.Parameters.AddWithValue("@ShopAdjustID", CInt(ShopAdjustID));
            //        InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
            //        InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
            //         InsertCmd.Parameters.AddWithValue("@Qty", CInt(qty));
            //        InsertCmd.Parameters.AddWithValue("@Value", CDec(Value));
            //        InsertCmd.ExecuteNonQuery();
            //    }
            //}         
            return SaveToDB;
        }
        public bool UpdateShopAdjustLine()
        {
            //using(SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = GetConnString(1);
            //    using (SqlCommand UpdateCmd = new SqlCommand())
            //    {
            //        UpdateCmd.Connection = conn;
            //        UpdateCmd.Connection.Open();
            //        UpdateCmd.CommandType = CommandType.Text;
            //        UpdateCmd.CommandText = "UPDATE tblShopAdjustmentsLines SET MovementType = @MovementType,Qty = @Qty,Value = @Value WHERE ShopAdjustID = @ShopAdjustID AND StockCode = @StockCode";
            //        UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
            //        UpdateCmd.Parameters.AddWithValue("@MovementType", MovementType);
            //        UpdateCmd.Parameters.AddWithValue("@Qty", CInt(Qty));
            //        UpdateCmd.Parameters.AddWithValue("@Value", CDec(Value));
            //        UpdateCmd.Parameters.AddWithValue("@ShopAdjustID", CInt(ID));
            //        UpdateCmd.ExecuteNonQuery();
            //    }
            //}
            return UpdateToDB;
        }
        public bool DeleteShopAdjustLine()
        {
            return DeleteFromDB;
        }
    }
}
