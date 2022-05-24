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
using System.IO;

namespace DataMaintenance.UI.SetUp
{
    public partial class FrmSmbConfig : Form
    {
        public FrmSmbConfig()

        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbTest_Click(object sender, EventArgs e)
        {
            
            SmbFiels smbFiels = new SmbFiels();

            try
            {
                if (smbFiels.ConnectTest(txtHostName.Text, txtUser.Text, txtPwd.Text))
                {
                    MessageBox.Show("测试连接成功！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }

            //try
            //{
            //   byte[] data=   smbFiels.GetFile(txtHostName.Text, txtDirectory.Text, txtFilePath.Text, 
            //       "7b5dfbcb-2f25-49ea-a5b8-0080702d8835.txt", txtUser.Text, txtPwd.Text).ToArray();


            //    FileStream fs = new FileStream(Environment.CurrentDirectory + "test.pdf", FileMode.Create);


            //    fs.Write(data, 0, data.Length);

            //    MessageBox.Show("download success");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}





        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// save connecting  string of smb 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbSave_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.txtHostName.Text;
            m.DataBase = txtDirectory.Text;
            m.FileDirectory = txtFilePath.Text;
            m.UserName = this.txtUser.Text;
            m.Pwd = this.txtPwd.Text;

            //存储到物理文件SmbConnectiongString.text
                         
            ConnectString connectString = new ConnectString();
            connectString.PutSmbConnectionString(m,Environment.CurrentDirectory+@"/SmbConfig.bin");

         
        }

        /// <summary>
        /// 读取数据库配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfig_Load(object sender, EventArgs e)
        {
         
          ConnectString connectString = new ConnectString();
          ConnectStringModel m=  connectString.GetSmbConnectionString(Environment.CurrentDirectory + @"/SmbConfig.bin");

            if (m!= null)
            {
                this.txtHostName.Text = m.DataSource;
                this.txtDirectory.Text = m.DataBase;
                txtFilePath.Text = m.FileDirectory;
                this.txtUser.Text = m.UserName;
                txtPwd.PasswordChar = '*';
                this.txtPwd.Text = m.Pwd;
            }
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectString connectString = new ConnectString();
            ConnectStringModel m = connectString.GetSmbConnectionString(Environment.CurrentDirectory + @"/SmbConfig.bin");
            //new SmbFiels().ReadSmbFile(m.DataSource, m.DataBase, "下载链接.docx", m.UserName, m.Pwd);
            new SmbFiels().GetFile(m.DataSource, m.DataBase, m.FileDirectory, "下载链接.docx",m.UserName, m.Pwd);

        }
    }
}
