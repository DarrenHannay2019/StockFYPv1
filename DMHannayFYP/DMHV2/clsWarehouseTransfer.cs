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

    public class clsWarehouseTransfer : clsUtils
    {
        public string ToWarehouseRef { get; set; }
        public string ToWarehouseName { get; set; }
    }
    public class clsWarehouseTransferHead : clsWarehouseTransfer
    {
        public bool SaveWarehouseTransferHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblWhTransfers (Reference, TransferDate, WharehouseRef, WarehouseName, ToWarehouseRef, ToWarehouseName, TotalQtyOut, TotalQtyIn, CreatedBy, CreatedDate) VALUES (@Reference, @TransferDate, @WarehouseRef, @WarehouseName, @ToWarehouseRef, @ToWarehouseName, @TotalQtyOut, @TotalQtyIn, @CreatedBy, @CreatedDate)";
                    InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                    InsertCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    InsertCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                    InsertCmd.Parameters.AddWithValue("@ToWarehouseRef", ToWarehouseRef);
                    InsertCmd.Parameters.AddWithValue("@ToWarehouseName", ToWarehouseName);
                    InsertCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                    InsertCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblWHTransfers SET Reference = @Reference, TransferDate = @TransferDate, WarehouseRef = @WarehouseRef, WarehouseName = @WarehouseName, ToWarehouseRef = @ToWarehouseRef, ToWarehouseName = @ToShopName, TotalQtyOut = @TotalQtyOut, TotalQtyOut = @TotalQtyOut WHERE TransferID = @TransferID";
                    UpdateCmd.Parameters.AddWithValue("@TransferID", ID);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                    UpdateCmd.Parameters.AddWithValue("@ToWarehouseRef", ToWarehouseRef);
                    UpdateCmd.Parameters.AddWithValue("@ToWarehouseName", ToWarehouseName);
                    UpdateCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                    UpdateCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferHead()
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
    public class clsWarehouseTransferLine : clsWarehouseTransfer
    {
        public bool SaveWarehouseTransferLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblWHTransferLines (TransferID, SMTOID, SMTIID, StockCode, CurrentQty, TOQty, TIQty) VALUES (@TransferID, @SMTOID, @SMTIID, @StockCode, @CurrentQty, @TOQty, @TIQty)";
                    InsertCmd.Parameters.AddWithValue("@TransferID", ID);
                    InsertCmd.Parameters.AddWithValue("@SMTOID", smtoid);
                    InsertCmd.Parameters.AddWithValue("@SMTIID", smtiid);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@CurrentQty", CurrQty);
                    InsertCmd.Parameters.AddWithValue("@TOQty", TOQty);
                    InsertCmd.Parameters.AddWithValue("@TIQty", TIQty);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblWHTransferLines SET SMTOID = @SMTOID, SMTIID = @SMTIID, CurrentQty = @CurrentQty, TOQty = @TOQty, TIQty = @TIQty WHERE TransferID = @TransferID AND StockCode = @StockCode";
                    UpdateCmd.Parameters.AddWithValue("@TransferID", ID);
                    UpdateCmd.Parameters.AddWithValue("@SMTOID", smtoid);
                    UpdateCmd.Parameters.AddWithValue("@SMTIID", smtiid);
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@CurrentQty", CurrQty);
                    UpdateCmd.Parameters.AddWithValue("@TOQty", TOQty);
                    UpdateCmd.Parameters.AddWithValue("@TIQty", TIQty);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferLine()
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
