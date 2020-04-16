namespace DMHV2
{
    partial class frmShopDelivery
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.DgvRecords = new System.Windows.Forms.DataGridView();
            this.StockCodeDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GarmentsDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Deliverlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label8 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdClearForm = new System.Windows.Forms.Button();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtWarehouseRef = new System.Windows.Forms.TextBox();
            this.cmdAddItem = new System.Windows.Forms.Button();
            this.txtQtyHangers = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtShopRef = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotalGarments = new System.Windows.Forms.TextBox();
            this.txtDelNoteNumber = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Red;
            this.txtQty.Location = new System.Drawing.Point(181, 291);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(115, 26);
            this.txtQty.TabIndex = 14;
            // 
            // DgvRecords
            // 
            this.DgvRecords.AllowUserToAddRows = false;
            this.DgvRecords.AllowUserToDeleteRows = false;
            this.DgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCodeDG,
            this.GarmentsDG,
            this.ValueCol});
            this.DgvRecords.Location = new System.Drawing.Point(20, 376);
            this.DgvRecords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.RowHeadersWidth = 51;
            this.DgvRecords.Size = new System.Drawing.Size(460, 205);
            this.DgvRecords.TabIndex = 25;
            // 
            // StockCodeDG
            // 
            this.StockCodeDG.HeaderText = "Stock Code";
            this.StockCodeDG.MinimumWidth = 6;
            this.StockCodeDG.Name = "StockCodeDG";
            // 
            // GarmentsDG
            // 
            this.GarmentsDG.HeaderText = "Garments";
            this.GarmentsDG.MinimumWidth = 6;
            this.GarmentsDG.Name = "GarmentsDG";
            // 
            // ValueCol
            // 
            this.ValueCol.HeaderText = "Value";
            this.ValueCol.MinimumWidth = 6;
            this.ValueCol.Name = "ValueCol";
            this.ValueCol.Visible = false;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(123, 20);
            this.ToolStripStatusLabel1.Text = "Delivery Lines :    ";
            // 
            // Deliverlabel
            // 
            this.Deliverlabel.Name = "Deliverlabel";
            this.Deliverlabel.Size = new System.Drawing.Size(153, 20);
            this.Deliverlabel.Text = "ToolStripStatusLabel2";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(22, 292);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(150, 25);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Warehouse Qty";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.Deliverlabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 712);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 24, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(509, 26);
            this.StatusStrip1.TabIndex = 29;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label21.Location = new System.Drawing.Point(57, 251);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(115, 25);
            this.Label21.TabIndex = 17;
            this.Label21.Text = "Stock Code";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label22.Location = new System.Drawing.Point(54, 331);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(118, 25);
            this.Label22.TabIndex = 15;
            this.Label22.Text = "Delivery Qty";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(357, 331);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(40, 35);
            this.cmdClear.TabIndex = 7;
            this.cmdClear.Text = "-";
            this.cmdClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdClearForm
            // 
            this.cmdClearForm.Location = new System.Drawing.Point(365, 655);
            this.cmdClearForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClearForm.Name = "cmdClearForm";
            this.cmdClearForm.Size = new System.Drawing.Size(126, 35);
            this.cmdClearForm.TabIndex = 10;
            this.cmdClearForm.Text = "Clear";
            this.cmdClearForm.UseVisualStyleBackColor = true;
            this.cmdClearForm.Click += new System.EventHandler(this.cmdClearForm_Click);
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(181, 251);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStockCode.MaxLength = 30;
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(168, 30);
            this.txtStockCode.TabIndex = 4;
            this.txtStockCode.Leave += new System.EventHandler(this.txtStockCode_Leave);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label16.Location = new System.Drawing.Point(73, 95);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(99, 25);
            this.Label16.TabIndex = 21;
            this.Label16.Text = "Shop Ref:";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(50, 129);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(122, 25);
            this.Label17.TabIndex = 20;
            this.Label17.Text = "Shop Name:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(97, 656);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(126, 35);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtWarehouseRef
            // 
            this.txtWarehouseRef.Location = new System.Drawing.Point(181, 169);
            this.txtWarehouseRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWarehouseRef.Name = "txtWarehouseRef";
            this.txtWarehouseRef.Size = new System.Drawing.Size(94, 30);
            this.txtWarehouseRef.TabIndex = 3;
            this.txtWarehouseRef.Leave += new System.EventHandler(this.txtWarehouseRef_Leave);
            // 
            // cmdAddItem
            // 
            this.cmdAddItem.Location = new System.Drawing.Point(309, 329);
            this.cmdAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdAddItem.Name = "cmdAddItem";
            this.cmdAddItem.Size = new System.Drawing.Size(40, 35);
            this.cmdAddItem.TabIndex = 6;
            this.cmdAddItem.Text = "+";
            this.cmdAddItem.UseVisualStyleBackColor = true;
            this.cmdAddItem.Click += new System.EventHandler(this.cmdAddItem_Click);
            // 
            // txtQtyHangers
            // 
            this.txtQtyHangers.Location = new System.Drawing.Point(180, 331);
            this.txtQtyHangers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQtyHangers.Name = "txtQtyHangers";
            this.txtQtyHangers.Size = new System.Drawing.Size(115, 30);
            this.txtQtyHangers.TabIndex = 5;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(231, 656);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(126, 35);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(181, 9);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(192, 30);
            this.DateTimePicker1.TabIndex = 0;
            // 
            // txtShopRef
            // 
            this.txtShopRef.Location = new System.Drawing.Point(180, 89);
            this.txtShopRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShopRef.MaxLength = 8;
            this.txtShopRef.Name = "txtShopRef";
            this.txtShopRef.Size = new System.Drawing.Size(91, 30);
            this.txtShopRef.TabIndex = 2;
            this.txtShopRef.Leave += new System.EventHandler(this.txtShopRef_Leave);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Red;
            this.Label4.Location = new System.Drawing.Point(185, 586);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(152, 25);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Delivery Total:";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(181, 129);
            this.txtShopName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(299, 30);
            this.txtShopName.TabIndex = 12;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label18.Location = new System.Drawing.Point(18, 172);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(154, 25);
            this.Label18.TabIndex = 19;
            this.Label18.Text = "Warehouse Ref:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 50);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(164, 25);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Delivery Note No:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label2.Location = new System.Drawing.Point(38, 9);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 25);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Delivery Date:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(-5, 212);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(177, 25);
            this.Label20.TabIndex = 18;
            this.Label20.Text = "Warehouse Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(381, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 25);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Record No:";
            // 
            // txtTotalGarments
            // 
            this.txtTotalGarments.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalGarments.Location = new System.Drawing.Point(298, 616);
            this.txtTotalGarments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalGarments.Name = "txtTotalGarments";
            this.txtTotalGarments.Size = new System.Drawing.Size(166, 30);
            this.txtTotalGarments.TabIndex = 28;
            // 
            // txtDelNoteNumber
            // 
            this.txtDelNoteNumber.Location = new System.Drawing.Point(386, 39);
            this.txtDelNoteNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelNoteNumber.Name = "txtDelNoteNumber";
            this.txtDelNoteNumber.Size = new System.Drawing.Size(94, 30);
            this.txtDelNoteNumber.TabIndex = 11;
            // 
            // txtReference
            // 
            this.txtReference.BackColor = System.Drawing.SystemColors.Window;
            this.txtReference.Location = new System.Drawing.Point(181, 49);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReference.MaxLength = 90;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(166, 30);
            this.txtReference.TabIndex = 1;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(181, 209);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(283, 30);
            this.txtWarehouseName.TabIndex = 13;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(87, 611);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(152, 25);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Total Garments:";
            // 
            // frmShopDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 738);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.DgvRecords);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdClearForm);
            this.Controls.Add(this.txtStockCode);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtWarehouseRef);
            this.Controls.Add(this.cmdAddItem);
            this.Controls.Add(this.txtQtyHangers);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtShopRef);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtTotalGarments);
            this.Controls.Add(this.txtDelNoteNumber);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.Label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmShopDelivery";
            this.Text = "frmShopDelivery";
            this.Load += new System.EventHandler(this.frmShopDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.DataGridView DgvRecords;
        internal System.Windows.Forms.DataGridViewTextBoxColumn StockCodeDG;
        internal System.Windows.Forms.DataGridViewTextBoxColumn GarmentsDG;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ValueCol;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel Deliverlabel;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Button cmdClearForm;
        internal System.Windows.Forms.TextBox txtStockCode;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.TextBox txtWarehouseRef;
        internal System.Windows.Forms.Button cmdAddItem;
        internal System.Windows.Forms.TextBox txtQtyHangers;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.TextBox txtShopRef;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtShopName;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotalGarments;
        internal System.Windows.Forms.TextBox txtDelNoteNumber;
        internal System.Windows.Forms.TextBox txtReference;
        internal System.Windows.Forms.TextBox txtWarehouseName;
        internal System.Windows.Forms.Label Label5;
    }
}