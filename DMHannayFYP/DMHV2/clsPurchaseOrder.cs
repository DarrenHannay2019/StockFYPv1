namespace DMHV2
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsPurchaseOrder : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 00/02/2020
        public int PurchaseOrderID { get; set; }
        public clsPurchaseOrder()
        {
            
        }
        ~clsPurchaseOrder()
        {
           
        }
        public void LoadNewPurchaseOrder()
        {
            frmPurchaseOrder oPurchaseOrder = new frmPurchaseOrder();
            oPurchaseOrder.Show();
        }
        public void LoadSelectedPurchaseOrder()
        {
            frmPurchaseOrder oPurchaseOrder = new frmPurchaseOrder();
            oPurchaseOrder.TxtOrderID.Text = PurchaseOrderID.ToString();
            oPurchaseOrder.Show();
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
        ~clsPurchaseOrderLine()
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
                        sqlCommand.CommandText = "INSERT INTO tblPurchaseOrderLines (PurchaseOrderID, StockCode, DeliveredQtyGarments, DeliveredQtyBoxes, DeliveredQtyHangers,  LineAmount) VALUES (@PurchaseOrderID, @StockCode, @DeliveredQtyGarments, @DeliveredQtyBoxes, @DeliveredQtyHangers,, @LineAmount)";
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@LineAmount", LineAmount);                    
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
                        sqlCommand.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@LineAmount", LineAmount);
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
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.CommandText = "DELETE FROM tblPurchaseOrders where PurchaseOrderID = @PurchaseOrderID";
                    DeleteCmd.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
    }
    public class clsPurchaseOrderHead : clsUtils
    {
        public int TotalGarments;
        public int TotalHangers;
        public int TotalBoxes;
        public int PurchaseOrderID;
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
        private int UserIDs;
        public clsPurchaseOrderHead(int UserID)
        {
            UserIDs = UserID;
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~clsPurchaseOrderHead()
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
                        sqlCommand.Parameters.AddWithValue("@OurRef", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalGarments);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLoose", TotalHangers);
                        sqlCommand.Parameters.AddWithValue("@NetAmount", NetAmount);
                        sqlCommand.Parameters.AddWithValue("@Commission", Commission);
                        sqlCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        sqlCommand.Parameters.AddWithValue("@VATAmount", VATAmount);
                        sqlCommand.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        sqlCommand.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@Notes", Notes);
                        sqlCommand.Parameters.AddWithValue("@Invoice", SupplierInvoice);
                        sqlCommand.Parameters.AddWithValue("@Shipper", Shipper);
                        sqlCommand.Parameters.AddWithValue("@ShipperInvoice", ShipperInvoice);
                        sqlCommand.Parameters.AddWithValue("@CreatedBy", UserIDs);
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
                        sqlCommand.Parameters.AddWithValue("@OurRef", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@LocationRef", WarehouseRef);
                        sqlCommand.Parameters.AddWithValue("@TotalItems", TotalGarments);
                        sqlCommand.Parameters.AddWithValue("@TotalBoxes", TotalBoxes);
                        sqlCommand.Parameters.AddWithValue("@TotalLoose", TotalHangers);
                        sqlCommand.Parameters.AddWithValue("@NetAmount", NetAmount);
                        sqlCommand.Parameters.AddWithValue("@Commission", Commission);
                        sqlCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        sqlCommand.Parameters.AddWithValue("@VATAmount", VATAmount);
                        sqlCommand.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        sqlCommand.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@Notes", Notes);
                        sqlCommand.Parameters.AddWithValue("@Invoice", SupplierInvoice);
                        sqlCommand.Parameters.AddWithValue("@Shipper", Shipper);
                        sqlCommand.Parameters.AddWithValue("@ShipperInvoice", ShipperInvoice);
                        sqlCommand.Parameters.AddWithValue("@DeliveriesID", PurchaseOrderID);
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
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand DeleteCmd = new SqlCommand())
                {
                    DeleteCmd.Connection = conn;
                    DeleteCmd.CommandText = "DELETE FROM tblPurchaseOrders where PurchaseOrderID = @PurchaseOrderID";
                    DeleteCmd.Parameters.AddWithValue("@PurchaseOrderID", PurchaseOrderID);
                    DeleteCmd.ExecuteNonQuery();
                }
            }
            return DeleteFromDB;
        }
        public int GetLastPurchaseOrderHead()
        {
            Result = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                conn.Open();
                using (SqlCommand SelectCmd = new SqlCommand())
                {
                    SelectCmd.Connection = conn;
                    SelectCmd.CommandText = "SELECT COUNT(*) AS MaxRef FROM tblPurchaseOrders";
                    Result = (int)SelectCmd.ExecuteNonQuery();
                }
            }       
            return Result;           
        }
    }
}
