using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopDelivery : clsUtils
    {
        public void LoadNewForm()
        {

        }
        public void LoadSelectedForm()
        {

        }
    }
    public class clsShopDeliveryHead : clsShopDelivery
    {
        public bool SaveShopDeliveryHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopDeliveries(ShopRef,ShopName,WarehouseRef,WarehouseName,Reference,TotalItems,DeliveryDate,DeliveryType,ConfirmedDate,Notes,CreatedBy,CreatedDate) VALUES (@ShopRef,@ShopName,@WarehouseRef,@WarehouseName,@Reference,@TotalItems,@DeliveryDate,@DeliveryType,@ConfirmedDate,@Notes,@CreatedBy,@CreatedDate)"
                With.Parameters
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@WarehouseName", WarehousesName)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@DeliveryDate", CDate(DeliveryDate))
                    .AddWithValue("@DeliveryType", "Confirmed")
                    .AddWithValue("@ConfirmedDate", CDate(DeliveryDate))
                    .AddWithValue("@Notes", "")
                    .AddWithValue("@CreatedBy", username)
                    .AddWithValue("@CreatedDate", Date.Now)
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopDeliveryHead()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopDeliveries SET ShopRef = @ShopRef,ShopName = @ShopName,WarehouseRef = @WarehouseRef,WarehouseName = @WarehouseName,Reference = @Reference,TotalItems = @TotalItems,DeliveryDate = @DeliveryDate,DeliveryType = @DeliveryType,ConfirmedDate = @ConfirmedDate,Notes = @Notes WHERE DeliveriesID = @DeliveriesID"
                With.Parameters
                    .AddWithValue("@DeliveriesID", CInt(DeliveriesID))
                    .AddWithValue("@ShopRef", ShopRef)
                    .AddWithValue("@ShopName", ShopName)
                    .AddWithValue("@WarehouseRef", WarehouseRef)
                    .AddWithValue("@WarehouseName", WarehousesName)
                    .AddWithValue("@Reference", Reference)
                    .AddWithValue("@TotalItems", CInt(TotalItems))
                    .AddWithValue("@DeliveryDate", CDate(DeliveryDate))
                    .AddWithValue("@DeliveryType", "Confirmed")
                    .AddWithValue("@ConfirmedDate", CDate(DeliveryDate))
                    .AddWithValue("@Notes", "")
                End With
                .ExecuteNonQuery()
            End With
        End Using
        Return True
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopDeliveryLine : clsShopDelivery
    {
        public bool SaveShopDeliveryLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim inscmd As New SqlCommand
            With inscmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblShopDeliveriesLines (SDeliveriesID,SStockCode,DeliveredQty) VALUES (@SDeliveriesID,@SStockCode,@DeliveredQty)"
                With.Parameters
                    .AddWithValue("@SDeliveriesID", CInt(SDeliveriesID))
                    .AddWithValue("@SStockCode", SStockCode)
                    .AddWithValue("@DeliveredQty", CInt(DeliveredQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return SaveToDB;
        }
        public bool UpdateShopDeliveryLine()
        {
            Using conn As New SqlConnection(ut.GetConnString())
            Dim updCmd As New SqlCommand()
            With updCmd
                .Connection = conn
                .Connection.Open()
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tblShopDeliveriesLines SET DeliveredQty = @DeliveredQty WHERE SDeliveriesID = @SDeliveriesID AND SStockCode = SStockCode"
                With.Parameters
                    .AddWithValue("@SDeliveriesID", CInt(SDeliveriesID))
                    .AddWithValue("@SStockCode", SStockCode)
                    .AddWithValue("@DeliveredQty", CInt(DeliveredQty))
                End With
                .ExecuteNonQuery()
            End With
        End Using
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryLine()
        {
            return DeleteFromDB;
        }
    }
}
