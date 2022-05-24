using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.DAL;
using Utility.Model;
using static Utility.Sql.Sqlhelper;
using Utility.Files;

namespace DataMaintenance.UI.SetUp

{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region 变量
        #endregion


        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbTest_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();
         
            m.DataSource = this.DbIT.TxtServer.Text;
            m.DataBase = this.DbIT.TxtDataBase.Text;
            m.UserName = this.DbIT.TxtUser.Text;
            m.Pwd = this.DbIT.TxtPWD.Text;

            Utility.DAL.ConnectString dbConnect = new Utility.DAL.ConnectString();
            dbConnect.DbConnectTest(m);
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.DbIT.TxtServer.Text;
            m.DataBase = this.DbIT.TxtDataBase.Text;
            m.UserName = this.DbIT.TxtUser.Text;
            m.Pwd = this.DbIT.TxtPWD.Text;

            //存储到AppConfig文件中
            ConnectString dbConnect = new ConnectString();
            dbConnect.DbConnectStringSave(m, DataSourceType.it.ToString());

            //存储为Json文件
            m.Pwd = Utility.Encrypt.Encode("mixture"); //不存储真实密码
            string fileName= Environment.CurrentDirectory + "\\" + DataSourceType.it.ToString() + "DBConfig.txt";
            Utility.Files.JsonOperate jsonOperate = new Utility.Files.JsonOperate();
            jsonOperate.ModelToJsonFile(fileName, m);
        }

        /// <summary>
        /// 读取数据库配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            string itFileName = Environment.CurrentDirectory + "\\" + DataSourceType.it.ToString() + "DBConfig.txt";
            string u8FileName = Environment.CurrentDirectory + "\\" + DataSourceType.u8.ToString() + "DBConfig.txt";
            ConnectString dbConnect = new ConnectString();
            dbConnect.ReadConfig(itFileName, this.lblStatus);
            dbConnect.ReadConfig(u8FileName, this.lblU8status);
        }

        #region U8数据库

        private void btnU8test_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.DBU8.TxtServer.Text;
            m.DataBase = this.DBU8.TxtDataBase.Text;
            m.UserName = this.DBU8.TxtUser.Text;
            m.Pwd = this.DBU8.TxtPWD.Text;

            Utility.DAL.ConnectString dbConnect = new Utility.DAL.ConnectString();
            dbConnect.DbConnectTest(m);
        }

        private void tsbU8save_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.DBU8.TxtServer.Text;
            m.DataBase = this.DBU8.TxtDataBase.Text;
            m.UserName = this.DBU8.TxtUser.Text;
            m.Pwd = this.DBU8.TxtPWD.Text;

            //存储到AppConfig文件中
            ConnectString dbConnect = new ConnectString();
            dbConnect.DbConnectStringSave(m, DataSourceType.u8.ToString());

            //存储为Json文件
            m.Pwd = Utility.Encrypt.Encode("mixture"); //不存储真实密码
            string fileName = Environment.CurrentDirectory + "\\" + DataSourceType.u8.ToString() + "DBConfig.txt";
            Utility.Files.JsonOperate jsonOperate = new Utility.Files.JsonOperate();
            jsonOperate.ModelToJsonFile(fileName, m);
        }


        #endregion


        #region ufsystem库连接
        /// <summary>
        /// ufsystem库的连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUFsystemTest_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.dbUfSystem.TxtServer.Text;
            m.DataBase = this.dbUfSystem.TxtDataBase.Text;
            m.UserName = this.dbUfSystem.TxtUser.Text;
            m.Pwd = this.dbUfSystem.TxtPWD.Text;

            Utility.DAL.ConnectString dbConnect = new Utility.DAL.ConnectString();
            dbConnect.DbConnectTest(m);
        }

        private void btnSaveUfSystemp_Click(object sender, EventArgs e)
        {

            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.dbUfSystem.TxtServer.Text;
            m.DataBase = this.dbUfSystem.TxtDataBase.Text;
            m.UserName = this.dbUfSystem.TxtUser.Text;
            m.Pwd = this.dbUfSystem.TxtPWD.Text;

            //存储到AppConfig文件中
            ConnectString dbConnect = new ConnectString();
            dbConnect.DbConnectStringSave(m, DataSourceType.ufsystem.ToString());

            //存储为Json文件
            m.Pwd = Utility.Encrypt.Encode("mixture"); //不存储真实密码
            string fileName = Environment.CurrentDirectory + "\\" + DataSourceType.u8.ToString() + "DBConfig.txt";
            Utility.Files.JsonOperate jsonOperate = new Utility.Files.JsonOperate();
            jsonOperate.ModelToJsonFile(fileName, m);
        }

        #endregion


    }
}
