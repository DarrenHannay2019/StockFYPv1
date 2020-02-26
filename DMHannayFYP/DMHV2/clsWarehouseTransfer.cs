namespace DMHV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class clsWarehouseTransfer : clsUtils
    {
    }
    public class clsWarehouseTransferHead : clsWarehouseTransfer
    {
        public bool SaveWarehouseTransferHead()
        {
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferHead()
        {
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsWarehouseTransferLine : clsWarehouseTransfer
    {
        public bool SaveWarehouseTransferLine()
        {
            return SaveToDB;
        }
        public bool UpdateWarehouseTransferLine()
        {
            return UpdateToDB;
        }
        public bool DeleteWarehouseTransferLine()
        {
            return DeleteFromDB;
        }
    }
}
