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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     // Exit the application
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int PassResult = 0;
            int TotalUsers = 0;
            clsEmployee clsEmployee = new clsEmployee();
            PassResult = clsEmployee.GetLoginUserID(TxtUserName.Text.TrimEnd(), TxtPassword.Text.TrimEnd());
            if (PassResult != 0 || TotalUsers != 0)
            {

            }
            else
            {
                DialogResult dialog = MessageBox.Show("Unknown User and do you wish to add new user?",Application.ProductName,MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes)
                {

                }
                else
                {
                    TxtUserName.Clear();
                    TxtPassword.Clear();
                    TxtUserName.Select();
                }
            }
        }
    }
}
