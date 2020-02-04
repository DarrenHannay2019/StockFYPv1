using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class FrmEmployee : Form
    {
        public string ModeOfForm;
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
                clsEmployee.SaveToEmployeeTable();
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

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // Close The Form
        }
    }
}
