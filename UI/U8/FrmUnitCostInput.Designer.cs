
namespace DataMaintenance.UI.U8
{
    partial class FrmUnitCostInput
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbAddRow = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblCostType = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.cmbCostType = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbAccountNo = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.cinvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panTitel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panTitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbSave,
            this.tsbUpdate,
            this.tsbEdit,
            this.tsbAddRow,
            this.tsbDeleteRow,
            this.tsbDelete,
            this.tsbFirst,
            this.tsbNext,
            this.tsbPrevious,
            this.tsbLast});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1051, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::DataMaintenance.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::DataMaintenance.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = global::DataMaintenance.Properties.Resources.update;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(53, 22);
            this.tsbUpdate.Text = "更新";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdateU8Cost_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::DataMaintenance.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(53, 22);
            this.tsbEdit.Text = "编辑";
            // 
            // tsbAddRow
            // 
            this.tsbAddRow.Image = global::DataMaintenance.Properties.Resources.add_a_row;
            this.tsbAddRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddRow.Name = "tsbAddRow";
            this.tsbAddRow.Size = new System.Drawing.Size(53, 22);
            this.tsbAddRow.Text = "增行";
            this.tsbAddRow.Click += new System.EventHandler(this.tsbAddRow_Click);
            // 
            // tsbDeleteRow
            // 
            this.tsbDeleteRow.Image = global::DataMaintenance.Properties.Resources.DeleteRow;
            this.tsbDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteRow.Name = "tsbDeleteRow";
            this.tsbDeleteRow.Size = new System.Drawing.Size(53, 22);
            this.tsbDeleteRow.Text = "删行";
            this.tsbDeleteRow.Click += new System.EventHandler(this.tsbDeleteRow_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::DataMaintenance.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(53, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbFirst
            // 
            this.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirst.Image = global::DataMaintenance.Properties.Resources.first_page;
            this.tsbFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirst.Name = "tsbFirst";
            this.tsbFirst.Size = new System.Drawing.Size(23, 22);
            this.tsbFirst.Text = "首期";
            this.tsbFirst.Click += new System.EventHandler(this.tsbFirst_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = global::DataMaintenance.Properties.Resources.Next_page;
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Text = "下期";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbPrevious
            // 
            this.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrevious.Image = global::DataMaintenance.Properties.Resources.previous_page;
            this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevious.Name = "tsbPrevious";
            this.tsbPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsbPrevious.Text = "前期";
            this.tsbPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrevious.Click += new System.EventHandler(this.tsbPrevious_Click);
            // 
            // tsbLast
            // 
            this.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLast.Image = global::DataMaintenance.Properties.Resources.Last_page;
            this.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLast.Name = "tsbLast";
            this.tsbLast.Size = new System.Drawing.Size(23, 22);
            this.tsbLast.Text = "末期";
            this.tsbLast.Click += new System.EventHandler(this.tsbLast_Click);
            // 
            // gbHeader
            // 
            this.gbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeader.Controls.Add(this.lblCostType);
            this.gbHeader.Controls.Add(this.lblAccountNo);
            this.gbHeader.Controls.Add(this.cmbCostType);
            this.gbHeader.Controls.Add(this.cmbMonth);
            this.gbHeader.Controls.Add(this.cmbAccountNo);
            this.gbHeader.Controls.Add(this.cmbYear);
            this.gbHeader.Controls.Add(this.lblYear);
            this.gbHeader.Controls.Add(this.lblMonth);
            this.gbHeader.Location = new System.Drawing.Point(12, 78);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(1027, 100);
            this.gbHeader.TabIndex = 1;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "输入期间";
            // 
            // lblCostType
            // 
            this.lblCostType.AutoSize = true;
            this.lblCostType.Location = new System.Drawing.Point(771, 45);
            this.lblCostType.Name = "lblCostType";
            this.lblCostType.Size = new System.Drawing.Size(53, 12);
            this.lblCostType.TabIndex = 4;
            this.lblCostType.Text = "成本类型";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(29, 45);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(29, 12);
            this.lblAccountNo.TabIndex = 3;
            this.lblAccountNo.Text = "账套";
            // 
            // cmbCostType
            // 
            this.cmbCostType.FormattingEnabled = true;
            this.cmbCostType.Items.AddRange(new object[] {
            "生产单位成本",
            "销售单位成本"});
            this.cmbCostType.Location = new System.Drawing.Point(840, 42);
            this.cmbCostType.Name = "cmbCostType";
            this.cmbCostType.Size = new System.Drawing.Size(121, 20);
            this.cmbCostType.TabIndex = 2;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(589, 42);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 20);
            this.cmbMonth.TabIndex = 2;
            // 
            // cmbAccountNo
            // 
            this.cmbAccountNo.FormattingEnabled = true;
            this.cmbAccountNo.Items.AddRange(new object[] {
            "027"});
            this.cmbAccountNo.Location = new System.Drawing.Point(82, 42);
            this.cmbAccountNo.Name = "cmbAccountNo";
            this.cmbAccountNo.Size = new System.Drawing.Size(121, 20);
            this.cmbAccountNo.TabIndex = 2;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(330, 42);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 20);
            this.cmbYear.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(254, 45);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 12);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "会计年度";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(514, 45);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(53, 12);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "会计期间";
            // 
            // dgvDetail
            // 
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinvCode,
            this.cinvName,
            this.cinvStd,
            this.unitCost});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetail.Location = new System.Drawing.Point(12, 207);
            this.dgvDetail.Name = "dgvDetail";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.Size = new System.Drawing.Size(1027, 339);
            this.dgvDetail.TabIndex = 2;
            this.dgvDetail.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvBody_CellBeginEdit);
            this.dgvDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetail_CellEndEdit);
            this.dgvDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetail_RowPostPaint);
            // 
            // cinvCode
            // 
            this.cinvCode.DataPropertyName = "cInvCode";
            this.cinvCode.HeaderText = "存货编码";
            this.cinvCode.Name = "cinvCode";
            // 
            // cinvName
            // 
            this.cinvName.DataPropertyName = "cInvName";
            this.cinvName.HeaderText = "存货名称";
            this.cinvName.Name = "cinvName";
            this.cinvName.ReadOnly = true;
            // 
            // cinvStd
            // 
            this.cinvStd.DataPropertyName = "cInvStd";
            this.cinvStd.HeaderText = "规格型号";
            this.cinvStd.Name = "cinvStd";
            this.cinvStd.ReadOnly = true;
            // 
            // unitCost
            // 
            this.unitCost.DataPropertyName = "unitCost";
            this.unitCost.HeaderText = "单位成本";
            this.unitCost.Name = "unitCost";
            // 
            // panTitel
            // 
            this.panTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitel.Controls.Add(this.lblTitle);
            this.panTitel.Location = new System.Drawing.Point(12, 29);
            this.panTitel.Name = "panTitel";
            this.panTitel.Size = new System.Drawing.Size(1027, 43);
            this.panTitel.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(426, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "单位成本输入";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "存货编码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "存货名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "规格型号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "单位成本";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmUnitCostInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 558);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmUnitCostInput";
            this.Text = "单位成本输入";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Panel panTitel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.ComboBox cmbAccountNo;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.Label lblCostType;
        private System.Windows.Forms.ComboBox cmbCostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDeleteRow;
        private System.Windows.Forms.ToolStripButton tsbAddRow;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbPrevious;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCost;
    }
}