using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopTransfer : clsUtils
    {
    }
    public class clsShopTransferHead : clsUtils
    {
        public bool SaveShopTransferHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblShopTransfers (Reference, TransferDate, ShopRef, ShopName, ToShopRef, ToShopName, TotalQtyOut, TotalQtyIn, CreatedBy, CreatedDate) VALUES (@Reference, @TransferDate, @ShopRef, @ShopName, @ToShopRef, @ToShopName, @TotalQtyOut, @TotalQtyIn, @CreatedBy, @CreatedDate)";
                    InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                    InsertCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    InsertCmd.Parameters.AddWithValue("@ToShopRef", ToShopRef);
                    InsertCmd.Parameters.AddWithValue("@ToShopName", ToShopName);
                    InsertCmd.Parameters.AddWithValue("@TotalQtyOut", Qty*-1);
                    InsertCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopTransferHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblShopTransfers SET Reference = @Reference, TransferDate = @TransferDate, ShopRef = @ShopRef, ShopName = @ShopName, ToShopRef = @ToShopRef, ToShopName = @ToShopName, TotalQtyOut = @TotalQtyOut, TotalQtyOut = @TotalQtyOut WHERE TransferID = @TransferID";
                    UpdateCmd.Parameters.AddWithValue("@TransferID", ID);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TransferDate", MovementDate);
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    UpdateCmd.Parameters.AddWithValue("@ToShopRef", ToShopRef);
                    UpdateCmd.Parameters.AddWithValue("@ToShopName", ToShopName);
                    UpdateCmd.Parameters.AddWithValue("@TotalQtyOut", Qty * -1);
                    UpdateCmd.Parameters.AddWithValue("@TotalQtyIn", Qty);
                    UpdateCmd.ExecuteNonQuery();
                }
            }          
            return UpdateToDB;
        }
        public bool DeleteShopTransferHead()
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
    public class clsShopTransferLine : clsUtils
    {
        public bool SaveShopTransferLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblShopTransferLines (TransferID, SMTOID, SMTIID, StockCode, CurrentQty, TOQty, TIQty) VALUES (@TransferID, @SMTOID, @SMTIID, @StockCode, @CurrentQty, @TOQty, @TIQty)";
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
        public bool UpdateShopTransferLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblShopTransferLines SET SMTOID = @SMTOID, SMTIID = @SMTIID, CurrentQty = @CurrentQty, TOQty = @TOQty, TIQty = @TIQty WHERE TransferID = @TransferID AND StockCode = @StockCode";
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
        public bool DeleteShopTransferLine()
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
