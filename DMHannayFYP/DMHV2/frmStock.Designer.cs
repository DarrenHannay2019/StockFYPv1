namespace DMHV2
{
    partial class frmStock
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
            System.Windows.Forms.Label StockCodeLabel;
            System.Windows.Forms.Label SupplierRefLabel;
            System.Windows.Forms.Label DeadCodeLabel;
            System.Windows.Forms.Label AmountTakenLabel;
            System.Windows.Forms.Label CostValueLabel;
            System.Windows.Forms.Label PCMarkUpLabel;
            this.gridTrans = new System.Windows.Forms.DataGridView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TxtCostValue = new System.Windows.Forms.TextBox();
            this.TxtAmountTaken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboSeason = new System.Windows.Forms.ComboBox();
            this.TxtSupplierRef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtStockCode = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdOK = new System.Windows.Forms.Button();
            this.DeadCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            StockCodeLabel = new System.Windows.Forms.Label();
            SupplierRefLabel = new System.Windows.Forms.Label();
            DeadCodeLabel = new System.Windows.Forms.Label();
            AmountTakenLabel = new System.Windows.Forms.Label();
            CostValueLabel = new System.Windows.Forms.Label();
            PCMarkUpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // StockCodeLabel
            // 
            StockCodeLabel.AutoSize = true;
            StockCodeLabel.Location = new System.Drawing.Point(71, 19);
            StockCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            StockCodeLabel.Name = "StockCodeLabel";
            StockCodeLabel.Size = new System.Drawing.Size(112, 24);
            StockCodeLabel.TabIndex = 47;
            StockCodeLabel.Text = "Stock Code:";
            // 
            // SupplierRefLabel
            // 
            SupplierRefLabel.AutoSize = true;
            SupplierRefLabel.Location = new System.Drawing.Point(64, 58);
            SupplierRefLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            SupplierRefLabel.Name = "SupplierRefLabel";
            SupplierRefLabel.Size = new System.Drawing.Size(118, 24);
            SupplierRefLabel.TabIndex = 48;
            SupplierRefLabel.Text = "Supplier Ref:";
            // 
            // DeadCodeLabel
            // 
            DeadCodeLabel.AutoSize = true;
            DeadCodeLabel.Location = new System.Drawing.Point(72, 131);
            DeadCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            DeadCodeLabel.Name = "DeadCodeLabel";
            DeadCodeLabel.Size = new System.Drawing.Size(111, 24);
            DeadCodeLabel.TabIndex = 49;
            DeadCodeLabel.Text = "Dead Code:";
            // 
            // AmountTakenLabel
            // 
            AmountTakenLabel.AutoSize = true;
            AmountTakenLabel.Location = new System.Drawing.Point(46, 209);
            AmountTakenLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            AmountTakenLabel.Name = "AmountTakenLabel";
            AmountTakenLabel.Size = new System.Drawing.Size(139, 24);
            AmountTakenLabel.TabIndex = 50;
            AmountTakenLabel.Text = "Amount Taken:";
            // 
            // CostValueLabel
            // 
            CostValueLabel.AutoSize = true;
            CostValueLabel.Location = new System.Drawing.Point(76, 170);
            CostValueLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            CostValueLabel.Name = "CostValueLabel";
            CostValueLabel.Size = new System.Drawing.Size(106, 24);
            CostValueLabel.TabIndex = 51;
            CostValueLabel.Text = "Cost Value:";
            // 
            // PCMarkUpLabel
            // 
            PCMarkUpLabel.AutoSize = true;
            PCMarkUpLabel.Location = new System.Drawing.Point(72, 245);
            PCMarkUpLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            PCMarkUpLabel.Name = "PCMarkUpLabel";
            PCMarkUpLabel.Size = new System.Drawing.Size(110, 24);
            PCMarkUpLabel.TabIndex = 52;
            PCMarkUpLabel.Text = "PCMark Up:";
            // 
            // gridTrans
            // 
            this.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrans.Location = new System.Drawing.Point(15, 305);
            this.gridTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridTrans.Name = "gridTrans";
            this.gridTrans.RowHeadersWidth = 62;
            this.gridTrans.Size = new System.Drawing.Size(548, 129);
            this.gridTrans.TabIndex = 68;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(451, 166);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 28);
            this.textBox8.TabIndex = 67;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(450, 236);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 28);
            this.textBox7.TabIndex = 66;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(451, 201);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 28);
            this.textBox6.TabIndex = 65;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(185, 238);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 28);
            this.textBox5.TabIndex = 64;
            // 
            // TxtCostValue
            // 
            this.TxtCostValue.Location = new System.Drawing.Point(185, 166);
            this.TxtCostValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCostValue.Name = "TxtCostValue";
            this.TxtCostValue.Size = new System.Drawing.Size(110, 28);
            this.TxtCostValue.TabIndex = 63;
            // 
            // TxtAmountTaken
            // 
            this.TxtAmountTaken.Location = new System.Drawing.Point(185, 202);
            this.TxtAmountTaken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAmountTaken.Name = "TxtAmountTaken";
            this.TxtAmountTaken.Size = new System.Drawing.Size(110, 28);
            this.TxtAmountTaken.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Items In Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Sold Qty:";
            // 
            // CboSeason
            // 
            this.CboSeason.FormattingEnabled = true;
            this.CboSeason.Location = new System.Drawing.Point(185, 87);
            this.CboSeason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboSeason.Name = "CboSeason";
            this.CboSeason.Size = new System.Drawing.Size(185, 30);
            this.CboSeason.TabIndex = 59;
            // 
            // TxtSupplierRef
            // 
            this.TxtSupplierRef.Location = new System.Drawing.Point(185, 51);
            this.TxtSupplierRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSupplierRef.Name = "TxtSupplierRef";
            this.TxtSupplierRef.Size = new System.Drawing.Size(162, 28);
            this.TxtSupplierRef.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Zero Qty:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(322, 132);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Delivered Qty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Season:";
            // 
            // TxtStockCode
            // 
            this.TxtStockCode.Location = new System.Drawing.Point(185, 15);
            this.TxtStockCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtStockCode.Name = "TxtStockCode";
            this.TxtStockCode.Size = new System.Drawing.Size(162, 28);
            this.TxtStockCode.TabIndex = 53;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(436, 441);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(125, 30);
            this.CmdCancel.TabIndex = 46;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdOK
            // 
            this.CmdOK.Location = new System.Drawing.Point(306, 441);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(125, 30);
            this.CmdOK.TabIndex = 45;
            this.CmdOK.Text = "Button1";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // DeadCodeCheckBox
            // 
            this.DeadCodeCheckBox.Location = new System.Drawing.Point(185, 126);
            this.DeadCodeCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeadCodeCheckBox.Name = "DeadCodeCheckBox";
            this.DeadCodeCheckBox.Size = new System.Drawing.Size(35, 33);
            this.DeadCodeCheckBox.TabIndex = 44;
            this.DeadCodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Location Stock Levels";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridTrans);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TxtCostValue);
            this.Controls.Add(this.TxtAmountTaken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboSeason);
            this.Controls.Add(this.TxtSupplierRef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtStockCode);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdOK);
            this.Controls.Add(StockCodeLabel);
            this.Controls.Add(SupplierRefLabel);
            this.Controls.Add(DeadCodeLabel);
            this.Controls.Add(this.DeadCodeCheckBox);
            this.Controls.Add(AmountTakenLabel);
            this.Controls.Add(CostValueLabel);
            this.Controls.Add(PCMarkUpLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTrans;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TxtCostValue;
        private System.Windows.Forms.TextBox TxtAmountTaken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboSeason;
        private System.Windows.Forms.TextBox TxtSupplierRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtStockCode;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdOK;
        internal System.Windows.Forms.CheckBox DeadCodeCheckBox;
        private System.Windows.Forms.Label label6;
    }
}