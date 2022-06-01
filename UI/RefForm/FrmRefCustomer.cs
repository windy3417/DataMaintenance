﻿using DataMaintenance.DAL.U8services;
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


        void InitializeContolState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoGenerateColumns = false;
        }

        #endregion

        #region delegate

        public Action<Customer> ActionRefCustomerEntity;

        public Action<string> ActionRefCustomerCode;

        #endregion

        void InitializeControlDataSource()
        {
            //dataGridView1.DataSource = new CustomerAttachmentService().GetListArchiveEntiy();
            dataGridView1.DataSource = new CustomerRefService().GetListCustomerInArchive();



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #region Get data


        #endregion

        #region ui handle

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new Utility.Style.StyleDataGridView().DisplayRowNo(e, dataGridView1);
        }
        #endregion

        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            Customer m = new Customer();
            m.cCusCode = dataGridView1.CurrentRow.Cells["ccusCode"].Value.ToString();
            m.cCusName = dataGridView1.CurrentRow.Cells["cCusName"].Value.ToString();

            if (ActionRefCustomerEntity != null)
            {
                ActionRefCustomerEntity.Invoke(m);
            }
            this.Close();
        }

     
    }
}
