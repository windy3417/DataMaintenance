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
            cmb_user.DataSource = new UserService().getUserList().Where<UserModle>(c => c.DateOfCancellation == null).Select((c) => new { c.userID, c.name,c.pwd,c.RegistrationDate }).ToList();

            cmb_user.DisplayMember = "name";
            cmb_user.ValueMember = "userID";

           
        }

        #region 事件

        public event EventHandler<AuthorizationEventArgs> authorizPass;

        /// <summary>
        /// 事件处理方法,调用端实例化事件委托后就执行
        /// </summary>
        /// <param name="authorizationEventArgs"></param>
        protected virtual void onAuthorizPass(AuthorizationEventArgs authorizationEventArgs)
        {
            authorizPass?.Invoke(this, authorizationEventArgs);
        }

        #endregion

        private void btn_certain_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            if (txt_pwd.Text!="")
            {
                string pwd = Encrypt.Encode(txt_pwd.Text);
              

                if (new UserService().loginCheck(Convert.ToInt32(cmb_user.SelectedValue), pwd))
                {
                    //引发验证通过事件
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           
        }
    }


    /// <summary>
    /// 事件数据类，传递验证成功数据
    /// </summary>
    public class AuthorizationEventArgs : EventArgs

    {
        public bool userAndPwdRight { get; set; }
    }
}
