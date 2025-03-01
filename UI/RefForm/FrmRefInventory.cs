﻿using DataMaintenance.DAL.RefServices.U8services;
using DataMaintenance.DAL.TableServices.U8services;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.DAL;

namespace DataMaintenance.UI.Ref
{
    public partial class FrmRefInventory : Form

    {
        public FrmRefInventory(String u8Account)
        {
            _u8Account = u8Account;
            InitializeComponent();
            InitializeContolState();
            InitailTreeViewDataSource(_u8Account);
           
        }

        #region vary

          string _u8Account { get; set; }
        List<InventoryClass> listClass = new List<InventoryClass>();
        List<Inventory> inventoryList;

        #endregion

        #region delegate

        public Action<Inventory> ActionRefIventoryItem;


        public Action<string> ActionRefInventoryCode;
        //using func delegate can exchange data each other
        //Func<int, Inventory> FuncTestl;

        #endregion

       
        #region Get data
        void InitailTreeViewDataSource(String u8Account)
        {
                     
            #region treeView dataSource

            listClass = (from s in new MasterDataService().GetListInventoryClass(u8Account)
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
        /// get inventory list after checking inventory class 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvArchive.DataSource = null;
            string ccode = e.Node.Tag.ToString();
            Inventory m = new Inventory();
            SqlParameter[] sqlParameters = { new SqlParameter("@cInvCCode", ccode) };

            var inventory= QueryService.GetListFromSingleTable<Inventory>( sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8,_u8Account);

                   
            dgvArchive.DataSource = inventory.ToList();
        
                     
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
            // 检查是否有选中的行
            if (dgvArchive.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一行数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Inventory m = new Inventory();
            m.cInvCode = dgvArchive.CurrentRow.Cells["cinvCode"].Value.ToString();
            m.cInvName = dgvArchive.CurrentRow.Cells["cinvName"].Value.ToString();
            m.cInvStd = dgvArchive.CurrentRow.Cells["std"].Value.ToString();

            if (ActionRefIventoryItem != null)
            {
                ActionRefIventoryItem.Invoke(m);
            }

            ActionRefInventoryCode?.Invoke(m.cInvCode);
            //can call the resulte provided insistance of Func delegate
            //FuncTestl?.Invoke(3).
            this.Close();
        }


        #endregion

    }
}
