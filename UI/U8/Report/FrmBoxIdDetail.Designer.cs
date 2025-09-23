
namespace DataMaintenance.UI.U8
{
    partial class FrmBoxIdDetail
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
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.ddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmPagingReader1 = new Utility.UControl.XmPagingReader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddate,
            this.voucherId,
            this.cInvCode,
            this.boxId,
            this.iquantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.Location = new System.Drawing.Point(0, 33);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.Size = new System.Drawing.Size(662, 438);
            this.dgvDetail.TabIndex = 0;
            // 
            // ddate
            // 
            this.ddate.HeaderText = "入库日期";
            this.ddate.Name = "ddate";
            this.ddate.ReadOnly = true;
            // 
            // voucherId
            // 
            this.voucherId.HeaderText = "入库单号";
            this.voucherId.Name = "voucherId";
            this.voucherId.ReadOnly = true;
            // 
            // cInvCode
            // 
            this.cInvCode.HeaderText = "存货编码";
            this.cInvCode.Name = "cInvCode";
            this.cInvCode.ReadOnly = true;
            // 
            // boxId
            // 
            this.boxId.HeaderText = "箱号";
            this.boxId.Name = "boxId";
            this.boxId.ReadOnly = true;
            // 
            // iquantity
            // 
            this.iquantity.HeaderText = "数量";
            this.iquantity.Name = "iquantity";
            this.iquantity.ReadOnly = true;
            // 
            // xmPagingReader1
            // 
            this.xmPagingReader1.ColumnsForSum = null;
            this.xmPagingReader1.DataSource = null;
            this.xmPagingReader1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xmPagingReader1.Location = new System.Drawing.Point(0, 474);
            this.xmPagingReader1.Name = "xmPagingReader1";
            this.xmPagingReader1.PageSize = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xmPagingReader1.Size = new System.Drawing.Size(662, 25);
            this.xmPagingReader1.StartNo = "1";
            this.xmPagingReader1.TabIndex = 1;
            this.xmPagingReader1.TableBody = null;
            this.xmPagingReader1.Text = "xmPagingReader1";
            this.xmPagingReader1.TotalPages = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(662, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::DataMaintenance.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(61, 22);
            this.tsbExport.Text = "export";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // FrmBoxIdDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 499);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.xmPagingReader1);
            this.Controls.Add(this.dgvDetail);
            this.Name = "FrmBoxIdDetail";
            this.Text = "箱号明细";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetail;
        private Utility.UControl.XmPagingReader xmPagingReader1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn iquantity;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExport;
    }
}