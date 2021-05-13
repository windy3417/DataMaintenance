namespace DataMaintenance.UI

{
    partial class FrmConfig
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
            this.TsbTest = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TsbSave = new System.Windows.Forms.Button();
            this.DbIT = new Utility.UControl.DbConnectControl();
            this.gbU8 = new System.Windows.Forms.GroupBox();
            this.tsbU8save = new System.Windows.Forms.Button();
            this.btnU8test = new System.Windows.Forms.Button();
            this.lblU8status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DBU8 = new Utility.UControl.DbConnectControl();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbU8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsbTest
            // 
            this.TsbTest.Location = new System.Drawing.Point(98, 177);
            this.TsbTest.Name = "TsbTest";
            this.TsbTest.Size = new System.Drawing.Size(50, 23);
            this.TsbTest.TabIndex = 1;
            this.TsbTest.Text = "测试";
            this.TsbTest.UseVisualStyleBackColor = true;
            this.TsbTest.Click += new System.EventHandler(this.TsbTest_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbClose
            // 
            this.TsbClose.Image = global::DataMaintenance.Properties.Resources.exit;
            this.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClose.Name = "TsbClose";
            this.TsbClose.Size = new System.Drawing.Size(52, 22);
            this.TsbClose.Text = "关闭";
            this.TsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TsbSave);
            this.groupBox1.Controls.Add(this.DbIT);
            this.groupBox1.Controls.Add(this.TsbTest);
            this.groupBox1.Location = new System.Drawing.Point(50, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IT数据库配置";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(96, 218);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 12);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "未配置：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "配置状态：";
            // 
            // TsbSave
            // 
            this.TsbSave.Location = new System.Drawing.Point(177, 177);
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(50, 23);
            this.TsbSave.TabIndex = 4;
            this.TsbSave.Text = "保存";
            this.TsbSave.UseVisualStyleBackColor = true;
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // DbIT
            // 
            this.DbIT.Location = new System.Drawing.Point(24, 20);
            this.DbIT.Name = "DbIT";
            this.DbIT.Size = new System.Drawing.Size(236, 151);
            this.DbIT.TabIndex = 0;
            // 
            // gbU8
            // 
            this.gbU8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbU8.Controls.Add(this.tsbU8save);
            this.gbU8.Controls.Add(this.btnU8test);
            this.gbU8.Controls.Add(this.lblU8status);
            this.gbU8.Controls.Add(this.label3);
            this.gbU8.Controls.Add(this.DBU8);
            this.gbU8.Location = new System.Drawing.Point(475, 41);
            this.gbU8.Name = "gbU8";
            this.gbU8.Size = new System.Drawing.Size(354, 280);
            this.gbU8.TabIndex = 3;
            this.gbU8.TabStop = false;
            this.gbU8.Text = "U8数据库配置";
            // 
            // tsbU8save
            // 
            this.tsbU8save.Location = new System.Drawing.Point(185, 177);
            this.tsbU8save.Name = "tsbU8save";
            this.tsbU8save.Size = new System.Drawing.Size(50, 23);
            this.tsbU8save.TabIndex = 6;
            this.tsbU8save.Text = "保存";
            this.tsbU8save.UseVisualStyleBackColor = true;
            this.tsbU8save.Click += new System.EventHandler(this.tsbU8save_Click);
            // 
            // btnU8test
            // 
            this.btnU8test.Location = new System.Drawing.Point(98, 177);
            this.btnU8test.Name = "btnU8test";
            this.btnU8test.Size = new System.Drawing.Size(50, 23);
            this.btnU8test.TabIndex = 5;
            this.btnU8test.Text = "测试";
            this.btnU8test.UseVisualStyleBackColor = true;
            this.btnU8test.Click += new System.EventHandler(this.btnU8test_Click);
            // 
            // lblU8status
            // 
            this.lblU8status.AutoSize = true;
            this.lblU8status.Location = new System.Drawing.Point(96, 218);
            this.lblU8status.Name = "lblU8status";
            this.lblU8status.Size = new System.Drawing.Size(53, 12);
            this.lblU8status.TabIndex = 4;
            this.lblU8status.Text = "未配置：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "配置状态：";
            // 
            // DBU8
            // 
            this.DBU8.Location = new System.Drawing.Point(24, 20);
            this.DBU8.Name = "DBU8";
            this.DBU8.Size = new System.Drawing.Size(236, 151);
            this.DBU8.TabIndex = 0;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 348);
            this.Controls.Add(this.gbU8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmConfig";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbU8.ResumeLayout(false);
            this.gbU8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.UControl.DbConnectControl DbIT;
        private System.Windows.Forms.Button TsbTest;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TsbSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbU8;
        private System.Windows.Forms.Button btnU8test;
        private System.Windows.Forms.Label lblU8status;
        private System.Windows.Forms.Label label3;
        private Utility.UControl.DbConnectControl DBU8;
        private System.Windows.Forms.Button tsbU8save;
    }
}