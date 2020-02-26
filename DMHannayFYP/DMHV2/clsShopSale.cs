using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopSale : clsUtils
    {
    }
    public class clsShopSaleHead : clsShopSale
    {
        public bool SaveShopSaleHead()
        {
            Try
            Using conn As New SqlConnection(ut.GetConnString())
                Dim inscmd As New SqlCommand
                With inscmd
                    .Connection = conn
                    .Connection.Open()
                    .CommandType = CommandType.Text
                    .CommandText = "INSERT INTO tblSales (ShopRef,ShopName,SAReference,TransactionDate,TotalQty,TotalValue,CreatedBy,CreatedDate) VALUES (@ShopRef,@ShopName,@SAReference,@TransactionDate,@TotalQty,@TotalValue,@CreatedBy,@CreatedDate)"
                    With.Parameters
                        .AddWithValue("@ShopRef", shopref)
                        .AddWithValue("@ShopName", shopname)
                        .AddWithValue("@SAReference", "0")
                        .AddWithValue("@TransactionDate", TransactionDate)
                        .AddWithValue("@TotalQty", TotalQty)
                        .AddWithValue("@TotalValue", TotalValue)
                        .AddWithValue("@CreatedBy", username)
                        .AddWithValue("@CreatedDate", Date.Now)
                    End With
                    .ExecuteNonQuery()
                End With
            End Using
            Return True
        Catch ex As SqlException
            MsgBox("Record Creation Failed because of" & vbCrLf & ex.ErrorCode & "  " & ex.Message, MsgBoxStyle.Information, Application.ProductName)
        End Try
            return SaveToDB;
        }
        public bool UpdateShopSaleHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblSales SET ShopRef = @ShopRef,ShopName=@ShopName,SAReference = @SAReference,TransactionDate=@TransactionDate,TotalQty = @TotalQty,TotalValue=@TotalValue WHERE SalesID=@SalesID"
                With.Parameters
                    .AddWithValue("@SalesID", CInt(SalesID))
                    .AddWithValue("@ShopRef", shopref)
                    .AddWithValue("@ShopName", shopname)
                    .AddWithValue("@SAReference", SAReference)
                    .AddWithValue("@TransactionDate", CDate(TransactionDate))
                    .AddWithValue("@TotalQty", CInt(TotalQty))
                    .AddWithValue("@TotalValue", CDec(TotalValue))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopSaleHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopSaleLine : clsShopSale
    {
        public bool SaveShopSaleLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblSalesLines (SalesID,StockCode,CurrentQty,QtySold,SalesAmount,StockMovementID) VALUES (@SalesID,@StockCode,@CurrentQty,@QtySold,@SalesAmount,@StockMovementID)"
                With.Parameters
                    .AddWithValue("@SalesID", salesID)
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@CurrentQty", CurrentQty)
                    .AddWithValue("@QtySold", QtySold)
                    .AddWithValue("@SalesAmount", SalesAmount)
                    .AddWithValue("@StockMovementID", StockID)
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
            return SaveToDB;
        }
        public bool UpdateShopSaleLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblSalesLines SET CurrentQty = @CurrentQty, QtySold = @QtySold,SalesAmount = @SalesAmount,StockMovementID = @StockMovementID WHERE SalesID = @SalesID AND StockCode =@StockCode"
                With.Parameters
                    .AddWithValue("@SalesID", CInt(salesID))
                    .AddWithValue("@StockCode", stockcode)
                    .AddWithValue("@CurrentQty", CInt(CurrentQty))
                    .AddWithValue("@QtySold", CInt(QtySold))
                    .AddWithValue("@SalesAmount", CDec(SalesAmount))
                    .AddWithValue("@StockMovementID", CInt(StockID))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopSaleLine()
        {
            return DeleteFromDB;
        }
        public bool DeleteShopZeroSaleLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "DELETE from tblSalesLines WHERE SalesID = @SalesID AND QtySold = @QtySold AND SalesAmount = @SalesAmount;"
                With.Parameters
                    .AddWithValue("@SalesID", salesID)
                    .AddWithValue("@QtySold", "0")
                    .AddWithValue("@SalesAmount", "0.00")

                End With
                .ExecuteNonQuery()
            End With
        End Using
            return DeleteFromDB;
        }
    }
}
