namespace DataMaintenance.UI
{
    partial class FrmImport
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbImportTemplate = new System.Windows.Forms.ToolStripButton();
            this.TsbImport = new System.Windows.Forms.ToolStripButton();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            this.DgvImport = new System.Windows.Forms.DataGridView();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImportTemplate,
            this.TsbImport,
            this.TsbSave,
            this.TsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbImportTemplate
            // 
            this.tsbImportTemplate.Image = global::DataMaintenance.Properties.Resources.download;
            this.tsbImportTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImportTemplate.Name = "tsbImportTemplate";
            this.tsbImportTemplate.Size = new System.Drawing.Size(79, 22);
            this.tsbImportTemplate.Text = "模板下载";
            this.tsbImportTemplate.Click += new System.EventHandler(this.tsbImportTemplate_Click);
            // 
            // TsbImport
            // 
            this.TsbImport.Image = global::DataMaintenance.Properties.Resources.importdir_wiz;
            this.TsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbImport.Name = "TsbImport";
            this.TsbImport.Size = new System.Drawing.Size(53, 22);
            this.TsbImport.Text = "导入";
            this.TsbImport.Click += new System.EventHandler(this.TsbImport_Click);
            // 
            // TsbSave
            // 
            this.TsbSave.Image = global::DataMaintenance.Properties.Resources.save;
            this.TsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(53, 22);
            this.TsbSave.Text = "保存";
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // TsbClose
            // 
            this.TsbClose.Image = global::DataMaintenance.Properties.Resources.exit;
            this.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClose.Name = "TsbClose";
            this.TsbClose.Size = new System.Drawing.Size(53, 22);
            this.TsbClose.Text = "关闭";
            this.TsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // DgvImport
            // 
            this.DgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvImport.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvImport.Location = new System.Drawing.Point(12, 97);
            this.DgvImport.Name = "DgvImport";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvImport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvImport.RowTemplate.Height = 23;
            this.DgvImport.Size = new System.Drawing.Size(776, 330);
            this.DgvImport.TabIndex = 1;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(25, 49);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(41, 12);
            this.lblAccountNo.TabIndex = 2;
            this.lblAccountNo.Text = "账套号";
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "017",
            "018"});
            this.cmbAccountNo.Location = new System.Drawing.Point(95, 46);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(121, 20);
            this.cmbAccountNo.TabIndex = 3;
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbAccountNo);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.DgvImport);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmImport";
            this.Text = "外借刀具导入";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbImport;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripButton TsbClose;
        private System.Windows.Forms.DataGridView DgvImport;
        private System.Windows.Forms.ToolStripButton tsbImportTemplate;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.ComboBox cmbAccountNo;
    }
}