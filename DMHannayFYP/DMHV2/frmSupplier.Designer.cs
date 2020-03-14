namespace DMHV2
{
    partial class frmSupplier
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
            this.TxtMemo = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtWebsiteAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEmailAddress = new System.Windows.Forms.TextBox();
            this.TxtFaxNumber = new System.Windows.Forms.TextBox();
            this.TxtTelephoneNumber1 = new System.Windows.Forms.TextBox();
            this.TxtPostCode = new System.Windows.Forms.TextBox();
            this.TxtAddressLine4 = new System.Windows.Forms.TextBox();
            this.TxtAddressLine3 = new System.Windows.Forms.TextBox();
            this.TxtAddressLine2 = new System.Windows.Forms.TextBox();
            this.TxtAddressLine1 = new System.Windows.Forms.TextBox();
            this.TxtContactName = new System.Windows.Forms.TextBox();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.TxtSupplierRef = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridTrans = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdOK = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMemo
            // 
            this.TxtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMemo.Location = new System.Drawing.Point(3, 2);
            this.TxtMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMemo.Multiline = true;
            this.TxtMemo.Name = "TxtMemo";
            this.TxtMemo.Size = new System.Drawing.Size(542, 305);
            this.TxtMemo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtWebsiteAddress);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.TxtEmailAddress);
            this.tabPage1.Controls.Add(this.TxtFaxNumber);
            this.tabPage1.Controls.Add(this.TxtTelephoneNumber1);
            this.tabPage1.Controls.Add(this.TxtPostCode);
            this.tabPage1.Controls.Add(this.TxtAddressLine4);
            this.tabPage1.Controls.Add(this.TxtAddressLine3);
            this.tabPage1.Controls.Add(this.TxtAddressLine2);
            this.tabPage1.Controls.Add(this.TxtAddressLine1);
            this.tabPage1.Controls.Add(this.TxtContactName);
            this.tabPage1.Controls.Add(this.TxtSupplierName);
            this.tabPage1.Controls.Add(this.TxtSupplierRef);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.Label10);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.Label9);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.Label5);
            this.tabPage1.Controls.Add(this.Label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(548, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtWebsiteAddress
            // 
            this.TxtWebsiteAddress.Location = new System.Drawing.Point(140, 274);
            this.TxtWebsiteAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtWebsiteAddress.MaxLength = 255;
            this.TxtWebsiteAddress.Name = "TxtWebsiteAddress";
            this.TxtWebsiteAddress.Size = new System.Drawing.Size(361, 22);
            this.TxtWebsiteAddress.TabIndex = 47;
            this.TxtWebsiteAddress.Leave += new System.EventHandler(this.TxtWebsiteAddress_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "WebSite:";
            // 
            // TxtEmailAddress
            // 
            this.TxtEmailAddress.Location = new System.Drawing.Point(142, 232);
            this.TxtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmailAddress.MaxLength = 255;
            this.TxtEmailAddress.Name = "TxtEmailAddress";
            this.TxtEmailAddress.Size = new System.Drawing.Size(361, 22);
            this.TxtEmailAddress.TabIndex = 45;
            this.TxtEmailAddress.Leave += new System.EventHandler(this.TxtEmailAddress_Leave);
            // 
            // TxtFaxNumber
            // 
            this.TxtFaxNumber.Location = new System.Drawing.Point(348, 206);
            this.TxtFaxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFaxNumber.MaxLength = 20;
            this.TxtFaxNumber.Name = "TxtFaxNumber";
            this.TxtFaxNumber.Size = new System.Drawing.Size(154, 22);
            this.TxtFaxNumber.TabIndex = 43;
            // 
            // TxtTelephoneNumber1
            // 
            this.TxtTelephoneNumber1.Location = new System.Drawing.Point(142, 206);
            this.TxtTelephoneNumber1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelephoneNumber1.MaxLength = 20;
            this.TxtTelephoneNumber1.Name = "TxtTelephoneNumber1";
            this.TxtTelephoneNumber1.Size = new System.Drawing.Size(154, 22);
            this.TxtTelephoneNumber1.TabIndex = 42;
            // 
            // TxtPostCode
            // 
            this.TxtPostCode.Location = new System.Drawing.Point(142, 181);
            this.TxtPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPostCode.MaxLength = 11;
            this.TxtPostCode.Name = "TxtPostCode";
            this.TxtPostCode.Size = new System.Drawing.Size(89, 22);
            this.TxtPostCode.TabIndex = 41;
            this.TxtPostCode.Leave += new System.EventHandler(this.TxtPostCode_Leave);
            // 
            // TxtAddressLine4
            // 
            this.TxtAddressLine4.Location = new System.Drawing.Point(142, 155);
            this.TxtAddressLine4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddressLine4.MaxLength = 60;
            this.TxtAddressLine4.Name = "TxtAddressLine4";
            this.TxtAddressLine4.Size = new System.Drawing.Size(365, 22);
            this.TxtAddressLine4.TabIndex = 40;
            this.TxtAddressLine4.Leave += new System.EventHandler(this.TxtAddressLine4_Leave);
            // 
            // TxtAddressLine3
            // 
            this.TxtAddressLine3.Location = new System.Drawing.Point(142, 134);
            this.TxtAddressLine3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddressLine3.MaxLength = 60;
            this.TxtAddressLine3.Name = "TxtAddressLine3";
            this.TxtAddressLine3.Size = new System.Drawing.Size(365, 22);
            this.TxtAddressLine3.TabIndex = 39;
            this.TxtAddressLine3.Leave += new System.EventHandler(this.TxtAddressLine3_Leave);
            // 
            // TxtAddressLine2
            // 
            this.TxtAddressLine2.Location = new System.Drawing.Point(142, 109);
            this.TxtAddressLine2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddressLine2.MaxLength = 60;
            this.TxtAddressLine2.Name = "TxtAddressLine2";
            this.TxtAddressLine2.Size = new System.Drawing.Size(365, 22);
            this.TxtAddressLine2.TabIndex = 38;
            this.TxtAddressLine2.Leave += new System.EventHandler(this.TxtAddressLine2_Leave);
            // 
            // TxtAddressLine1
            // 
            this.TxtAddressLine1.Location = new System.Drawing.Point(142, 82);
            this.TxtAddressLine1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAddressLine1.MaxLength = 60;
            this.TxtAddressLine1.Name = "TxtAddressLine1";
            this.TxtAddressLine1.Size = new System.Drawing.Size(365, 22);
            this.TxtAddressLine1.TabIndex = 37;
            this.TxtAddressLine1.Leave += new System.EventHandler(this.TxtAddressLine1_Leave);
            // 
            // TxtContactName
            // 
            this.TxtContactName.Location = new System.Drawing.Point(142, 57);
            this.TxtContactName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtContactName.MaxLength = 60;
            this.TxtContactName.Name = "TxtContactName";
            this.TxtContactName.Size = new System.Drawing.Size(365, 22);
            this.TxtContactName.TabIndex = 36;
            this.TxtContactName.Leave += new System.EventHandler(this.TxtContactName_Leave);
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(142, 31);
            this.TxtSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSupplierName.MaxLength = 60;
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(365, 22);
            this.TxtSupplierName.TabIndex = 35;
            this.TxtSupplierName.Leave += new System.EventHandler(this.TxtSupplierName_Leave);
            // 
            // TxtSupplierRef
            // 
            this.TxtSupplierRef.Location = new System.Drawing.Point(142, 6);
            this.TxtSupplierRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSupplierRef.MaxLength = 8;
            this.TxtSupplierRef.Name = "TxtSupplierRef";
            this.TxtSupplierRef.Size = new System.Drawing.Size(120, 22);
            this.TxtSupplierRef.TabIndex = 34;
            this.TxtSupplierRef.Leave += new System.EventHandler(this.TxtSupplierRef_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(44, 6);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 17);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Supplier Ref:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(80, 237);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(46, 17);
            this.Label10.TabIndex = 33;
            this.Label10.Text = "EMail:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 32);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 17);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Supplier Name:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(303, 209);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(34, 17);
            this.Label9.TabIndex = 32;
            this.Label9.Text = "Fax:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(36, 58);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 17);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Contact Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(62, 86);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 17);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Address:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(116, 206);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(26, 17);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "(1)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(58, 187);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 17);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "Post Code:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(28, 206);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 17);
            this.Label6.TabIndex = 29;
            this.Label6.Text = "Telephone:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridTrans);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(548, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridTrans
            // 
            this.gridTrans.AllowUserToAddRows = false;
            this.gridTrans.AllowUserToDeleteRows = false;
            this.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTrans.Location = new System.Drawing.Point(3, 2);
            this.gridTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridTrans.Name = "gridTrans";
            this.gridTrans.ReadOnly = true;
            this.gridTrans.RowHeadersWidth = 62;
            this.gridTrans.Size = new System.Drawing.Size(542, 305);
            this.gridTrans.TabIndex = 34;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TxtMemo);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(548, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Memo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 338);
            this.tabControl1.TabIndex = 39;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(462, 352);
            this.CmdClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(100, 22);
            this.CmdClear.TabIndex = 38;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(355, 352);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(100, 22);
            this.CmdCancel.TabIndex = 37;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdOK
            // 
            this.CmdOK.Location = new System.Drawing.Point(247, 352);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(100, 22);
            this.CmdOK.TabIndex = 36;
            this.CmdOK.Text = "Button1";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 388);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSupplier";
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMemo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TxtWebsiteAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtEmailAddress;
        private System.Windows.Forms.TextBox TxtFaxNumber;
        private System.Windows.Forms.TextBox TxtTelephoneNumber1;
        private System.Windows.Forms.TextBox TxtPostCode;
        private System.Windows.Forms.TextBox TxtAddressLine4;
        private System.Windows.Forms.TextBox TxtAddressLine3;
        private System.Windows.Forms.TextBox TxtAddressLine2;
        private System.Windows.Forms.TextBox TxtAddressLine1;
        private System.Windows.Forms.TextBox TxtContactName;
        private System.Windows.Forms.TextBox TxtSupplierName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.DataGridView gridTrans;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.Button CmdClear;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdOK;
        public System.Windows.Forms.TextBox TxtSupplierRef;
    }
}