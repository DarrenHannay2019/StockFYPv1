using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopReturn : clsUtils
    {
    }
    public class clsShopReturnHead : clsShopReturn
    {
        public bool SaveShopReturnHead()
        {
            return SaveToDB;
        }
        public bool UpdateShopReturnHead()
        {
            return UpdateToDB;
        }
        public bool DeleteShopReturnHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopReturnLine : clsShopReturn
    {
        public bool SaveShopReturnLine()
        {
            return SaveToDB;
        }
        public bool UpdateShopReturnLine()
        {
            return UpdateToDB;
        }
        public bool DeleteShopReturnLine()
        {
            return DeleteFromDB;
        }
    }
}
