using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHV2
{
    public class clsShopTransfer : clsUtils
    {
    }
    public class clsShopTransferHead : clsUtils
    {
        public bool SaveShopTransferHead()
        {
            return SaveToDB;
        }
        public bool UpdateShopTransferHead()
        {
            return UpdateToDB;
        }
        public bool DeleteShopTransferHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsShopTransferLine : clsUtils
    {
        public bool SaveShopTransferLine()
        {
            return SaveToDB;
        }
        public bool UpdateShopTransferLine()
        {
            return UpdateToDB;
        }
        public bool DeleteShopTransferLine()
        {
            return DeleteFromDB;
        }
    }
}
