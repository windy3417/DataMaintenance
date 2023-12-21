
namespace DataMaintenance.UI.U8
{
    partial class FrmPoAttachment
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.gpQuery = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.xmTxtVendor = new Utility.UControl.XmTextBoxWithButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panTitel = new System.Windows.Forms.Panel();
            this.labTitel = new System.Windows.Forms.Label();
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.xmPagingReader1 = new Utility.UControl.XmPagingReader();
            this.toolStrip1.SuspendLayout();
            this.gpQuery.SuspendLayout();
            this.panTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::DataMaintenance.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(53, 22);
            this.tsbExport.Text = "导出";
            // 
            // gpQuery
            // 
            this.gpQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpQuery.Controls.Add(this.btnQuery);
            this.gpQuery.Controls.Add(this.xmTxtVendor);
            this.gpQuery.Controls.Add(this.label1);
            this.gpQuery.Location = new System.Drawing.Point(12, 94);
            this.gpQuery.Name = "gpQuery";
            this.gpQuery.Size = new System.Drawing.Size(814, 68);
            this.gpQuery.TabIndex = 1;
            this.gpQuery.TabStop = false;
            this.gpQuery.Text = "查询条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(714, 24);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // xmTxtVendor
            // 
            this.xmTxtVendor.Location = new System.Drawing.Point(91, 27);
            this.xmTxtVendor.Name = "xmTxtVendor";
            this.xmTxtVendor.Size = new System.Drawing.Size(281, 21);
            this.xmTxtVendor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商编码";
            // 
            // panTitel
            // 
            this.panTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitel.Controls.Add(this.labTitel);
            this.panTitel.Location = new System.Drawing.Point(0, 28);
            this.panTitel.Name = "panTitel";
            this.panTitel.Size = new System.Drawing.Size(838, 60);
            this.panTitel.TabIndex = 2;
            // 
            // labTitel
            // 
            this.labTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitel.AutoSize = true;
            this.labTitel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitel.Location = new System.Drawing.Point(324, 18);
            this.labTitel.Name = "labTitel";
            this.labTitel.Size = new System.Drawing.Size(160, 24);
            this.labTitel.TabIndex = 0;
            this.labTitel.Text = "采购订单附件";
            // 
            // dgvBody
            // 
            this.dgvBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBody.Location = new System.Drawing.Point(12, 168);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.RowTemplate.Height = 23;
            this.dgvBody.Size = new System.Drawing.Size(814, 354);
            this.dgvBody.TabIndex = 3;
            // 
            // xmPagingReader1
            // 
            this.xmPagingReader1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xmPagingReader1.ColumnsForSum = null;
            this.xmPagingReader1.DataSource = null;
            this.xmPagingReader1.Dock = System.Windows.Forms.DockStyle.None;
            this.xmPagingReader1.Location = new System.Drawing.Point(472, 525);
            this.xmPagingReader1.Name = "xmPagingReader1";
            this.xmPagingReader1.PageSize = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xmPagingReader1.Size = new System.Drawing.Size(354, 25);
            this.xmPagingReader1.StartNo = "1";
            this.xmPagingReader1.TabIndex = 4;
            this.xmPagingReader1.TableBody = null;
            this.xmPagingReader1.Text = "xmPagingReader1";
            this.xmPagingReader1.TotalPages = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FrmPoAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 562);
            this.Controls.Add(this.xmPagingReader1);
            this.Controls.Add(this.dgvBody);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.gpQuery);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPoAttachment";
            this.Text = "采购订单附件";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpQuery.ResumeLayout(false);
            this.gpQuery.PerformLayout();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.GroupBox gpQuery;
        private System.Windows.Forms.Panel panTitel;
        private System.Windows.Forms.Label labTitel;
        private Utility.UControl.XmTextBoxWithButton xmTxtVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBody;
        private Utility.UControl.XmPagingReader xmPagingReader1;
        private System.Windows.Forms.Button btnQuery;
    }
}