using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Model;
using DataMaintenance;
using System.Linq;
using DataMaintenance.Model.Maintenance;

namespace DataMaintenance.UI
{
    public partial class Frm_menuList : Utility.UI.Frm_archiveList
    {
        public Frm_menuList()
        {
            InitializeComponent();
            initializeControlState();
            initalizeDataGridView();
        }

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        void initializeControlState()
        {
            base.lbl_title.Text = "菜单列表";
           

        }

        /// <summary>
        /// 初始化dataGridView栏目
        /// </summary>
        private void initalizeDataGridView()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            MenuModle m = new MenuModle();
            //var mType = m.GetType();



            DataGridViewTextBoxColumn menuID = new DataGridViewTextBoxColumn();
            menuID.HeaderText = "菜单编码";
            menuID.DataPropertyName = "menuID";
            menuID.CellTemplate = cell;
            base.dgv_templet.Columns.Add(menuID);

            DataGridViewTextBoxColumn menuName = new DataGridViewTextBoxColumn();
            menuName.HeaderText = "菜单名称";
            menuName.DataPropertyName = "menuName";
            menuName.CellTemplate = cell;
            base.dgv_templet.Columns.Add(menuName);
        }

        protected override void query()
        {
            using (var db = new DataMaintenanceContext())
            {

                try
                {
                    var query = from q in db.Menus
                                select q;


                    base.dgv_templet.DataSource = query.OrderBy(o => o.menuID).ToList();

                    //处理数据为空示和时的数据转换错误，可先转成泛型再求和
                    lbl_sum.Text = query.ToList().Count().ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据查询错误:" + ex.Message + ex.InnerException, "数据查询提示");
                    return;
                }
            }
        }

        protected override void deleteModle(object selected)
        {
            base.deleteModle(selected);
            var db = new DataMaintenanceContext();
            MenuModle m = new MenuModle();

            List<MenuModle> del = (from d in db.Menus
                                where d.menuID == (int)selected
                                select d).ToList<MenuModle>();
            //移除数据库的数据
            db.Menus.Remove(del[0]);
            db.SaveChanges();
            //tsb_query.PerformClick();
        }
    }
}
