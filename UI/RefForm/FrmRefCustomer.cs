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
    public partial class FrmRefCustomer : Form
    {
        public FrmRefCustomer()
        {
            InitializeComponent();
            InitializeContolState();
            InitializeControlDataSource();
           


        }

        #region Intial


        void InitializeContolState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvArchive.AutoGenerateColumns = false;
        }

        #endregion

        public string U8AccountNo { get; set; }
        #region delegate

        public Action<Customer> ActionRefCustomerEntity;

        public Action<string> ActionRefCustomerCode;

        #endregion

        void InitializeControlDataSource()
        {
            
            dgvArchive.DataSource = new CustomerRefService().GetListCustomerInArchive(U8AccountNo);


            dgvArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #region Get data


        #endregion

        #region ui handle

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new Utility.Style.DataGridViewStyle().DisplayRowNo(e, dgvArchive,false);
        }
        #endregion

        /// <summary>
        /// return data to caller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            Customer m = new Customer();
            m.cCusCode = dgvArchive.CurrentRow.Cells["ccusCode"].Value.ToString();
            m.cCusName = dgvArchive.CurrentRow.Cells["cCusName"].Value.ToString();

            if (ActionRefCustomerEntity != null)
            {
                ActionRefCustomerEntity.Invoke(m);
            }

            if (ActionRefCustomerCode!=null)
            {
                ActionRefCustomerCode.Invoke(m.cCusCode);
            }
            this.Close();
        }

     
    }
}
