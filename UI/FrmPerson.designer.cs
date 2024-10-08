﻿namespace DataMaintenance.UI
{
    partial class FrmPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cusCode = new System.Windows.Forms.TextBox();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.lbl_regitrationDate = new System.Windows.Forms.Label();
            this.tbd_effect = new Utility.UControl.XmTxtBoxWithDate();
            this.label4 = new System.Windows.Forms.Label();
            this.tbd_failure = new Utility.UControl.XmTxtBoxWithDate();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_voucherStatus = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登录密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failuerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.panTitel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panTitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 159);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_cusCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_cusName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_regitrationDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbd_effect, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbd_failure, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_pwd, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "人员名称标签";
            this.label1.Text = "人员姓名:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Tag = "人员编码标签";
            this.label2.Text = "人员编码：";
            // 
            // txt_cusCode
            // 
            this.txt_cusCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cusCode.Location = new System.Drawing.Point(111, 9);
            this.txt_cusCode.Name = "txt_cusCode";
            this.txt_cusCode.Size = new System.Drawing.Size(252, 21);
            this.txt_cusCode.TabIndex = 1;
            this.txt_cusCode.Tag = "客户编码";
            this.txt_cusCode.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
            // 
            // txt_cusName
            // 
            this.txt_cusName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cusName.Location = new System.Drawing.Point(111, 49);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(252, 21);
            this.txt_cusName.TabIndex = 2;
            this.txt_cusName.Tag = "客户名称";
            // 
            // lbl_regitrationDate
            // 
            this.lbl_regitrationDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_regitrationDate.AutoSize = true;
            this.lbl_regitrationDate.Location = new System.Drawing.Point(381, 14);
            this.lbl_regitrationDate.Name = "lbl_regitrationDate";
            this.lbl_regitrationDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_regitrationDate.TabIndex = 0;
            this.lbl_regitrationDate.Tag = "注册日期标签";
            this.lbl_regitrationDate.Text = "注册日期：";
            // 
            // tbd_effect
            // 
            this.tbd_effect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbd_effect.Location = new System.Drawing.Point(477, 9);
            this.tbd_effect.Name = "tbd_effect";
            this.tbd_effect.Size = new System.Drawing.Size(252, 21);
            this.tbd_effect.TabIndex = 3;
            this.tbd_effect.Tag = "生效日期";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Tag = "注销日期标签";
            this.label4.Text = "注销日期：";
            // 
            // tbd_failure
            // 
            this.tbd_failure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbd_failure.Location = new System.Drawing.Point(477, 49);
            this.tbd_failure.Name = "tbd_failure";
            this.tbd_failure.Size = new System.Drawing.Size(252, 21);
            this.tbd_failure.TabIndex = 3;
            this.tbd_failure.Tag = "失效日期";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Tag = "登录密码标签";
            this.label5.Text = "登录密码:";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_pwd.Location = new System.Drawing.Point(111, 90);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(252, 21);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Tag = "登录密码";
            // 
            // lbl_voucherStatus
            // 
            this.lbl_voucherStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_voucherStatus.AutoSize = true;
            this.lbl_voucherStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_voucherStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_voucherStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_voucherStatus.Location = new System.Drawing.Point(662, 24);
            this.lbl_voucherStatus.Name = "lbl_voucherStatus";
            this.lbl_voucherStatus.Size = new System.Drawing.Size(72, 14);
            this.lbl_voucherStatus.TabIndex = 3;
            this.lbl_voucherStatus.Text = "档案状态：";
            // 
            // lbl_customer
            // 
            this.lbl_customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customer.Location = new System.Drawing.Point(350, 14);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(149, 24);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "人 员 档 案";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.usersName,
            this.登录密码,
            this.registrationDate,
            this.failuerDate});
            this.dgvDetail.Location = new System.Drawing.Point(12, 274);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(793, 287);
            this.dgvDetail.TabIndex = 2;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvDetail.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // userID
            // 
            this.userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userID.DataPropertyName = "userID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.userID.DefaultCellStyle = dataGridViewCellStyle2;
            this.userID.FillWeight = 50.76142F;
            this.userID.Frozen = true;
            this.userID.HeaderText = "人员编码";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            // 
            // usersName
            // 
            this.usersName.DataPropertyName = "userName";
            this.usersName.FillWeight = 149.2386F;
            this.usersName.HeaderText = "人员姓名";
            this.usersName.Name = "usersName";
            this.usersName.ReadOnly = true;
            // 
            // 登录密码
            // 
            this.登录密码.DataPropertyName = "pwd";
            this.登录密码.HeaderText = "登录密码";
            this.登录密码.Name = "登录密码";
            this.登录密码.ReadOnly = true;
            // 
            // registrationDate
            // 
            this.registrationDate.DataPropertyName = "RegistrationDate";
            this.registrationDate.HeaderText = "注册日期";
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.ReadOnly = true;
            // 
            // failuerDate
            // 
            this.failuerDate.DataPropertyName = "failuerDate";
            this.failuerDate.HeaderText = "注销日期";
            this.failuerDate.Name = "failuerDate";
            this.failuerDate.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_abandon,
            this.tsb_save,
            this.tsb_modify,
            this.tsb_query,
            this.tsb_delete,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(53, 22);
            this.tsb_add.Text = "增加";
            this.tsb_add.Click += new System.EventHandler(this.Tsb_add_Click);
            // 
            // tsb_abandon
            // 
            this.tsb_abandon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_abandon.Image")));
            this.tsb_abandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_abandon.Name = "tsb_abandon";
            this.tsb_abandon.Size = new System.Drawing.Size(53, 22);
            this.tsb_abandon.Text = "放弃";
            this.tsb_abandon.Click += new System.EventHandler(this.Tsb_abandon_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.Tsb_save_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(53, 22);
            this.tsb_modify.Text = "修改";
            this.tsb_modify.Click += new System.EventHandler(this.Tsb_modify_Click);
            // 
            // tsb_query
            // 
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(53, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(53, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(53, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // panTitel
            // 
            this.panTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTitel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTitel.Controls.Add(this.lbl_customer);
            this.panTitel.Controls.Add(this.lbl_voucherStatus);
            this.panTitel.Location = new System.Drawing.Point(0, 29);
            this.panTitel.Name = "panTitel";
            this.panTitel.Size = new System.Drawing.Size(817, 55);
            this.panTitel.TabIndex = 4;
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 573);
            this.Controls.Add(this.panTitel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmUserInfo";
            this.Text = "人员档案";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_customer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_customer_KeyPress);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panTitel.ResumeLayout(false);
            this.panTitel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cusCode;
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label lbl_regitrationDate;
        private System.Windows.Forms.Label label4;
        private Utility.UControl.XmTxtBoxWithDate tbd_effect;
        private Utility.UControl.XmTxtBoxWithDate tbd_failure;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_abandon;
        private System.Windows.Forms.Label lbl_voucherStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.Panel panTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登录密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn failuerDate;
    }
}