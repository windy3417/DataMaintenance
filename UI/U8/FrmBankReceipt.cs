

using DataMaintenance.DAL.ViewServices.U8services;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.Ref;
using SMBLibrary.Client;
using SMBLibrary;
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
using U8service.DAL.JoinTableSvc;

using Utility.DAL;
using Utility.Files;
using Utility.Model;
using Utility.Sql;
using Utility.Style;


namespace DataMaintenance.UI.U8
{
    public partial class FrmBankReceipt : Form
    {
        public FrmBankReceipt()

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

            // if the file name is not pdf, return
            if (!dataGridView1.CurrentRow.Cells[this.archiveName.Name.ToString()].Value.ToString().EndsWith(".pdf"))
            {

                MessageBox.Show("银行承兑汇票支付，请在网银系统下载签收回单");
                return;
            }

            string[] savingFileName = dataGridView1.CurrentRow.Cells[this.archiveName.Name.ToString()].Value.ToString().Split(new char[] { '.' });
            string[] fileDirectoryArray = savingFileName[0].Split(new char[] { '-' });

            StringBuilder fileDirectory = new StringBuilder();

            for (int i = 0; i < fileDirectoryArray.Length - 1; i++)
            {
                fileDirectory.Append(fileDirectoryArray[i]);
                if (i != fileDirectoryArray.Length - 2)
                {
                    fileDirectory.Append("\\");
                }
            }

            ConnectStringModel m = new ConnectStringModel
            {
                DataBase = "BankReceipt",
                FileDirectory = "CS\\" + $"{fileDirectory.ToString()}",
                Pwd = "Br2007",
                UserName = "bank"
            };


            string fileName = dataGridView1.CurrentRow.Cells[this.archiveName.Name.ToString()].Value.ToString();

            byte[] data = new SmbFiels().GetFile("192.168.10.201", m.DataBase, m.FileDirectory, fileName, m.UserName, m.Pwd).ToArray();

            string saveDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + dataGridView1.CurrentRow.Cells["archiveName"].Value;
            FileStream fs = new FileStream(saveDir, FileMode.Create);
            fs.Write(data, 0, data.Length);
            fs.Close();



            System.Diagnostics.Process.Start(saveDir);

        }

        private void BatchDowanloadFiles(object sender, EventArgs e)
        {


            if (MessageBox.Show("确认批量下载？这将是个耗时操作", "download or not", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Cursor = Cursors.WaitCursor;



                //choose save directory
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string savePath = folderBrowserDialog.SelectedPath;


                //construct a file path array from each archiveName cell value of row in dataGridView1

                List<string> filePathList = new List<string>();
                List<string> failedFileList = new List<string>();
                int successCount = 0;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // if the file name is not pdf, next
                    if (!dataGridView1.Rows[i].Cells[this.archiveName.Name.ToString()].Value.ToString().EndsWith(".pdf"))
                    {
                        continue;
                    }
                    filePathList.Add(dataGridView1.Rows[i].Cells[this.archiveName.Name.ToString()].Value.ToString());

                }

                //construct a file directory array from filePathList
                for (int i = 0; i < filePathList.Count; i++)
                {
                    string[] savingFileName = filePathList[i].Split(new char[] { '.' });
                    string[] fileDirectoryArray = savingFileName[0].Split(new char[] { '-' });
                    StringBuilder fileDirectory = new StringBuilder();
                    for (int j = 0; j < fileDirectoryArray.Length - 1; j++)
                    {
                        fileDirectory.Append(fileDirectoryArray[j]);
                        if (j != fileDirectoryArray.Length - 1)
                        {
                            fileDirectory.Append("\\");
                        }


                    }
                   
                    //fetch file from smb server
                    ConnectStringModel m = new ConnectStringModel
                    {
                        DataBase = "BankReceipt",
                        FileDirectory = "CS\\" + $"{fileDirectory.ToString()}",
                        Pwd = "Br2007",
                        UserName = "bank"
                    };
                    string fileName = filePathList[i];

                    //if file does not exist, next
                    if (new SmbFiels().GetFile("192.168.10.201", m.DataBase, m.FileDirectory, fileName, m.UserName, m.Pwd)is null)
                    {
                        failedFileList.Add(fileName);
                        continue;
                    }   

                    byte[] data = new SmbFiels().GetFile("192.168.10.201", m.DataBase, m.FileDirectory, fileName, m.UserName, m.Pwd).ToArray();


                    FileStream fs = new FileStream(savePath + "\\" + fileName, FileMode.Create);
                    fs.Write(data, 0, data.Length);
                    successCount++;
                    fs.Close();


                }




                this.Cursor = Cursors.Default;
                // show combined result in a single message box
                StringBuilder resultSb = new StringBuilder();
                resultSb.AppendFormat("成功下载{0}个银行回单", successCount);
                if (failedFileList.Count > 0)
                {
                    resultSb.AppendLine();
                    resultSb.AppendLine();
                    resultSb.AppendLine("以下文件下载失败：");
                    foreach (var file in failedFileList)
                    {
                        resultSb.AppendLine(file);
                    }
                }

                MessageBox.Show(resultSb.ToString());
            }

        }


        private void tsbQuery_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var query = @"
                    select c.cVenCode, c.cVenName, b.dVouchDate,
                           b.cDigest, a.downloadState
                    from ef_bank_log as a
                    inner join AP_ApplyPayVouch as b on a.cVouchid = b.cVouchID
                    inner join Vendor as c on b.cDwCode = c.cVenCode
                    where a.downloadState <> ''";

                var filters = new List<string>();
                var parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(xmtxtVendorCode.Text))
                {
                    filters.Add("c.cVenCode=@vendorCode");
                    parameters.Add(new SqlParameter("@vendorCode", $"%{xmtxtVendorCode.Text.Trim()}%"));
                }

                // Optional date range filter
                if (chkEnableDateFilter.Checked)
                {
                    filters.Add("b.dVouchDate >= @startDate AND b.dVouchDate < @endDate");
                    //set satart date as first day of last month


                    parameters.Add(new SqlParameter("@startDate", dtpStartDate.Value));
                    parameters.Add(new SqlParameter("@endDate", dtpEndDate.Value.AddDays(1))); // inclusive
                }

                if (filters.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", filters);
                }

                using (SqlConnection conn = Sqlhelper.sqlConnection(Sqlhelper.DataSourceType.u8, txtAccountNo.Text.ToString()))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                this.Cursor = Cursors.Default;
                this.DecorateDataGridView();
            }
            catch (Exception)
            {
                throw;
            }
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


        }


        #region data bind
        void GetInventoryCode(Inventory inventory)
        {
            this.xmtxtVendorCode.Text = inventory.cInvCode;
            this.txtArchvieName.Text = inventory.cInvName;

        }

        void GetCutomerCode(U8service.Model.Customer customer)
        {
            this.xmtxtVendorCode.Text = customer.cCusCode;
            this.txtArchvieName.Text = customer.cCusName;

        }

        void GetVendorCode(Vendor vendor)
        {
            this.xmtxtVendorCode.Text = vendor.cVenCode;
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

            if (xmtxtVendorCode.Text != "")
            {
                sqlParameters.Add(new SqlParameter("@cInvCode", xmtxtVendorCode.Text));
            }




        }



        void SetDefaultValue()
        {
            txtAccountNo.Text = "017";
            DateTime now = DateTime.Now;
            DateTime firstDayOfLastMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
            dtpStartDate.Value = firstDayOfLastMonth;
        }
        #endregion

        #endregion


        #region UI handl
        void InitializeControlsState()
        {
            this.FormClosed += FrmArchiveAttachment_FormClosed;
            xmtxtVendorCode.RefButton.Click += RefButton_Click;
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
            style.DisplayRowNo(e, dataGridView1, false);
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
    }



}
