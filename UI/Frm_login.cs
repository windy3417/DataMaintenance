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
            txt_userID.Focus();
            //txt_userID.TabIndex = 0;
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
           
            if (inputVlidate())
            {
                //登录系统
                if (ch_changePWD.Checked == false)
                {
                    string pwd = Encrypt.Encode(txt_pwd.Text);
                    //string pwd = txt_pwd.Text;


                    if (new UserService().loginCheckWithSqlparameters(txt_userID.Text, pwd))
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
                //登录系统并修改密码
                else
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

            }
            ;


        }


        /// <summary>
        /// 登录前数据库连接设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_conect_Click(object sender, EventArgs e)
        {
            Utility.UI.Frm_DoubleDB_loginConfig f = new Utility.UI.Frm_DoubleDB_loginConfig();

            f.ShowDialog();
        }

        #endregion



        private void closeLoginForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
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

        /// <summary>
        /// 检测数据库是否连接
        /// </summary>
        void checkDatabaseConect()
        {
            if (ConfigurationManager.ConnectionStrings["plugConection"] != null & ConfigurationManager.ConnectionStrings["myConection"] != null)
            {
                btn_conect.Visible = false;
            }
        }

        /// <summary>
        /// 非空校验
        /// </summary>
        /// <returns></returns>
        private bool inputVlidate()
        {

            for (int i = 0; i < this.p_login.Controls.Count;)
            {

                if (this.p_login.Controls[i].Text == "" || this.p_login.Controls[i].Text == null)
                {
                    MessageBox.Show(this.p_login.Controls[i].Tag + "不能为空", "输入校验");
                    return false;
                }


                i++;


            }
            return true;


        }
    }






}
