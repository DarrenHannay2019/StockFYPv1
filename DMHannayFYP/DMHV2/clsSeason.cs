using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsSeason : clsUtils
    {
        public int SeasonID { get; set; }
        public void LoadNewSeasonForm()
        {
            frmSeason season = new frmSeason
            {
                ModeOfForm = "New"
            };
            season.ShowDialog();
        }
        public void LoadSelectedSeasonForm()
        {
            frmSeason frm = new frmSeason()
            {
                ModeOfForm = "Old",
                SeasonIDs = SeasonID
            };
            frm.ShowDialog();
        }
        public bool DeleteSeasonName()
        {
            return DeleteFromDB;
        }
        public bool UpdateSeasonName()
        {
            return UpdateToDB;
        }
        public bool SaveSeasonName()
        {
            return SaveToDB;
        }
    }
}
