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

        #region field

        List<InventoryClass> listClass = new List<InventoryClass>();


        #endregion

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
            #region treeView dataSource

            listClass = (from s in new MasterDataService().GetListInventoryClass()
                        select s). ToList();


            var q = listClass.Where(s => s.iInvCGrade == 1);

            treeView1.BeginUpdate();

            //add root node
            foreach (var item in q)
            {
                TreeNode treeNode = new TreeNode($"({item.cInvCCode}){item.cInvCName}");
                treeNode.Tag = item.cInvCCode;
                treeView1.Nodes.Add(treeNode);
                //add child node
                AddChildNodes(treeNode,1);


            }



            treeView1.EndUpdate();

            #endregion

            dataGridView1.DataSource = new InventoryRefService().GetListInventoryInArchiveWithEF();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        /// <summary>
        /// add child nodes
        /// </summary>
        /// <param name="parentNodes"></param>
        void AddChildNodes(TreeNode parentNode,int parentGrade)
        {

            //var q = from s in new MasterDataService().GetListInventoryClass().Where(s => s.cInvCCode.StartsWith(parentNode.Tag.ToString())
            //        & s.iInvCGrade == parentGrade+ 1)

            //        select new { s.cInvCCode, s.cInvCName,s.iInvCGrade };

            //improve speed by 2 seconds from 21 seconds with  list data structure instead of EF 

            var q = from s in listClass.Where(s => s.cInvCCode.StartsWith(parentNode.Tag.ToString())
                       & s.iInvCGrade == parentGrade + 1)
                    select s;

                  


            #region treeView dataSource


            foreach (var item in q)
                {
                    TreeNode treeNode = new TreeNode($"({item.cInvCCode}){item.cInvCName}");
                    treeNode.Tag = item.cInvCCode;

                    parentNode.Nodes.Add(treeNode);
                    AddChildNodes(treeNode,item.iInvCGrade);

                }

         
                #endregion
           
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
