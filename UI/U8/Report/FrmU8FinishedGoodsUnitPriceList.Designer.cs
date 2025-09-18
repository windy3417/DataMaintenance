
namespace DataMaintenance.UI.U8.Report
{
    partial class FrmU8FinishedGoodsUnitPriceList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.panTitlel = new System.Windows.Forms.Panel();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFitler = new System.Windows.Forms.ToolStripButton();
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.accountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iunitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInvCode = new System.Windows.Forms.Label();
            this.txbtnInvCode = new Utility.UControl.XmTextBoxWithButton();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panTitlel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            this.tlpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(3, 14);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(29, 12);
            this.lblAccountNo.TabIndex = 3;
            this.lblAccountNo.Text = "账套";
            this.lblAccountNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "017",
            "018"});
            this.cmbAccountNo.Location = new System.Drawing.Point(38, 10);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(108, 20);
            this.cmbAccountNo.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(352, 14);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "到";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(152, 14);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 12);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "单据日期";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitel.Location = new System.Drawing.Point(316, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(235, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "产成品入库单价列表";
            // 
            // panTitlel
            // 
            this.panTitlel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitlel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitlel.Controls.Add(this.lblTitel);
            this.panTitlel.Location = new System.Drawing.Point(12, 33);
            this.panTitlel.Name = "panTitlel";
            this.panTitlel.Size = new System.Drawing.Size(884, 43);
            this.panTitlel.TabIndex = 6;
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::DataMaintenance.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(53, 22);
            this.tsbExport.Text = "导出";
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuery,
            this.tsbExport,
            this.tsbFitler});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFitler
            // 
            this.tsbFitler.Image = global::DataMaintenance.Properties.Resources.filter;
            this.tsbFitler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFitler.Name = "tsbFitler";
            this.tsbFitler.Size = new System.Drawing.Size(53, 22);
            this.tsbFitler.Text = "筛选";
            this.tsbFitler.Click += new System.EventHandler(this.tsbFitler_Click);
            // 
            // dgvBody
            // 
            this.dgvBody.AllowUserToAddRows = false;
            this.dgvBody.AllowUserToDeleteRows = false;
            this.dgvBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBody.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNo,
            this.Year,
            this.Month,
            this.cInvCode,
            this.cInvName,
            this.clnvStd,
            this.iunitCost});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBody.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBody.Location = new System.Drawing.Point(12, 167);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBody.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBody.RowTemplate.Height = 23;
            this.dgvBody.Size = new System.Drawing.Size(884, 407);
            this.dgvBody.TabIndex = 7;
            this.dgvBody.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBody_RowPostPaint);
            // 
            // accountNo
            // 
            this.accountNo.DataPropertyName = "accountNo";
            this.accountNo.HeaderText = "账套号";
            this.accountNo.Name = "accountNo";
            this.accountNo.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "会计年度";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            dataGridViewCellStyle2.NullValue = null;
            this.Month.DefaultCellStyle = dataGridViewCellStyle2;
            this.Month.HeaderText = "会计期间";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // cInvCode
            // 
            this.cInvCode.DataPropertyName = "cInvCode";
            this.cInvCode.HeaderText = "存货编码";
            this.cInvCode.Name = "cInvCode";
            this.cInvCode.ReadOnly = true;
            // 
            // cInvName
            // 
            this.cInvName.DataPropertyName = "cInvName";
            this.cInvName.HeaderText = "存货名称";
            this.cInvName.Name = "cInvName";
            this.cInvName.ReadOnly = true;
            // 
            // clnvStd
            // 
            this.clnvStd.DataPropertyName = "cInvStd";
            this.clnvStd.HeaderText = "规格型号";
            this.clnvStd.Name = "clnvStd";
            this.clnvStd.ReadOnly = true;
            // 
            // iunitCost
            // 
            this.iunitCost.DataPropertyName = "iunitCost";
            this.iunitCost.HeaderText = "单位成本";
            this.iunitCost.Name = "iunitCost";
            this.iunitCost.ReadOnly = true;
            // 
            // lblInvCode
            // 
            this.lblInvCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInvCode.AutoSize = true;
            this.lblInvCode.Location = new System.Drawing.Point(516, 14);
            this.lblInvCode.Name = "lblInvCode";
            this.lblInvCode.Size = new System.Drawing.Size(53, 12);
            this.lblInvCode.TabIndex = 0;
            this.lblInvCode.Text = "存货编码";
            // 
            // txbtnInvCode
            // 
            this.txbtnInvCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbtnInvCode.Location = new System.Drawing.Point(575, 10);
            this.txbtnInvCode.Name = "txbtnInvCode";
            this.txbtnInvCode.Size = new System.Drawing.Size(124, 21);
            this.txbtnInvCode.TabIndex = 4;
            this.txbtnInvCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtnInvCode_KeyPress);
            // 
            // tlpFilter
            // 
            this.tlpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFilter.ColumnCount = 14;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlpFilter.Controls.Add(this.lblAccountNo, 0, 0);
            this.tlpFilter.Controls.Add(this.cmbAccountNo, 1, 0);
            this.tlpFilter.Controls.Add(this.lblYear, 2, 0);
            this.tlpFilter.Controls.Add(this.lblInvCode, 11, 0);
            this.tlpFilter.Controls.Add(this.lblMonth, 9, 0);
            this.tlpFilter.Controls.Add(this.dtpStartDate, 8, 0);
            this.tlpFilter.Controls.Add(this.dtpEndDate, 10, 0);
            this.tlpFilter.Controls.Add(this.btnQuery, 13, 0);
            this.tlpFilter.Controls.Add(this.txbtnInvCode, 12, 0);
            this.tlpFilter.Location = new System.Drawing.Point(12, 94);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(884, 41);
            this.tlpFilter.TabIndex = 9;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Location = new System.Drawing.Point(211, 10);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(129, 21);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Location = new System.Drawing.Point(375, 10);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(129, 21);
            this.dtpEndDate.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuery.Location = new System.Drawing.Point(714, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(78, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // FrmU8FinishedGoodsUnitPriceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 580);
            this.Controls.Add(this.tlpFilter);
            this.Controls.Add(this.panTitlel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBody);
            this.Name = "FrmU8FinishedGoodsUnitPriceReport";
            this.Text = "产成品入库单价列表";
            this.panTitlel.ResumeLayout(false);
            this.panTitlel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.ComboBox cmbAccountNo;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Panel panTitlel;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvBody;
        private Utility.UControl.XmTextBoxWithButton txbtnInvCode;
        private System.Windows.Forms.Label lblInvCode;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ToolStripButton tsbFitler;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iunitCost;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}