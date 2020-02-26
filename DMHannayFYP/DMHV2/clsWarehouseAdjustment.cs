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

    public class clsWarehouseAdjustment : clsUtils
    {

    }
    public class clsWarehouseAdjustmentHead : clsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWarehouseAdjustments(WarehouseRef,Reference,TotalLossItems,TotalGainItems,MovementDate,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@Reference,@TotalLossItems,@TotalGainItems,@MovementDate,@CreatedBy,@CreatedDate)"
                With.Parameters
                    .AddWithValue("@WarehouseRef", WarehouseRef)
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
        public bool UpdateWarehouseAdjustmentHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWarehouseAdjustments SET WarehouseRef = @WarehouseRef,Reference = @Reference,TotalLossItems = @TotalLossItems,TotalGainItems = @TotalGainItems, MovementDate = @MovementDate WHERE ID = @ID"
                With.Parameters
                    .AddWithValue("@ID", ID)
                    .AddWithValue("@WarehouseRef", ShopRef)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalLossItems", TotalLossItems)
                    .AddWithValue("@TotalGainItems", TotalGainItems)
                    .AddWithValue("@MovementDate", CDate(MovementDate))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsWarehouseAdjustmentLine : clsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblWarehouseAdjustmentsLines(WarehouseAdjustID,StockCode,MovementType,Qty,Value) VALUES (@WarehouseAdjustID,@StockCode,@MovementType,@Qty,@Value)"
                With.Parameters
                    .AddWithValue("@WarehouseAdjustID", CInt(WarehouseAdjustID))
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
        public bool UpdateWarehouseAdjustmentLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblWarehouseAdjustmentsLines SET MovementType = @MovementType,Qty = @Qty,Value = @Value WHERE WarehouseAdjustID = @WarehouseAdjustID AND StockCode = @StockCode"
                With.Parameters
                    .AddWithValue("@StockCode", StockCode)
                    .AddWithValue("@MovementType", MovementType)
                    .AddWithValue("@Qty", CInt(Qty))
                    .AddWithValue("@Value", CDec(Value))
                    .AddWithValue("@WarehouseAdjustID", CInt(ID))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentLine()
        {
            return DeleteFromDB;
        }
    }
}
