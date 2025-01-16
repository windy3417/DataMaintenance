

using DataMaintenance.DAL.ViewServices.U8services;
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
using U8services.DAL.JoinTableServices;
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
            SetDefaultValue();
            InitializeControlsState();
        }

         


        #region get data


        /// <summary>
        /// download files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
             dataGridView1.Columns["downLoad"].Index) return;
            ConnectString connectString = new ConnectString();
            ConnectStringModel m = connectString.GetSmbConnectionString(Environment.CurrentDirectory + @"/SmbConfig.bin");

            string[] savingFileName = dataGridView1.CurrentRow.Cells["archiveName"].Value.ToString().Split(new char[] { '.' });
            string extName = "." + savingFileName.Last();

            if (extName != ".rar")
            {
                extName = ".txt";
            }

            string fileName = dataGridView1.CurrentRow.Cells["GUID"].Value.ToString() + extName;

            byte[] data = new SmbFiels().GetFile(m.DataSource.Trim(), m.DataBase, m.FileDirectory, fileName, m.UserName, m.Pwd).ToArray();

            string saveDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + dataGridView1.CurrentRow.Cells["archiveName"].Value;
            FileStream fs = new FileStream(saveDir, FileMode.Create);
            fs.Write(data, 0, data.Length);
            fs.Close();



            System.Diagnostics.Process.Start(saveDir);

        }


        /// <summary>
        /// refer  data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefButton_Click(object sender, EventArgs e)

        {

            this.Cursor = Cursors.WaitCursor;
            //choose reference form

            switch (cmbArchiveType.Text)
            {
                case "客户":
                   U8services.UI.FrmRef.FrmRefCustomer  f = new U8services.UI.FrmRef.FrmRefCustomer(txtAccountNo.Text);
                    f.ActionRefCustomerEntity = GetCutomerCode;
                    f.Show();
                    break;

                case "存货":
                    FrmRefInventoryWithAttacchment fi = new FrmRefInventoryWithAttacchment();
                    fi.ActionRefIventoryEntity = GetInventoryCode;
                    fi.Show();
                    this.Cursor = Cursors.Default;
                    break;
                case "供应商":
                    FrmRefVendor fv = new FrmRefVendor();
                    fv.ActionRefVendorEntity = GetVendorCode;
                    fv.Show();
                    this.Cursor = Cursors.Default;
                    break;
            }
        }
          
        

        #region data bind
        void GetInventoryCode(Inventory inventory)
        {
            this.xmtxtArchivementBodyCode.Text = inventory.cInvCode;
            this.txtArchvieName.Text = inventory.cInvName;

        }

        void GetCutomerCode(U8services.Model.Customer  customer)
        {
            this.xmtxtArchivementBodyCode.Text = customer.cCusCode;
            this.txtArchvieName.Text = customer.cCusName;

        }

        void GetVendorCode(Vendor vendor)   
        {
            this.xmtxtArchivementBodyCode.Text = vendor.cVenCode;
            this.txtArchvieName.Text = vendor.cVenName;

        }

        /// <summary>
        /// bind data to dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string archiveType = "";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            if (xmtxtArchivementBodyCode.Text != "")
            {
                sqlParameters.Add(new SqlParameter("@cInvCode", xmtxtArchivementBodyCode.Text));
            }


            if (cmbArchiveType.Text == "客户")
            {
                archiveType = "Customer";
                sqlParameters.Add(new SqlParameter("@cTableName", archiveType));
                this.dataGridView1.DataSource = new CustomerAttachmentService(txtAccountNo.Text).GetCustomerArchive(sqlParameters).ToList();
            }
            if (cmbArchiveType.Text == "供应商")
            {
                archiveType = "Vendor";
                sqlParameters.Add(new SqlParameter("@cTableName", archiveType));
                this.dataGridView1.DataSource = new U8services.DAL.JoinTableServices.VendorAttachmentService(txtAccountNo.Text).GetVendorArchive(sqlParameters).ToList();
            }

            if (cmbArchiveType.Text == "存货")
            {
                //采用sqlhelper 中的方法直联数据库，否则太慢
                archiveType = "Inventory";
                SqlParameter[] sqlParameter= { new SqlParameter("@cTableName", archiveType) ,
                new SqlParameter("@cInvCode", xmtxtArchivementBodyCode.Text)};
                
             
                this.dataGridView1.DataSource = new U8services.DAL.JoinTableServices.InventoryAttachmentService().GetInventoryArchive(sqlParameter);
            }



            this.Cursor = Cursors.Default;
            this.DecorateDataGridView();
        }

        void SetDefaultValue()
        {
            cmbArchiveType.Text = "客户";
            txtAccountNo.Text = "017";
        }
        #endregion



        #endregion


        #region UI handl
        void InitializeControlsState()
        {
            this.FormClosed += FrmArchiveAttachment_FormClosed;
            xmtxtArchivementBodyCode.RefButton.Click += RefButton_Click;
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
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dataGridView1,false);
            style.DataGridViewColumnHeaderStyle(dataGridView1);

        }

        private void FrmArchiveAttachment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string archiveType = "";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            if (xmtxtArchivementBodyCode.Text != "")
            {
                sqlParameters.Add(new SqlParameter("@cInvCode", xmtxtArchivementBodyCode.Text));
            }


            if (cmbArchiveType.Text == "客户")
            {
                archiveType = "Customer";
                sqlParameters.Add(new SqlParameter("@cTableName", archiveType));
                this.dataGridView1.DataSource = new CustomerAttachmentService(txtAccountNo.Text).GetCustomerArchive(sqlParameters).ToList();
            }
            if (cmbArchiveType.Text == "供应商")
            {
                archiveType = "Vendor";
                sqlParameters.Add(new SqlParameter("@cTableName", archiveType));
                this.dataGridView1.DataSource = new U8services.DAL.JoinTableServices.VendorAttachmentService(txtAccountNo.Text).GetVendorArchive(sqlParameters).ToList();
            }

            if (cmbArchiveType.Text == "存货")
            {
                //采用sqlhelper 中的方法直联数据库，否则太慢
                archiveType = "Inventory";
                SqlParameter[] sqlParameter = { new SqlParameter("@cTableName", archiveType) ,
                new SqlParameter("@cInvCode", xmtxtArchivementBodyCode.Text)};


                this.dataGridView1.DataSource = new U8services.DAL.JoinTableServices.InventoryAttachmentService().GetInventoryArchive(sqlParameter);
            }



            this.Cursor = Cursors.Default;
            this.DecorateDataGridView();
        }
    }
}
