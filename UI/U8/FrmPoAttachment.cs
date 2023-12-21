using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U8services.Model;
using U8services.UI.FrmRef;

namespace DataMaintenance.UI.U8
{
    public partial class FrmPoAttachment : Form
    {
        public FrmPoAttachment()
        {
            InitializeComponent();
            xmTxtVendor.RefButton.Click += RefButton_Click;
            
        }

        private void RefButton_Click(object sender, EventArgs e)
        {
            FrmRefVendor fv = new FrmRefVendor();
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
    }
}
