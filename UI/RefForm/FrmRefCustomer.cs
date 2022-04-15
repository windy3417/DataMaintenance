using DataMaintenance.DAL.U8services;
using DataMaintenance.DAL.U8services.RefServices;
using DataMaintenance.DAL.U8services.TableServices;
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

        void InitializeControlDataSource()
        {
            //dataGridView1.DataSource = new CustomerAttachmentService().GetListArchiveEntiy();
            dataGridView1.DataSource = new CustomerRefService().GetListCustomerInArchive();


         
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void InitializeContolState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoGenerateColumns = false;
        }

        #endregion

        public Action<Customer> ActionRefCustomerEntity;

        public Action<string> ActionRefVendorCode;

        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            Customer m = new Customer();
            m.cCusCode = dataGridView1.CurrentRow.Cells["customerCode"].Value.ToString();
            m.cCusName = dataGridView1.CurrentRow.Cells["customerName"].Value.ToString();

            if (ActionRefCustomerEntity != null)
            {
                ActionRefCustomerEntity.Invoke(m);
            }
            this.Close();
        }
    }
}
