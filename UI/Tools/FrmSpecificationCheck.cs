using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using (var db = new U8Context("017"))
                {


                    //存货编码不以x开头的则是非修磨刀具
                    var q = from s in db.Inventory.Where(s => s.cInvCCode.StartsWith("9"))
                            where !s.cInvCode.ToUpper().StartsWith("X")//此句很关键,采用StringComparison.OrdinalIgnoreCase功能去忽略大小写会报错
                            select new { 存货编码 = s.cInvCode, 存货名称 = s.cInvName, 规格型号 = s.cInvStd, 建档日期 = s.dSDate };


                 


                    //查找重复项
                    var q1 = from s in db.Inventory.Where(s => s.cInvCCode.StartsWith("9"))
                             where !s.cInvCode.ToUpper().StartsWith("X")
                             group s by  s.cInvStd  into g
                             where g.Count() >=2
                             
                             select new { 规格型号 = g.Key, 重复个数 = g.Count() };

                    var qz = from s1 in q
                             join s2 in q1 on s1.规格型号 equals s2.规格型号
                             orderby   s1.建档日期 descending
                             select new { s1.存货编码, s1.存货名称, s1.规格型号, s2.重复个数,s1.建档日期 };

                    dataGridView1.DataSource = qz.ToList();
                    dataGridView1.AutoResizeColumns();
                    this.Cursor = Cursors.Default;
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
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dataGridView1,false);
          
            
        }

        private void tsmDetails_Click(object sender, EventArgs e)
        {
            string cinvstd = this.dataGridView1.CurrentCell.Value.ToString();
            try
            {
               
                using (var db=new U8Context("017"))
                {
                    var q=from s in db.Inventory.Where(s =>s.cInvStd==cinvstd && s.cInvCCode.StartsWith("9"))
                          where !s.cInvCode.ToUpper().StartsWith("X")
                          select new { 存货编码=s.cInvCode, 存货名称=s.cInvName, 规格型号=s.cInvStd, 建档日期=s.dSDate };


                    FrmDupliateDetails f = new FrmDupliateDetails();
                    f.MaximizeBox = false;
                    f.MinimizeBox = false;
                    f.dataGridView1.DataSource = q.ToList();
                    f.ShowDialog();
                    
                    //f.Show();

                }
            }
            catch (Exception)
            {

                throw;
            }
           
              
            

           
        }

        private void tsbExportToExcel_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dataGridView1, "规格重复刀具明细");
        }
    }
}
