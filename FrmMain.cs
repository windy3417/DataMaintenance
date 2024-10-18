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
using DataMaintenance.GlobeVary;
using Utility;
using Utility.UI;
using DataMaintenance.UI.ClearLocker;
using System.Threading.Tasks;
using DataMaintenance.UI.Tools;
using DataMaintenance.UI.U8Attachment;
using DataMaintenance.UI.SetUp;
using DataMaintenance.Model.Maintenance;

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
            tstb_currentUser.Text = CurrentUser.userID+" "+CurrentUser.userName;
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
            tstb_currentUser.Text = CurrentUser.userID +" "+ CurrentUser.userName;
            
        }
        #endregion

        #region tabpage process

        /// <summary>
        /// open form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemClick(object sender, EventArgs e)
        {


            ToolStripItem toolStripItem = (ToolStripItem)sender;
            // Instantiate the form using reflection
            Type formType = Type.GetType(toolStripItem.Tag.ToString());
            Form form = (Form)Activator.CreateInstance(formType);


            string tabPageText = form.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(form, tabPageText, tabControl1, false);


                   



        }

        /// <summary>
        /// custom header of tabpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            TabPage tabPage = tabControl1.TabPages[e.Index];


            string tabText = tabPage.Text;
            tabPage.ToolTipText = tabText;


            // Create a font for drawing the close button
            var closeButtonFont = new Font("Segoe UI", 8, FontStyle.Bold);

            // Calculate the bounds of the tab header text and the button
            Rectangle tabBounds = tabControl1.GetTabRect(e.Index);

            Rectangle textBounds = new Rectangle(tabBounds.Location, new Size(tabBounds.Width - 16, tabBounds.Height));

            Rectangle buttonBounds = new Rectangle(tabBounds.Right - 16, tabBounds.Top, 16, 16);


            // Use a Graphics object to measure the text width


            SizeF textSize = e.Graphics.MeasureString(tabText, tabPage.Font);

            // If the text overflows, replace the excess characters with an ellipsis
            if (textSize.Width > textBounds.Width)
            {
                int ellipsisWidth = TextRenderer.MeasureText("...", tabPage.Font).Width;
                int cutoff = 0;
                for (int i = tabText.Length - 1; i >= 0; i--)
                {
                    textSize = e.Graphics.MeasureString(tabText.Substring(0, i) + "...", tabPage.Font);
                    if (textSize.Width + ellipsisWidth <= e.Bounds.Width)
                    {
                        cutoff = i;
                        break;
                    }
                }
                tabText = tabText.Substring(0, cutoff) + "...";
            }

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };


            // Draw the tab header text in unslected status of tabpage 
            //TextRenderer.DrawText(e.Graphics, tabText, tabPage.Font, textBounds, tabPage.ForeColor,TextFormatFlags.VerticalCenter);

            e.Graphics.DrawString(tabText, tabPage.Font, Brushes.Black, tabBounds, sf);


            // Draw the button and fill backgroud when selected the tabpage


            if (e.Index == tabControl1.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.SkyBlue), tabBounds);
                e.Graphics.DrawString(tabText, tabPage.Font, Brushes.Black, textBounds, sf);

                e.Graphics.DrawString("X", closeButtonFont, Brushes.Red, buttonBounds);
            }


            // Store the button bounds in the Tag property of the tabPage
            tabPage.Tag = buttonBounds;

        }


        /// <summary>
        /// colse the child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                TabPage tabPage = tabControl1.TabPages[i];
                Rectangle buttonBounds = (Rectangle)tabPage.Tag;

                if (buttonBounds.Contains(e.Location))
                {
                    // Close the child form of the tabPage
                    Form childForm = tabPage.Controls[0] as Form;
                    childForm.Close();

                    //Remove the tabPage from the tabControl
                    tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }


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
            FrmDeleteLockedVendor f = new FrmDeleteLockedVendor();
            embedForm(f);
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
            FrmPerson config = new FrmPerson();
            embedForm(config);
        }

        private void 权限生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db=new DataMaintenanceContext())
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
            FrmMenuList f = new FrmMenuList();
            embedForm(f);
        }

        private void 重登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Application.Restart();
            UI.Frmlogin frm_Login = new UI.Frmlogin();
            frm_Login.ShowDialog();
           
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

        private void tsmArchiveAttachment_Click(object sender, EventArgs e)
        {
            FrmArchiveAttachment f = new FrmArchiveAttachment();
            embedForm(f);
        }

        private void tsmSmbConnectiongString_Click(object sender, EventArgs e)
        {
            FrmSmbConfig f = new FrmSmbConfig();
            embedForm(f);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (CurrentUser.userID!="2007" || CurrentUser.userID=="043")
            {
                this.成本管理ToolStripMenuItem.Visible = false;
            }
        }
    }
}
