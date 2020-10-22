﻿using DataMaintenance.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Utility;
using Utility.UI;

namespace DataMaintenance
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            initializeControlsState();
        }

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initializeControlsState()
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void 刀具管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 属性修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_toolProperty t = new Frm_toolProperty();
            string tabPageText = t.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(t, tabPageText, tabControl1, panel1);
        }

        private void 数据库设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_config frm_Scrap = new Frm_config();
            string tabPageText = frm_Scrap.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(frm_Scrap, tabPageText, tabControl1, panel1);
        }
    }
}
