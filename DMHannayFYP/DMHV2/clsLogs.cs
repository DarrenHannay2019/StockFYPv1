namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    public class clsLogs : clsUtils 
    {
        public int LocationType { get; set; }
        public string StockCode { get; set; }
        public string SupplierRef { get; set; }
        public string LocationRef { get; set; }
        public string StringMovementType { get; set; }
        public int MovementType { get; set; }
        public int Qty { get; set; }
        public string RecordType { get; set; }
        public DateTime MovementDate { get; set; }
        public string Reference { get; set; }
        public int UserID { get; set; }
        public int DeliveredQtyHangers { get; set; }
        public int DeliveredQtyBoxes { get; set; }
        public int DeliveredQtyGarments { get; set; }
        public decimal MovementValue { get; set; }
        public int TransferReference { get; set; }


        public clsLogs()
        {
            SaveToDB = false;
            DeleteFromDB = false;
        }
        ~clsLogs()
        {
            SaveToDB = false;
            DeleteFromDB = false;
        }
        public bool SaveToSysLogTable()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblSystemLog (StockCode, SupplierRef, LocationRef, Qty, MovementType, RecordType, MovementDate, TimeStamp, Reference, CreatedBy) VALUES (@StockCode, @SupplierRef, @LocationRef, @Qty, @MovementType, @RecordType, @MovementDate, @TimeStamp, @Reference, @CreatedBy)";
                        InsertCmd.Parameters.AddWithValue("StockCode", StockCode);
                        InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        InsertCmd.Parameters.AddWithValue("@LocationRef", LocationRef);
                        InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                        InsertCmd.Parameters.AddWithValue("@MovementType", StringMovementType);
                        InsertCmd.Parameters.AddWithValue("@RecordType", RecordType);
                        InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        InsertCmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                        InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }               
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                SaveToDB = false;
            else
                SaveToDB = true;
            return SaveToDB;
        }
        public bool SaveToStockMovementsTable()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand InsertCmd = new SqlCommand())
                    {
                        InsertCmd.Connection = conn;
                        InsertCmd.CommandType = CommandType.Text;
                        InsertCmd.CommandText = "INSERT INTO tblStockMovements (StockCode, SupplierRef, LocationRef, LocationType, MovementQtyHangers, MovementQtyBoxes, MovementType, MovementDate, MovementValue, Reference, TransferReference, CreatedBy, CreatedDate) VALUES (@StockCode, @SupplierRef, @LocationRef, @LocationType, @MovementQtyHangers, @MovementQtyBoxes, @MovementType, @MovementDate, @MovementValue, @Reference, @TransferReference, @CreatedBy, @CreatedDate)";
                        InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        InsertCmd.Parameters.AddWithValue("@LocationRef", LocationRef);
                        InsertCmd.Parameters.AddWithValue("@LocationType", LocationType);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyHangers", DeliveredQtyHangers);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyBoxes", DeliveredQtyBoxes);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyGarments", DeliveredQtyGarments);
                        InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        InsertCmd.Parameters.AddWithValue("@MovementValue", MovementValue);
                        InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                        InsertCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }                
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                SaveToDB = false;
            else
                SaveToDB = true;
            return SaveToDB;
        }
        public bool DeleteFromStockMovemmentsTable()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblStockMovements WHERE MovementType = @MovementType AND TransferReference = @TransferReference AND MovementDate = @MovementDate";
                        DeleteCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        DeleteCmd.Parameters.AddWithValue("@TransferReference", TransferReference);                        
                        DeleteCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }                
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                DeleteFromDB = false;
            else
                DeleteFromDB = true;
            return DeleteFromDB;
        }
        public bool DeleteZeroQtyFromStockMovementsTable()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblStockMovements WHERE MovementType = @MovementType AND TransferReference = @TransferReference AND Reference = @Reference AND MovementDate = @MovementDate AND MovementQtyHangers = '0' AND MovementQtyBoxes = '0' AND MovementQtyGarments = '0' AND MovementValue = '0'";
                        DeleteCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        DeleteCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        DeleteCmd.Parameters.AddWithValue("@Reference", Reference);
                        DeleteCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            if (Result != 1)
                DeleteFromDB = false;
            else
                DeleteFromDB = true;
            return DeleteFromDB;
        }
    }
}
