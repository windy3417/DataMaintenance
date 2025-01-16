
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.xmTxtVendor = new Utility.UControl.XmTextBoxWithButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panTitel = new System.Windows.Forms.Panel();
            this.labTitel = new System.Windows.Forms.Label();
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.xmPagingReader1 = new Utility.UControl.XmPagingReader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport,
            this.tsbQuery});
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
            // xmTxtVendor
            // 
            this.xmTxtVendor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xmTxtVendor.Location = new System.Drawing.Point(74, 14);
            this.xmTxtVendor.Name = "xmTxtVendor";
            this.xmTxtVendor.Size = new System.Drawing.Size(281, 21);
            this.xmTxtVendor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
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
            this.panTitel.Location = new System.Drawing.Point(12, 28);
            this.panTitel.Name = "panTitel";
            this.panTitel.Size = new System.Drawing.Size(814, 60);
            this.panTitel.TabIndex = 2;
            // 
            // labTitel
            // 
            this.labTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitel.AutoSize = true;
            this.labTitel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitel.Location = new System.Drawing.Point(312, 18);
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
            this.dgvBody.Location = new System.Drawing.Point(12, 212);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.RowTemplate.Height = 23;
            this.dgvBody.Size = new System.Drawing.Size(814, 310);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtAccountNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xmTxtVendor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "账套编码";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountNo.Location = new System.Drawing.Point(74, 64);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(281, 21);
            this.txtAccountNo.TabIndex = 3;
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = global::DataMaintenance.Properties.Resources.query;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(53, 22);
            this.tsbQuery.Text = "查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // FrmPoAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.xmPagingReader1);
            this.Controls.Add(this.dgvBody);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPoAttachment";
            this.Text = "采购订单附件";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.Panel panTitel;
        private System.Windows.Forms.Label labTitel;
        private Utility.UControl.XmTextBoxWithButton xmTxtVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBody;
        private Utility.UControl.XmPagingReader xmPagingReader1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label2;
    }
}