using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopAdjustment : clsUtils
    {
    }
    public class clsShopAdjustmentHead : clsUtils
    {
        public bool SaveShopAdjustHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopAdjustments(ShopRef,Reference,TotalLossItems,TotalGainItems,MovementDate,CreatedBy,CreatedDate) VALUES (@ShopRef,@Reference,@TotalLossItems,@TotalGainItems,@MovementDate,@CreatedBy,@CreatedDate)"
                With.Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", CInt(TotalLossItems))
                    .AddWithValue("@TotalGainItems", CInt(TotalGainItems))
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopAdjustHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopAdjustments SET ShopRef = @ShopRef,Reference = @Reference,TotalLossItems = @TotalLossItems,TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID"
                With.Parameters
                    .AddWithValue("@ID", CInt(ID))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", CInt(TotalLossItems))
                    .AddWithValue("@TotalGainItems", CInt(TotalGainItems))
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
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
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopAdjustmentsLines(ShopAdjustID,StockCode,MovementType,Qty,Value) VALUES (@ShopAdjustID,@StockCode,@MovementType,@Qty,@Value)"
                With.Parameters
                    .AddWithValue("@ShopAdjustID", CInt(ShopAdjustID))
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(qty))
                    .AddWithValue("@Value", CDec(Value))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopAdjustLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopAdjustmentsLines SET MovementType = @MovementType,Qty = @Qty,Value = @Value WHERE ShopAdjustID = @ShopAdjustID AND StockCode = @StockCode"
                With.Parameters
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CDec(Value))
                    .AddWithValue("@ShopAdjustID", CInt(ID))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopAdjustLine()
        {
            return DeleteFromDB;
        }
    }
}
