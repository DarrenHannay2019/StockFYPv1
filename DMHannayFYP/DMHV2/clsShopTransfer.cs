using System;
using System.Collections.Generic;
using System.Linq;
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
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopTransfers (Reference,TransferDate,ShopRef,ShopName,ToShopRef,ToShopName,TotalQtyOut,TotalQtyIn,CreatedBy,CreatedDate) VALUES (@Reference,@TransferDate,@ShopRef,@ShopName,@ToShopRef,@ToShopName,@TotalQtyOut,@TotalQtyIn,@CreatedBy,@CreatedDate)"
                With.Parameters
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TransferDate", CDate(TransferDate))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@ToShopRef", ToShopRef)
                    .AddWithValue("@ToShopName", ToShopName)
                    .AddWithValue("@TotalQtyOut", CInt(TotalQtyOut))
                    .AddWithValue("@TotalQtyIn", CInt(TotalQtyIn))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopTransferHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopTransfers SET Reference = @Reference,TransferDate = @TransferDate,ShopRef = @ShopRef,ShopName = @ShopName,ToShopRef = @ToShopRef,ToShopName = @ToShopName,TotalQtyOut = @TotalQtyOut,TotalQtyIn = @TotalQtyOut WHERE TransferID = @TransferID"
                With.Parameters
                    .AddWithValue("@TransferID", CInt(TransferID))
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TransferDate", CDate(TransferDate))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@ToShopRef", ToShopRef)
                    .AddWithValue("@ToShopName", ToShopName)
                    .AddWithValue("@TotalQtyOut", CInt(TotalQtyOut))
                    .AddWithValue("@TotalQtyIn", CInt(TotalQtyIn))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopTransferHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopTransferLine : clsUtils
    {
        public bool SaveShopTransferLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopTransferLines (TransferID,SMTOID,SMTIID,StockCode,CurrentQty,TOQty,TIQty) VALUES (@TransferID,@SMTOID,@SMTIID,@StockCode,@CurrentQty,@TOQty,@TIQty)"
                With.Parameters
                    .AddWithValue("@TransferID", TransferID)
                    .AddWithValue("@SMTOID", CInt(smtoid))
                    .AddWithValue("@SMTIID", CInt(smtiid))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@CurrentQty", CInt(CurrQty))
                    .AddWithValue("@TOQty", CInt(TOQty))
                    .AddWithValue("@TIQty", CInt(TIQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopTransferLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopTransferLines SET SMTOID = @SMTOID,SMTIID=@SMTIID,CurrentQty = @CurrentQty,TOQty=@TOQty,TIQty=@TIQty WHERE TransferID=@TransferID AND StockCode = @StockCode"
                With.Parameters
                    .AddWithValue("@TransferID", CInt(TransferID))
                    .AddWithValue("@SMTOID", CInt(smtoid))
                    .AddWithValue("@SMTIID", CInt(smtiid))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@CurrentQty", CInt(CurrQty))
                    .AddWithValue("@TOQty", CInt(TOQty))
                    .AddWithValue("@TIQty", CInt(TIQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopTransferLine()
        {
            return DeleteFromDB;
        }
    }
}
