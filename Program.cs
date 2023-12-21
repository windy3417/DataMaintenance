using DataMaintenance.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataMaintenance
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region 登录检测
            Frmlogin frm_Login = new Frmlogin();

            frm_Login.ShowDialog();
            if (frm_Login.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

            #endregion


            //Application.Run(new FrmMain());


        }

    }
}
