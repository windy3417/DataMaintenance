using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.Ref;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.DAL;

namespace DataMaintenance.UI.U8.Report
{
    public partial class FrmU8FinishedGoodsUnitPriceReport : Form
    {
        public FrmU8FinishedGoodsUnitPriceReport()
        {
            InitializeComponent();
            InitializeControlsStatus();
        }

        void InitializeControlsStatus()
        {
            txbtnInvCode.RefButton.Click += new EventHandler(this.TxbtnInvCode_Click);
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();

            //set the dtpStartDate as first day of current year and dtpEndDate as last day of current year
           dtpStartDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
          dtpEndDate.Value = new DateTime(DateTime.Now.Year, 12, 31);

          cmbAccountNo.Text = "018";
    

            style.DataGridViewColumnHeaderStyle(dgvBody);

        }


        private void TxbtnInvCode_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(cmbAccountNo.Text))
            {
                MessageBox.Show("请选择账套号", "空值提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmRefInventory f = new FrmRefInventory(cmbAccountNo.Text);

            f.ActionRefInventoryCode = s => txbtnInvCode.Text = s;

            f.ShowDialog();
        }

        private void txbtnInvCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Return)
            {
                //this.btnRef.Visible = false;

                // 确保只对特定列进行处理


                if (!string.IsNullOrEmpty(txbtnInvCode.Text))
                {
                    // 调用数据库查询方法
                    Inventory m = QueryService.GetItemFromSingleTable<Inventory>(new SqlParameter[] { new SqlParameter(@"cInvCode", txbtnInvCode.Text) },
                        Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);


                    // 如果查询成功，则填充
                    if (!String.IsNullOrEmpty(m.cInvCode))
                    {
                        txbtnInvCode.Text = m.cInvCode;
                        //txbtnInvCode.SelectNextControl(toolStrip1, true, true, false, true);
                        //we should send tab twice,otherwise the next control will not be focused
                        SendKeys.Send("{TAB}");
                        SendKeys.Send("{TAB}");
                    }
                    else
                    {
                        // 如果没有找到对应的记录，则提示用户
                        MessageBox.Show("未找到对应的存货信息，请检查输入的编码是否正确。", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }



            }


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
         
                var query = from s in db.rdrecord10
                            join i in db.rdrecords10 on s.ID equals i.ID
                            join u in db.Inventory on i.cInvCode equals u.cInvCode
                            let conditon=!String.IsNullOrEmpty(txbtnInvCode.Text) ? i.cInvCode==txbtnInvCode.Text : true
                            where s.dDate >= dtpStartDate.Value && s.dDate<=dtpEndDate.Value && i.iUnitCost.HasValue && i.iUnitCost.Value > 0 
                                && conditon
                   
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
                
              dgvBody.DataSource=  query.Distinct().OrderBy(s => s.year).ThenBy(s => s.month). ToList();
            this.Cursor = Cursors.Default;
            }



           
        }

        #region style
        private void dgvBody_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();

            style.DisplayRowNo(e, dgvBody, false);
      
        }

        #endregion


        private void tsbFitler_Click(object sender, EventArgs e)
        {
            // Add filter icons to each column header
            foreach (DataGridViewColumn column in dgvBody.Columns)
            {
                AddFilterIconToHeader(column);
            }
            //remove the filter icon from columns after clicking the filter button again when there are filter icons in the header cells
            //if (filterIcons.Count > 0)
            //{
            //    RemoveFilterIconFromHeader();

            //}
           
        }

        private void AddFilterIconToHeader(DataGridViewColumn column)
        {
            Point headerCell = dgvBody.GetColumnDisplayRectangle(column.Index, true).Location;
            Point location = new Point(headerCell.X + 4, headerCell.Y + 4);

            PictureBox filterIcon = new PictureBox
            {
                Size = new Size(16, 16),
                Location = location,
                Image = Properties.Resources.filter, // Replace with your filter icon image
                Dock = DockStyle.None,
                Visible = true
            };

            dgvBody.Controls.Add(filterIcon);

            //filterIcon.Click += (s, ev) => ShowFilterWindow(column);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            tsbQuery.PerformClick();
        }
    }
}
    

