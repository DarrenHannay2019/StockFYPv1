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

    public class clsWarehouseAdjustment : clsUtils
    {

    }
    public class clsWarehouseAdjustmentHead : clsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentHead()
        {
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentHead()
        {
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentHead()
        {
            return DeleteFromDB;
        }
    }
    public class clsWarehouseAdjustmentLine : clsWarehouseAdjustment
    {
        public bool SaveWarehouseAdjustmentLine()
        {
            return SaveToDB;
        }
        public bool UpdateWarehouseAdjustmentLine()
        {
            return UpdateToDB;
        }
        public bool DeleteWarehouseAdjustmentLine()
        {
            return DeleteFromDB;
        }
    }
}
