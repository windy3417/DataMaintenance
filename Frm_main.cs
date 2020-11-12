﻿using DataMaintenance.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Modle;
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

        #region 初始化

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initializeControlsState()
        {
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion


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

        private void 权限生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db=new DataMaitenanceContext())
            {
                //List<MenuModle> mList = new List<MenuModle>();
                MenuModle m = new MenuModle();
                foreach (ToolStripMenuItem item in ms_main.Items)
                {
                    //m.menuID += 1;
                    m.menuName = item.Text;
                    //不知原因？虽然menus中有五个元素，但五个元素都相同
                    //即后一个元素会覆盖前一个元素的值，只有每一次都使用
                    //saveChanges()方法才把五个元素都保存在数据库，否则
                    //只能保存最后一个元素到数据库，即便采用泛型List,
                    //使用db.Menus.AddRange()方法也只能保存最后条数据到数据库
                    //不知道是否与自增量有关？
                    db.Menus.Add(m);
                    db.SaveChanges();

                }

                
                
                MessageBox.Show("权限表成功生成");
            }
        }

        private void 菜单清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_menuList f = new Frm_menuList();
            embedForm(f);
        }
    }
}
