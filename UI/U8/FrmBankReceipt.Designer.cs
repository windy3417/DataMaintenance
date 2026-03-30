
namespace DataMaintenance.UI.U8
{
    partial class FrmBankReceipt
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
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbBatchDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xmtxtVendorCode = new Utility.UControl.XmTextBoxWithButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEnableDateFilter = new System.Windows.Forms.CheckBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveMarsterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDigest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downLoad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPayedDate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPayedEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPayedStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtArchvieName = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuery,
            this.tsbBatchDownload,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbBatchDownload
            // 
            this.tsbBatchDownload.Image = global::DataMaintenance.Properties.Resources.download;
            this.tsbBatchDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBatchDownload.Name = "tsbBatchDownload";
            this.tsbBatchDownload.Size = new System.Drawing.Size(79, 22);
            this.tsbBatchDownload.Text = "批量下载";
            this.tsbBatchDownload.Click += new System.EventHandler(this.BatchDowanloadFiles);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::DataMaintenance.Properties.Resources.exit;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(53, 22);
            this.tsbClose.Text = "关闭";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.cInvCode,
            this.archiveMarsterName,
            this.applyDate,
            this.payedDate,
            this.cDigest,
            this.archiveName,
            this.downLoad});
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 434);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "供应商编码：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.422111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.889724F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.16291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.508772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.66416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.882205F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.639098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.55779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.022556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.89975F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.xmtxtVendorCode, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtArchvieName, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountNo, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkEnableDateFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPayedDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpPayedStartDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndDate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpPayedEndDate, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 81);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // xmtxtVendorCode
            // 
            this.xmtxtVendorCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xmtxtVendorCode.Location = new System.Drawing.Point(556, 7);
            this.xmtxtVendorCode.Name = "xmtxtVendorCode";
            this.xmtxtVendorCode.Size = new System.Drawing.Size(86, 21);
            this.xmtxtVendorCode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "账套编号：";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountNo.Location = new System.Drawing.Point(720, 7);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(75, 21);
            this.txtAccountNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "申请日期：";
            // 
            // chkEnableDateFilter
            // 
            this.chkEnableDateFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEnableDateFilter.AutoSize = true;
            this.chkEnableDateFilter.Location = new System.Drawing.Point(91, 11);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(15, 14);
            this.chkEnableDateFilter.TabIndex = 6;
            this.chkEnableDateFilter.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.Location = new System.Drawing.Point(125, 7);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(115, 21);
            this.dtpStartDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "到";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDate.Location = new System.Drawing.Point(274, 7);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtpEndDate.TabIndex = 5;
            // 
            // choose
            // 
            this.choose.HeaderText = "选择";
            this.choose.Name = "choose";
            // 
            // cInvCode
            // 
            this.cInvCode.DataPropertyName = "cVenCode";
            this.cInvCode.HeaderText = "供应商编码";
            this.cInvCode.Name = "cInvCode";
            // 
            // archiveMarsterName
            // 
            this.archiveMarsterName.DataPropertyName = "cVenName";
            this.archiveMarsterName.HeaderText = "供应商名称";
            this.archiveMarsterName.Name = "archiveMarsterName";
            // 
            // applyDate
            // 
            this.applyDate.DataPropertyName = "applyDate";
            this.applyDate.HeaderText = "请款日期";
            this.applyDate.Name = "applyDate";
            // 
            // payedDate
            // 
            this.payedDate.DataPropertyName = "payedDate";
            this.payedDate.HeaderText = "支付日期";
            this.payedDate.Name = "payedDate";
            this.payedDate.ReadOnly = true;
            // 
            // cDigest
            // 
            this.cDigest.DataPropertyName = "cDigest";
            this.cDigest.HeaderText = "支付摘要";
            this.cDigest.Name = "cDigest";
            // 
            // archiveName
            // 
            this.archiveName.DataPropertyName = "downloadState";
            this.archiveName.HeaderText = "回单名称";
            this.archiveName.Name = "archiveName";
            // 
            // downLoad
            // 
            this.downLoad.HeaderText = "下载";
            this.downLoad.Name = "downLoad";
            this.downLoad.Text = "下载";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "支付日期：";
            // 
            // cbPayedDate
            // 
            this.cbPayedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPayedDate.AutoSize = true;
            this.cbPayedDate.Location = new System.Drawing.Point(91, 51);
            this.cbPayedDate.Name = "cbPayedDate";
            this.cbPayedDate.Size = new System.Drawing.Size(15, 14);
            this.cbPayedDate.TabIndex = 6;
            this.cbPayedDate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "供应商名称：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "到";
            // 
            // dtpPayedEndDate
            // 
            this.dtpPayedEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpPayedEndDate.Location = new System.Drawing.Point(274, 48);
            this.dtpPayedEndDate.Name = "dtpPayedEndDate";
            this.dtpPayedEndDate.Size = new System.Drawing.Size(116, 21);
            this.dtpPayedEndDate.TabIndex = 5;
            // 
            // dtpPayedStartDate
            // 
            this.dtpPayedStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpPayedStartDate.Location = new System.Drawing.Point(125, 48);
            this.dtpPayedStartDate.Name = "dtpPayedStartDate";
            this.dtpPayedStartDate.Size = new System.Drawing.Size(115, 21);
            this.dtpPayedStartDate.TabIndex = 4;
            // 
            // txtArchvieName
            // 
            this.txtArchvieName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtArchvieName, 3);
            this.txtArchvieName.Location = new System.Drawing.Point(556, 48);
            this.txtArchvieName.Name = "txtArchvieName";
            this.txtArchvieName.Size = new System.Drawing.Size(239, 21);
            this.txtArchvieName.TabIndex = 7;
            // 
            // FrmBankReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmBankReceipt";
            this.Text = "Bank Receipt";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tsbBatchDownload;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Utility.UControl.XmTextBoxWithButton xmtxtVendorCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEnableDateFilter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveMarsterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn payedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDigest;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveName;
        private System.Windows.Forms.DataGridViewButtonColumn downLoad;
        private System.Windows.Forms.DateTimePicker dtpPayedStartDate;
        private System.Windows.Forms.DateTimePicker dtpPayedEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPayedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArchvieName;
    }
}