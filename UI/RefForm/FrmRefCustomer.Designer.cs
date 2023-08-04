
namespace DataMaintenance.UI.Ref
{
    partial class FrmRefCustomer
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
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.ccusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCertain = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArchive
            // 
            this.dgvArchive.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccusCode,
            this.cCusName});
            this.dgvArchive.Location = new System.Drawing.Point(12, 43);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.RowTemplate.Height = 23;
            this.dgvArchive.Size = new System.Drawing.Size(758, 395);
            this.dgvArchive.TabIndex = 0;
            this.dgvArchive.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ccusCode
            // 
            this.ccusCode.DataPropertyName = "cCusCode";
            this.ccusCode.HeaderText = "客户编码";
            this.ccusCode.Name = "ccusCode";
            // 
            // cCusName
            // 
            this.cCusName.DataPropertyName = "cCusName";
            this.cCusName.HeaderText = "客户名称";
            this.cCusName.Name = "cCusName";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCertain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCertain
            // 
            this.tsbCertain.Image = global::DataMaintenance.Properties.Resources.enable;
            this.tsbCertain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCertain.Name = "tsbCertain";
            this.tsbCertain.Size = new System.Drawing.Size(53, 22);
            this.tsbCertain.Text = "确定";
            this.tsbCertain.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // FrmRefCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvArchive);
            this.Name = "FrmRefCustomer";
            this.Text = "客户档案参照";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCertain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCusName;
    }
}