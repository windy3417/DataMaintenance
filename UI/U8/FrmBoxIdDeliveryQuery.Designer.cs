
namespace DataMaintenance.UI.U8
{
    partial class FrmBoxIdDeliveryQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoxIdDeliveryQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.当前页导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部数据导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.panTitel = new System.Windows.Forms.Panel();
            this.labTitel = new System.Windows.Forms.Label();
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerCode = new Utility.UControl.XmTextBoxWithButton();
            this.txtInvcode = new Utility.UControl.XmTextBoxWithButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmPagingReader1 = new Utility.UControl.XmPagingReader();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outBoundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panTitel.SuspendLayout();
            this.gpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuery,
            this.toolStripDropDownButton1,
            this.tsbPreview,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1073, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = global::DataMaintenance.Properties.Resources.Search;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(53, 22);
            this.tsbQuery.Text = "查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.当前页导出ToolStripMenuItem,
            this.全部数据导出ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::DataMaintenance.Properties.Resources.export;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "导出";
            // 
            // 当前页导出ToolStripMenuItem
            // 
            this.当前页导出ToolStripMenuItem.Name = "当前页导出ToolStripMenuItem";
            this.当前页导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.当前页导出ToolStripMenuItem.Text = "当前页导出";
            this.当前页导出ToolStripMenuItem.Click += new System.EventHandler(this.当前页导出ToolStripMenuItem_Click);
            // 
            // 全部数据导出ToolStripMenuItem
            // 
            this.全部数据导出ToolStripMenuItem.Name = "全部数据导出ToolStripMenuItem";
            this.全部数据导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.全部数据导出ToolStripMenuItem.Text = "全部数据导出";
            this.全部数据导出ToolStripMenuItem.Click += new System.EventHandler(this.全部数据导出ToolStripMenuItem_Click);
            // 
            // tsbPreview
            // 
            this.tsbPreview.Image = global::DataMaintenance.Properties.Resources.预览;
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Size = new System.Drawing.Size(53, 22);
            this.tsbPreview.Text = "预览";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(53, 22);
            this.tsbPrint.Text = "打印";
            // 
            // panTitel
            // 
            this.panTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitel.Controls.Add(this.labTitel);
            this.panTitel.Location = new System.Drawing.Point(12, 29);
            this.panTitel.Name = "panTitel";
            this.panTitel.Size = new System.Drawing.Size(1049, 49);
            this.panTitel.TabIndex = 1;
            // 
            // labTitel
            // 
            this.labTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitel.AutoSize = true;
            this.labTitel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitel.Location = new System.Drawing.Point(416, 14);
            this.labTitel.Name = "labTitel";
            this.labTitel.Size = new System.Drawing.Size(160, 24);
            this.labTitel.TabIndex = 0;
            this.labTitel.Text = "出库箱号列表";
            // 
            // gpFilter
            // 
            this.gpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFilter.Controls.Add(this.dtpEndDate);
            this.gpFilter.Controls.Add(this.dtpStartDate);
            this.gpFilter.Controls.Add(this.txtCustomerCode);
            this.gpFilter.Controls.Add(this.txtInvcode);
            this.gpFilter.Controls.Add(this.label4);
            this.gpFilter.Controls.Add(this.label5);
            this.gpFilter.Controls.Add(this.label3);
            this.gpFilter.Controls.Add(this.label2);
            this.gpFilter.Location = new System.Drawing.Point(12, 91);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(1049, 100);
            this.gpFilter.TabIndex = 2;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "查询条件";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(420, 66);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 21);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(420, 34);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtpStartDate.TabIndex = 2;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(83, 66);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(200, 21);
            this.txtCustomerCode.TabIndex = 1;
            // 
            // txtInvcode
            // 
            this.txtInvcode.Location = new System.Drawing.Point(83, 35);
            this.txtInvcode.Name = "txtInvcode";
            this.txtInvcode.Size = new System.Drawing.Size(200, 21);
            this.txtInvcode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "客户编码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "到";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出库日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "存货编码";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusName,
            this.outBoundDate,
            this.voucherId,
            this.cinvCode,
            this.cinvName,
            this.cinvStd,
            this.iQuantity,
            this.boxId,
            this.memo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.Location = new System.Drawing.Point(12, 197);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.RowTemplate.Height = 23;
            this.dgvReport.Size = new System.Drawing.Size(1049, 368);
            this.dgvReport.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "客户名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "出库日期";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "出库单号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "存货编码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "存货名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "规格型号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "出库数量";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "出库箱号";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // xmPagingReader1
            // 
            this.xmPagingReader1.ColumnsForSum = null;
            this.xmPagingReader1.DataSource = null;
            this.xmPagingReader1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xmPagingReader1.Location = new System.Drawing.Point(0, 568);
            this.xmPagingReader1.Name = "xmPagingReader1";
            this.xmPagingReader1.PageSize = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xmPagingReader1.Size = new System.Drawing.Size(1073, 25);
            this.xmPagingReader1.StartNo = "1";
            this.xmPagingReader1.TabIndex = 4;
            this.xmPagingReader1.TableBody = null;
            this.xmPagingReader1.Text = "xmPagingReader1";
            this.xmPagingReader1.TotalPages = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cusName
            // 
            this.cusName.HeaderText = "客户名称";
            this.cusName.Name = "cusName";
            this.cusName.ReadOnly = true;
            // 
            // outBoundDate
            // 
            this.outBoundDate.HeaderText = "出库日期";
            this.outBoundDate.Name = "outBoundDate";
            this.outBoundDate.ReadOnly = true;
            // 
            // voucherId
            // 
            this.voucherId.HeaderText = "出库单号";
            this.voucherId.Name = "voucherId";
            this.voucherId.ReadOnly = true;
            // 
            // cinvCode
            // 
            this.cinvCode.HeaderText = "存货编码";
            this.cinvCode.Name = "cinvCode";
            this.cinvCode.ReadOnly = true;
            // 
            // cinvName
            // 
            this.cinvName.HeaderText = "存货名称";
            this.cinvName.Name = "cinvName";
            this.cinvName.ReadOnly = true;
            // 
            // cinvStd
            // 
            this.cinvStd.HeaderText = "规格型号";
            this.cinvStd.Name = "cinvStd";
            this.cinvStd.ReadOnly = true;
            // 
            // iQuantity
            // 
            this.iQuantity.HeaderText = "出库数量";
            this.iQuantity.Name = "iQuantity";
            this.iQuantity.ReadOnly = true;
            // 
            // boxId
            // 
            this.boxId.HeaderText = "出库箱号";
            this.boxId.Name = "boxId";
            this.boxId.ReadOnly = true;
            // 
            // memo
            // 
            this.memo.HeaderText = "备注";
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            // 
            // FrmBoxIdDeliveryQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 593);
            this.Controls.Add(this.xmPagingReader1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmBoxIdDeliveryQuery";
            this.Text = "出库产品箱号";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbPreview;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Panel panTitel;
        private System.Windows.Forms.Label labTitel;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private Utility.UControl.XmTextBoxWithButton txtCustomerCode;
        private Utility.UControl.XmTextBoxWithButton txtInvcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Utility.UControl.XmPagingReader xmPagingReader1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 当前页导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部数据导出ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn outBoundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
    }
}