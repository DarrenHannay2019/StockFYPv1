namespace DMHV2
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
            this.TxtQtyLoose = new System.Windows.Forms.TextBox();
            this.TxtNetCostLine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.ColStockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyBoxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyLoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label28 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
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
            this.TxtWarehouseName = new System.Windows.Forms.TextBox();
            this.TxtWarehouseRef = new System.Windows.Forms.TextBox();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.TxtSupplierRef = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.CboSeasonName = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.TxtOurRef = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOrderID
            // 
            this.TxtOrderID.Location = new System.Drawing.Point(477, 43);
            this.TxtOrderID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtOrderID.Name = "TxtOrderID";
            this.TxtOrderID.Size = new System.Drawing.Size(132, 30);
            this.TxtOrderID.TabIndex = 54;
            // 
            // TxtShipperName
            // 
            this.TxtShipperName.Location = new System.Drawing.Point(477, 117);
            this.TxtShipperName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtShipperName.Name = "TxtShipperName";
            this.TxtShipperName.Size = new System.Drawing.Size(132, 30);
            this.TxtShipperName.TabIndex = 13;
            this.TxtShipperName.Leave += new System.EventHandler(this.TxtShipperName_Leave);
            // 
            // BtnDeleteFromGrid
            // 
            this.BtnDeleteFromGrid.Location = new System.Drawing.Point(763, 371);
            this.BtnDeleteFromGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDeleteFromGrid.Name = "BtnDeleteFromGrid";
            this.BtnDeleteFromGrid.Size = new System.Drawing.Size(99, 34);
            this.BtnDeleteFromGrid.TabIndex = 11;
            this.BtnDeleteFromGrid.Text = "Remove";
            this.BtnDeleteFromGrid.UseVisualStyleBackColor = true;
            this.BtnDeleteFromGrid.Click += new System.EventHandler(this.BtnDeleteFromGrid_Click);
            // 
            // BtnAddToGrid
            // 
            this.BtnAddToGrid.Location = new System.Drawing.Point(657, 371);
            this.BtnAddToGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAddToGrid.Name = "BtnAddToGrid";
            this.BtnAddToGrid.Size = new System.Drawing.Size(99, 34);
            this.BtnAddToGrid.TabIndex = 10;
            this.BtnAddToGrid.Text = "Add";
            this.BtnAddToGrid.UseVisualStyleBackColor = true;
            this.BtnAddToGrid.Click += new System.EventHandler(this.BtnAddToGrid_Click);
            // 
            // TxtQtyBoxes
            // 
            this.TxtQtyBoxes.Location = new System.Drawing.Point(341, 375);
            this.TxtQtyBoxes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtQtyBoxes.Name = "TxtQtyBoxes";
            this.TxtQtyBoxes.Size = new System.Drawing.Size(88, 30);
            this.TxtQtyBoxes.TabIndex = 7;
            // 
            // TxtSuppliersInvoiceNumber
            // 
            this.TxtSuppliersInvoiceNumber.Location = new System.Drawing.Point(477, 254);
            this.TxtSuppliersInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSuppliersInvoiceNumber.Name = "TxtSuppliersInvoiceNumber";
            this.TxtSuppliersInvoiceNumber.Size = new System.Drawing.Size(132, 30);
            this.TxtSuppliersInvoiceNumber.TabIndex = 15;
            // 
            // TxtStockCode
            // 
            this.TxtStockCode.Location = new System.Drawing.Point(14, 375);
            this.TxtStockCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtStockCode.Name = "TxtStockCode";
            this.TxtStockCode.Size = new System.Drawing.Size(217, 30);
            this.TxtStockCode.TabIndex = 5;
            this.TxtStockCode.Leave += new System.EventHandler(this.TxtStockCode_Leave);
            // 
            // TxtQtyItems
            // 
            this.TxtQtyItems.Location = new System.Drawing.Point(238, 375);
            this.TxtQtyItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtQtyItems.Name = "TxtQtyItems";
            this.TxtQtyItems.Size = new System.Drawing.Size(78, 30);
            this.TxtQtyItems.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(336, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Qty Boxes";
            // 
            // TxtQtyLoose
            // 
            this.TxtQtyLoose.Location = new System.Drawing.Point(452, 375);
            this.TxtQtyLoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtQtyLoose.Name = "TxtQtyLoose";
            this.TxtQtyLoose.Size = new System.Drawing.Size(67, 30);
            this.TxtQtyLoose.TabIndex = 8;
            // 
            // TxtNetCostLine
            // 
            this.TxtNetCostLine.Location = new System.Drawing.Point(561, 375);
            this.TxtNetCostLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNetCostLine.Name = "TxtNetCostLine";
            this.TxtNetCostLine.Size = new System.Drawing.Size(84, 30);
            this.TxtNetCostLine.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(233, 347);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Qty Items";
            // 
            // DgvItems
            // 
            this.DgvItems.AllowUserToAddRows = false;
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStockCode,
            this.ColQtyItems,
            this.ColQtyBoxes,
            this.ColQtyLoose,
            this.ColNetAmount});
            this.DgvItems.Location = new System.Drawing.Point(14, 411);
            this.DgvItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.RowHeadersWidth = 51;
            this.DgvItems.Size = new System.Drawing.Size(631, 188);
            this.DgvItems.TabIndex = 60;
            this.DgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItems_CellEndEdit);
            // 
            // ColStockCode
            // 
            this.ColStockCode.FillWeight = 180F;
            this.ColStockCode.HeaderText = "Stock Code";
            this.ColStockCode.MinimumWidth = 8;
            this.ColStockCode.Name = "ColStockCode";
            this.ColStockCode.Width = 180;
            // 
            // ColQtyItems
            // 
            this.ColQtyItems.FillWeight = 90F;
            this.ColQtyItems.HeaderText = "Qty Items";
            this.ColQtyItems.MinimumWidth = 8;
            this.ColQtyItems.Name = "ColQtyItems";
            this.ColQtyItems.Width = 90;
            // 
            // ColQtyBoxes
            // 
            this.ColQtyBoxes.FillWeight = 90F;
            this.ColQtyBoxes.HeaderText = "Qty Boxes";
            this.ColQtyBoxes.MinimumWidth = 8;
            this.ColQtyBoxes.Name = "ColQtyBoxes";
            this.ColQtyBoxes.Width = 90;
            // 
            // ColQtyLoose
            // 
            this.ColQtyLoose.FillWeight = 50F;
            this.ColQtyLoose.HeaderText = "Qty Loose";
            this.ColQtyLoose.MinimumWidth = 8;
            this.ColQtyLoose.Name = "ColQtyLoose";
            this.ColQtyLoose.Width = 50;
            // 
            // ColNetAmount
            // 
            this.ColNetAmount.FillWeight = 140F;
            this.ColNetAmount.HeaderText = "NetAmount";
            this.ColNetAmount.MinimumWidth = 8;
            this.ColNetAmount.Name = "ColNetAmount";
            this.ColNetAmount.Width = 140;
            // 
            // TxtShipperInvoiceNumber
            // 
            this.TxtShipperInvoiceNumber.Location = new System.Drawing.Point(477, 181);
            this.TxtShipperInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtShipperInvoiceNumber.Name = "TxtShipperInvoiceNumber";
            this.TxtShipperInvoiceNumber.Size = new System.Drawing.Size(132, 30);
            this.TxtShipperInvoiceNumber.TabIndex = 14;
            // 
            // TxtTotalOrderPrice
            // 
            this.TxtTotalOrderPrice.Location = new System.Drawing.Point(859, 189);
            this.TxtTotalOrderPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotalOrderPrice.Name = "TxtTotalOrderPrice";
            this.TxtTotalOrderPrice.Size = new System.Drawing.Size(90, 30);
            this.TxtTotalOrderPrice.TabIndex = 40;
            // 
            // TxtTotalNet
            // 
            this.TxtTotalNet.Location = new System.Drawing.Point(859, 45);
            this.TxtTotalNet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotalNet.Name = "TxtTotalNet";
            this.TxtTotalNet.Size = new System.Drawing.Size(90, 30);
            this.TxtTotalNet.TabIndex = 41;
            // 
            // TxtDeliveryCharges
            // 
            this.TxtDeliveryCharges.Location = new System.Drawing.Point(859, 81);
            this.TxtDeliveryCharges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDeliveryCharges.Name = "TxtDeliveryCharges";
            this.TxtDeliveryCharges.Size = new System.Drawing.Size(90, 30);
            this.TxtDeliveryCharges.TabIndex = 16;
            this.TxtDeliveryCharges.Text = "0.00";
            this.TxtDeliveryCharges.Leave += new System.EventHandler(this.TxtDeliveryCharges_Leave);
            // 
            // TxtCommission
            // 
            this.TxtCommission.Location = new System.Drawing.Point(859, 117);
            this.TxtCommission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCommission.Name = "TxtCommission";
            this.TxtCommission.Size = new System.Drawing.Size(90, 30);
            this.TxtCommission.TabIndex = 17;
            this.TxtCommission.Text = "0.00";
            this.TxtCommission.Leave += new System.EventHandler(this.TxtCommission_Leave);
            // 
            // TxtTotalGarments
            // 
            this.TxtTotalGarments.Location = new System.Drawing.Point(859, 322);
            this.TxtTotalGarments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotalGarments.Name = "TxtTotalGarments";
            this.TxtTotalGarments.Size = new System.Drawing.Size(55, 30);
            this.TxtTotalGarments.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(728, 286);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "Total Boxes:";
            // 
            // TxtTotalBoxes
            // 
            this.TxtTotalBoxes.Location = new System.Drawing.Point(859, 281);
            this.TxtTotalBoxes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotalBoxes.Name = "TxtTotalBoxes";
            this.TxtTotalBoxes.Size = new System.Drawing.Size(55, 30);
            this.TxtTotalBoxes.TabIndex = 38;
            // 
            // TxtTotalLooseItems
            // 
            this.TxtTotalLooseItems.Location = new System.Drawing.Point(859, 238);
            this.TxtTotalLooseItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotalLooseItems.Name = "TxtTotalLooseItems";
            this.TxtTotalLooseItems.Size = new System.Drawing.Size(55, 30);
            this.TxtTotalLooseItems.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(730, 243);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 25);
            this.label26.TabIndex = 36;
            this.label26.Text = "Total Loose:";
            // 
            // TxtVATAmount
            // 
            this.TxtVATAmount.Location = new System.Drawing.Point(859, 153);
            this.TxtVATAmount.Name = "TxtVATAmount";
            this.TxtVATAmount.Size = new System.Drawing.Size(90, 30);
            this.TxtVATAmount.TabIndex = 18;
            this.TxtVATAmount.Text = "0.00";
            this.TxtVATAmount.Leave += new System.EventHandler(this.TxtVATAmount_Leave);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(652, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(147, 25);
            this.label27.TabIndex = 48;
            this.label27.Text = "Purchase VAT:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(828, 153);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 25);
            this.label28.TabIndex = 45;
            this.label28.Text = "£";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(652, 46);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 25);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "Net:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(828, 46);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(23, 25);
            this.Label14.TabIndex = 42;
            this.Label14.Text = "£";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label7.Location = new System.Drawing.Point(652, 81);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(168, 25);
            this.Label7.TabIndex = 50;
            this.Label7.Text = "Delivery Charges:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(828, 84);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(23, 25);
            this.Label19.TabIndex = 43;
            this.Label19.Text = "£";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label8.Location = new System.Drawing.Point(652, 117);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(126, 25);
            this.Label8.TabIndex = 49;
            this.Label8.Text = "Commission:";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(827, 117);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(23, 25);
            this.Label23.TabIndex = 44;
            this.Label23.Text = "£";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(652, 189);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(62, 25);
            this.Label9.TabIndex = 47;
            this.Label9.Text = "Total:";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(827, 189);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 25);
            this.Label24.TabIndex = 46;
            this.Label24.Text = "£";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(728, 325);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(114, 25);
            this.Label10.TabIndex = 34;
            this.Label10.Text = "Total Items:";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label22.Location = new System.Drawing.Point(447, 347);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(102, 25);
            this.Label22.TabIndex = 32;
            this.Label22.Text = "Qty Loose";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label21.Location = new System.Drawing.Point(9, 347);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(115, 25);
            this.Label21.TabIndex = 29;
            this.Label21.Text = "Stock Code";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label25.Location = new System.Drawing.Point(557, 347);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(88, 25);
            this.Label25.TabIndex = 33;
            this.Label25.Text = "Net Cost";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(477, 9);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(98, 25);
            this.Label13.TabIndex = 53;
            this.Label13.Text = "Order No:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label2.Location = new System.Drawing.Point(477, 81);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 25);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Shipper:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label3.Location = new System.Drawing.Point(467, 153);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(183, 25);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "Shipper Invoice No:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label4.Location = new System.Drawing.Point(467, 225);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(197, 25);
            this.Label4.TabIndex = 57;
            this.Label4.Text = "Suppliers Invoice No:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(196, 271);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(263, 62);
            this.TxtNotes.TabIndex = 12;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label15.Location = new System.Drawing.Point(52, 158);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(134, 25);
            this.Label15.TabIndex = 25;
            this.Label15.Text = "Delivery Date:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(9, 48);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(177, 25);
            this.Label20.TabIndex = 22;
            this.Label20.Text = "Warehouse Name:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(777, 571);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(112, 28);
            this.cmdCancel.TabIndex = 20;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label18.Location = new System.Drawing.Point(32, 12);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(154, 25);
            this.Label18.TabIndex = 21;
            this.Label18.Text = "Warehouse Ref:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(657, 571);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(112, 28);
            this.cmdOK.TabIndex = 19;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label16.Location = new System.Drawing.Point(62, 84);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(124, 25);
            this.Label16.TabIndex = 23;
            this.Label16.Text = "Supplier Ref:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox1.Location = new System.Drawing.Point(564, 675);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(165, 29);
            this.CheckBox1.TabIndex = 168;
            this.CheckBox1.Text = "Direct To Shop";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(39, 122);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(147, 25);
            this.Label17.TabIndex = 24;
            this.Label17.Text = "Supplier Name:";
            // 
            // TxtWarehouseName
            // 
            this.TxtWarehouseName.Location = new System.Drawing.Point(194, 45);
            this.TxtWarehouseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWarehouseName.Name = "TxtWarehouseName";
            this.TxtWarehouseName.Size = new System.Drawing.Size(211, 30);
            this.TxtWarehouseName.TabIndex = 59;
            // 
            // TxtWarehouseRef
            // 
            this.TxtWarehouseRef.Location = new System.Drawing.Point(194, 9);
            this.TxtWarehouseRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWarehouseRef.Name = "TxtWarehouseRef";
            this.TxtWarehouseRef.Size = new System.Drawing.Size(132, 30);
            this.TxtWarehouseRef.TabIndex = 0;
            this.TxtWarehouseRef.Leave += new System.EventHandler(this.TxtWarehouseRef_Leave);
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(194, 117);
            this.TxtSupplierName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(211, 30);
            this.TxtSupplierName.TabIndex = 58;
            // 
            // TxtSupplierRef
            // 
            this.TxtSupplierRef.Location = new System.Drawing.Point(194, 81);
            this.TxtSupplierRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSupplierRef.Name = "TxtSupplierRef";
            this.TxtSupplierRef.Size = new System.Drawing.Size(132, 30);
            this.TxtSupplierRef.TabIndex = 1;
            this.TxtSupplierRef.Leave += new System.EventHandler(this.TxtSupplierRef_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 153);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(728, 9);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(140, 25);
            this.Label5.TabIndex = 52;
            this.Label5.Text = "Order Totals:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(100, 228);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 25);
            this.label29.TabIndex = 27;
            this.label29.Text = "Season:";
            // 
            // CboSeasonName
            // 
            this.CboSeasonName.FormattingEnabled = true;
            this.CboSeasonName.Location = new System.Drawing.Point(194, 225);
            this.CboSeasonName.Name = "CboSeasonName";
            this.CboSeasonName.Size = new System.Drawing.Size(265, 33);
            this.CboSeasonName.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(101, 192);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 25);
            this.label30.TabIndex = 26;
            this.label30.Text = "Our Ref:";
            // 
            // TxtOurRef
            // 
            this.TxtOurRef.Location = new System.Drawing.Point(194, 189);
            this.TxtOurRef.Name = "TxtOurRef";
            this.TxtOurRef.Size = new System.Drawing.Size(177, 30);
            this.TxtOurRef.TabIndex = 3;
            this.TxtOurRef.Leave += new System.EventHandler(this.TxtOurRef_Leave);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label31.Location = new System.Drawing.Point(117, 264);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(69, 25);
            this.label31.TabIndex = 28;
            this.label31.Text = "Notes:";
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 615);
            this.Controls.Add(this.BtnDeleteFromGrid);
            this.Controls.Add(this.TxtNetCostLine);
            this.Controls.Add(this.BtnAddToGrid);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.TxtQtyLoose);
            this.Controls.Add(this.TxtQtyBoxes);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.TxtStockCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQtyItems);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.TxtOrderID);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtTotalOrderPrice);
            this.Controls.Add(this.TxtTotalGarments);
            this.Controls.Add(this.TxtVATAmount);
            this.Controls.Add(this.TxtTotalNet);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtShipperName);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.TxtCommission);
            this.Controls.Add(this.TxtDeliveryCharges);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtShipperInvoiceNumber);
            this.Controls.Add(this.TxtSuppliersInvoiceNumber);
            this.Controls.Add(this.TxtTotalBoxes);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtTotalLooseItems);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.TxtWarehouseName);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.TxtSupplierName);
            this.Controls.Add(this.TxtOurRef);
            this.Controls.Add(this.TxtWarehouseRef);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.CboSeasonName);
            this.Controls.Add(this.TxtSupplierRef);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.DgvItems);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPurchaseOrder";
            this.Text = "frmPurchaseOrder";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtShipperName;
        private System.Windows.Forms.Button BtnDeleteFromGrid;
        private System.Windows.Forms.Button BtnAddToGrid;
        private System.Windows.Forms.TextBox TxtQtyBoxes;
        private System.Windows.Forms.TextBox TxtSuppliersInvoiceNumber;
        private System.Windows.Forms.TextBox TxtStockCode;
        private System.Windows.Forms.TextBox TxtQtyItems;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtQtyLoose;
        private System.Windows.Forms.TextBox TxtNetCostLine;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvItems;
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
        internal System.Windows.Forms.Label label28;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label25;
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
        private System.Windows.Forms.TextBox TxtWarehouseName;
        private System.Windows.Forms.TextBox TxtWarehouseRef;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.TextBox TxtSupplierRef;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label Label5;
        public System.Windows.Forms.TextBox TxtOrderID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox CboSeasonName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TxtOurRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyBoxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyLoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNetAmount;
        private System.Windows.Forms.Label label31;
    }
}