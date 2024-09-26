using DataMaintenance.DAL.RefServices.U8services;

using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataMaintenance.UI.Ref
{
    public partial class FrmRefVendor : Form

    {
        public FrmRefVendor()

        {
            InitializeComponent();
            InitializeContolState();
            BindData();
           


        }

        public string U8AccountNo { get; set;}
        

        #region Intial


        void InitializeContolState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvBody.AutoGenerateColumns = false;
        }

        #endregion

        #region delegate

        public Action<Vendor> ActionRefVendorEntity;

        public Action<string> ActionRefCustomerCode;

        #endregion


        #region Get data
        void BindData()
        {
          
            dgvBody.DataSource = new VendorRefService().GetListVendorInArchive(U8AccountNo);


            dgvBody.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #endregion

        #region ui handle

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new Utility.Style.DataGridViewStyle().DisplayRowNo(e, dgvBody,false);
        }
        #endregion

        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            Vendor m = new Vendor();
            m.cVenCode = dgvBody.CurrentRow.Cells["cVenCode"].Value.ToString();
            m.cVenName = dgvBody.CurrentRow.Cells["cVenName"].Value.ToString();


            ActionRefVendorEntity?.Invoke(m);
            
            this.Close();
        }

     
    }
}
