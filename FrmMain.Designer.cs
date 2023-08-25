namespace DataMaintenance
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单清单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSmbConnectiongString = new System.Windows.Forms.ToolStripMenuItem();
            this.刀具管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外借导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUnitCostQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpecifiactionCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.清除锁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客商解锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.凭证解锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目解锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任务清理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.授权ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.u8附件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArchiveAttachment = new System.Windows.Forms.ToolStripMenuItem();
            this.箱号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库箱号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ts_foot = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstb_currentUser = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.箱号结存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ts_foot.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.刀具管理ToolStripMenuItem,
            this.清除锁定ToolStripMenuItem,
            this.授权ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.u8附件管理ToolStripMenuItem,
            this.箱号管理ToolStripMenuItem,
            this.重登录ToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(786, 24);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库设置ToolStripMenuItem,
            this.权限生成ToolStripMenuItem,
            this.菜单清单ToolStripMenuItem,
            this.权限设定ToolStripMenuItem,
            this.tsmSmbConnectiongString});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 数据库设置ToolStripMenuItem
            // 
            this.数据库设置ToolStripMenuItem.Name = "数据库设置ToolStripMenuItem";
            this.数据库设置ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.数据库设置ToolStripMenuItem.Text = "数据库设置";
            this.数据库设置ToolStripMenuItem.Click += new System.EventHandler(this.数据库设置ToolStripMenuItem1_Click);
            // 
            // 权限生成ToolStripMenuItem
            // 
            this.权限生成ToolStripMenuItem.Name = "权限生成ToolStripMenuItem";
            this.权限生成ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.权限生成ToolStripMenuItem.Text = "权限表";
            this.权限生成ToolStripMenuItem.Click += new System.EventHandler(this.权限生成ToolStripMenuItem_Click);
            // 
            // 菜单清单ToolStripMenuItem
            // 
            this.菜单清单ToolStripMenuItem.Name = "菜单清单ToolStripMenuItem";
            this.菜单清单ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.菜单清单ToolStripMenuItem.Text = "菜单清单";
            this.菜单清单ToolStripMenuItem.Click += new System.EventHandler(this.菜单清单ToolStripMenuItem_Click);
            // 
            // 权限设定ToolStripMenuItem
            // 
            this.权限设定ToolStripMenuItem.Name = "权限设定ToolStripMenuItem";
            this.权限设定ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.权限设定ToolStripMenuItem.Text = "权限设定";
            this.权限设定ToolStripMenuItem.Click += new System.EventHandler(this.权限设定ToolStripMenuItem_Click);
            // 
            // tsmSmbConnectiongString
            // 
            this.tsmSmbConnectiongString.Name = "tsmSmbConnectiongString";
            this.tsmSmbConnectiongString.Size = new System.Drawing.Size(163, 22);
            this.tsmSmbConnectiongString.Text = "SMB连接字符串";
            this.tsmSmbConnectiongString.Click += new System.EventHandler(this.tsmSmbConnectiongString_Click);
            // 
            // 刀具管理ToolStripMenuItem
            // 
            this.刀具管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.属性修改ToolStripMenuItem,
            this.外借导入ToolStripMenuItem,
            this.tsmUnitCostQuery,
            this.tsmSpecifiactionCheck});
            this.刀具管理ToolStripMenuItem.Name = "刀具管理ToolStripMenuItem";
            this.刀具管理ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.刀具管理ToolStripMenuItem.Text = "刀具管理";
            this.刀具管理ToolStripMenuItem.Click += new System.EventHandler(this.刀具管理ToolStripMenuItem_Click);
            // 
            // 属性修改ToolStripMenuItem
            // 
            this.属性修改ToolStripMenuItem.Name = "属性修改ToolStripMenuItem";
            this.属性修改ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.属性修改ToolStripMenuItem.Text = "属性修改";
            this.属性修改ToolStripMenuItem.Click += new System.EventHandler(this.属性修改ToolStripMenuItem_Click);
            // 
            // 外借导入ToolStripMenuItem
            // 
            this.外借导入ToolStripMenuItem.Name = "外借导入ToolStripMenuItem";
            this.外借导入ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.外借导入ToolStripMenuItem.Text = "外借导入";
            this.外借导入ToolStripMenuItem.Click += new System.EventHandler(this.外借导入ToolStripMenuItem_Click);
            // 
            // tsmUnitCostQuery
            // 
            this.tsmUnitCostQuery.Name = "tsmUnitCostQuery";
            this.tsmUnitCostQuery.Size = new System.Drawing.Size(126, 22);
            this.tsmUnitCostQuery.Text = "单价查询";
            this.tsmUnitCostQuery.Click += new System.EventHandler(this.tsmUnitCostQuery_Click);
            // 
            // tsmSpecifiactionCheck
            // 
            this.tsmSpecifiactionCheck.Name = "tsmSpecifiactionCheck";
            this.tsmSpecifiactionCheck.Size = new System.Drawing.Size(126, 22);
            this.tsmSpecifiactionCheck.Text = "规格检视";
            this.tsmSpecifiactionCheck.Click += new System.EventHandler(this.tsmSpecifiactionCheck_Click);
            // 
            // 清除锁定ToolStripMenuItem
            // 
            this.清除锁定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客商解锁ToolStripMenuItem,
            this.凭证解锁ToolStripMenuItem,
            this.科目解锁ToolStripMenuItem,
            this.任务清理ToolStripMenuItem});
            this.清除锁定ToolStripMenuItem.Name = "清除锁定ToolStripMenuItem";
            this.清除锁定ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.清除锁定ToolStripMenuItem.Text = "清除锁定";
            // 
            // 客商解锁ToolStripMenuItem
            // 
            this.客商解锁ToolStripMenuItem.Name = "客商解锁ToolStripMenuItem";
            this.客商解锁ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.客商解锁ToolStripMenuItem.Text = "客商解锁";
            this.客商解锁ToolStripMenuItem.Click += new System.EventHandler(this.客商解锁ToolStripMenuItem_Click);
            // 
            // 凭证解锁ToolStripMenuItem
            // 
            this.凭证解锁ToolStripMenuItem.Name = "凭证解锁ToolStripMenuItem";
            this.凭证解锁ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.凭证解锁ToolStripMenuItem.Text = "凭证解锁";
            // 
            // 科目解锁ToolStripMenuItem
            // 
            this.科目解锁ToolStripMenuItem.Name = "科目解锁ToolStripMenuItem";
            this.科目解锁ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.科目解锁ToolStripMenuItem.Text = "科目解锁";
            // 
            // 任务清理ToolStripMenuItem
            // 
            this.任务清理ToolStripMenuItem.Name = "任务清理ToolStripMenuItem";
            this.任务清理ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.任务清理ToolStripMenuItem.Text = "任务清理";
            this.任务清理ToolStripMenuItem.Click += new System.EventHandler(this.任务清理ToolStripMenuItem_Click);
            // 
            // 授权ToolStripMenuItem
            // 
            this.授权ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采购订单ToolStripMenuItem});
            this.授权ToolStripMenuItem.Name = "授权ToolStripMenuItem";
            this.授权ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.授权ToolStripMenuItem.Text = "授权";
            // 
            // 采购订单ToolStripMenuItem
            // 
            this.采购订单ToolStripMenuItem.Name = "采购订单ToolStripMenuItem";
            this.采购订单ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.采购订单ToolStripMenuItem.Text = "采购订单";
            this.采购订单ToolStripMenuItem.Click += new System.EventHandler(this.采购订单ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员档案ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 人员档案ToolStripMenuItem
            // 
            this.人员档案ToolStripMenuItem.Name = "人员档案ToolStripMenuItem";
            this.人员档案ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.人员档案ToolStripMenuItem.Text = "人员档案";
            this.人员档案ToolStripMenuItem.Click += new System.EventHandler(this.人员档案ToolStripMenuItem_Click);
            // 
            // u8附件管理ToolStripMenuItem
            // 
            this.u8附件管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchiveAttachment});
            this.u8附件管理ToolStripMenuItem.Name = "u8附件管理ToolStripMenuItem";
            this.u8附件管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.u8附件管理ToolStripMenuItem.Text = "U8附件管理";
            // 
            // tsmArchiveAttachment
            // 
            this.tsmArchiveAttachment.Name = "tsmArchiveAttachment";
            this.tsmArchiveAttachment.Size = new System.Drawing.Size(217, 22);
            this.tsmArchiveAttachment.Text = "客户供应商存货档案附件";
            this.tsmArchiveAttachment.Click += new System.EventHandler(this.tsmArchiveAttachment_Click);
            // 
            // 箱号管理ToolStripMenuItem
            // 
            this.箱号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出库箱号ToolStripMenuItem,
            this.箱号结存ToolStripMenuItem});
            this.箱号管理ToolStripMenuItem.Name = "箱号管理ToolStripMenuItem";
            this.箱号管理ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.箱号管理ToolStripMenuItem.Text = "箱号管理";
            // 
            // 出库箱号ToolStripMenuItem
            // 
            this.出库箱号ToolStripMenuItem.Name = "出库箱号ToolStripMenuItem";
            this.出库箱号ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.出库箱号ToolStripMenuItem.Tag = "DataMaintenance.UI.U8.FrmBoxIdDeliveryQuery";
            this.出库箱号ToolStripMenuItem.Text = "出库箱号";
            this.出库箱号ToolStripMenuItem.Click += new System.EventHandler(this.MenuItemClick);
            // 
            // 重登录ToolStripMenuItem
            // 
            this.重登录ToolStripMenuItem.Name = "重登录ToolStripMenuItem";
            this.重登录ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.重登录ToolStripMenuItem.Text = "重登录";
            this.重登录ToolStripMenuItem.Click += new System.EventHandler(this.重登录ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ts_foot);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 300);
            this.panel1.TabIndex = 1;
            // 
            // ts_foot
            // 
            this.ts_foot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_foot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstb_currentUser});
            this.ts_foot.Location = new System.Drawing.Point(0, 275);
            this.ts_foot.Name = "ts_foot";
            this.ts_foot.Size = new System.Drawing.Size(786, 25);
            this.ts_foot.TabIndex = 1;
            this.ts_foot.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "当前用户有：";
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // tstb_currentUser
            // 
            this.tstb_currentUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstb_currentUser.Name = "tstb_currentUser";
            this.tstb_currentUser.Size = new System.Drawing.Size(100, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // 箱号结存ToolStripMenuItem
            // 
            this.箱号结存ToolStripMenuItem.Name = "箱号结存ToolStripMenuItem";
            this.箱号结存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.箱号结存ToolStripMenuItem.Tag = "DataMaintenance.UI.U8.FrmBoxIdExist";
            this.箱号结存ToolStripMenuItem.Text = "箱号结存";
            this.箱号结存ToolStripMenuItem.Click += new System.EventHandler(this.MenuItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ms_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.Name = "FrmMain";
            this.Text = "数据维护";
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ts_foot.ResumeLayout(false);
            this.ts_foot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem 刀具管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性修改ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
   
        private System.Windows.Forms.ToolStripMenuItem 清除锁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客商解锁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 凭证解锁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目解锁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任务清理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 授权ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单清单ToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem 重登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_foot;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstb_currentUser;
        private System.Windows.Forms.ToolStripMenuItem 权限设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外借导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUnitCostQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmSpecifiactionCheck;
        private System.Windows.Forms.ToolStripMenuItem u8附件管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmArchiveAttachment;
        private System.Windows.Forms.ToolStripMenuItem tsmSmbConnectiongString;
        private System.Windows.Forms.ToolStripMenuItem 箱号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库箱号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 箱号结存ToolStripMenuItem;
    }
}

