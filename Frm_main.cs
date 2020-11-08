using DataMaintenance.UI;
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

     
        private void 客商解锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 采购订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      
                Frm_PO config = new Frm_PO();
                embedForm(config);
            
        }

        private void embedForm(Form form)
        {
            EmbedForm embedForm = new EmbedForm();

            embedForm.openForm(form, form.Text, tabControl1, panel1);
        }

        private void 数据库设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_DoubleDataBaseConfig  config = new Frm_DoubleDataBaseConfig();
            embedForm(config);
        }

        private void 人员档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_user config = new Frm_user();
            embedForm(config);
        }
    }
}
