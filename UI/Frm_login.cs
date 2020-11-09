using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Services;
using DataMaintenance.Modle;
using Utility;
using System.Configuration;

namespace DataMaintenance.UI
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
            intializeControlState();
            initializeDatasource();
        }


        #region 初始化

        void intializeControlState()
        {
            lbl_information.Visible = false;
            checkDatabaseConect();
        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
        {
            
        }

        #endregion



        #region 事件

        public event EventHandler<AuthorizationEventArgs> authorizPass;

        /// <summary>
        /// 事件处理方法,调用端实例化事件委托后就执行该方法
        /// authorizPass?本质上相当于执行方法时的第二次判断
        /// 引发事件是执行事件处理方法的第一次判断
        /// </summary>
        /// <param name="authorizationEventArgs"></param>
        protected virtual void onAuthorizPass(AuthorizationEventArgs authorizationEventArgs)
        {
            authorizPass?.Invoke(this, authorizationEventArgs);
        }

        /// <summary>
        /// 登录确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_certain_Click(object sender, EventArgs e)
        {
           
            if (txt_pwd.Text != "")
            {
                string pwd = Encrypt.Encode(txt_pwd.Text);


                if (new UserService().loginCheck(txt_userID.Text, pwd))
                {
                    Frm_main f = new Frm_main();
                    f.Show();

                    this.Hide();
                    f.FormClosed += closeLoginForm;
                }


                else
                {

                    lbl_information.Text = "";
                    lbl_information.Text = lbl_information.Text + "您输入的用户名或密码不正确，请重新输入";
                    lbl_information.Visible = true;
                    txt_pwd.Focus();

                }

            }
            else
            {
                lbl_information.Text = "";
                lbl_information.Text = "请输入密码";
                lbl_information.Visible = true;
                txt_pwd.Focus();

            }

        }

        #endregion



        private void closeLoginForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_conect_Click(object sender, EventArgs e)
        {
            Utility.UI.Frm_DoubleDB_loginConfig f = new Utility.UI.Frm_DoubleDB_loginConfig();
            
            f.ShowDialog();
        }

        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }

        void checkDatabaseConect()
        {
            if(ConfigurationManager.ConnectionStrings["plugConection"] != null & ConfigurationManager.ConnectionStrings["myConection"] != null)
            {
                btn_conect.Visible = false;
            }
        }
    }

    



    /// <summary>
    /// 事件数据类，传递验证成功数据，类似于模型类，用于存储数据
    /// </summary>
    //public class AuthorizationEventArgs : EventArgs

    //{
    //    public bool userAndPwdRight { get; set; }
    //}
}
