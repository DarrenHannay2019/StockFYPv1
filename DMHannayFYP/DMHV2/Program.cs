using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FrmWarehouse());
            //Application.Run(new frmPurchaseOrder());
            //Application.Run(new frmShop());
            //Application.Run(new frmSupplier());
            //Application.Run(new frmStock());
            //Application.Run(new frmSeason());
            Application.Run(new frmShopDelivery());
            //Application.Run(new frmWarehouseAdjustment());
            //Application.Run(new frmWarehouseTransfer());
            //Application.Run(new frmWarehouseReturn());
            //Application.Run(new frmShopAdjustment());
            //Application.Run(new frmShopTransfer());
            //Application.Run(new frmShopSale());
            //Application.Run(new frmShopReturn());

        }
    }
}
