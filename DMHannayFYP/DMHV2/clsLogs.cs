using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsLogs : clsUtils 
    {
        public clsLogs()
        {

        }
        ~clsLogs()
        {

        }
        public bool SaveToSysLogTable()
        {
            return SaveToDB;
        }
        public bool SaveToStockMovementsTable()
        {
            return SaveToDB;
        }
        public bool DeleteFromStockMovemmentsTable()
        {
            return DeleteFromDB;
        }
        public bool DeleteZeroQtyFromStockMovementsTable()
        {
            return DeleteFromDB;
        }
    }
}
