using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DataMaintenance.Model;
using Utility;
using DataMaintenance.DAL;

namespace DataMaintenance.UI
{
    public partial class Frm_authorization : Form
    {
        public Frm_authorization()
        {
            InitializeComponent();
            initializeDatasource();
        }

     


        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
        {
            cmb_user.DataSource = new UserService().getUserList().Where<UserModle>(c => c.DateOfCancellation == null).Select((c) => new { c.userID, c.UserName,c.pwd,c.RegistrationDate }).ToList();

            cmb_user.DisplayMember = "name";
            cmb_user.ValueMember = "userID";

           
        }

        #region 自定义事件

        /// <summary>
        /// 定义事件
        /// </summary>
        public event EventHandler<AuthorizationEventArgs> authorizPass;


        /// <summary>
        /// 引发事件
        /// 授权修改权限，授权通过后则引发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_certain_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            if (txt_pwd.Text != "")
            {
                string pwd = Encrypt.Encode(txt_pwd.Text);


                if (new UserService().loginCheck(cmb_user.SelectedValue.ToString(), pwd))
                {
                    //引发事件并传递事件包含的数据，该事件检验用户名密码是否正确
                    AuthorizationEventArgs authorizationEventArgs = new AuthorizationEventArgs();
                    authorizationEventArgs.userAndPwdRight = true;
                    onAuthorizPass(authorizationEventArgs);

                    this.Close();
                }


                else
                {

                    lbl_information.Text = "";
                    lbl_information.Text = lbl_information.Text + "您输入受权密码不正确，请重新输入";

                }

            }
            else
            {
                lbl_information.Text = "";
                lbl_information.Text = "请输入受权密码";

            }

        }

        /// <summary>
        /// 事件处理方法
        /// 调用端实例化事件委托后就执行该方法
        /// authorizPass?本质上相当于执行方法时的第二次判断
        /// 引发事件是执行事件处理方法的第一次判断
        /// </summary>
        /// <param name="authorizationEventArgs"></param>
        protected virtual void onAuthorizPass(AuthorizationEventArgs authorizationEventArgs)
        {
            authorizPass?.Invoke(this, authorizationEventArgs);
        }

        /// <summary>
        /// 事件数据类，传递验证成功数据，类似于模型类，用于存储数据
        /// </summary>
        public class AuthorizationEventArgs : EventArgs

        {
            public bool userAndPwdRight { get; set; }
        }

        #endregion



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           
        }
    }


    
}
