using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsPurchaseOrder : clsUtils
    {
        public clsPurchaseOrder()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~clsPurchaseOrder()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }

    }
    public class clsPurchaseOrderLine : clsUtils
    {

    }
    public class clsPurchaseOrderHead : clsUtils
    {

    }
}
