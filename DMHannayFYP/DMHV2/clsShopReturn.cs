using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopReturn : clsUtils
    {
    }
    public class clsShopReturnHead : clsShopReturn
    {
        public bool SaveShopReturnHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblReturns(ShopRef,WarehouseRef,Reference,TotalItems,TransactionDate,CreatedBy,CreatedDate) VALUES (@ShopRef,@WarehouseRef,@Reference,@TotalItems,@TransactionDate,@CreatedBy,@CreatedDate)"
                With.Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopReturnHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblReturns SET ShopRef=@ShopRef,WarehouseRef=@WarehouseRef,Reference=@Reference,TotalItems = @TotalItems,TransactionDate=@TransactionDate WHERE ReturnsID =@ReturnsID"
                With.Parameters
                    .AddWithValue("@ReturnsID", CInt(ReturnID))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopReturnHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopReturnLine : clsShopReturn
    {
        public bool SaveShopReturnLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblReturnLines (ReturnID,StockCode,Qty,Value) VALUES (@ReturnID,@StockCode,@Qty,@Value)"
                With.Parameters
                    .AddWithValue("@ReturnID", ReturnID)
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@Qty", Qty)
                    .AddWithValue("@Value", Value)
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopReturnLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblReturnLines SET Qty = @Qty,Value=@Value WHERE ReturnID = @ReturnID AND StockCode = @StockCode"
                With.Parameters
                    .AddWithValue("@ReturnID", CInt(ReturnID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CInt(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopReturnLine()
        {
            return DeleteFromDB;
        }
    }
}
