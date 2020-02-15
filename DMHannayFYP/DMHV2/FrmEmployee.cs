namespace DMHV2
{
    using System;
    using System.Windows.Forms;

    public partial class FrmEmployee : Form
    {
        public string ModeOfForm { get; set; }
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            if (ModeOfForm == "New")
            {
                BtnOK.Text = "Save";
            }
            else
            {
                BtnOK.Text = "OK";
                LoadData();
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // depeneding on the function mode depends on what funciton is called from the clsEmployee
            if(BtnOK.Text == "OK")
            {
                // Updating the current record to the database
                clsEmployee clsEmployee = new clsEmployee();
                clsEmployee.PasswordEntered = TxtPassword.Text.TrimEnd();
                clsEmployee.LoginCode = TxtLoginCode.Text.TrimEnd();
                clsEmployee.FirstName = TxtFirstName.Text.TrimEnd();
                clsEmployee.LastName = TxtLastName.Text.TrimEnd();
                clsEmployee.ProfileID = CboProfiles.SelectedIndex;
                clsEmployee.SaveToEmployeeTable(1);
            }
            else
            {
                // Saving a new record to the database
                clsEmployee clsEmployee = new clsEmployee();
                clsEmployee.PasswordEntered = TxtPassword.Text.TrimEnd();
                clsEmployee.LoginCode = TxtLoginCode.Text.TrimEnd();
                clsEmployee.FirstName = TxtFirstName.Text.TrimEnd();
                clsEmployee.LastName = TxtLastName.Text.TrimEnd();
                clsEmployee.ProfileID = CboProfiles.SelectedIndex;
                clsEmployee.UpdateToEmployeeTable();
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // Close The Form
        }
        private void LoadData()
        {

        }
    }
}
