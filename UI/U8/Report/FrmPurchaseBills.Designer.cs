namespace DataMaintenance.UI.U8.Report
{
    partial class FrmPurchaseBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseBills));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbPrePage = new System.Windows.Forms.ToolStripButton();
            this.tsbNextPage = new System.Windows.Forms.ToolStripButton();
            this.tsbFirstPage = new System.Windows.Forms.ToolStripButton();
            this.tsbLastPage = new System.Windows.Forms.ToolStripButton();
            this.lblPageInfo = new System.Windows.Forms.ToolStripLabel();
            this.xmTxtSupplier = new Utility.UControl.XmTextBoxWithButton();
            this.txtPageNum = new System.Windows.Forms.ToolStripTextBox();
            this.tsbGo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuery,
            this.tsbExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = global::DataMaintenance.Properties.Resources.Search;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(59, 22);
            this.tsbQuery.Text = "Query";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::DataMaintenance.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(61, 22);
            this.tsbExport.Text = "Export";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // dgvBody
            // 
            this.dgvBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBody.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBody.Location = new System.Drawing.Point(12, 172);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.RowTemplate.Height = 23;
            this.dgvBody.Size = new System.Drawing.Size(822, 327);
            this.dgvBody.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(323, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purhcse Bills";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAccountNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.xmTxtSupplier, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 58);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "account number";
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "017",
            "018"});
            this.cmbAccountNo.Location = new System.Drawing.Point(79, 4);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(118, 20);
            this.cmbAccountNo.TabIndex = 1;
            this.cmbAccountNo.SelectedValueChanged += new System.EventHandler(this.cmbAccountNo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "start date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "end date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.Location = new System.Drawing.Point(79, 33);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(118, 21);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDate.Location = new System.Drawing.Point(293, 33);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(126, 21);
            this.dtpEndDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "supplier";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFirstPage,
            this.tsbPrePage,
            this.tsbNextPage,
            this.tsbLastPage,
            this.lblPageInfo,
            this.txtPageNum,
            this.tsbGo});
            this.toolStrip2.Location = new System.Drawing.Point(0, 511);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(846, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbPrePage
            // 
            this.tsbPrePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrePage.Image = global::DataMaintenance.Properties.Resources.previous_page;
            this.tsbPrePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrePage.Name = "tsbPrePage";
            this.tsbPrePage.Size = new System.Drawing.Size(23, 22);
            this.tsbPrePage.Text = "toolStripButton1";
            // 
            // tsbNextPage
            // 
            this.tsbNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextPage.Image = global::DataMaintenance.Properties.Resources.Next_page;
            this.tsbNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextPage.Name = "tsbNextPage";
            this.tsbNextPage.Size = new System.Drawing.Size(23, 22);
            this.tsbNextPage.Text = "toolStripButton1";
            // 
            // tsbFirstPage
            // 
            this.tsbFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirstPage.Image = global::DataMaintenance.Properties.Resources.first_page;
            this.tsbFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirstPage.Name = "tsbFirstPage";
            this.tsbFirstPage.Size = new System.Drawing.Size(23, 22);
            this.tsbFirstPage.Text = "toolStripButton1";
            // 
            // tsbLastPage
            // 
            this.tsbLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastPage.Image = global::DataMaintenance.Properties.Resources.Last_page;
            this.tsbLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastPage.Name = "tsbLastPage";
            this.tsbLastPage.Size = new System.Drawing.Size(23, 22);
            this.tsbLastPage.Text = "toolStripButton1";
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(86, 22);
            this.lblPageInfo.Text = "toolStripLabel1";
            // 
            // xmTxtSupplier
            // 
            this.xmTxtSupplier.Location = new System.Drawing.Point(293, 3);
            this.xmTxtSupplier.Name = "xmTxtSupplier";
            this.xmTxtSupplier.Size = new System.Drawing.Size(194, 21);
            this.xmTxtSupplier.TabIndex = 3;
            // 
            // txtPageNum
            // 
            this.txtPageNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbGo
            // 
            this.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbGo.Image")));
            this.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGo.Name = "tsbGo";
            this.tsbGo.Size = new System.Drawing.Size(23, 22);
            this.tsbGo.Text = "toolStripButton1";
            // 
            // FrmPurchaseBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 536);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBody);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPurchaseBills";
            this.Text = "Purchase Bills";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.DataGridView dgvBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbPrePage;
        private System.Windows.Forms.ToolStripButton tsbFirstPage;
        private System.Windows.Forms.ToolStripButton tsbNextPage;
        private System.Windows.Forms.ToolStripButton tsbLastPage;
        private System.Windows.Forms.ToolStripLabel lblPageInfo;
        private Utility.UControl.XmTextBoxWithButton xmTxtSupplier;
        private System.Windows.Forms.ToolStripTextBox txtPageNum;
        private System.Windows.Forms.ToolStripButton tsbGo;
    }
}