
namespace DataMaintenance.UI.Ref
{
    partial class FrmRefVendor

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCertain = new System.Windows.Forms.ToolStripButton();
            this.cVenCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cVenCode,
            this.cVenName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(758, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
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
            // cVenCode
            // 
            this.cVenCode.DataPropertyName = "cVenCode";
            this.cVenCode.HeaderText = "供应商编码";
            this.cVenCode.Name = "cVenCode";
            // 
            // cVenName
            // 
            this.cVenName.DataPropertyName = "cVenName";
            this.cVenName.HeaderText = "供应商名称";
            this.cVenName.Name = "cVenName";
            // 
            // FrmRefVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRefVendor";
            this.Text = "供应商档案参照";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCertain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVenCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVenName;
    }
}