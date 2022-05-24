
namespace DataMaintenance.UI.U8Attachment
{
    partial class FrmArchiveAttachment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchiveAttachment));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtArchvieName = new System.Windows.Forms.TextBox();
            this.txtArchiveCode = new System.Windows.Forms.TextBox();
            this.cmbArchiveType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveMarsterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downLoad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "批量下载";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.cInvCode,
            this.archiveMarsterName,
            this.archiveName,
            this.GUID,
            this.downLoad});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 310);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // gpFilter
            // 
            this.gpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFilter.Controls.Add(this.btnRef);
            this.gpFilter.Controls.Add(this.btnQuery);
            this.gpFilter.Controls.Add(this.txtArchvieName);
            this.gpFilter.Controls.Add(this.txtArchiveCode);
            this.gpFilter.Controls.Add(this.cmbArchiveType);
            this.gpFilter.Controls.Add(this.label2);
            this.gpFilter.Controls.Add(this.label3);
            this.gpFilter.Controls.Add(this.label1);
            this.gpFilter.Location = new System.Drawing.Point(12, 28);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(776, 84);
            this.gpFilter.TabIndex = 2;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "查询条件";
            // 
            // btnRef
            // 
            this.btnRef.Image = global::DataMaintenance.Properties.Resources.button;
            this.btnRef.Location = new System.Drawing.Point(502, 24);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(26, 21);
            this.btnRef.TabIndex = 4;
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(654, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtArchvieName
            // 
            this.txtArchvieName.Location = new System.Drawing.Point(117, 56);
            this.txtArchvieName.Name = "txtArchvieName";
            this.txtArchvieName.Size = new System.Drawing.Size(383, 21);
            this.txtArchvieName.TabIndex = 2;
            // 
            // txtArchiveCode
            // 
            this.txtArchiveCode.Location = new System.Drawing.Point(384, 24);
            this.txtArchiveCode.Name = "txtArchiveCode";
            this.txtArchiveCode.Size = new System.Drawing.Size(116, 21);
            this.txtArchiveCode.TabIndex = 2;
            // 
            // cmbArchiveType
            // 
            this.cmbArchiveType.FormattingEnabled = true;
            this.cmbArchiveType.Items.AddRange(new object[] {
            "客户",
            "供应商",
            "存货"});
            this.cmbArchiveType.Location = new System.Drawing.Point(117, 26);
            this.cmbArchiveType.Name = "cmbArchiveType";
            this.cmbArchiveType.Size = new System.Drawing.Size(121, 20);
            this.cmbArchiveType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "档案主体编码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "档案主体名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "档案类型：";
            // 
            // choose
            // 
            this.choose.HeaderText = "选择";
            this.choose.Name = "choose";
            // 
            // cInvCode
            // 
            this.cInvCode.DataPropertyName = "ArchiveCode";
            this.cInvCode.HeaderText = "档案主体编码";
            this.cInvCode.Name = "cInvCode";
            // 
            // archiveMarsterName
            // 
            this.archiveMarsterName.DataPropertyName = "archiveMarsterName";
            this.archiveMarsterName.HeaderText = "档案主体名称";
            this.archiveMarsterName.Name = "archiveMarsterName";
            // 
            // archiveName
            // 
            this.archiveName.DataPropertyName = "archiveName";
            this.archiveName.HeaderText = "档案名称";
            this.archiveName.Name = "archiveName";
            // 
            // GUID
            // 
            this.GUID.DataPropertyName = "AttachFileGUID";
            this.GUID.HeaderText = "文档GUID";
            this.GUID.Name = "GUID";
            this.GUID.Visible = false;
            // 
            // downLoad
            // 
            this.downLoad.HeaderText = "下载";
            this.downLoad.Name = "downLoad";
            this.downLoad.Text = "下载";
            // 
            // FrmArchiveAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmArchiveAttachment";
            this.Text = "客户供应商存货档案附件";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtArchiveCode;
        private System.Windows.Forms.ComboBox cmbArchiveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchvieName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveMarsterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.DataGridViewButtonColumn downLoad;
    }
}