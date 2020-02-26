using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsWarehouseReturn : clsUtils
    {
    }
    public class clsWarehouseReturnHead : clsWarehouseReturn
    {
        public bool SaveWarehouseReturnHead()
        {
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnHead()
        {
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsWarehouseReturnLine : clsWarehouseReturn
    {
        public bool SaveWarehouseReturnLine()
        {
            return SaveToDB;
        }
        public bool UpdateWarehouseReturnLine()
        {
            return UpdateToDB;
        }
        public bool DeleteWarehouseReturnLine()
        {
            return DeleteFromDB;
        }
    }

}
