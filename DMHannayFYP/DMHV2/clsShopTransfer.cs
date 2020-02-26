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
                    InsertCmd.Parameters.AddWithValue("@TransferDate", CDate(TransferDate));
                    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    InsertCmd.Parameters.AddWithValue("@ToShopRef", ToShopRef);
                    InsertCmd.Parameters.AddWithValue("@ToShopName", ToShopName);
                    InsertCmd.Parameters.AddWithValue("@TotalQtyOut", CInt(TotalQtyOut));
                    InsertCmd.Parameters.AddWithValue("@TotalQtyIn", CInt(TotalQtyIn));
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", username);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", Date.Now);
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
                    UpdateCmd.Parameters.AddWithValue("@TransferID", CInt(TransferID));
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                    UpdateCmd.Parameters.AddWithValue("@TransferDate", CDate(TransferDate));
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    UpdateCmd.Parameters.AddWithValue("@ToShopRef", ToShopRef);
                    UpdateCmd.Parameters.AddWithValue("@ToShopName", ToShopName);
                    UpdateCmd.Parameters.AddWithValue("@TotalQtyOut", CInt(TotalQtyOut));
                    UpdateCmd.Parameters.AddWithValue("@TotalQtyIn", CInt(TotalQtyIn));
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
                    InsertCmd.Parameters.AddWithValue("@TransferID", TransferID);
                    InsertCmd.Parameters.AddWithValue("@SMTOID", CInt(smtoid));
                    InsertCmd.Parameters.AddWithValue("@SMTIID", CInt(smtiid));
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@CurrentQty", CInt(CurrQty));
                    InsertCmd.Parameters.AddWithValue("@TOQty", CInt(TOQty));
                    InsertCmd.Parameters.AddWithValue("@TIQty", CInt(TIQty));
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
                    UpdateCmd.Parameters.AddWithValue("@TransferID", CInt(TransferID));
                    UpdateCmd.Parameters.AddWithValue("@SMTOID", CInt(smtoid));
                    UpdateCmd.Parameters.AddWithValue("@SMTIID", CInt(smtiid));
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@CurrentQty", CInt(CurrQty));
                    UpdateCmd.Parameters.AddWithValue("@TOQty", CInt(TOQty));
                    UpdateCmd.Parameters.AddWithValue("@TIQty", CInt(TIQty));
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
