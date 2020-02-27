namespace DMHV2
{
    partial class frmSettings
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
            this.CmdRestore = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtVATReg = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblRestoreInfo = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtWWW = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.CmdBackup = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.lblBackupinfo = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAdd4 = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.CmdOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.GroupBox3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdRestore
            // 
            this.CmdRestore.Location = new System.Drawing.Point(26, 171);
            this.CmdRestore.Margin = new System.Windows.Forms.Padding(4);
            this.CmdRestore.Name = "CmdRestore";
            this.CmdRestore.Size = new System.Drawing.Size(218, 28);
            this.CmdRestore.TabIndex = 2;
            this.CmdRestore.Text = "Restore Backup";
            this.CmdRestore.UseVisualStyleBackColor = true;
            this.CmdRestore.Click += new System.EventHandler(this.CmdRestore_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(30, 25);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(223, 17);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "Select dabase you want to restore";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.CmdRestore);
            this.GroupBox3.Controls.Add(this.ComboBox3);
            this.GroupBox3.Controls.Add(this.ComboBox2);
            this.GroupBox3.Location = new System.Drawing.Point(9, 7);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(403, 228);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Restore Database";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(23, 119);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(196, 17);
            this.Label14.TabIndex = 3;
            this.Label14.Text = "Select backup file from the list";
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(24, 139);
            this.ComboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(240, 24);
            this.ComboBox3.TabIndex = 1;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(26, 54);
            this.ComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(189, 24);
            this.ComboBox2.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(146, 23);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.MaxLength = 60;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(305, 22);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtVATRate
            // 
            this.txtVATRate.Location = new System.Drawing.Point(146, 343);
            this.txtVATRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.Size = new System.Drawing.Size(84, 22);
            this.txtVATRate.TabIndex = 10;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 27);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 17);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Company Name:";
            // 
            // txtVATReg
            // 
            this.txtVATReg.Location = new System.Drawing.Point(146, 375);
            this.txtVATReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtVATReg.Name = "txtVATReg";
            this.txtVATReg.Size = new System.Drawing.Size(308, 22);
            this.txtVATReg.TabIndex = 11;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(64, 59);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(64, 17);
            this.Label20.TabIndex = 30;
            this.Label20.Text = "Address:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(30, 379);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(91, 17);
            this.Label10.TabIndex = 53;
            this.Label10.Text = "VAT Reg No:";
            // 
            // lblRestoreInfo
            // 
            this.lblRestoreInfo.AutoSize = true;
            this.lblRestoreInfo.Location = new System.Drawing.Point(20, 257);
            this.lblRestoreInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestoreInfo.Name = "lblRestoreInfo";
            this.lblRestoreInfo.Size = new System.Drawing.Size(59, 17);
            this.lblRestoreInfo.TabIndex = 2;
            this.lblRestoreInfo.Text = "Label12";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(48, 187);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 17);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Post Code:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(96, 251);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(34, 17);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Fax:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(63, 283);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 17);
            this.Label6.TabIndex = 34;
            this.Label6.Text = "Website:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(22, 315);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(102, 17);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "Email Address:";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.Coral;
            this.TabPage4.Controls.Add(this.lblRestoreInfo);
            this.TabPage4.Controls.Add(this.Label13);
            this.TabPage4.Controls.Add(this.GroupBox3);
            this.TabPage4.Location = new System.Drawing.Point(4, 25);
            this.TabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage4.Size = new System.Drawing.Size(453, 382);
            this.TabPage4.TabIndex = 1;
            this.TabPage4.Text = "Restore";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(32, 54);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(237, 24);
            this.ComboBox1.TabIndex = 0;
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Location = new System.Drawing.Point(45, 224);
            this.Label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(80, 17);
            this.Label40.TabIndex = 32;
            this.Label40.Text = "Telephone:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(26, 20);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(288, 25);
            this.Label11.TabIndex = 1;
            this.Label11.Text = "Select Database from the list";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(3, 347);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(116, 17);
            this.Label8.TabIndex = 36;
            this.Label8.Text = "Default Vat Rate:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 311);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(146, 55);
            this.txtAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd1.MaxLength = 60;
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(308, 22);
            this.txtAdd1.TabIndex = 1;
            // 
            // txtWWW
            // 
            this.txtWWW.Location = new System.Drawing.Point(146, 279);
            this.txtWWW.Margin = new System.Windows.Forms.Padding(4);
            this.txtWWW.MaxLength = 90;
            this.txtWWW.Name = "txtWWW";
            this.txtWWW.Size = new System.Drawing.Size(308, 22);
            this.txtWWW.TabIndex = 8;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(146, 87);
            this.txtAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd2.MaxLength = 10;
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(308, 22);
            this.txtAdd2.TabIndex = 2;
            // 
            // CmdBackup
            // 
            this.CmdBackup.Location = new System.Drawing.Point(32, 87);
            this.CmdBackup.Margin = new System.Windows.Forms.Padding(4);
            this.CmdBackup.Name = "CmdBackup";
            this.CmdBackup.Size = new System.Drawing.Size(195, 28);
            this.CmdBackup.TabIndex = 1;
            this.CmdBackup.Text = "Create Backup";
            this.CmdBackup.UseVisualStyleBackColor = true;
            this.CmdBackup.Click += new System.EventHandler(this.CmdBackup_Click);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(146, 247);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4);
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(308, 22);
            this.txtFax.TabIndex = 7;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(412, 501);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(112, 28);
            this.CmdCancel.TabIndex = 5;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // txtAdd3
            // 
            this.txtAdd3.Location = new System.Drawing.Point(146, 119);
            this.txtAdd3.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd3.MaxLength = 10;
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(308, 22);
            this.txtAdd3.TabIndex = 3;
            // 
            // lblBackupinfo
            // 
            this.lblBackupinfo.AutoSize = true;
            this.lblBackupinfo.Location = new System.Drawing.Point(9, 166);
            this.lblBackupinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupinfo.Name = "lblBackupinfo";
            this.lblBackupinfo.Size = new System.Drawing.Size(51, 17);
            this.lblBackupinfo.TabIndex = 2;
            this.lblBackupinfo.Text = "Label9";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Orange;
            this.TabPage3.Controls.Add(this.lblBackupinfo);
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage3.Size = new System.Drawing.Size(453, 382);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Backup";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.CmdBackup);
            this.GroupBox2.Controls.Add(this.ComboBox1);
            this.GroupBox2.Location = new System.Drawing.Point(9, 26);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(318, 123);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Backup Database";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage3);
            this.TabControl2.Controls.Add(this.TabPage4);
            this.TabControl2.Location = new System.Drawing.Point(4, 7);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(461, 411);
            this.TabControl2.TabIndex = 2;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.TabControl2);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage2.Size = new System.Drawing.Size(473, 429);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Backup / Restore";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(146, 215);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelephone.MaxLength = 20;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(308, 22);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtAdd4
            // 
            this.txtAdd4.Location = new System.Drawing.Point(146, 151);
            this.txtAdd4.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd4.MaxLength = 10;
            this.txtAdd4.Name = "txtAdd4";
            this.txtAdd4.Size = new System.Drawing.Size(308, 22);
            this.txtAdd4.TabIndex = 4;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(146, 183);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostCode.MaxLength = 10;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(84, 22);
            this.txtPostCode.TabIndex = 5;
            // 
            // CmdOK
            // 
            this.CmdOK.Location = new System.Drawing.Point(292, 501);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(4);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(112, 28);
            this.CmdOK.TabIndex = 3;
            this.CmdOK.Text = "OK";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCompanyName);
            this.GroupBox1.Controls.Add(this.txtVATRate);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtVATReg);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label40);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtEmail);
            this.GroupBox1.Controls.Add(this.txtAdd1);
            this.GroupBox1.Controls.Add(this.txtWWW);
            this.GroupBox1.Controls.Add(this.txtAdd2);
            this.GroupBox1.Controls.Add(this.txtFax);
            this.GroupBox1.Controls.Add(this.txtAdd3);
            this.GroupBox1.Controls.Add(this.txtTelephone);
            this.GroupBox1.Controls.Add(this.txtAdd4);
            this.GroupBox1.Controls.Add(this.txtPostCode);
            this.GroupBox1.Location = new System.Drawing.Point(4, 4);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(632, 418);
            this.GroupBox1.TabIndex = 55;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Settings";
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage1.Size = new System.Drawing.Size(473, 429);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Company Details";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(38, 39);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(481, 458);
            this.TabControl1.TabIndex = 4;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdOK);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdRestore;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox ComboBox3;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.TextBox txtCompanyName;
        internal System.Windows.Forms.TextBox txtVATRate;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtVATReg;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label lblRestoreInfo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtAdd1;
        internal System.Windows.Forms.TextBox txtWWW;
        internal System.Windows.Forms.TextBox txtAdd2;
        internal System.Windows.Forms.Button CmdBackup;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.TextBox txtAdd3;
        internal System.Windows.Forms.Label lblBackupinfo;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox txtTelephone;
        internal System.Windows.Forms.TextBox txtAdd4;
        internal System.Windows.Forms.TextBox txtPostCode;
        internal System.Windows.Forms.Button CmdOK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabControl TabControl1;
    }
}