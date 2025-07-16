using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U8service.DAL.JoinTable.Purchase;
using U8service.Model;
using U8service.Model.ViewModel;
using U8service.UI.FrmRef;

namespace DataMaintenance.UI.U8
{
    public partial class FrmPoAttachment : Form
    {
        public FrmPoAttachment()
        {
            InitializeComponent();
            txtAccountNo.Text = "017";
            xmTxtVendor.RefButton.Click += RefButton_Click;

        }
        List<POVModel> ls;

        private void RefButton_Click(object sender, EventArgs e)
        {
            FrmRefVendor fv = new FrmRefVendor(txtAccountNo.Text);
            fv.ActionRefVendorEntity = GetVendorCode;
            fv.Show();
        }


        void GetVendorCode(Vendor vendor)
        {

            this.xmTxtVendor.Text = vendor.cVenCode + "-" + vendor.cVenName;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var getPoAttachment = new U8service.DAL.JoinTable.Purchase.POSvc(txtAccountNo.Text);
            if (rbDetail.Checked)
            {
                if (ls is null)
                {
                    this.ls = getPoAttachment.GetPO(dtpStartDate.Value, dtpEndDate.Value, cmbBizType.Text.ToString());
                    dgvBody.DataSource = ls;
                }
                else
                {
                    ls.Clear();
                    this.ls = getPoAttachment.GetPO(dtpStartDate.Value, dtpEndDate.Value, cmbBizType.Text.ToString());
                    dgvBody.DataSource = ls;
                }

            }
            else
            {

                if (ls is null)
                {
                    this.ls = getPoAttachment.GetPOHeader(dtpStartDate.Value, dtpEndDate.Value, cmbBizType.Text.ToString());
                    dgvBody.DataSource = ls;
                }
                else
                {
                    ls.Clear();
                    this.ls = getPoAttachment.GetPOHeader(dtpStartDate.Value, dtpEndDate.Value, cmbBizType.Text.ToString());
                    dgvBody.DataSource = ls;
                }
            }




            dgvBody.ReadOnly = true;
            this.Cursor = Cursors.Default;
        }
        private void dgvBody_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dgvBody, false);
            style.DataGridViewColumnHeaderStyle(dgvBody);

        }

        private void tsbDownloadBatch_Click(object sender, EventArgs e)
        {
            string targetDirectory;
            //choose target directory
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                targetDirectory = fbd.SelectedPath;

                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                this.Cursor=Cursors.WaitCursor;
                try
                {
                    foreach (var m in ls)
                    {


                        U8service.DAL.JoinTable.VoucherAccessoriesSvc attachment = new U8service.DAL.JoinTable.VoucherAccessoriesSvc(txtAccountNo.Text);
                        VoucherAccessories voucherAccessory = attachment.Read("88", m.POID.ToString());

                        if (voucherAccessory != null && voucherAccessory.FileContent.Length > 0)
                        {
                            string fileName = $"{m.PONumber}---{voucherAccessory.FileName}"; // 可以根据需要更改扩展名
                            string filePath = Path.Combine(targetDirectory, fileName);

                            File.WriteAllBytes(filePath, voucherAccessory.FileContent);

                        }


                    }

                    MessageBox.Show("文件保存成功", "文件保存提示");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.InnerException);
                }
                this.Cursor=Cursors.Default;
               
            }




        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            //export the data from datagridview to excel
            Utility.Excel.ExportExcel export = new Utility.Excel.ExportExcel();
            export.ExportExcelWithNPOI(dgvBody, "采购订单");

        }
    }
}


