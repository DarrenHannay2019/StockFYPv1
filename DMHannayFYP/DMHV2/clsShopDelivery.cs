using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopDelivery : clsUtils
    {
        public void LoadNewForm()
        {

        }
        public void LoadSelectedForm()
        {

        }
    }
    public class clsShopDeliveryHead : clsShopDelivery
    {
        public bool SaveShopDeliveryHead()
        {
            return SaveToDB;
        }
        public bool UpdateShopDeliveryHead()
        {
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopDeliveryLine : clsShopDelivery
    {
        public bool SaveShopDeliveryLine()
        {
            return SaveToDB;
        }
        public bool UpdateShopDeliveryLine()
        {
            return UpdateToDB;
        }
        public bool DeleteShopDeliveryLine()
        {
            return DeleteFromDB;
        }
    }
}
