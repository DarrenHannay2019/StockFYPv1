using System;
using System.Data.SqlClient;
using System.Data;

namespace DMHV2
{
    public class clsSettings : clsUtils
    {
        public clsSettings()
        {

        }
        ~clsSettings()
        {

        }
        public bool SaveSettings()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand InsertCmd = new SqlCommand())
                {
                    InsertCmd.Connection = conn;
                    InsertCmd.Connection.Open();
                    InsertCmd.CommandType = CommandType.Text;
                    InsertCmd.CommandText = "INSERT INTO tblCompanyDetails () VALUES ()";
                    InsertCmd.Parameters.AddWithValue("@ShopRef", ShopRef);
                    InsertCmd.Parameters.AddWithValue("@ShopName", ShopName);
                    InsertCmd.Parameters.AddWithValue("@Reference", "0");
                    InsertCmd.Parameters.AddWithValue("@TransactionDate", MovementDate);
                    InsertCmd.Parameters.AddWithValue("@TotalQty", Qty);
                    InsertCmd.Parameters.AddWithValue("@TotalValue", Value);
                    InsertCmd.Parameters.AddWithValue("@CreatedBy", UserID);
                    InsertCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    InsertCmd.ExecuteNonQuery();
                }
            }
            return SaveToDB;            
        }
        public bool UpdateSettings()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(1);
                using (SqlCommand UpdateCmd = new SqlCommand())
                {
                    UpdateCmd.Connection = conn;
                    UpdateCmd.Connection.Open();
                    UpdateCmd.CommandType = CommandType.Text;
                    UpdateCmd.CommandText = "UPDATE tblCompanyDetails SET @xx=Xx WHERE @XX=XX";
                    UpdateCmd.Parameters.AddWithValue("@ReturnID", ID);
                    UpdateCmd.Parameters.AddWithValue("@StockCode", StockCode);
                    UpdateCmd.Parameters.AddWithValue("@Qty", Qty);
                    UpdateCmd.Parameters.AddWithValue("@Value", Value);
                    UpdateCmd.ExecuteNonQuery();
                }
            }

            return UpdateToDB;
        }
        public string Backup()
        {
            string UniqueIdenity;
            string time;
            string day;
            string month;
            string year;
            time = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            day = DateTime.Now.Day.ToString();
            month = DateTime.Now.Month.ToString();
            year = DateTime.Now.Year.ToString();
            UniqueIdenity = year + month + day + time;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnString(3);
                using (SqlCommand BackupCmd = new SqlCommand())
                {
                    BackupCmd.Connection = conn;
                    BackupCmd.Connection.Open();
                    BackupCmd.CommandText = "Backup database " + Reference + " to disk = 'C:\\DBBackup\\'"+ Reference + "_"+UniqueIdenity +"'.bak'";
                    BackupCmd.ExecuteNonQuery();
                }
            }
            return "Backup Completed";
        }
        public void Restore()
        {

        }
    }
}
