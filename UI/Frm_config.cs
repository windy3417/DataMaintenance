using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Modle;
using Utility;

namespace DataMaintenance.UI
{
    public partial class Frm_config : Utility.UI.Frm_DoubleDB_loginConfig
    {
        public Frm_config()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 管理员信息设置
        /// </summary>
      protected  override void adminSetUp()
        {
            using (var db = new DataMaitenanceContext())
            {
                UserModle m = new UserModle();

                m.userID = base.txt_adminCode.Text;
                m.name = base.txt_adminName.Text;
                m.pwd = Utility.Encrypt.Encode(base.txt_adminPwd.Text);
                m.RegistrationDate = DateTime.Now;

                db.Users.Add(m);
                db.SaveChanges();
            }

        }
    }
}
