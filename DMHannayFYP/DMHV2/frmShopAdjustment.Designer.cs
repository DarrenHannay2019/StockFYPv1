namespace DMHV2
{
    partial class frmShopAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtSID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtTotalLoss = new System.Windows.Forms.TextBox();
            this.txtTotalGain = new System.Windows.Forms.TextBox();
            this.UnitPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.stockCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromShopRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransFromQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransToQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdDeleteFromGrid = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtAdjustHangers = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.CmdAddToGrid = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.CmdOK = new System.Windows.Forms.Button();
            this.txtCurrentHangers = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.txtWarehouseRef = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSID
            // 
            this.TxtSID.Location = new System.Drawing.Point(458, 11);
            this.TxtSID.Name = "TxtSID";
            this.TxtSID.Size = new System.Drawing.Size(110, 20);
            this.TxtSID.TabIndex = 45;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(320, 11);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(138, 18);
            this.Label11.TabIndex = 44;
            this.Label11.Text = "Shop Adjustment ID";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(341, 415);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(76, 18);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "Total Gain";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(435, 415);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 18);
            this.Label6.TabIndex = 55;
            this.Label6.Text = "Total Loss";
            // 
            // txtTotalLoss
            // 
            this.txtTotalLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLoss.Location = new System.Drawing.Point(440, 439);
            this.txtTotalLoss.Name = "txtTotalLoss";
            this.txtTotalLoss.Size = new System.Drawing.Size(54, 24);
            this.txtTotalLoss.TabIndex = 54;
            // 
            // txtTotalGain
            // 
            this.txtTotalGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGain.Location = new System.Drawing.Point(345, 439);
            this.txtTotalGain.Name = "txtTotalGain";
            this.txtTotalGain.Size = new System.Drawing.Size(65, 24);
            this.txtTotalGain.TabIndex = 53;
            // 
            // UnitPrices
            // 
            this.UnitPrices.HeaderText = "UnitPrices";
            this.UnitPrices.MinimumWidth = 6;
            this.UnitPrices.Name = "UnitPrices";
            this.UnitPrices.Visible = false;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeCol,
            this.FromShopRef,
            this.CurrentQty,
            this.TransFromQty,
            this.TransToQty,
            this.MovementDate,
            this.UnitPrices});
            this.dgvItems.Location = new System.Drawing.Point(43, 220);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(533, 192);
            this.dgvItems.TabIndex = 39;
            // 
            // stockCodeCol
            // 
            this.stockCodeCol.HeaderText = "Stock Code";
            this.stockCodeCol.MinimumWidth = 6;
            this.stockCodeCol.Name = "stockCodeCol";
            // 
            // FromShopRef
            // 
            this.FromShopRef.HeaderText = "From Shop";
            this.FromShopRef.MinimumWidth = 6;
            this.FromShopRef.Name = "FromShopRef";
            this.FromShopRef.Visible = false;
            // 
            // CurrentQty
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.CurrentQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.CurrentQty.HeaderText = "Current Qty";
            this.CurrentQty.MinimumWidth = 6;
            this.CurrentQty.Name = "CurrentQty";
            // 
            // TransFromQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.TransFromQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.TransFromQty.HeaderText = "Adjustment Type";
            this.TransFromQty.MinimumWidth = 6;
            this.TransFromQty.Name = "TransFromQty";
            // 
            // TransToQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.TransToQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.TransToQty.HeaderText = "Adjustment Qty";
            this.TransToQty.MinimumWidth = 6;
            this.TransToQty.Name = "TransToQty";
            // 
            // MovementDate
            // 
            this.MovementDate.HeaderText = "Movement Date";
            this.MovementDate.MinimumWidth = 6;
            this.MovementDate.Name = "MovementDate";
            this.MovementDate.Visible = false;
            // 
            // CmdDeleteFromGrid
            // 
            this.CmdDeleteFromGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDeleteFromGrid.Location = new System.Drawing.Point(523, 168);
            this.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid";
            this.CmdDeleteFromGrid.Size = new System.Drawing.Size(28, 33);
            this.CmdDeleteFromGrid.TabIndex = 35;
            this.CmdDeleteFromGrid.Text = "-";
            this.CmdDeleteFromGrid.UseVisualStyleBackColor = true;
            this.CmdDeleteFromGrid.Click += new System.EventHandler(this.CmdDeleteFromGrid_Click);
            // 
            // cboType
            // 
            this.cboType.AutoCompleteCustomSource.AddRange(new string[] {
            "Gain",
            "Loss"});
            this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Loss",
            "Gain"});
            this.cboType.Location = new System.Drawing.Point(252, 178);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(134, 26);
            this.cboType.TabIndex = 32;
            // 
            // txtAdjustHangers
            // 
            this.txtAdjustHangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustHangers.Location = new System.Drawing.Point(404, 178);
            this.txtAdjustHangers.Name = "txtAdjustHangers";
            this.txtAdjustHangers.Size = new System.Drawing.Size(60, 24);
            this.txtAdjustHangers.TabIndex = 33;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(391, 146);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(112, 18);
            this.Label8.TabIndex = 43;
            this.Label8.Text = "Adjustment Qty:";
            // 
            // CmdAddToGrid
            // 
            this.CmdAddToGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddToGrid.Location = new System.Drawing.Point(488, 169);
            this.CmdAddToGrid.Name = "CmdAddToGrid";
            this.CmdAddToGrid.Size = new System.Drawing.Size(28, 34);
            this.CmdAddToGrid.TabIndex = 34;
            this.CmdAddToGrid.Text = "+";
            this.CmdAddToGrid.UseVisualStyleBackColor = true;
            this.CmdAddToGrid.Click += new System.EventHandler(this.CmdAddToGrid_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(248, 146);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(121, 18);
            this.Label7.TabIndex = 42;
            this.Label7.Text = "Adjustment Type:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(40, 108);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(91, 18);
            this.Label5.TabIndex = 50;
            this.Label5.Text = "Shop Name:";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Enabled = false;
            this.txtWarehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseName.Location = new System.Drawing.Point(133, 105);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(138, 24);
            this.txtWarehouseName.TabIndex = 51;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(133, 3);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(164, 24);
            this.DateTimePicker1.TabIndex = 28;
            this.DateTimePicker1.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(10, 7);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(125, 18);
            this.Label10.TabIndex = 46;
            this.Label10.Text = "Transaction Date:";
            // 
            // CmdOK
            // 
            this.CmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdOK.Location = new System.Drawing.Point(345, 470);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(65, 33);
            this.CmdOK.TabIndex = 36;
            this.CmdOK.Text = "Add";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // txtCurrentHangers
            // 
            this.txtCurrentHangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHangers.Location = new System.Drawing.Point(148, 178);
            this.txtCurrentHangers.Name = "txtCurrentHangers";
            this.txtCurrentHangers.Size = new System.Drawing.Size(99, 24);
            this.txtCurrentHangers.TabIndex = 40;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdCancel.Location = new System.Drawing.Point(488, 470);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(88, 33);
            this.CmdCancel.TabIndex = 38;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdClear.Location = new System.Drawing.Point(416, 470);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(65, 33);
            this.CmdClear.TabIndex = 37;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // txtWarehouseRef
            // 
            this.txtWarehouseRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseRef.Location = new System.Drawing.Point(133, 67);
            this.txtWarehouseRef.MaxLength = 8;
            this.txtWarehouseRef.Name = "txtWarehouseRef";
            this.txtWarehouseRef.Size = new System.Drawing.Size(58, 24);
            this.txtWarehouseRef.TabIndex = 30;
            this.txtWarehouseRef.Leave += new System.EventHandler(this.txtWarehouseRef_Leave);
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(133, 38);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(122, 24);
            this.txtReference.TabIndex = 29;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(50, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 18);
            this.Label1.TabIndex = 49;
            this.Label1.Text = "Reference:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(57, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 18);
            this.Label2.TabIndex = 47;
            this.Label2.Text = "Shop Ref:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(144, 146);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 18);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Current Qty:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(43, 146);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 18);
            this.Label3.TabIndex = 48;
            this.Label3.Text = "Stock Code:";
            // 
            // txtStockCode
            // 
            this.txtStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCode.Location = new System.Drawing.Point(45, 178);
            this.txtStockCode.MaxLength = 30;
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(98, 24);
            this.txtStockCode.TabIndex = 31;
            this.txtStockCode.Leave += new System.EventHandler(this.txtStockCode_Leave);
            // 
            // frmShopAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 515);
            this.Controls.Add(this.TxtSID);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtTotalLoss);
            this.Controls.Add(this.txtTotalGain);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.CmdDeleteFromGrid);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtAdjustHangers);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.CmdAddToGrid);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.CmdOK);
            this.Controls.Add(this.txtCurrentHangers);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.txtWarehouseRef);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtStockCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmShopAdjustment";
            this.Text = "frmShopAdjustment";
            this.Load += new System.EventHandler(this.frmShopAdjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtSID;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtTotalLoss;
        internal System.Windows.Forms.TextBox txtTotalGain;
        internal System.Windows.Forms.DataGridViewTextBoxColumn UnitPrices;
        internal System.Windows.Forms.DataGridView dgvItems;
        internal System.Windows.Forms.DataGridViewTextBoxColumn stockCodeCol;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FromShopRef;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CurrentQty;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TransFromQty;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TransToQty;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MovementDate;
        internal System.Windows.Forms.Button CmdDeleteFromGrid;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.TextBox txtAdjustHangers;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button CmdAddToGrid;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtWarehouseName;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button CmdOK;
        internal System.Windows.Forms.TextBox txtCurrentHangers;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdClear;
        internal System.Windows.Forms.TextBox txtWarehouseRef;
        internal System.Windows.Forms.TextBox txtReference;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtStockCode;
    }
}