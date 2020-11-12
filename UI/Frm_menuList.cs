using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Modle;
using DataMaintenance;
using System.Linq;

namespace DataMaintenance.UI
{
    public partial class Frm_menuList : Utility.UI.Frm_archiveList
    {
        public Frm_menuList()
        {
            InitializeComponent();
            initialzeControlState();
        }

        void initialzeControlState()
        {

            DataGridViewCell cell = new DataGridViewTextBoxCell();
             MenuModle  m = new MenuModle();
            //var mType = m.GetType();
            
            

            DataGridViewColumn menuID = new DataGridViewColumn();
            menuID.HeaderText = "菜单编码";
            menuID.DataPropertyName = "menuID";
            menuID.CellTemplate = cell;
            base.dgv_templet.Columns.Add(menuID);

            DataGridViewColumn menuName = new DataGridViewColumn();
            menuName.HeaderText = "菜单名称";
            menuName.DataPropertyName = "menuName";
            menuName.CellTemplate = cell;
            base.dgv_templet.Columns.Add(menuName);

       


        }

        protected override void query()
        {
            using (var db = new DataMaitenanceContext())
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
    }
}
