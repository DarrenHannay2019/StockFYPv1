namespace DMHV2
{
    partial class frmShopReturn
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
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.DgvRecords = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.txtShopRef = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtWarehouseRef = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmdClearGrid = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtTransferQty = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(150, 52);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(439, 22);
            this.txtWarehouseName.TabIndex = 7;
            this.txtWarehouseName.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 87);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(92, 17);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Transfer Qty:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(146, 23);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(49, 17);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Name:";
            // 
            // DgvRecords
            // 
            this.DgvRecords.AllowUserToAddRows = false;
            this.DgvRecords.AllowUserToDeleteRows = false;
            this.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvRecords.Location = new System.Drawing.Point(15, 119);
            this.DgvRecords.Margin = new System.Windows.Forms.Padding(4);
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.RowHeadersWidth = 51;
            this.DgvRecords.Size = new System.Drawing.Size(380, 162);
            this.DgvRecords.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ReturnLineID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ReturnID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock Code";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Value";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // txtReturnID
            // 
            this.txtReturnID.Enabled = false;
            this.txtReturnID.Location = new System.Drawing.Point(126, 12);
            this.txtReturnID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.Size = new System.Drawing.Size(148, 22);
            this.txtReturnID.TabIndex = 14;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(42, 21);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(64, 17);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "ReturnID";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(342, 47);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(150, 21);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.Text = "Return To Supplier";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(284, 16);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(42, 17);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Date:";
            // 
            // DtpDate
            // 
            this.DtpDate.CustomFormat = "dd-MM-yyyy";
            this.DtpDate.Location = new System.Drawing.Point(342, 12);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(200, 22);
            this.DtpDate.TabIndex = 0;
            this.DtpDate.Value = new System.DateTime(2016, 2, 7, 0, 0, 0, 0);
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(342, 76);
            this.txtShopName.Margin = new System.Windows.Forms.Padding(4);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(274, 22);
            this.txtShopName.TabIndex = 12;
            this.txtShopName.TabStop = false;
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Location = new System.Drawing.Point(126, 140);
            this.txtCurrentQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.Size = new System.Drawing.Size(148, 22);
            this.txtCurrentQty.TabIndex = 5;
            // 
            // txtStockCode
            // 
            this.txtStockCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStockCode.Location = new System.Drawing.Point(126, 108);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockCode.MaxLength = 30;
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(148, 22);
            this.txtStockCode.TabIndex = 4;
            this.txtStockCode.Leave += new System.EventHandler(this.txtStockCode_Leave);
            // 
            // txtShopRef
            // 
            this.txtShopRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShopRef.Location = new System.Drawing.Point(126, 76);
            this.txtShopRef.Margin = new System.Windows.Forms.Padding(4);
            this.txtShopRef.MaxLength = 8;
            this.txtShopRef.Name = "txtShopRef";
            this.txtShopRef.Size = new System.Drawing.Size(148, 22);
            this.txtShopRef.TabIndex = 2;
            this.txtShopRef.Leave += new System.EventHandler(this.txtShopRef_Leave);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(126, 44);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(148, 22);
            this.txtReference.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(279, 80);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 17);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(22, 144);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 17);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Current Qty:";
            // 
            // txtWarehouseRef
            // 
            this.txtWarehouseRef.Location = new System.Drawing.Point(14, 52);
            this.txtWarehouseRef.Margin = new System.Windows.Forms.Padding(4);
            this.txtWarehouseRef.MaxLength = 8;
            this.txtWarehouseRef.Name = "txtWarehouseRef";
            this.txtWarehouseRef.Size = new System.Drawing.Size(92, 22);
            this.txtWarehouseRef.TabIndex = 6;
            this.txtWarehouseRef.Leave += new System.EventHandler(this.txtWarehouseRef_Leave);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(519, 516);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(112, 28);
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 112);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 17);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Stock Code:";
            // 
            // cmdClearGrid
            // 
            this.cmdClearGrid.Location = new System.Drawing.Point(430, 84);
            this.cmdClearGrid.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClearGrid.Name = "cmdClearGrid";
            this.cmdClearGrid.Size = new System.Drawing.Size(112, 28);
            this.cmdClearGrid.TabIndex = 2;
            this.cmdClearGrid.Text = "Delete All";
            this.cmdClearGrid.UseVisualStyleBackColor = true;
            this.cmdClearGrid.Click += new System.EventHandler(this.cmdClearGrid_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(309, 84);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(112, 28);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtTotalItems);
            this.GroupBox2.Controls.Add(this.cmdClearGrid);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.cmdAdd);
            this.GroupBox2.Controls.Add(this.txtTransferQty);
            this.GroupBox2.Controls.Add(this.txtWarehouseName);
            this.GroupBox2.Controls.Add(this.txtWarehouseRef);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.DgvRecords);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(13, 207);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(639, 302);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Return To:";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(408, 254);
            this.txtTotalItems.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(86, 22);
            this.txtTotalItems.TabIndex = 7;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(404, 234);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(81, 17);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "Total Items:";
            // 
            // txtTransferQty
            // 
            this.txtTransferQty.Location = new System.Drawing.Point(150, 84);
            this.txtTransferQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransferQty.Name = "txtTransferQty";
            this.txtTransferQty.Size = new System.Drawing.Size(148, 22);
            this.txtTransferQty.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 23);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(111, 17);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Warehouse Ref:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(34, 80);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 17);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Shop Ref:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(27, 48);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 17);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Reference:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(275, 516);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(112, 28);
            this.cmdOK.TabIndex = 7;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(397, 516);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(112, 28);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtReturnID);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.DtpDate);
            this.GroupBox1.Controls.Add(this.txtShopName);
            this.GroupBox1.Controls.Add(this.txtCurrentQty);
            this.GroupBox1.Controls.Add(this.txtStockCode);
            this.GroupBox1.Controls.Add(this.txtShopRef);
            this.GroupBox1.Controls.Add(this.txtReference);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(13, 25);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(639, 178);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Current";
            // 
            // frmShopReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 752);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmShopReturn";
            this.Text = "frmShopReturn";
            this.Load += new System.EventHandler(this.frmShopReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtWarehouseName;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView DgvRecords;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.TextBox txtReturnID;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.DateTimePicker DtpDate;
        internal System.Windows.Forms.TextBox txtShopName;
        internal System.Windows.Forms.TextBox txtCurrentQty;
        internal System.Windows.Forms.TextBox txtStockCode;
        internal System.Windows.Forms.TextBox txtShopRef;
        internal System.Windows.Forms.TextBox txtReference;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtWarehouseRef;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button cmdClearGrid;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtTotalItems;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtTransferQty;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}