namespace DMHV2
{
    partial class frmDataGrid
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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLFunction = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsbNew = new System.Windows.Forms.ToolStripButton();
            this.TsbRecord = new System.Windows.Forms.ToolStripButton();
            this.TsbDelete = new System.Windows.Forms.ToolStripButton();
            this.TsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.TsbPrint = new System.Windows.Forms.ToolStripButton();
            this.TsbFind = new System.Windows.Forms.ToolStripButton();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            this.TSBBalances = new System.Windows.Forms.ToolStripButton();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(800, 450);
            this.SplitContainer1.SplitterDistance = 71;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNew,
            this.TsbRecord,
            this.TsbDelete,
            this.TsbRefresh,
            this.TsbPrint,
            this.TsbFind,
            this.TSBBalances,
            this.TsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 71);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.DataGridView1);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.StatusStrip1);
            this.SplitContainer2.Size = new System.Drawing.Size(800, 374);
            this.SplitContainer2.SplitterDistance = 336;
            this.SplitContainer2.SplitterWidth = 5;
            this.SplitContainer2.TabIndex = 0;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.Size = new System.Drawing.Size(800, 336);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLFunction,
            this.TSSCount,
            this.ToolStripStatusLabel3});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 7);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(800, 26);
            this.StatusStrip1.TabIndex = 0;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // TSSLFunction
            // 
            this.TSSLFunction.Name = "TSSLFunction";
            this.TSSLFunction.Size = new System.Drawing.Size(88, 20);
            this.TSSLFunction.Text = "Warehouses";
            // 
            // TSSCount
            // 
            this.TSSCount.Name = "TSSCount";
            this.TSSCount.Size = new System.Drawing.Size(41, 20);
            this.TSSCount.Text = "0000";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(62, 20);
            this.ToolStripStatusLabel3.Text = "Records";
            // 
            // TsbNew
            // 
            this.TsbNew.Image = global::DMHV2.Properties.Resources._006_draw;
            this.TsbNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNew.Name = "TsbNew";
            this.TsbNew.Size = new System.Drawing.Size(50, 68);
            this.TsbNew.Text = "New";
            this.TsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbNew.Click += new System.EventHandler(this.TsbNew_Click);
            // 
            // TsbRecord
            // 
            this.TsbRecord.Image = global::DMHV2.Properties.Resources._008_note;
            this.TsbRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRecord.Name = "TsbRecord";
            this.TsbRecord.Size = new System.Drawing.Size(70, 68);
            this.TsbRecord.Text = "Record";
            this.TsbRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbRecord.Click += new System.EventHandler(this.TsbRecord_Click);
            // 
            // TsbDelete
            // 
            this.TsbDelete.Image = global::DMHV2.Properties.Resources._003_can;
            this.TsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDelete.Name = "TsbDelete";
            this.TsbDelete.Size = new System.Drawing.Size(66, 68);
            this.TsbDelete.Text = "Delete";
            this.TsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbDelete.Click += new System.EventHandler(this.TsbDelete_Click);
            // 
            // TsbRefresh
            // 
            this.TsbRefresh.Image = global::DMHV2.Properties.Resources._002_arrows;
            this.TsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRefresh.Name = "TsbRefresh";
            this.TsbRefresh.Size = new System.Drawing.Size(74, 68);
            this.TsbRefresh.Text = "Refresh";
            this.TsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbRefresh.Click += new System.EventHandler(this.TsbRefresh_Click);
            // 
            // TsbPrint
            // 
            this.TsbPrint.Image = global::DMHV2.Properties.Resources._005_technology;
            this.TsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPrint.Name = "TsbPrint";
            this.TsbPrint.Size = new System.Drawing.Size(53, 68);
            this.TsbPrint.Text = "Print";
            this.TsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbPrint.Visible = false;
            this.TsbPrint.Click += new System.EventHandler(this.TsbPrint_Click);
            // 
            // TsbFind
            // 
            this.TsbFind.Image = global::DMHV2.Properties.Resources._004_eye;
            this.TsbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbFind.Name = "TsbFind";
            this.TsbFind.Size = new System.Drawing.Size(49, 68);
            this.TsbFind.Text = "Find";
            this.TsbFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbFind.Click += new System.EventHandler(this.TsbFind_Click);
            // 
            // TsbClose
            // 
            this.TsbClose.Image = global::DMHV2.Properties.Resources._001_close;
            this.TsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClose.Name = "TsbClose";
            this.TsbClose.Size = new System.Drawing.Size(56, 68);
            this.TsbClose.Text = "Close";
            this.TsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // TSBBalances
            // 
            this.TSBBalances.Image = global::DMHV2.Properties.Resources.account_balances;
            this.TSBBalances.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBBalances.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBalances.Name = "TSBBalances";
            this.TSBBalances.Size = new System.Drawing.Size(82, 68);
            this.TSBBalances.Text = "Balances";
            this.TSBBalances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBBalances.Visible = false;
            this.TSBBalances.Click += new System.EventHandler(this.TSBBalances_Click);
            // 
            // frmDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmDataGrid";
            this.Text = "frmDataGrid";
            this.Load += new System.EventHandler(this.frmDataGrid_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNew;
        private System.Windows.Forms.ToolStripButton TsbRecord;
        private System.Windows.Forms.ToolStripButton TsbDelete;
        public System.Windows.Forms.ToolStripButton TsbRefresh;
        private System.Windows.Forms.ToolStripButton TsbPrint;
        private System.Windows.Forms.ToolStripButton TsbFind;
        private System.Windows.Forms.ToolStripButton TsbClose;
        public System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel TSSLFunction;
        internal System.Windows.Forms.ToolStripStatusLabel TSSCount;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.BindingSource BindingSource1;
        private System.Windows.Forms.ToolStripButton TSBBalances;
    }
}