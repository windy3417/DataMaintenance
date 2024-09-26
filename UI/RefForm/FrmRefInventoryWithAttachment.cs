using DataMaintenance.DAL.RefServices.U8services;
using DataMaintenance.DAL.TableServices.U8services;
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
    public partial class FrmRefInventoryWithAttacchment : Form


    {
        public FrmRefInventoryWithAttacchment()

        {
            InitializeComponent();
            InitializeContolState();
            DataBind();
           
        }
        public string U8AccountNo { get; set;}

        #region vary


        List<InventoryClass> listClass = new List<InventoryClass>();
        List<Inventory> inventoryList;

        #endregion

        #region delegate

        public Action<Inventory> ActionRefIventoryEntity;


        public Action<string> ActionRefInventoryCode;

        #endregion

       
        #region Get data
        void DataBind()
        {
           
            #region dataGridView datasource

            inventoryList = new InventoryRefService().GetListInventoryInArchiveWithEF();

            dgvArchive.DataSource = inventoryList;

            dgvArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            #endregion

            #region treeView dataSource

            listClass = (from s in new MasterDataService().GetListInventoryClass(U8AccountNo)
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


        /// <summary>
        /// get inventory after checking inventory class 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvArchive.DataSource = null;
            string ccode = e.Node.Tag.ToString();

            var q = inventoryList.Where(s => s.cInvCCode.StartsWith(ccode));

                        
            dgvArchive.DataSource = q.ToList();
                            
        }

        #endregion

      
        #region ui handle


        void InitializeContolState()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
           
            dgvArchive.AutoGenerateColumns = false;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new Utility.Style.DataGridViewStyle().DisplayRowNo(e, dgvArchive,false);
        }


        #endregion

        #region return data to caller

        /// <summary>
        /// return data to caller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            Inventory m = new Inventory();
            m.cInvCode = dgvArchive.CurrentRow.Cells["cinvCode"].Value.ToString();
            m.cInvName = dgvArchive.CurrentRow.Cells["cinvName"].Value.ToString();
            m.cInvStd = dgvArchive.CurrentRow.Cells["std"].Value.ToString();

            if (ActionRefIventoryEntity != null)
            {
                ActionRefIventoryEntity.Invoke(m);
            }

            ActionRefInventoryCode?.Invoke(m.cInvCode);
            this.Close();
        }


        #endregion
    }
}
