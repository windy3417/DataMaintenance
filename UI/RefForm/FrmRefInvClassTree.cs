using DataMaintenance.DAL.TableServices.U8services;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaintenance.UI.RefForm
{
    public partial class FrmRefInvClassTree : Form
    {
        public FrmRefInvClassTree()
        {
            InitializeComponent();
            InitailTreeViewDataSource("018");
        }
        List<InventoryClass> listClass = new List<InventoryClass>();
        public Action<InventoryClass> ActionInvClassDate;

        void InitailTreeViewDataSource(String u8Account)
        {

            #region treeView dataSource

            listClass = (from s in new MasterDataService().GetListInventoryClass(u8Account)
                         select s).ToList();


            var q = listClass.Where(s => s.iInvCGrade == 1);

            treeView1.BeginUpdate();

            //add root node
            foreach (var item in q)
            {
                TreeNode treeNode = new TreeNode($"({item.cInvCCode}){item.cInvCName}");
                treeNode.Tag = item.cInvCCode;
                treeView1.Nodes.Add(treeNode);
                //add child node
                AddChildNodes(treeNode, 1);


            }



            treeView1.EndUpdate();

            #endregion

        }


        /// <summary>
        /// add child nodes
        /// </summary>
        /// <param name="parentNodes"></param>
        void AddChildNodes(TreeNode parentNode, int parentGrade)
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
                AddChildNodes(treeNode, item.iInvCGrade);

            }


            #endregion

        }

        private void tsbCertain_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Tag != null)
            {
                string selectedTag = treeView1.SelectedNode.Tag.ToString();
                InventoryClass m = listClass.FirstOrDefault(item => item.cInvCCode == selectedTag);

                if (m != null)
                {
                    ActionInvClassDate?.Invoke(m);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selected node does not correspond to a valid InventoryClass.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No node is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


