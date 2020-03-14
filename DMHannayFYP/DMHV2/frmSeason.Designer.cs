namespace DMHV2
{
    partial class frmSeason
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtSeasonName = new System.Windows.Forms.TextBox();
            this.LblSeasonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(372, 96);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 31);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtSeasonName
            // 
            this.TxtSeasonName.Location = new System.Drawing.Point(149, 61);
            this.TxtSeasonName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSeasonName.Name = "TxtSeasonName";
            this.TxtSeasonName.Size = new System.Drawing.Size(323, 28);
            this.TxtSeasonName.TabIndex = 10;
            // 
            // LblSeasonID
            // 
            this.LblSeasonID.BackColor = System.Drawing.Color.MistyRose;
            this.LblSeasonID.Location = new System.Drawing.Point(145, 17);
            this.LblSeasonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSeasonID.Name = "LblSeasonID";
            this.LblSeasonID.Size = new System.Drawing.Size(104, 32);
            this.LblSeasonID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Season Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Season ID:";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(285, 95);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(84, 32);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // frmSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 153);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtSeasonName);
            this.Controls.Add(this.LblSeasonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSeason";
            this.Text = "frmSeason";
            this.Load += new System.EventHandler(this.frmSeason_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtSeasonName;
        private System.Windows.Forms.Label LblSeasonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
    }
}