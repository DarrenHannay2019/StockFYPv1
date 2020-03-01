using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using(SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblShopDeliveries(ShopRef, ShopName, WarehouseRef, WarehouseName, Reference, TotalItems, DeliveryDate, DeliveryType, ConfirmedDate, Notes, CreatedBy, CreatedDate) VALUES (@ShopRef, @ShopName, @WarehouseRef, @WarehouseName, @Reference, @TotalItems, @DeliveryDate, @DeliveryType, @ConfirmedDate, @Notes, @CreatedBy, @CreatedDate)";
                    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    InsertCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    InsertCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                    InsertCmd.Parameters.AddWithValue("@Reference", Reference);
                    InsertCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                    InsertCmd.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@DeliveryType", "Confirmed");
                    InsertCmd.Parameters.AddWithValue("@ConfirmedDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@Notes", "");
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopDeliveryHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblShopDeliveries SET ShopRef = @ShopRef, ShopName = @ShopName, WarehouseRef = @WarehouseRef, WarehouseName = @WarehouseName, Reference = @Reference, TotalItems = @TotalItems, DeliveryDate = @DeliveryDate, DeliveryType = @DeliveryType, ConfirmedDate = @ConfirmedDate, Notes = @Notes WHERE DeliveriesID = @DeliveriesID";
                    UpdateCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                    UpdateCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    UpdateCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseRef", WarehouseRef);
                    UpdateCmd.Parameters.AddWithValue("@WarehouseName", WarehouseName);
                    UpdateCmd.Parameters.AddWithValue("@Reference", Reference);
                   UpdateCmd.Parameters.AddWithValue("@TotalItems", TotalItems);
                    UpdateCmd.Parameters.AddWithValue("@DeliveryDate", MovementDate);
                    UpdateCmd.Parameters.AddWithValue("@DeliveryType", "Confirmed");
                    UpdateCmd.Parameters.AddWithValue("@ConfirmedDate", MovementDate);
                    UpdateCmd.Parameters.AddWithValue("@Notes", "");
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryHead()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE from tblShopDeliveries where DeliveriesID = @DeliveriesID;";
                    DeleteCmd.Parameters.AddWithValue("@DeliveriesID", ID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
    public class clsShopDeliveryLine : clsShopDelivery
    {
        public bool SaveShopDeliveryLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblShopDeliveriesLines (DeliveriesID, StockCode, DeliveredQty) VALUES (@DeliveriesID, @StockCode, @DeliveredQty)";
                    InsertCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                    InsertCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    InsertCmd.Parameters.AddWithValue("@DeliveredQty", Qty);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;
        }
        public bool UpdateShopDeliveryLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblShopDeliveriesLines SET DeliveredQty = @DeliveredQty WHERE DeliveriesID = @DeliveriesID AND StockCode = StockCode";

                    UpdateCmd.Parameters.AddWithValue("@DeliveriesID", ShopDelID);
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@DeliveredQty", Qty);
                    UpdateCmd.ExecuteNonQuery();
                }
            }
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryLine()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.Connection.Open();
                    DeleteCmd.CommandType = CommandType.Text;
                    DeleteCmd.CommandText = "DELETE from tblShopDeliveriesLines WHERE DeliveriesID = @DeliveriesID;";
                    DeleteCmd.Parameters.AddWithValue("@DeliveriesID", ID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
}
