using DataMaintenance.DAL.RefServices.U8services;
using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.DAL;

namespace DataMaintenance.UI.Ref
{
    public partial class FrmRefWarehouse : Form
    {
        public FrmRefWarehouse()

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

        #region delegate

        public Action<Warehouse> ActionRefWarehouseEntity;

        public Action<string> ActionRefWarehouseCode;

        #endregion

        void InitializeControlDataSource()
        {
            var dataSource = QueryService.GetListFromSingleTable<Warehouse>(Utility.Sql.Sqlhelper.DataSourceType.u8).OrderBy(s => s.cWhCode);
            dgvArchive.DataSource = dataSource.ToList();


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
            Warehouse m = new Warehouse();
            m.cWhCode = dgvArchive.CurrentRow.Cells["cWhCode"].Value.ToString();
            m.cWhName = dgvArchive.CurrentRow.Cells[cWhName.Name.ToString()].Value.ToString();

            if (ActionRefWarehouseEntity != null)
            {
                ActionRefWarehouseEntity.Invoke(m);
            }

            if (ActionRefWarehouseCode!=null)
            {
                ActionRefWarehouseCode.Invoke(m.cWhCode);
            }
            this.Close();
        }

     
    }
}
