
namespace DataMaintenance.UI.U8.VoucherList
{
    partial class FrmUnitProductionCostList
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
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.panTitlel = new System.Windows.Forms.Panel();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.accountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panTitlel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            this.gbHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuery,
            this.tsbExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
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
            // panTitlel
            // 
            this.panTitlel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitlel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitlel.Controls.Add(this.lblTitel);
            this.panTitlel.Location = new System.Drawing.Point(12, 40);
            this.panTitlel.Name = "panTitlel";
            this.panTitlel.Size = new System.Drawing.Size(776, 43);
            this.panTitlel.TabIndex = 2;
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitel.Location = new System.Drawing.Point(303, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(160, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "单位成本列表";
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
            this.iYear,
            this.cMonth,
            this.cInvCode,
            this.cInvName,
            this.clnvStd,
            this.unitCost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBody.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBody.Location = new System.Drawing.Point(12, 161);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBody.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBody.RowTemplate.Height = 23;
            this.dgvBody.Size = new System.Drawing.Size(776, 277);
            this.dgvBody.TabIndex = 3;
            this.dgvBody.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBody_RowPostPaint);
            // 
            // gbHeader
            // 
            this.gbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeader.Controls.Add(this.lblAccountNo);
            this.gbHeader.Controls.Add(this.cmbMonth);
            this.gbHeader.Controls.Add(this.cmbAccountNo);
            this.gbHeader.Controls.Add(this.cmbYear);
            this.gbHeader.Controls.Add(this.lblYear);
            this.gbHeader.Controls.Add(this.lblMonth);
            this.gbHeader.Location = new System.Drawing.Point(12, 89);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(776, 66);
            this.gbHeader.TabIndex = 4;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "查询条件";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(29, 28);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(29, 12);
            this.lblAccountNo.TabIndex = 3;
            this.lblAccountNo.Text = "账套";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(589, 25);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 20);
            this.cmbMonth.TabIndex = 2;
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "018"});
            this.cmbAccountNo.Location = new System.Drawing.Point(82, 25);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(121, 20);
            this.cmbAccountNo.TabIndex = 2;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(330, 25);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 20);
            this.cmbYear.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(254, 28);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 12);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "会计年度";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(514, 28);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(53, 12);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "会计期间";
            // 
            // accountNo
            // 
            this.accountNo.DataPropertyName = "accountNo";
            this.accountNo.HeaderText = "账套号";
            this.accountNo.Name = "accountNo";
            this.accountNo.ReadOnly = true;
            // 
            // iYear
            // 
            this.iYear.DataPropertyName = "iYear";
            this.iYear.HeaderText = "会计年度";
            this.iYear.Name = "iYear";
            this.iYear.ReadOnly = true;
            // 
            // cMonth
            // 
            this.cMonth.DataPropertyName = "cMonth";
            this.cMonth.HeaderText = "会计期间";
            this.cMonth.Name = "cMonth";
            this.cMonth.ReadOnly = true;
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
            // unitCost
            // 
            this.unitCost.DataPropertyName = "unitCost";
            this.unitCost.HeaderText = "单位成本";
            this.unitCost.Name = "unitCost";
            this.unitCost.ReadOnly = true;
            // 
            // FrmUnitProductionCostList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.dgvBody);
            this.Controls.Add(this.panTitlel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmUnitProductionCostList";
            this.Text = "产品单位成本列表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panTitlel.ResumeLayout(false);
            this.panTitlel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.Panel panTitlel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgvBody;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbAccountNo;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCost;
    }
}