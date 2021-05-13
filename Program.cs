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

            //#region 登录检测
            //Frm_login frm_Login = new Frm_login();

            //frm_Login.ShowDialog();
            //if (frm_Login.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new Frm_main());
            //}
            //else
            //{
            //    Application.Exit();
            //}

            //#endregion


            Application.Run(new FrmMain());


        }

    }
}
