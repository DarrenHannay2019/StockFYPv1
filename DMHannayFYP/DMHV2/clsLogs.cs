namespace DMHV2
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    public class clsLogs : clsUtils 
    {
        public int LocationType { get; set; }
        public clsLogs()
        {

        }
        ~clsLogs()
        {

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
                        InsertCmd.CommandText = "INSERT INTO tblSysLog (StockCode, SupplierRef, LocationRef, Qty, MovementType, RecordType, MovementDate, TimeStamp, Reference, CreatedBy) VALUES (@StockCode, @SupplierRef, @LocationRef, @Qty, @MovementType, @RecordType, @MovementDate, @TimeStamp, @Reference, @CreatedBy)";
                        InsertCmd.Parameters.AddWithValue("StockCode", StockCode);
                        InsertCmd.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        InsertCmd.Parameters.AddWithValue("@LocationRef", ShopRef);
                        InsertCmd.Parameters.AddWithValue("@Qty", Qty);
                        InsertCmd.Parameters.AddWithValue("@MovementType", ShopName);
                        InsertCmd.Parameters.AddWithValue("@RecordType", WarehouseName);
                        InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        InsertCmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                        InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
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
                        if(LocationType == 2)
                            InsertCmd.Parameters.AddWithValue("@LocationRef", ShopRef);
                        else
                            InsertCmd.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        InsertCmd.Parameters.AddWithValue("@LocationType", LocationType);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyHangers", DeliveredQtyHangers);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyBoxes", DeliveredQtyBoxes);
                        InsertCmd.Parameters.AddWithValue("@MovementQtyGarments", DeliveredQtyBoxes);
                        InsertCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        InsertCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        InsertCmd.Parameters.AddWithValue("@MovementValue", Value);
                        InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                        InsertCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                        InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)InsertCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
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
                        DeleteCmd.CommandText = "DELETE FROM tblStockMovements WHERE MovementType = @MovementType AND TransferReference = @TransferReference AND Reference = @Reference AND MovementDate = @MovementDate";
                        DeleteCmd.Parameters.AddWithValue("@MovementType", MovementType);
                        DeleteCmd.Parameters.AddWithValue("@TransferReference", TransferReference);
                        DeleteCmd.Parameters.AddWithValue("@Reference", Reference);
                        DeleteCmd.Parameters.AddWithValue("@MovementDate", MovementDate);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    DeleteFromDB = false;
                }
                else
                {
                    DeleteFromDB = true;
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
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
                if (Result != 1)
                {
                    DeleteFromDB = false;
                }
                else
                {
                    DeleteFromDB = true;
                }
            }
            catch (SqlException ex)
            {
                DeleteFromDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return DeleteFromDB;
        }
    }
}
