using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHV2
{
    public partial class FrmMain : Form
    {
        public Form RefToLoginForm { get; set; }
        public int UserID;
        public string UserName;
        public FrmMain()
        {
            InitializeComponent();
        }
        // Sprint One Start
        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Warehouse records from the database
            // 1
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 1,
                Text = "Warehouses",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Supplier records from the database
            // 3
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 3,
                Text = "Suppliers",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void shopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load Shop records from the database
            // 2
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 2,
                Text = "Shops",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only to retreieve the current stock from the database
            // 4
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 4,
                Text = "Current Stock",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void allStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To Load all stock item records from the database
            // 5
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 5,
                Text = "All Stock",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void seasonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get all season names from the database
            // 6
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 6,
                Text = "Seasons",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To load all purchase orders
            // 7
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 7,
                Text = "Purchase Orders",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            Application.Exit();     // Exit the application
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Functions not implemented as of this release
           // shopFunctionsToolStripMenuItem.Visible = false;
           // maintananceFunctionsToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
           // warehouseAdjustmentsToolStripMenuItem.Visible = false;
          //  warehouseReturnsToolStripMenuItem.Visible = false;
          //  warehouseTransfersToolStripMenuItem.Visible = false;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //foreach (Form DataGrids in Application.OpenForms)
            //{
            //    if (DataGrids is frmDataGrid)
            //    {
            //        DataGrids.Close();
            //        break;
            //    }
            //}
            //   RefToLoginForm.ShowDialog();
        }
        // End Of Sprint One
        // Start Of Sprint Two
        private void warehouseAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //8
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 8,
                Text = "Warehouse Adjustments",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void warehouseTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //9
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 9,
                Text = "Warehouse Transfers",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void warehouseReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 10,
                Text = "Warehouse Returns",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }
      
        private void shopDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //11
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 11,
                Text = "Shop Deliveries",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }
        // End Of Sprint Two
        // Start Of Sprint Three
        private void shopAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //12
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 12,
                Text = "Shop Adjustments",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void shopTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //13
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 13,
                Text = "Shop Transfers",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void shopSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //14
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 14,
                Text = "Shop Sales",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void shopReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //15
            frmDataGrid objGrid = new frmDataGrid
            {
                FunctionID = 15,
                Text = "Shop Returns",
                UserIDs = UserID,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            objGrid.Show();
            splitContainer1.Panel2.Controls.Add(objGrid);
            objGrid.BringToFront();
        }

        private void maintananceFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();   // close the form
            RefToLoginForm.ShowDialog();
          //  this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSettings settings = new clsSettings();
            settings.LoadSettings();
        }
    }
}
