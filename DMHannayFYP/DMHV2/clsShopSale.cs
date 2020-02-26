using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopSale : clsUtils
    {
    }
    public class clsShopSaleHead : clsShopSale
    {
        public bool SaveShopSaleHead()
        {
            return SaveToDB;
        }
        public bool UpdateShopSaleHead()
        {
            return UpdateToDB;
        }
        public bool DeleteShopSaleHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopSaleLine : clsShopSale
    {
        public bool SaveShopSaleLine()
        {
            return SaveToDB;
        }
        public bool UpdateShopSaleLine()
        {
            return UpdateToDB;
        }
        public bool DeleteShopSaleLine()
        {
            return DeleteFromDB;
        }
    }
}
