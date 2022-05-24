
using DataMaintenance.DAL.U8services;
using DataMaintenance.DAL.U8services.TableServices;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.Ref;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.DAL;
using Utility.Files;
using Utility.Model;
using Utility.Style;

namespace DataMaintenance.UI.U8Attachment
{
    public partial class FrmArchiveAttachment : Form
    {
        public FrmArchiveAttachment()
        {
            InitializeComponent();
            InitializeControlsData();
            InitializeControlsState();
        }


        private void FrmArchiveAttachment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region get data


        void InitializeControlsData()
        {
            cmbArchiveType.Text = "客户";
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            switch (cmbArchiveType.Text)
            {
                case "客户":
                    FrmRefCustomer f = new FrmRefCustomer();
                    f.ActionRefCustomerEntity = GetCustomerCode;
                    f.Show();
                    break;
            }
        }

        void GetCustomerCode(Customer customer)
        {
            this.txtArchiveCode.Text = customer.cCusCode;
            this.txtArchvieName.Text = customer.cCusName;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string archiveType = "";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
     
            if (txtArchiveCode.Text != "")
            {
                sqlParameters.Add(new SqlParameter("@cInvCode", txtArchiveCode.Text));
            }

           
            if (cmbArchiveType.Text == "客户")
            {
                archiveType = "Customer";
                sqlParameters.Add(new SqlParameter("@cTableName", archiveType));
                this.dataGridView1.DataSource = new CustomerAttachmentService().GetCustomerArchive(sqlParameters).ToList();
            }
            if (cmbArchiveType.Text == "供应商")
            {
                archiveType = "Vendor";
            }

            if (cmbArchiveType.Text == "存货")
            {
                archiveType = "Inventory";
            }

            //SqlParameter[] sqlParameters = { new SqlParameter("@cInvCode", txtArchiveCode.Text), new SqlParameter("@cTableName", archiveType) };

        
          

           


            //var q = QueryService.GetDataList<Attachfile>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8);

            //var q1 = QueryService.GetDataList<Customer>(Utility.Sql.Sqlhelper.DataSourceType.u8);

            //var q3 = from s in q
            //         join c in q1 on s.cInvCode equals c.cCusCode
            //         select new { cInvCode = c.cCusCode, archiveMarsterName = c.cCusName, archiveName = s.cFileName, s.AttachFileGUID };

            

            this.DecorateDataGridView();
        }

        #endregion


        #region style
        void InitializeControlsState()
        {
            this.FormClosed += FrmArchiveAttachment_FormClosed;
            dataGridView1.AutoGenerateColumns = false;

        }

        void DecorateDataGridView()
        {
            this.downLoad.Text = "下载";
            //let button display "download"
            this.downLoad.UseColumnTextForButtonValue = true;
            this.dataGridView1.DoubleBuffered(true);

            dataGridView1.AutoResizeColumns();



        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView style = new Utility.Style.StyleDataGridView();
            style.DisplayRowNo(e, dataGridView1);
            style.DataGridViewColumnHeaderStyle(dataGridView1);

        }



        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
             dataGridView1.Columns["downLoad"].Index) return;
            ConnectString connectString = new ConnectString();
            ConnectStringModel m = connectString.GetSmbConnectionString(Environment.CurrentDirectory + @"/SmbConfig.bin");

            string[] savingFileName = dataGridView1.CurrentRow.Cells["archiveName"].Value.ToString().Split(new char[] { '.' });
            string extName = "."+ savingFileName.Last();

            if (extName!=".rar")
            {
                extName = ".txt";
            }

            string fileName = dataGridView1.CurrentRow.Cells["GUID"].Value.ToString() + extName;

            byte[] data = new SmbFiels().GetFile(m.DataSource.Trim(), m.DataBase, m.FileDirectory, fileName, m.UserName, m.Pwd).ToArray();

            string saveDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\" + dataGridView1.CurrentRow.Cells["archiveName"].Value;
            FileStream fs = new FileStream(saveDir , FileMode.Create);
            fs.Write(data, 0, data.Length);



            System.Diagnostics.Process.Start(saveDir);

        }
    }
}
