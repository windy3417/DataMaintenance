
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
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.cVenCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCertain = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpQuery = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gpQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBody
            // 
            this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cVenCode,
            this.cVenName});
            this.dgvBody.Location = new System.Drawing.Point(12, 90);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.RowTemplate.Height = 23;
            this.dgvBody.Size = new System.Drawing.Size(758, 348);
            this.dgvBody.TabIndex = 0;
            this.dgvBody.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
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
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(657, 20);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "全文查询";
            // 
            // gpQuery
            // 
            this.gpQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpQuery.Controls.Add(this.textBox1);
            this.gpQuery.Controls.Add(this.btnQuery);
            this.gpQuery.Controls.Add(this.label1);
            this.gpQuery.Location = new System.Drawing.Point(12, 28);
            this.gpQuery.Name = "gpQuery";
            this.gpQuery.Size = new System.Drawing.Size(758, 56);
            this.gpQuery.TabIndex = 4;
            this.gpQuery.TabStop = false;
            this.gpQuery.Text = "查询条件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 21);
            this.textBox1.TabIndex = 4;
            // 
            // FrmRefVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.gpQuery);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBody);
            this.Name = "FrmRefVendor";
            this.Text = "供应商档案参照";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpQuery.ResumeLayout(false);
            this.gpQuery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBody;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCertain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVenCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVenName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpQuery;
        private System.Windows.Forms.TextBox textBox1;
    }
}