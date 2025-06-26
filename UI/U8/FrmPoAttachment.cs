using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U8service.Model;
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

        private void RefButton_Click(object sender, EventArgs e)
        {
            FrmRefVendor fv = new FrmRefVendor(txtAccountNo.Text);
            fv.ActionRefVendorEntity = GetVendorCode;
            fv.Show();
        }


        void GetVendorCode(Vendor vendor)
        {
           
            this.xmTxtVendor.Text = vendor.cVenCode + "-"+vendor.cVenName;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.Cursor=Cursors.WaitCursor;
            var getPoAttachment = new U8service.DAL.JoinTable.Purchase.POSvc(txtAccountNo.Text);
            if (rbDetail.Checked)
            {
                dgvBody.DataSource = getPoAttachment.GetPO(dtpStartDate.Value, dtpEndDate.Value, cmbBizType.Text.ToString());
            }
            else
            {
                dgvBody.DataSource = getPoAttachment.GetPOHeader(dtpStartDate.Value, dtpEndDate.Value, cmbBizType.Text.ToString());
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

        }
    }
}
