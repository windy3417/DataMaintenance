using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Model;


namespace DataMaintenance.UI.Tools
{
    public partial class FrmSpecificationCheck : Form
    {
        public FrmSpecificationCheck()
        {
            InitializeComponent();
            this.FormClosed += closeParentForm;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new U8Context())
                {
                    var q = from t in db.Inventory.Where(s => s.cInvCCode.StartsWith("9"))

                            select new { 存货编码=t.cInvCode, 存货名称=t.cInvName, 规格型号=t.cInvStd ,建档日期=t.dSDate};




                    var q1 = from t in db.Inventory.Where(s => s.cInvCCode.StartsWith("9"))
                             group t by  t.cInvStd  into g
                             where g.Count() > 1
                             
                             select new { 规格型号 = g.Key, 重复个数 = g.Count() };

                    var qz = from s1 in q
                             join s2 in q1 on s1.规格型号 equals s2.规格型号
                             orderby  s1.建档日期 descending,s1.规格型号 
                             select new { s1.存货编码, s1.存货名称, s1.规格型号, s2.重复个数,s1.建档日期 };

                    dataGridView1.DataSource = qz.ToList();
                    dataGridView1.AutoResizeColumns();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView style = new Utility.Style.StyleDataGridView();
            style.DisplayRowNo(e, dataGridView1);
          
            
        }
    }
}
