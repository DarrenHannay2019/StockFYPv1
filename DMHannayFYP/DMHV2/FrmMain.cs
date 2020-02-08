﻿using System;
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
        public int UserID = 0;
        public string UserName;
        public FrmMain()
        {
            InitializeComponent();
        }
        // Sprint One Start
        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 3
        }

        private void shopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 2
        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 4
        }

        private void allStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 5
        }

        private void seasonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 6
        }

        private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 7
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefToLoginForm.Close();
            Application.Exit();     // Exit the application
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form DataGrids in Application.OpenForms)
            {
                if (DataGrids is frmDataGrid)
                {
                    DataGrids.Close();
                    break;
                }
            }
            //   RefToLoginForm.ShowDialog();
        }
        // End Of Sprint One
        // Start Of Sprint Two
        private void warehouseAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //8
        }

        private void warehouseTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //9
        }

        private void warehouseReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10
        }
      
        private void shopDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //11
        }
        // End Of Sprint Two
        // Start Of Sprint Three
        private void shopAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //12
        }

        private void shopTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //13
        }

        private void shopSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //14
        }

        private void shopReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //15
        }

        private void maintananceFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefToLoginForm.ShowDialog();
            this.Hide();
        }

      
    }
}
