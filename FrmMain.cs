using DataMaintenance.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Model;
using DataMaintenance.Data;
using Utility;
using Utility.UI;
using DataMaintenance.UI.ClearLocker;
using System.Threading.Tasks;
using DataMaintenance.UI.Tools;

namespace DataMaintenance
{
    public partial class FrmMain : Form
    {
        public FrmMain()
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

            //状态栏显示已经登录的用户信息
            tstb_currentUser.Text = CurrentUser.userID;
            //用户重登录后即刻刷新登录状态栏
            CurrentUser.authorizPass += CurrentUser_authorizPass;

        }

        /// <summary>
        /// 用户重登录后即刻刷新登录状态栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentUser_authorizPass(object sender, EventArgs e)
        {
            tstb_currentUser.Text = CurrentUser.userID;
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
           FrmConfig config = new FrmConfig();
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

        private void 重登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Frm_login frm_Login = new UI.Frm_login();
            frm_Login.ShowDialog();
            if (frm_Login.DialogResult==DialogResult.OK)
            {
                //new Task
                    
            }
        }

        private void 权限设定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_authorize f = new Frm_authorize();
            embedForm(f);
        }

        private void 外借导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImport f = new FrmImport();
            embedForm(f);
        }

        private void tsmUnitCostQuery_Click(object sender, EventArgs e)
        {

        }

        private void tsmSpecifiactionCheck_Click(object sender, EventArgs e)
        {
            FrmSpecificationCheck f = new FrmSpecificationCheck();
            embedForm(f);
        }

        private void 任务清理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClearU8Task f = new FrmClearU8Task();
            embedForm(f);
        }
    }
}
