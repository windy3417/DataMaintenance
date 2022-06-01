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
    public partial class FrmRefInventory : Form

    {
        public FrmRefInventory()
        {
            InitializeComponent();
            InitializeContolState();
            InitializeControlDataSource();
           


        }

        #region delegate

        public Action<Inventory> ActionRefIventoryEntity;


        public Action<string> ActionRefInventoryCode;

        #endregion

        #region Intial


        void InitializeContolState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoGenerateColumns = false;
        }

        #endregion


        #region Get data
        void InitializeControlDataSource()
        {
            
            dataGridView1.DataSource = new InventoryRefService().GetListInventoryInArchive();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #endregion

        #region data handle


        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            Inventory m = new Inventory();
            m.cInvCode = dataGridView1.CurrentRow.Cells["cinvCode"].Value.ToString();
            m.cInvName = dataGridView1.CurrentRow.Cells["cinvName"].Value.ToString();
            m.cInvStd = dataGridView1.CurrentRow.Cells["std"].Value.ToString();

            if (ActionRefIventoryEntity != null)
            {
                ActionRefIventoryEntity.Invoke(m);
            }
            this.Close();
        }


        #endregion

        #region ui handle

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new Utility.Style.StyleDataGridView().DisplayRowNo(e, dataGridView1);
        }

        #endregion


    }
}
