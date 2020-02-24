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
    public partial class frmSeason : Form
    {
        public string ModeOfForm { get; set; }
        public int SeasonIDs { get; set; }
        public frmSeason()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            clsSeason season = new clsSeason();
            if(ModeOfForm == "New")
            {
                // Save to the database                
                season.SeasonName = TxtSeasonName.Text.TrimEnd();
                season.SaveSeasonName();
                this.Close();
            }
            else
            {
                season.SeasonName = TxtSeasonName.Text.TrimEnd();
                season.UpdateSeasonName();
                this.Close();   // close form
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   // close the form.
        }

        private void frmSeason_Load(object sender, EventArgs e)
        {
            if(ModeOfForm == "New")
            {
                BtnOK.Text = "Save";
            }
            else
            {
                BtnOK.Text = "Ok";
            }
        }
    }
}
