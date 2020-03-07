namespace DMHV2
{
    using System;
    using System.Data.SqlClient;
    using System.Data;
    using System.Windows.Forms;

    public class clsStock : clsUtils
    {
        // Properties / fields for the class
        // started 09/02/2020
        // completed 00/03/2020
        public bool DeadCode;
        public bool ZeroQty;      
        public decimal AmountTaken;
        public decimal CostValue;
        public decimal PCMarkUp;
        public clsStock()
        {
            SaveToDB = false;
            DeleteFromDB = false;
            UpdateToDB = false;
        }
        public void LoadNewForm()
        {
            frmStock objStock = new frmStock();
            objStock.FormMode = "New";
            objStock.ShowDialog();
        }
        public void LoadSelectedForm()
        {
            frmStock objStock = new frmStock();
            objStock.FormMode = "Old";
            objStock.ShowDialog();
        }
        public bool SaveStockCode()
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
                        sqlCommand.CommandText = "INSERT INTO tblStock (StockCode, SupplierRef, Season, DeadCode, AmountTaken, DeliveredQtyItems, DeliveredQtyBoxes, DeliveredQtyLoose, CostValue, PCMarkUp, ZeroQty, CreatedBy, CreatedDate) VALUES (@StockCode, @SupplierRef, @Season, @DeadCode, @AmountTaken, @DeliveredQtyItems, @DeliveredQtyBoxes, @DeliveredQtyLoose, @CostValue, @PCMarkUp, @ZeroQty, @CreatedBy, @CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@Season", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@DeadCode", DeadCode);
                        sqlCommand.Parameters.AddWithValue("@AmountTaken", AmountTaken);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyItem", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyLoose", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@CostValue", CostValue);
                        sqlCommand.Parameters.AddWithValue("@PCMarkUp", PCMarkUp);
                        sqlCommand.Parameters.AddWithValue("@ZeroQty", ZeroQty);
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
        public bool UpdateStockCode()
        {
            UpdateToDB = true;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = GetConnString(1);
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE tblStock SET SupplierRef=@SupplierRef,DeadCode=@DeadCode,AmountTaken=@AmountTaken,DeliveredQtyHangers=@DeliveredQtyHangers,CostValue=@CostValue,PCMarkUp=@PCMarkUp,ZeroQty=@ZeroQty,Season =@Season WHERE StockCode = @StockCode";
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@Season", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@DeadCode", DeadCode);
                        sqlCommand.Parameters.AddWithValue("@AmountTaken", AmountTaken);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyItem", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyLoose", DeliveredQtyHangers);
                        sqlCommand.Parameters.AddWithValue("@CostValue", CostValue);
                        sqlCommand.Parameters.AddWithValue("@PCMarkUp", PCMarkUp);
                        sqlCommand.Parameters.AddWithValue("@ZeroQty", ZeroQty);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return UpdateToDB;
        }
        public bool DeleteStockCode()
        {
            DeleteFromDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand DeleteCmd = new SqlCommand())
                    {
                        DeleteCmd.Connection = conn;
                        DeleteCmd.CommandType = CommandType.Text;
                        DeleteCmd.CommandText = "DELETE FROM tblStock where StockCode = @StockCode";
                        DeleteCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        Result = (int)DeleteCmd.ExecuteNonQuery();
                    }
                }
                if (Result == 1)
                {
                    DeleteFromDB = true;
                }
                else
                {
                    DeleteFromDB = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return DeleteFromDB;
        }
        public bool UpdateAmountTaken()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET AmountTaken = SELECT SUM(tblSalesLine.LineAmount) FROM tblStock,tblSalesLine WHERE (tblStock.StockCode = tblSalesLine.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }

            return UpdateToDB;
        }
        public bool UpdateCostValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET CostValue = SELECT SUM(tblPurchaseOrderLine.LineAmount) FROM tblStock,tblPurchaseOrderLine WHERE (tblStock.StockCode = tblPurchaseOrderLine.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            return UpdateToDB;
        }
        public bool UpdateDeliveredQtyHangersValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyHangers = SELECT SUM(tblPurchaseOrderLine.DeliveredQtyHangers) FROM tblStock,tblPurchaseOrderLine WHERE (tblStock.StockCode = tblPurchaseOrderLine.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            return UpdateToDB;
        }
        public bool UpdateDeliveredQtyBoxesValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyBoxes = SELECT SUM(tblPurchaseOrderLine.DeliveredQtyBoxes) FROM tblStock,tblPurchaseOrderLine WHERE (tblStock.StockCode = tblPurchaseOrderLine.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            return UpdateToDB;
        }
        public bool UpdateDeliveredQtyGarmentsValue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    try
                    {
                        conn.Open();
                        using (SqlCommand UpdateCmd = new SqlCommand())
                        {
                            UpdateCmd.Connection = conn;
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyGarments = SELECT SUM(tblPurchaseOrderLine.DeliveredQtyGarments) FROM tblStock,tblPurchaseOrderLine WHERE (tblStock.StockCode = tblPurchaseOrderLine.StockCode)";
                            UpdateCmd.CommandType = CommandType.Text;
                            Result = (int)UpdateCmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            return UpdateToDB;
        }
        public bool CheckStockCodeSave()
        {
            return UpdateToDB;
        }
        public bool UpdatePCMarkup()
        {
            return UpdateToDB;
        }
        public int GetStockQty()
        {
            return 0;
        }
    }
}
