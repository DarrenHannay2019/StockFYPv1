﻿namespace DMHV2
{
    partial class frmPurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtOrderID = new System.Windows.Forms.TextBox();
            this.TxtShipperName = new System.Windows.Forms.TextBox();
            this.BtnDeleteFromGrid = new System.Windows.Forms.Button();
            this.BtnAddToGrid = new System.Windows.Forms.Button();
            this.TxtQtyBoxes = new System.Windows.Forms.TextBox();
            this.TxtSuppliersInvoiceNumber = new System.Windows.Forms.TextBox();
            this.TxtStockCode = new System.Windows.Forms.TextBox();
            this.TxtQtyItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtQtyLoose = new System.Windows.Forms.TextBox();
            this.TxtNetCostLine = new System.Windows.Forms.TextBox();
            this.ColQtyLoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyBoxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.ColStockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtShipperInvoiceNumber = new System.Windows.Forms.TextBox();
            this.TxtTotalOrderPrice = new System.Windows.Forms.TextBox();
            this.TxtTotalNet = new System.Windows.Forms.TextBox();
            this.TxtDeliveryCharges = new System.Windows.Forms.TextBox();
            this.TxtCommission = new System.Windows.Forms.TextBox();
            this.TxtTotalGarments = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTotalBoxes = new System.Windows.Forms.TextBox();
            this.TxtTotalLooseItems = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TxtVATAmount = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.Label18 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TxtWarehouseName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtWarehouseRef = new System.Windows.Forms.TextBox();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtSupplierRef = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtOrderID
            // 
            this.TxtOrderID.Location = new System.Drawing.Point(123, 3);
            this.TxtOrderID.Name = "TxtOrderID";
            this.TxtOrderID.Size = new System.Drawing.Size(100, 26);
            this.TxtOrderID.TabIndex = 147;
            // 
            // TxtShipperName
            // 
            this.TxtShipperName.Location = new System.Drawing.Point(123, 29);
            this.TxtShipperName.Name = "TxtShipperName";
            this.TxtShipperName.Size = new System.Drawing.Size(100, 26);
            this.TxtShipperName.TabIndex = 148;
            // 
            // BtnDeleteFromGrid
            // 
            this.BtnDeleteFromGrid.Location = new System.Drawing.Point(345, 238);
            this.BtnDeleteFromGrid.Name = "BtnDeleteFromGrid";
            this.BtnDeleteFromGrid.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteFromGrid.TabIndex = 177;
            this.BtnDeleteFromGrid.Text = "Remove";
            this.BtnDeleteFromGrid.UseVisualStyleBackColor = true;
            // 
            // BtnAddToGrid
            // 
            this.BtnAddToGrid.Location = new System.Drawing.Point(345, 206);
            this.BtnAddToGrid.Name = "BtnAddToGrid";
            this.BtnAddToGrid.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToGrid.TabIndex = 176;
            this.BtnAddToGrid.Text = "Add";
            this.BtnAddToGrid.UseVisualStyleBackColor = true;
            // 
            // TxtQtyBoxes
            // 
            this.TxtQtyBoxes.Location = new System.Drawing.Point(151, 36);
            this.TxtQtyBoxes.Name = "TxtQtyBoxes";
            this.TxtQtyBoxes.Size = new System.Drawing.Size(43, 26);
            this.TxtQtyBoxes.TabIndex = 142;
            // 
            // TxtSuppliersInvoiceNumber
            // 
            this.TxtSuppliersInvoiceNumber.Location = new System.Drawing.Point(123, 81);
            this.TxtSuppliersInvoiceNumber.Name = "TxtSuppliersInvoiceNumber";
            this.TxtSuppliersInvoiceNumber.Size = new System.Drawing.Size(100, 26);
            this.TxtSuppliersInvoiceNumber.TabIndex = 150;
            // 
            // TxtStockCode
            // 
            this.TxtStockCode.Location = new System.Drawing.Point(3, 36);
            this.TxtStockCode.Name = "TxtStockCode";
            this.TxtStockCode.Size = new System.Drawing.Size(90, 26);
            this.TxtStockCode.TabIndex = 140;
            // 
            // TxtQtyItems
            // 
            this.TxtQtyItems.Location = new System.Drawing.Point(99, 36);
            this.TxtQtyItems.Name = "TxtQtyItems";
            this.TxtQtyItems.Size = new System.Drawing.Size(46, 26);
            this.TxtQtyItems.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(151, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 33);
            this.label1.TabIndex = 138;
            this.label1.Text = "Qty Boxes";
            // 
            // ColNetAmount
            // 
            this.ColNetAmount.FillWeight = 70F;
            this.ColNetAmount.HeaderText = "NetAmount";
            this.ColNetAmount.MinimumWidth = 8;
            this.ColNetAmount.Name = "ColNetAmount";
            this.ColNetAmount.Width = 70;
            // 
            // TxtQtyLoose
            // 
            this.TxtQtyLoose.Location = new System.Drawing.Point(200, 36);
            this.TxtQtyLoose.Name = "TxtQtyLoose";
            this.TxtQtyLoose.Size = new System.Drawing.Size(53, 26);
            this.TxtQtyLoose.TabIndex = 143;
            // 
            // TxtNetCostLine
            // 
            this.TxtNetCostLine.Location = new System.Drawing.Point(259, 36);
            this.TxtNetCostLine.Name = "TxtNetCostLine";
            this.TxtNetCostLine.Size = new System.Drawing.Size(64, 26);
            this.TxtNetCostLine.TabIndex = 144;
            // 
            // ColQtyLoose
            // 
            this.ColQtyLoose.FillWeight = 50F;
            this.ColQtyLoose.HeaderText = "Qty Loose";
            this.ColQtyLoose.MinimumWidth = 8;
            this.ColQtyLoose.Name = "ColQtyLoose";
            this.ColQtyLoose.Width = 50;
            // 
            // ColQtyBoxes
            // 
            this.ColQtyBoxes.FillWeight = 50F;
            this.ColQtyBoxes.HeaderText = "Qty Boxes";
            this.ColQtyBoxes.MinimumWidth = 8;
            this.ColQtyBoxes.Name = "ColQtyBoxes";
            this.ColQtyBoxes.Width = 50;
            // 
            // ColQtyItems
            // 
            this.ColQtyItems.FillWeight = 50F;
            this.ColQtyItems.HeaderText = "Qty Items";
            this.ColQtyItems.MinimumWidth = 8;
            this.ColQtyItems.Name = "ColQtyItems";
            this.ColQtyItems.Width = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(99, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 33);
            this.label11.TabIndex = 139;
            this.label11.Text = "Qty Items";
            // 
            // DgvItems
            // 
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStockCode,
            this.ColQtyItems,
            this.ColQtyBoxes,
            this.ColQtyLoose,
            this.ColNetAmount});
            this.DgvItems.Location = new System.Drawing.Point(7, 276);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.RowHeadersWidth = 51;
            this.DgvItems.Size = new System.Drawing.Size(398, 150);
            this.DgvItems.TabIndex = 175;
            // 
            // ColStockCode
            // 
            this.ColStockCode.HeaderText = "Stock Code";
            this.ColStockCode.MinimumWidth = 8;
            this.ColStockCode.Name = "ColStockCode";
            this.ColStockCode.Width = 150;
            // 
            // TxtShipperInvoiceNumber
            // 
            this.TxtShipperInvoiceNumber.Location = new System.Drawing.Point(123, 55);
            this.TxtShipperInvoiceNumber.Name = "TxtShipperInvoiceNumber";
            this.TxtShipperInvoiceNumber.Size = new System.Drawing.Size(100, 26);
            this.TxtShipperInvoiceNumber.TabIndex = 149;
            // 
            // TxtTotalOrderPrice
            // 
            this.TxtTotalOrderPrice.Location = new System.Drawing.Point(126, 107);
            this.TxtTotalOrderPrice.Name = "TxtTotalOrderPrice";
            this.TxtTotalOrderPrice.Size = new System.Drawing.Size(86, 26);
            this.TxtTotalOrderPrice.TabIndex = 154;
            // 
            // TxtTotalNet
            // 
            this.TxtTotalNet.Location = new System.Drawing.Point(126, 3);
            this.TxtTotalNet.Name = "TxtTotalNet";
            this.TxtTotalNet.Size = new System.Drawing.Size(86, 26);
            this.TxtTotalNet.TabIndex = 151;
            // 
            // TxtDeliveryCharges
            // 
            this.TxtDeliveryCharges.Location = new System.Drawing.Point(126, 29);
            this.TxtDeliveryCharges.Name = "TxtDeliveryCharges";
            this.TxtDeliveryCharges.Size = new System.Drawing.Size(86, 26);
            this.TxtDeliveryCharges.TabIndex = 152;
            this.TxtDeliveryCharges.Text = "0.00";
            // 
            // TxtCommission
            // 
            this.TxtCommission.Location = new System.Drawing.Point(126, 55);
            this.TxtCommission.Name = "TxtCommission";
            this.TxtCommission.Size = new System.Drawing.Size(86, 26);
            this.TxtCommission.TabIndex = 153;
            this.TxtCommission.Text = "0.00";
            // 
            // TxtTotalGarments
            // 
            this.TxtTotalGarments.Location = new System.Drawing.Point(92, 3);
            this.TxtTotalGarments.Name = "TxtTotalGarments";
            this.TxtTotalGarments.Size = new System.Drawing.Size(45, 26);
            this.TxtTotalGarments.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 33);
            this.label12.TabIndex = 158;
            this.label12.Text = "Total Garments:";
            // 
            // TxtTotalBoxes
            // 
            this.TxtTotalBoxes.Location = new System.Drawing.Point(92, 36);
            this.TxtTotalBoxes.Name = "TxtTotalBoxes";
            this.TxtTotalBoxes.Size = new System.Drawing.Size(44, 26);
            this.TxtTotalBoxes.TabIndex = 156;
            // 
            // TxtTotalLooseItems
            // 
            this.TxtTotalLooseItems.Location = new System.Drawing.Point(92, 69);
            this.TxtTotalLooseItems.Name = "TxtTotalLooseItems";
            this.TxtTotalLooseItems.Size = new System.Drawing.Size(45, 26);
            this.TxtTotalLooseItems.TabIndex = 157;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 34);
            this.label26.TabIndex = 159;
            this.label26.Text = "Total Garments:";
            // 
            // TxtVATAmount
            // 
            this.TxtVATAmount.Location = new System.Drawing.Point(125, 80);
            this.TxtVATAmount.Margin = new System.Windows.Forms.Padding(2);
            this.TxtVATAmount.Name = "TxtVATAmount";
            this.TxtVATAmount.Size = new System.Drawing.Size(88, 26);
            this.TxtVATAmount.TabIndex = 161;
            this.TxtVATAmount.Text = "0.00";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(2, 78);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 26);
            this.label27.TabIndex = 160;
            this.label27.Text = "Purchase VAT:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.04651F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.62791F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.32558F));
            this.tableLayoutPanel2.Controls.Add(this.label28, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label14, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtTotalOrderPrice, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtTotalNet, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtVATAmount, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.Label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label27, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Label19, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtDeliveryCharges, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtCommission, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label23, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Label24, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(435, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(215, 134);
            this.tableLayoutPanel2.TabIndex = 180;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(101, 78);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 20);
            this.label28.TabIndex = 167;
            this.label28.Text = "£";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(3, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 20);
            this.Label6.TabIndex = 117;
            this.Label6.Text = "Net:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(101, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(18, 20);
            this.Label14.TabIndex = 118;
            this.Label14.Text = "£";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label7.Location = new System.Drawing.Point(3, 26);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(73, 26);
            this.Label7.TabIndex = 119;
            this.Label7.Text = "Delivery Charges:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(101, 26);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(18, 20);
            this.Label19.TabIndex = 120;
            this.Label19.Text = "£";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label8.Location = new System.Drawing.Point(3, 52);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(86, 26);
            this.Label8.TabIndex = 121;
            this.Label8.Text = "Commission:";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(101, 52);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(18, 20);
            this.Label23.TabIndex = 122;
            this.Label23.Text = "£";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(3, 104);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(48, 20);
            this.Label9.TabIndex = 124;
            this.Label9.Text = "Total:";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(101, 104);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(18, 20);
            this.Label24.TabIndex = 123;
            this.Label24.Text = "£";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.32484F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.67516F));
            this.tableLayoutPanel1.Controls.Add(this.Label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtTotalGarments, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtTotalBoxes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtTotalLooseItems, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(493, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 100);
            this.tableLayoutPanel1.TabIndex = 179;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(3, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 33);
            this.Label10.TabIndex = 125;
            this.Label10.Text = "Total Garments:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66666F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.Controls.Add(this.TxtStockCode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtQtyBoxes, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtQtyItems, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtQtyLoose, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.Label22, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.Label21, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Label25, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtNetCostLine, 4, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 204);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(328, 66);
            this.tableLayoutPanel3.TabIndex = 178;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label22.Location = new System.Drawing.Point(200, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(53, 33);
            this.Label22.TabIndex = 109;
            this.Label22.Text = "Qty Loose";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label21.Location = new System.Drawing.Point(3, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(54, 33);
            this.Label21.TabIndex = 108;
            this.Label21.Text = "Stock Code";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label25.Location = new System.Drawing.Point(259, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(42, 33);
            this.Label25.TabIndex = 110;
            this.Label25.Text = "Net Cost";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Label13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtOrderID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtShipperName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtSuppliersInvoiceNumber, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.TxtShipperInvoiceNumber, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Label4, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(409, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(241, 106);
            this.tableLayoutPanel4.TabIndex = 181;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(3, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(77, 20);
            this.Label13.TabIndex = 112;
            this.Label13.Text = "Order No:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label2.Location = new System.Drawing.Point(3, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 20);
            this.Label2.TabIndex = 113;
            this.Label2.Text = "Shipper:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label3.Location = new System.Drawing.Point(3, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 26);
            this.Label3.TabIndex = 114;
            this.Label3.Text = "Shipper Invoice No:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label4.Location = new System.Drawing.Point(3, 78);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(87, 28);
            this.Label4.TabIndex = 115;
            this.Label4.Text = "Suppliers Invoice No:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNotes.Location = new System.Drawing.Point(3, 3);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(365, 83);
            this.TxtNotes.TabIndex = 0;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label15.Location = new System.Drawing.Point(31, 148);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(107, 20);
            this.Label15.TabIndex = 171;
            this.Label15.Text = "Delivery Date:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(7, 38);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(141, 20);
            this.Label20.TabIndex = 107;
            this.Label20.Text = "Warehouse Name:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(566, 406);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(84, 23);
            this.cmdCancel.TabIndex = 170;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label18.Location = new System.Drawing.Point(18, 9);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(125, 20);
            this.Label18.TabIndex = 106;
            this.Label18.Text = "Warehouse Ref:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(479, 406);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(84, 23);
            this.cmdOK.TabIndex = 169;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label16.Location = new System.Drawing.Point(6, 13);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(101, 20);
            this.Label16.TabIndex = 104;
            this.Label16.Text = "Supplier Ref:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox1.Location = new System.Drawing.Point(7, 174);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(141, 24);
            this.CheckBox1.TabIndex = 168;
            this.CheckBox1.Text = "Direct To Shop";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(6, 32);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(117, 20);
            this.Label17.TabIndex = 105;
            this.Label17.Text = "Supplier Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TxtNotes);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(371, 89);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TxtWarehouseName
            // 
            this.TxtWarehouseName.Location = new System.Drawing.Point(109, 32);
            this.TxtWarehouseName.Name = "TxtWarehouseName";
            this.TxtWarehouseName.Size = new System.Drawing.Size(100, 26);
            this.TxtWarehouseName.TabIndex = 135;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtWarehouseName);
            this.tabPage2.Controls.Add(this.Label18);
            this.tabPage2.Controls.Add(this.Label20);
            this.tabPage2.Controls.Add(this.TxtWarehouseRef);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 89);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Warehouse Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtWarehouseRef
            // 
            this.TxtWarehouseRef.Location = new System.Drawing.Point(109, 6);
            this.TxtWarehouseRef.Name = "TxtWarehouseRef";
            this.TxtWarehouseRef.Size = new System.Drawing.Size(100, 26);
            this.TxtWarehouseRef.TabIndex = 134;
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(92, 32);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(100, 26);
            this.TxtSupplierName.TabIndex = 134;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtSupplierName);
            this.tabPage1.Controls.Add(this.Label17);
            this.tabPage1.Controls.Add(this.Label16);
            this.tabPage1.Controls.Add(this.TxtSupplierRef);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 89);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Supplier Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtSupplierRef
            // 
            this.TxtSupplierRef.Location = new System.Drawing.Point(92, 6);
            this.TxtSupplierRef.Name = "TxtSupplierRef";
            this.TxtSupplierRef.Size = new System.Drawing.Size(100, 26);
            this.TxtSupplierRef.TabIndex = 133;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 122);
            this.tabControl1.TabIndex = 174;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 173;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(501, 132);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(168, 29);
            this.Label5.TabIndex = 172;
            this.Label5.Text = "Order Totals:";
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 468);
            this.Controls.Add(this.BtnDeleteFromGrid);
            this.Controls.Add(this.BtnAddToGrid);
            this.Controls.Add(this.DgvItems);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Label5);
            this.Name = "frmPurchaseOrder";
            this.Text = "frmPurchaseOrder";
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOrderID;
        private System.Windows.Forms.TextBox TxtShipperName;
        private System.Windows.Forms.Button BtnDeleteFromGrid;
        private System.Windows.Forms.Button BtnAddToGrid;
        private System.Windows.Forms.TextBox TxtQtyBoxes;
        private System.Windows.Forms.TextBox TxtSuppliersInvoiceNumber;
        private System.Windows.Forms.TextBox TxtStockCode;
        private System.Windows.Forms.TextBox TxtQtyItems;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNetAmount;
        private System.Windows.Forms.TextBox TxtQtyLoose;
        private System.Windows.Forms.TextBox TxtNetCostLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyLoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyBoxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyItems;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockCode;
        private System.Windows.Forms.TextBox TxtShipperInvoiceNumber;
        private System.Windows.Forms.TextBox TxtTotalOrderPrice;
        private System.Windows.Forms.TextBox TxtTotalNet;
        private System.Windows.Forms.TextBox TxtDeliveryCharges;
        private System.Windows.Forms.TextBox TxtCommission;
        private System.Windows.Forms.TextBox TxtTotalGarments;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTotalBoxes;
        private System.Windows.Forms.TextBox TxtTotalLooseItems;
        internal System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TxtVATAmount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label label28;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TxtNotes;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label Label17;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TxtWarehouseName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtWarehouseRef;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TxtSupplierRef;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label Label5;
    }
}