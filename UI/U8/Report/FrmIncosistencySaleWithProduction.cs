using DataMaintenance.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaintenance.UI.U8.Report
{
    public partial class FrmIncosistencySaleWithProduction : Form
    {
        public FrmIncosistencySaleWithProduction()
        {
            InitializeComponent();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            //check if the cmbAccountNo value is empty in tablelayout
            if (String.IsNullOrEmpty(cmbAccountNo.Text))
            {
                MessageBox.Show("请选择账套号", "空值提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            using (var db = new U8Context(cmbAccountNo.Text))
            {
                #region finished goods inbound voucher
                var query1 = from s in db.rdrecord10
                            join i in db.rdrecords10 on s.ID equals i.ID
                            join u in db.Inventory on i.cInvCode equals u.cInvCode

                            where s.dDate >= dtpStartDate.Value && s.dDate <= dtpEndDate.Value && i.iUnitCost.HasValue && i.iUnitCost.Value > 0


                            select new
                            {
                                accountNo = cmbAccountNo.Text,
                                year = s.dDate.Year,
                                month = s.dDate.Month,


                                //s.dDate,
                                i.cInvCode,
                                u.cInvName,
                                u.cInvStd,
                                i.iUnitCost,
                            };
                var p=query1.Distinct().OrderBy(s => s.cInvCode).ThenBy(s => s.year).ThenBy(s => s.month);

                #endregion

                #region sale outbound voucher

                var query2 = from s in db.rdrecord32
                            join i in db.rdrecords32 on s.ID equals i.ID
                            join u in db.Inventory on i.cInvCode equals u.cInvCode

                            where s.dDate >= dtpStartDate.Value && s.dDate <= dtpEndDate.Value && i.iUnitCost.HasValue && i.iUnitCost.Value > 0


                            select new
                            {
                                accountNo = cmbAccountNo.Text,
                                year = s.dDate.Year,
                                month = s.dDate.Month,


                                //s.dDate,
                                i.cInvCode,
                                u.cInvName,
                                u.cInvStd,
                                i.iUnitCost,
                            };
                var sa = query2.Distinct().OrderBy(s => s.cInvCode).ThenBy(s => s.year).ThenBy(s => s.month);


                #endregion


                // Perform left join between p and sa lists
                var result = from  saItem in  sa
                             join pItem in p
                             on new { Year = saItem.year, Month = saItem.month, InvCode = saItem.cInvCode }
                             equals new { Year = pItem.year, Month = pItem.month, InvCode = pItem.cInvCode }
                             into joinedItems
                             from pItem in joinedItems.DefaultIfEmpty()
                             where pItem == null
                             select new
                             {
                                 saItem.accountNo,
                                 saItem.year,
                                 saItem.month,
                                 saItem.cInvCode,
                                 saItem.cInvName,
                                 saItem.cInvStd,
                                 saItem.iUnitCost,
                                 
                             };

                dgvBody.DataSource = result.ToList();

             
            }

        }

        private void dgvBody_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle ui = new Utility.Style.DataGridViewStyle();
            ui.DisplayRowNo(e,dgvBody,false);
            this.Cursor = Cursors.Default;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            tsbQuery.PerformClick();
        }
    }
}
