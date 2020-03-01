﻿namespace DMHV2
{
    partial class frmShopSale
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
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.TxtStockCode = new System.Windows.Forms.TextBox();
            this.cmdDelToGrid = new System.Windows.Forms.Button();
            this.cmdAddToGrid = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtSoldToDate = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.txtDelivered = new System.Windows.Forms.TextBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.txtNetSale = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotalDelivered = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtTotalSold = new System.Windows.Forms.TextBox();
            this.txtTotalCurrQty = new System.Windows.Forms.TextBox();
            this.txtShopRef = new System.Windows.Forms.TextBox();
            this.txtTotalGarments = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(84, 123);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(150, 21);
            this.CheckBox1.TabIndex = 81;
            this.CheckBox1.Text = "Enter A Zero Stock";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // TxtStockCode
            // 
            this.TxtStockCode.Location = new System.Drawing.Point(411, 91);
            this.TxtStockCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStockCode.Name = "TxtStockCode";
            this.TxtStockCode.Size = new System.Drawing.Size(148, 22);
            this.TxtStockCode.TabIndex = 43;
            // 
            // cmdDelToGrid
            // 
            this.cmdDelToGrid.Location = new System.Drawing.Point(1077, 123);
            this.cmdDelToGrid.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDelToGrid.Name = "cmdDelToGrid";
            this.cmdDelToGrid.Size = new System.Drawing.Size(112, 28);
            this.cmdDelToGrid.TabIndex = 47;
            this.cmdDelToGrid.Text = "Delete";
            this.cmdDelToGrid.UseVisualStyleBackColor = true;
            this.cmdDelToGrid.Click += new System.EventHandler(this.cmdDelToGrid_Click);
            // 
            // cmdAddToGrid
            // 
            this.cmdAddToGrid.Location = new System.Drawing.Point(956, 123);
            this.cmdAddToGrid.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAddToGrid.Name = "cmdAddToGrid";
            this.cmdAddToGrid.Size = new System.Drawing.Size(112, 28);
            this.cmdAddToGrid.TabIndex = 46;
            this.cmdAddToGrid.Text = "Add";
            this.cmdAddToGrid.UseVisualStyleBackColor = true;
            this.cmdAddToGrid.Click += new System.EventHandler(this.cmdAddToGrid_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(1075, 528);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(112, 28);
            this.cmdCancel.TabIndex = 50;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Location = new System.Drawing.Point(953, 528);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(112, 28);
            this.cmdOK.TabIndex = 49;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(701, 74);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(36, 17);
            this.Label20.TabIndex = 75;
            this.Label20.Text = "Sold";
            // 
            // txtSoldToDate
            // 
            this.txtSoldToDate.Location = new System.Drawing.Point(701, 91);
            this.txtSoldToDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoldToDate.Name = "txtSoldToDate";
            this.txtSoldToDate.Size = new System.Drawing.Size(82, 22);
            this.txtSoldToDate.TabIndex = 74;
            this.txtSoldToDate.TabStop = false;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(579, 71);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(68, 17);
            this.Label19.TabIndex = 77;
            this.Label19.Text = "Delivered";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(805, 74);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(81, 17);
            this.Label18.TabIndex = 72;
            this.Label18.Text = "Current Qty";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Location = new System.Drawing.Point(805, 91);
            this.txtCurrentQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.Size = new System.Drawing.Size(128, 22);
            this.txtCurrentQty.TabIndex = 73;
            this.txtCurrentQty.TabStop = false;
            // 
            // txtDelivered
            // 
            this.txtDelivered.Location = new System.Drawing.Point(571, 91);
            this.txtDelivered.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelivered.Name = "txtDelivered";
            this.txtDelivered.Size = new System.Drawing.Size(110, 22);
            this.txtDelivered.TabIndex = 76;
            this.txtDelivered.TabStop = false;
            // 
            // lblShopName
            // 
            this.lblShopName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShopName.Location = new System.Drawing.Point(651, 22);
            this.lblShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(336, 30);
            this.lblShopName.TabIndex = 80;
            // 
            // txtNetSale
            // 
            this.txtNetSale.Location = new System.Drawing.Point(1082, 91);
            this.txtNetSale.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetSale.Name = "txtNetSale";
            this.txtNetSale.Size = new System.Drawing.Size(136, 22);
            this.txtNetSale.TabIndex = 45;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(949, 91);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(122, 22);
            this.txtQty.TabIndex = 44;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(1082, 74);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(66, 17);
            this.Label14.TabIndex = 70;
            this.Label14.Text = "Net Sale:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(949, 74);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(61, 17);
            this.Label13.TabIndex = 71;
            this.Label13.Text = "Quantity";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(301, 284);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(20, 17);
            this.Label15.TabIndex = 59;
            this.Label15.Text = "%";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(363, 159);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.Size = new System.Drawing.Size(831, 329);
            this.DataGridView1.TabIndex = 48;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(173, 66);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.DateTimePicker1.TabIndex = 41;
            // 
            // txtTotalDelivered
            // 
            this.txtTotalDelivered.Enabled = false;
            this.txtTotalDelivered.Location = new System.Drawing.Point(522, 496);
            this.txtTotalDelivered.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDelivered.Name = "txtTotalDelivered";
            this.txtTotalDelivered.Size = new System.Drawing.Size(88, 22);
            this.txtTotalDelivered.TabIndex = 67;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(417, 71);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(84, 17);
            this.Label12.TabIndex = 78;
            this.Label12.Text = "Stock Code:";
            // 
            // txtTotalSold
            // 
            this.txtTotalSold.Enabled = false;
            this.txtTotalSold.Location = new System.Drawing.Point(651, 496);
            this.txtTotalSold.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSold.Name = "txtTotalSold";
            this.txtTotalSold.Size = new System.Drawing.Size(95, 22);
            this.txtTotalSold.TabIndex = 69;
            // 
            // txtTotalCurrQty
            // 
            this.txtTotalCurrQty.Enabled = false;
            this.txtTotalCurrQty.Location = new System.Drawing.Point(770, 496);
            this.txtTotalCurrQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCurrQty.Name = "txtTotalCurrQty";
            this.txtTotalCurrQty.Size = new System.Drawing.Size(89, 22);
            this.txtTotalCurrQty.TabIndex = 68;
            // 
            // txtShopRef
            // 
            this.txtShopRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtShopRef.Location = new System.Drawing.Point(483, 22);
            this.txtShopRef.Margin = new System.Windows.Forms.Padding(4);
            this.txtShopRef.Name = "txtShopRef";
            this.txtShopRef.Size = new System.Drawing.Size(84, 22);
            this.txtShopRef.TabIndex = 42;
            // 
            // txtTotalGarments
            // 
            this.txtTotalGarments.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalGarments.Location = new System.Drawing.Point(173, 377);
            this.txtTotalGarments.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalGarments.Name = "txtTotalGarments";
            this.txtTotalGarments.Size = new System.Drawing.Size(148, 22);
            this.txtTotalGarments.TabIndex = 64;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(417, 496);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(51, 17);
            this.Label11.TabIndex = 66;
            this.Label11.Text = "Totals:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotal.Location = new System.Drawing.Point(173, 345);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 22);
            this.txtTotal.TabIndex = 63;
            this.txtTotal.TabStop = false;
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVAT.Location = new System.Drawing.Point(173, 313);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(148, 22);
            this.txtVAT.TabIndex = 60;
            this.txtVAT.TabStop = false;
            // 
            // txtNet
            // 
            this.txtNet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNet.Location = new System.Drawing.Point(173, 249);
            this.txtNet.Margin = new System.Windows.Forms.Padding(4);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(148, 22);
            this.txtNet.TabIndex = 57;
            this.txtNet.TabStop = false;
            // 
            // txtVATRate
            // 
            this.txtVATRate.Location = new System.Drawing.Point(173, 281);
            this.txtVATRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.Size = new System.Drawing.Size(116, 22);
            this.txtVATRate.TabIndex = 53;
            // 
            // txtSalesID
            // 
            this.txtSalesID.BackColor = System.Drawing.Color.White;
            this.txtSalesID.Location = new System.Drawing.Point(173, 22);
            this.txtSalesID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(148, 22);
            this.txtSalesID.TabIndex = 51;
            this.txtSalesID.TabStop = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Fuchsia;
            this.Label10.Location = new System.Drawing.Point(387, 32);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 17);
            this.Label10.TabIndex = 79;
            this.Label10.Text = "Shop Ref:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(41, 380);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(110, 17);
            this.Label9.TabIndex = 65;
            this.Label9.Text = "Total Garments:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(107, 348);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(44, 17);
            this.Label8.TabIndex = 62;
            this.Label8.Text = "Total:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(111, 316);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 17);
            this.Label7.TabIndex = 61;
            this.Label7.Text = "VAT:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(117, 252);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(34, 17);
            this.Label6.TabIndex = 56;
            this.Label6.Text = "Net:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(87, 220);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(140, 25);
            this.Label5.TabIndex = 55;
            this.Label5.Text = "Sales Totals:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(73, 284);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 58;
            this.Label4.Text = "VAT Rate:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 74);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(121, 17);
            this.Label2.TabIndex = 54;
            this.Label2.Text = "Transaction Date:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(41, 31);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 17);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "Sales ID:";
            // 
            // frmShopSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 740);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.TxtStockCode);
            this.Controls.Add(this.cmdDelToGrid);
            this.Controls.Add(this.cmdAddToGrid);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.txtSoldToDate);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.txtCurrentQty);
            this.Controls.Add(this.txtDelivered);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.txtNetSale);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtTotalDelivered);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtTotalSold);
            this.Controls.Add(this.txtTotalCurrQty);
            this.Controls.Add(this.txtShopRef);
            this.Controls.Add(this.txtTotalGarments);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtVATRate);
            this.Controls.Add(this.txtSalesID);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmShopSale";
            this.Text = "frmShopSale";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.TextBox TxtStockCode;
        internal System.Windows.Forms.Button cmdDelToGrid;
        internal System.Windows.Forms.Button cmdAddToGrid;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox txtSoldToDate;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox txtCurrentQty;
        internal System.Windows.Forms.TextBox txtDelivered;
        internal System.Windows.Forms.Label lblShopName;
        internal System.Windows.Forms.TextBox txtNetSale;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox txtTotalDelivered;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtTotalSold;
        internal System.Windows.Forms.TextBox txtTotalCurrQty;
        internal System.Windows.Forms.TextBox txtShopRef;
        internal System.Windows.Forms.TextBox txtTotalGarments;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtVAT;
        internal System.Windows.Forms.TextBox txtNet;
        internal System.Windows.Forms.TextBox txtVATRate;
        internal System.Windows.Forms.TextBox txtSalesID;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}