using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class frmSettings : Form
    {
        SqlDataReader reader;   // to read all data into the application
        public string FormMode { get; set; }

        public frmSettings()
        {
            InitializeComponent();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();       // Close the application's Settings form.
        }

        private void CmdBackup_Click(object sender, EventArgs e)
        {

        }

        private void CmdRestore_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadData()
        {

        }
        private void LoadCombos()
        {
            ComboBox1.Items.Clear();
            ComboBox2.Items.Clear();
            ComboBox3.Items.Clear();
            // load all database from the Server
            using (SqlConnection conn = new SqlConnection())
            {
                // attach the loading function to the connection string of the server
                conn.ConnectionString = clsUtils.GetConnString(3);
                using (SqlCommand DBNameCmd = new SqlCommand())
                {
                    DBNameCmd.CommandText = "Select name from sys.databases";
                    DBNameCmd.Connection = conn;
                    DBNameCmd.Connection.Open();
                    reader = DBNameCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ComboBox1.Items.Add(reader[0]);
                        ComboBox2.Items.Add(reader[0]);
                    }
                    string[] files = Directory.GetFiles(@"C:\\DBBackup");
                    if (Directory.Exists(@"C:\\DBBackup"))
                    {
                        foreach (string file in files)
                        {
                            ComboBox3.Items.Add(file);
                        }
                    }
                }

            }
        }
    }
}
