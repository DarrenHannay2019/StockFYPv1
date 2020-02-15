namespace DMHV2
{
    partial class FrmWarehouse
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.CmdOK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTotalValue = new System.Windows.Forms.Label();
            this.TxtTotalStock = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.gridTrans = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboWType = new System.Windows.Forms.ComboBox();
            this.TxteMail = new System.Windows.Forms.TextBox();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.TxtTelephone1 = new System.Windows.Forms.TextBox();
            this.TxtPostCode = new System.Windows.Forms.TextBox();
            this.TxtAddress4 = new System.Windows.Forms.TextBox();
            this.TxtAddress3 = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TxtContactName = new System.Windows.Forms.TextBox();
            this.TxtWarehouseName = new System.Windows.Forms.TextBox();
            this.TxtWarehouseRef = new System.Windows.Forms.TextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.TxtMemo = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOK
            // 
            this.CmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdOK.Location = new System.Drawing.Point(329, 406);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(100, 22);
            this.CmdOK.TabIndex = 13;
            this.CmdOK.Text = "Button1";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "0";
            // 
            // TxtTotalValue
            // 
            this.TxtTotalValue.AutoSize = true;
            this.TxtTotalValue.Location = new System.Drawing.Point(473, 331);
            this.TxtTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtTotalValue.Name = "TxtTotalValue";
            this.TxtTotalValue.Size = new System.Drawing.Size(48, 17);
            this.TxtTotalValue.TabIndex = 5;
            this.TxtTotalValue.Text = "£0000";
            // 
            // TxtTotalStock
            // 
            this.TxtTotalStock.AutoSize = true;
            this.TxtTotalStock.Location = new System.Drawing.Point(328, 331);
            this.TxtTotalStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtTotalStock.Name = "TxtTotalStock";
            this.TxtTotalStock.Size = new System.Drawing.Size(16, 17);
            this.TxtTotalStock.TabIndex = 4;
            this.TxtTotalStock.Text = "0";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(185, 331);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(51, 17);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "Totals:";
            // 
            // gridStock
            // 
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridStock.Location = new System.Drawing.Point(4, 3);
            this.gridStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.RowHeadersWidth = 62;
            this.gridStock.Size = new System.Drawing.Size(611, 325);
            this.gridStock.TabIndex = 0;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.label9);
            this.TabPage3.Controls.Add(this.TxtTotalValue);
            this.TabPage3.Controls.Add(this.TxtTotalStock);
            this.TabPage3.Controls.Add(this.Label12);
            this.TabPage3.Controls.Add(this.gridStock);
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage3.Size = new System.Drawing.Size(619, 345);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Stock";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // gridTrans
            // 
            this.gridTrans.AllowUserToAddRows = false;
            this.gridTrans.AllowUserToDeleteRows = false;
            this.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTrans.Location = new System.Drawing.Point(4, 3);
            this.gridTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridTrans.Name = "gridTrans";
            this.gridTrans.ReadOnly = true;
            this.gridTrans.RowHeadersVisible = false;
            this.gridTrans.RowHeadersWidth = 62;
            this.gridTrans.Size = new System.Drawing.Size(611, 339);
            this.gridTrans.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.gridTrans);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage2.Size = new System.Drawing.Size(619, 345);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Transactions";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClear.Location = new System.Drawing.Point(545, 406);
            this.CmdClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(100, 22);
            this.CmdClear.TabIndex = 15;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCancel.Location = new System.Drawing.Point(436, 406);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(100, 22);
            this.CmdCancel.TabIndex = 14;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new System.Drawing.Point(12, 22);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(627, 374);
            this.TabControl1.TabIndex = 12;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.cboWType);
            this.TabPage1.Controls.Add(this.TxteMail);
            this.TabPage1.Controls.Add(this.TxtFax);
            this.TabPage1.Controls.Add(this.TxtWebsite);
            this.TabPage1.Controls.Add(this.TxtTelephone1);
            this.TabPage1.Controls.Add(this.TxtPostCode);
            this.TabPage1.Controls.Add(this.TxtAddress4);
            this.TabPage1.Controls.Add(this.TxtAddress3);
            this.TabPage1.Controls.Add(this.TxtAddress2);
            this.TabPage1.Controls.Add(this.TxtAddress1);
            this.TabPage1.Controls.Add(this.TxtContactName);
            this.TabPage1.Controls.Add(this.TxtWarehouseName);
            this.TabPage1.Controls.Add(this.TxtWarehouseRef);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage1.Size = new System.Drawing.Size(619, 345);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(94, 287);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(42, 17);
            this.Label11.TabIndex = 22;
            this.Label11.Text = "EMail";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(93, 262);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(63, 17);
            this.Label10.TabIndex = 21;
            this.Label10.Text = "Website:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(332, 235);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(34, 17);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Fax:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(69, 235);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 17);
            this.Label7.TabIndex = 19;
            this.Label7.Text = "Telephone:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(71, 206);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(77, 17);
            this.Label6.TabIndex = 18;
            this.Label6.Text = "Post Code:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(84, 102);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 17);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "Address";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(332, 20);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 17);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Type:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(54, 73);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 17);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Contact Name:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(38, 50);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(126, 17);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Warehouse Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(48, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 17);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Warehouse Ref:";
            // 
            // cboWType
            // 
            this.cboWType.FormattingEnabled = true;
            this.cboWType.Items.AddRange(new object[] {
            "Active Warehouse",
            "WriteOff Warehouse"});
            this.cboWType.Location = new System.Drawing.Point(414, 17);
            this.cboWType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboWType.Name = "cboWType";
            this.cboWType.Size = new System.Drawing.Size(160, 24);
            this.cboWType.TabIndex = 2;
            // 
            // TxteMail
            // 
            this.TxteMail.Location = new System.Drawing.Point(153, 285);
            this.TxteMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxteMail.MaxLength = 255;
            this.TxteMail.Name = "TxteMail";
            this.TxteMail.Size = new System.Drawing.Size(329, 22);
            this.TxteMail.TabIndex = 12;
            this.TxteMail.Leave += new System.EventHandler(this.TxteMail_Leave);
            // 
            // TxtFax
            // 
            this.TxtFax.Location = new System.Drawing.Point(387, 232);
            this.TxtFax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFax.MaxLength = 20;
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(132, 22);
            this.TxtFax.TabIndex = 10;
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Location = new System.Drawing.Point(153, 259);
            this.TxtWebsite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWebsite.MaxLength = 255;
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(329, 22);
            this.TxtWebsite.TabIndex = 11;
            this.TxtWebsite.Leave += new System.EventHandler(this.TxtWebsite_Leave);
            // 
            // TxtTelephone1
            // 
            this.TxtTelephone1.Location = new System.Drawing.Point(153, 232);
            this.TxtTelephone1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTelephone1.MaxLength = 20;
            this.TxtTelephone1.Name = "TxtTelephone1";
            this.TxtTelephone1.Size = new System.Drawing.Size(171, 22);
            this.TxtTelephone1.TabIndex = 9;
            // 
            // TxtPostCode
            // 
            this.TxtPostCode.Location = new System.Drawing.Point(153, 204);
            this.TxtPostCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPostCode.MaxLength = 10;
            this.TxtPostCode.Name = "TxtPostCode";
            this.TxtPostCode.Size = new System.Drawing.Size(171, 22);
            this.TxtPostCode.TabIndex = 8;
            this.TxtPostCode.Leave += new System.EventHandler(this.TxtPostCode_Leave);
            // 
            // TxtAddress4
            // 
            this.TxtAddress4.Location = new System.Drawing.Point(153, 175);
            this.TxtAddress4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAddress4.MaxLength = 50;
            this.TxtAddress4.Name = "TxtAddress4";
            this.TxtAddress4.Size = new System.Drawing.Size(447, 22);
            this.TxtAddress4.TabIndex = 7;
            this.TxtAddress4.Leave += new System.EventHandler(this.TxtAddress4_Leave);
            // 
            // TxtAddress3
            // 
            this.TxtAddress3.Location = new System.Drawing.Point(153, 150);
            this.TxtAddress3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAddress3.MaxLength = 50;
            this.TxtAddress3.Name = "TxtAddress3";
            this.TxtAddress3.Size = new System.Drawing.Size(447, 22);
            this.TxtAddress3.TabIndex = 6;
            this.TxtAddress3.Leave += new System.EventHandler(this.TxtAddress3_Leave);
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Location = new System.Drawing.Point(153, 124);
            this.TxtAddress2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAddress2.MaxLength = 50;
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(447, 22);
            this.TxtAddress2.TabIndex = 5;
            this.TxtAddress2.Leave += new System.EventHandler(this.TxtAddress2_Leave);
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Location = new System.Drawing.Point(153, 98);
            this.TxtAddress1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAddress1.MaxLength = 50;
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(447, 22);
            this.TxtAddress1.TabIndex = 4;
            this.TxtAddress1.Leave += new System.EventHandler(this.TxtAddress1_Leave);
            // 
            // TxtContactName
            // 
            this.TxtContactName.Location = new System.Drawing.Point(153, 73);
            this.TxtContactName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtContactName.MaxLength = 50;
            this.TxtContactName.Name = "TxtContactName";
            this.TxtContactName.Size = new System.Drawing.Size(447, 22);
            this.TxtContactName.TabIndex = 3;
            this.TxtContactName.Leave += new System.EventHandler(this.TxtContactName_Leave);
            // 
            // TxtWarehouseName
            // 
            this.TxtWarehouseName.Location = new System.Drawing.Point(153, 47);
            this.TxtWarehouseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWarehouseName.MaxLength = 50;
            this.TxtWarehouseName.Name = "TxtWarehouseName";
            this.TxtWarehouseName.Size = new System.Drawing.Size(447, 22);
            this.TxtWarehouseName.TabIndex = 1;
            this.TxtWarehouseName.Leave += new System.EventHandler(this.TxtWarehouseName_Leave);
            // 
            // TxtWarehouseRef
            // 
            this.TxtWarehouseRef.Location = new System.Drawing.Point(152, 17);
            this.TxtWarehouseRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWarehouseRef.MaxLength = 8;
            this.TxtWarehouseRef.Name = "TxtWarehouseRef";
            this.TxtWarehouseRef.Size = new System.Drawing.Size(171, 22);
            this.TxtWarehouseRef.TabIndex = 0;
            this.TxtWarehouseRef.Leave += new System.EventHandler(this.TxtWarehouseRef_Leave);
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.TxtMemo);
            this.TabPage4.Location = new System.Drawing.Point(4, 25);
            this.TabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage4.Size = new System.Drawing.Size(619, 345);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Memo";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // TxtMemo
            // 
            this.TxtMemo.Location = new System.Drawing.Point(8, 6);
            this.TxtMemo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMemo.Multiline = true;
            this.TxtMemo.Name = "TxtMemo";
            this.TxtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMemo.Size = new System.Drawing.Size(605, 337);
            this.TxtMemo.TabIndex = 0;
            // 
            // FrmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 438);
            this.Controls.Add(this.CmdOK);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmWarehouse";
            this.Text = "FrmWarehouse";
            this.Load += new System.EventHandler(this.FrmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource2;
        public System.Windows.Forms.Button CmdOK;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label TxtTotalValue;
        internal System.Windows.Forms.Label TxtTotalStock;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DataGridView gridStock;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.DataGridView gridTrans;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button CmdClear;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboWType;
        internal System.Windows.Forms.TextBox TxteMail;
        internal System.Windows.Forms.TextBox TxtFax;
        internal System.Windows.Forms.TextBox TxtWebsite;
        internal System.Windows.Forms.TextBox TxtTelephone1;
        internal System.Windows.Forms.TextBox TxtPostCode;
        internal System.Windows.Forms.TextBox TxtAddress4;
        internal System.Windows.Forms.TextBox TxtAddress3;
        internal System.Windows.Forms.TextBox TxtAddress2;
        internal System.Windows.Forms.TextBox TxtAddress1;
        internal System.Windows.Forms.TextBox TxtContactName;
        internal System.Windows.Forms.TextBox TxtWarehouseName;
        internal System.Windows.Forms.TextBox TxtWarehouseRef;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.TextBox TxtMemo;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}