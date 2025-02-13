﻿namespace DMHV2
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
        public int UserID { get; set; }       
        public string StockCode;
        public string SupplierRef;
        public string SeasonName;
        public int DeliveredQtyHangers;
        public int DeliveredQtyBoxes;
        public int DeliveredQtyGarments;      
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
        ~clsStock()
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
            objStock.TxtStockCode.Text = StockCode;
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
                        sqlCommand.CommandText = "INSERT INTO tblStock (StockCode, SupplierRef, SeasonName, DeadCode, AmountTaken, DeliveredQtyGarments, DeliveredQtyBoxes, DeliveredQtyHangers, CostValue, PCMarkUp, ZeroQty, CreatedBy, CreatedDate) VALUES (@StockCode, @SupplierRef, @SeasonName, @DeadCode, @AmountTaken, @DeliveredQtyGarments, @DeliveredQtyBoxes, @DeliveredQtyHangers, @CostValue, @PCMarkUp, @ZeroQty, @CreatedBy, @CreatedDate)";
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@DeadCode", DeadCode);
                        sqlCommand.Parameters.AddWithValue("@AmountTaken", AmountTaken);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
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
                        sqlCommand.CommandText = "UPDATE tblStock SET SupplierRef = @SupplierRef, DeadCode = @DeadCode, AmountTaken = @AmountTaken, DeliveredQtyHangers = @DeliveredQtyHangers, DeliveredQtyBoxes = @DeliveredQtyBoxes,  DeliveredQtyGarments = @DeliveredQtyGarments, CostValue = @CostValue, PCMarkUp = @PCMarkUp, ZeroQty = @ZeroQty, SeasonName = @SeasonName WHERE StockCode = @StockCode";
                        sqlCommand.Parameters.AddWithValue("@StockCode", StockCode);
                        sqlCommand.Parameters.AddWithValue("@SupplierRef", SupplierRef);
                        sqlCommand.Parameters.AddWithValue("@SeasonName", SeasonName);
                        sqlCommand.Parameters.AddWithValue("@DeadCode", DeadCode);
                        sqlCommand.Parameters.AddWithValue("@AmountTaken", AmountTaken);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyGarments", DeliveredQtyGarments);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyBoxes", DeliveredQtyBoxes);
                        sqlCommand.Parameters.AddWithValue("@DeliveredQtyHangers", DeliveredQtyHangers);
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
                            UpdateCmd.CommandText = "UPDATE tblStock SET AmountTaken = SUM(tblSalesLine.LineAmount) As AmountTaken FROM tblStock,tblSalesLine WHERE (tblStock.StockCode = tblSalesLine.StockCode)";
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
                            UpdateCmd.CommandText = "UPDATE tblStock SET CostValue = qryPurchaseLineSum.LineAmount FROM tblStock,QryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
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
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyHangers = qryPurchaseLineSum.QtyHangers FROM tblStock,qryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
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
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyBoxes = qryPurchaseLineSum.QtyBoxes FROM tblStock,qryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
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
                            UpdateCmd.CommandText = "UPDATE tblStock SET DeliveredQtyGarments = qryPurchaseLineSum.QtyGarments FROM tblStock,qryPurchaseLineSum WHERE (tblStock.StockCode = qryPurchaseLineSum.StockCode)";
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
        public int CheckStockCodeSave()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT COUNT(*) AS Records FROM tblStock WHERE StockCode = @StockCode";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
        public bool UpdatePCMarkup()
        {
            // Due to restrictions unable to complete this section of code.
            return UpdateToDB;
        }
        public int GetWarehouseStockQty()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT QtyHangers FROM qryWarehouseStock WHERE StockCode = @StockCode AND LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        SelectCmd.Parameters.AddWithValue("@LocationRef", SupplierRef);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
        public int GetShopStockQty()
        {
            Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = GetConnString(1);
                    conn.Open();
                    using (SqlCommand SelectCmd = new SqlCommand())
                    {
                        SelectCmd.Connection = conn;
                        SelectCmd.CommandText = "SELECT QtyHangers FROM qryShopStock WHERE StockCode = @StockCode AND LocationRef = @LocationRef";
                        SelectCmd.CommandType = CommandType.Text;
                        SelectCmd.Parameters.AddWithValue("@StockCode", StockCode);
                        SelectCmd.Parameters.AddWithValue("@LocationRef", SupplierRef);
                        Result = (int)SelectCmd.ExecuteScalar();
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Result;
        }
    }
}
