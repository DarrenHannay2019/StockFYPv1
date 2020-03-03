using System;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
            clsSettings settings = new clsSettings();
            settings.ContactName = txtCompanyName.Text.TrimEnd();
            settings.AddressLine1 = txtAdd1.Text.TrimEnd();
            settings.AddressLine2 = txtAdd2.Text.TrimEnd();
            settings.AddressLine3 = txtAdd3.Text.TrimEnd();
            settings.AddressLine4 = txtAdd4.Text.TrimEnd();
            settings.PostCode = txtPostCode.Text.TrimEnd();
            settings.Telephone = txtTelephone.Text.TrimEnd();
            settings.Fax = txtFax.Text.TrimEnd();
            settings.Memo = txtVATReg.Text.TrimEnd();
            settings.eMail = txtEmail.Text.TrimEnd();
            settings.WebsiteAddress = txtWWW.Text.TrimEnd();
            settings.Value = Convert.ToDecimal(txtVATRate.Text.TrimEnd());
            if (FormMode == "New")
            {
                settings.SaveToDB = settings.SaveSettings();
                if (settings.SaveToDB == false)
                    MessageBox.Show("Unable to Save to Database", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    this.Close();
            }
            else
            {
                settings.UpdateToDB = settings.UpdateSettings();
                if(settings.UpdateToDB == false)
                    MessageBox.Show("Unable to Update in Database", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    this.Close();
            }
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
           if(FormMode == "New")
            {
                CmdOK.Text = "Save";
            }
           else
            {
                LoadData();
                CmdOK.Text = "OK";
            }
            LoadCombos();
        }
        private void LoadData()
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = clsUtils.GetConnString(1);
                conn.Open();
                DataSet SettingData = new DataSet();
                SqlDataAdapter SettingsDataAdapter = new SqlDataAdapter("SELECT * from tblCompanyDetails",conn);
                SettingsDataAdapter.Fill(SettingData, "tblCompanyDetails");
                txtCompanyName.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["CompanyName"].ToString();
                txtAdd1.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Street"].ToString();
                txtAdd2.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Area"].ToString();
                txtAdd3.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Town"].ToString();
                txtAdd4.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["County"].ToString();
                txtPostCode.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["PostCode"].ToString();
                txtTelephone.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Telephone"].ToString();
                txtFax.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Fax"].ToString();
                txtVATReg.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["VATRegistrationNo"].ToString();
                txtEmail.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Email"].ToString();
                txtWWW.Text = SettingData.Tables["tblCompanyDetails"].Rows[0]["Website"].ToString();
                double VatRate;
                VatRate = Convert.ToDouble(SettingData.Tables["tblCompanyDetails"].Rows[0]["VatRate"]);
                txtVATRate.Text = VatRate.ToString("P2",CultureInfo.InvariantCulture);
            // txtVATRate.Text = FormatPercent(txtVATRate.Text)
            }
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

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            txtCompanyName.Text = clsUtils.ChangeCase(txtCompanyName.Text, 3);
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            txtAdd1.Text = clsUtils.ChangeCase(txtAdd1.Text, 3);
        }

        private void txtAdd2_Leave(object sender, EventArgs e)
        {
            txtAdd2.Text = clsUtils.ChangeCase(txtAdd2.Text, 3);
        }

        private void txtAdd3_Leave(object sender, EventArgs e)
        {
            txtAdd3.Text = clsUtils.ChangeCase(txtAdd3.Text, 3);
        }

        private void txtAdd4_Leave(object sender, EventArgs e)
        {
            txtAdd4.Text = clsUtils.ChangeCase(txtAdd4.Text, 3);
        }

        private void txtPostCode_Leave(object sender, EventArgs e)
        {
            txtPostCode.Text = clsUtils.ChangeCase(txtPostCode.Text, 1);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (clsUtils.IsValidEmail(txtEmail.Text))
                txtEmail.Text = clsUtils.ChangeCase(txtEmail.Text, 2);
            else
            { txtEmail.Text = "Please Try Again"; }
        }

        private void txtWWW_Leave(object sender, EventArgs e)
        {
            txtWWW.Text = clsUtils.ChangeCase(txtWWW.Text, 2);
        }

        private void txtVATRate_Leave(object sender, EventArgs e)
        {
            txtVATRate.Text = VatRate.ToString("P2", CultureInfo.InvariantCulture);
        }

        private void txtVATReg_Leave(object sender, EventArgs e)
        {
            txtVATReg.Text = clsUtils.ChangeCase(txtVATReg.Text, 1);
        }
    }
}
