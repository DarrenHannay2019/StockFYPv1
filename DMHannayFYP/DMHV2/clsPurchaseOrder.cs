using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public class clsPurchaseOrder : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 00/02/2020

        public clsPurchaseOrder()
        {
            
        }
        ~clsPurchaseOrder()
        {
           
        }
        public void LoadNewPurchaseOrder()
        {

        }
        public void LoadSelectedPurchaseOrder()
        {

        }
    }
    public class clsPurchaseOrderLine : clsUtils
    {
        public decimal LineAmount;
        public int PurchaseOrderID;
        public clsPurchaseOrderLine()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public bool SaveToPurchaseOrderLinetbl()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblPurchaseOrderLines (PurchaseOrderID, StockCode, TotalItems, TotalBoxes, TotalLooseItems, LineAmount, LineVAT) VALUES (@PurchaseOrderID, @StockCode, @TotalItems, @TotalBoxes, @TotalLooseItems, @LineAmount, @LineVAT)";
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderId);
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCodeID);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalItems);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLooseItems", TotalLooseItems);
                        sqlCommand.Parameters.AddWithValue("@LineAmount", LineAmount);
                        sqlCommand.Parameters.AddWithValue("@LineVAT", LineVAT);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);

            }
            return SaveToDB;
        }
        public bool UpdateToPurchaseOrderLinetbl()
        {
            UpdateToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblPurchaseOrderLines SET TotalItems = @TotalItems,TotalBoxes = @TotalBoxes,TotalLooseItems = @TotalLooseItems,LineAmount = @LineAmount,LineVAT = @LineVAT WHERE PurchaseOrderID = @PurchaseOrderID AND StockCode = @StockCode";
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderId);
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCodeID);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalItems);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLooseItems", TotalLooseItems);
                        sqlCommand.Parameters.AddWithValue("@LineAmount", LineAmount);
                        sqlCommand.Parameters.AddWithValue("@LineVAT", LineVAT);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    UpdateToDB = false;
                }
                else
                {
                    UpdateToDB = true;
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);
            }
            return UpdateToDB;
        }
        public bool DeletePurchaseOrderLineRecord()
        {
            return DeleteFromDB;
        }
    }
    public class clsPurchaseOrderHead : clsUtils
    {
        public int TotalGarments;
        public int TotalHangers;
        public int TotalBoxes;
        public decimal NetAmount;
        public decimal DeliveryCharge;
        public decimal Commission;
        public decimal VATAmount;
        public decimal TotalAmount;
        public DateTime DeliveryDate;
        public string DeliveryType;
        public string Shipper;
        public string ShipperInvoice;
        public string SupplierInvoice;
        public string Notes;
        public clsPurchaseOrderHead()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public bool SaveToPurchaseOrderHeadtbl()
        {
            SaveToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO tblPurchaseOrders (OurRef, SupplierRef, LocationRef, TotalItems, TotalBoxes, TotalHangers, NetAmount, DeliveryCharge, Commission, VATAmount, TotalAmount, DeliveryDate, SeasonID, Notes, InvoiceNo, Shipper, ShipperInvoice, CreatedBy, CreatedDate) VALUES (@OurRef, @SupplierRef, @LocationRef, @TotalItems, @TotalBoxes, @TotalHangers, @NetAmount, @DeliveryCharge, @Commission, @VATAmount, @TotalAmount, @DeliveryDate, @SeasonID, @Notes, @InvoiceNo, @Shipper, @ShipperInvoice, @CreatedBy, @CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@OurRef", OurRef);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@LocationRef", LocationRef);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalItems);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLoose", TotalLoose);
                        sqlCommand.Parameters.AddWithValue("@NetAmount", NetAmount);
                        sqlCommand.Parameters.AddWithValue("@Commission", Commission);
                        sqlCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        sqlCommand.Parameters.AddWithValue("@VATAmount", VATAmount);
                        sqlCommand.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        sqlCommand.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                        sqlCommand.Parameters.AddWithValue("@SeasonID", SeasonID);
                        sqlCommand.Parameters.AddWithValue("@Notes", Notes);
                        sqlCommand.Parameters.AddWithValue("@Invoice", Invoice);
                        sqlCommand.Parameters.AddWithValue("@Shipper", Shipper);
                        sqlCommand.Parameters.AddWithValue("@ShipperInvoice", ShipperInvoice);
                        sqlCommand.Parameters.AddWithValue("@CreatedBy", UserID);
                        sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    SaveToDB = false;
                }
                else
                {
                    SaveToDB = true;
                }
            }
            catch (SqlException ex)
            {
                SaveToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);

            }
            return SaveToDB;
        }
        public bool UpdateToPurchaseOrderHeadtbl()
        {
            UpdateToDB = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblPurchaseOrders SET OurRef = @OurRef, SupplierRef = @SupplierRef, LocationRef = @LocationRef, TotalItems = @TotalItems, TotalBoxes = @TotalBoxes, TotalHangers = @TotalHangers, NetAmount = @NetAmount, DeliveryCharge = @DeliveryCharge, Commission = @Commission, VATAmount = @VATAmount, TotalAmount = @TotalAmount, DeliveryDate = @DeliveryDate, SeasonID = @SeasonID, Notes = @Notes, InvoiceNo = @InvoiceNo, Shipper = @Shipper, ShipperInvoice = @ShipperInvoice WHERE DeliveriesID = @DeliveriesID";
                        sqlCommand.Parameters.AddWithValue("@OurRef", OurRef);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@LocationRef", LocationRef);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalItems);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLoose", TotalLoose);
                        sqlCommand.Parameters.AddWithValue("@NetAmount", NetAmount);
                        sqlCommand.Parameters.AddWithValue("@Commission", Commission);
                        sqlCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        sqlCommand.Parameters.AddWithValue("@VATAmount", VATAmount);
                        sqlCommand.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        sqlCommand.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                        sqlCommand.Parameters.AddWithValue("@SeasonID", SeasonID);
                        sqlCommand.Parameters.AddWithValue("@Notes", Notes);
                        sqlCommand.Parameters.AddWithValue("@Invoice", Invoice);
                        sqlCommand.Parameters.AddWithValue("@Shipper", Shipper);
                        sqlCommand.Parameters.AddWithValue("@ShipperInvoice", ShipperInvoice);
                        sqlCommand.Parameters.AddWithValue("@DeliveriesID", DeliveriesID);
                        Result = (int)sqlCommand.ExecuteNonQuery();
                    }
                }
                if (Result != 1)
                {
                    UpdateToDB = false;
                }
                else
                {
                    UpdateToDB = true;
                }
            }
            catch (SqlException ex)
            {
                UpdateToDB = false;
                MessageBox.Show("Error in adding to database\n" + ex.Message);

            }
            return UpdateToDB;
        }
        public bool DeletePurchaseOrderHeadRecord()
        {
            return DeleteFromDB;
        }
        public int GetLastPurchaseOrderHead()
        {
            Result = 0;
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = GetConnString(1);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblPurchaseOrders";
                    Result = (int)sqlCommand.ExecuteNonQuery();
                }
            }
       
            return Result;
           
        }
    }
}
