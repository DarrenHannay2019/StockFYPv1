using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

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
        public bool UpdateSettings()
        {
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
