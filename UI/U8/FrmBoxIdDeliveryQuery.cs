using DataMaintenance.DAL.TableServices.U8services;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.Ref;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaintenance.UI.U8
{
    public partial class FrmBoxIdDeliveryQuery : Form
    {
        public FrmBoxIdDeliveryQuery()
        {
            InitializeComponent();
            InitialCotrolsData();
            InitialControlsStyle();
        }


       void InitialCotrolsData()
        {
            txtInvcode.RefButton.Click += RefInventory;
            txtCustomerCode.RefButton.Click += RefCustomer;

            cmbAccountNo.Text = "017";

            cusName.DataPropertyName = "ccusname";
            outBoundDate.DataPropertyName = "ddate";
            voucherId.DataPropertyName = "ccode";
            cinvCode.DataPropertyName = "cInvCode";
            cinvName.DataPropertyName = "cInvName";
            cinvStd.DataPropertyName = "cinvStd";
            iQuantity.DataPropertyName = "iquantity";
            boxId.DataPropertyName = "cdefine31";
            memo.DataPropertyName = "cMemo";

           

        }

        void InitialControlsStyle()
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle(dgvReport);
        }



        private void RefCustomer(object sender, EventArgs e)
        {
            FrmRefCustomer f = new FrmRefCustomer();
            f.ActionRefCustomerCode = s => txtCustomerCode.Text = s;
            f.Show();
        }

        private void RefInventory(object sender, EventArgs e)
        {
            FrmRefInventory f = new FrmRefInventory();
            f.ActionRefInventoryCode = s => txtInvcode.Text = s;
            f.Show();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            DataTable dt = GetData();

            #region create datasource for paging
            xmPagingReader1.ColumnsForSum = new string[] { "iquantity" };

            xmPagingReader1.PageSize = 100;
            xmPagingReader1.TotalPages = Math.Ceiling(dt.Rows.Count / xmPagingReader1.PageSize);

            xmPagingReader1.DataSource = dt.AsEnumerable();
            xmPagingReader1.TableBody = dgvReport;

            var q = xmPagingReader1.GetPagedData(dt.AsEnumerable(), 1).CopyToDataTable();
            #endregion


            #region add sum row
            decimal sum = q.AsEnumerable().Sum(a => a.Field<decimal>("iquantity"));
            //decimal sumForeign = dt.AsEnumerable().Sum(a => a.Field<decimal>(amount.DataPropertyName));

            q.Rows.Add();
            int i = q.Rows.Count;
            //dt.Rows[i - 1].SetField<string>(cusName.DataPropertyName, "合计");


            q.Rows[i - 1].SetField<decimal>("iquantity", sum);

            #endregion

            dgvReport.DataSource = q;
            TableStyle();

            Cursor = Cursors.Default;

        }

        private DataTable GetData()
        {
           
            
            //filter
            Func<rdrecord32, bool> funcHeader = d =>
            {
                bool result = true;
                if (txtCustomerCode.Text != "")
                {
                    result &= d.cCusCode == txtCustomerCode.Text;
                }

                //if (txtInvcode.Text != "")
                //{
                //    result &= d.PickUpHeaderId == txtDeclareNo.Text;
                //}

                if (dtpStartDate.Value != null & dtpEndDate.Value != null)
                {
                    result &= d.dDate >= dtpStartDate.Value.Date & d.dDate <= dtpEndDate.Value.Date;
                }

                return result;
            };

            Func<rdrecords32, bool> funcDetail = t =>
            {
                bool result = true;


                if (txtInvcode.Text != "")
                {
                    result &= t.cInvCode == txtInvcode.Text;
                }

              
                return result;
            };

            Rdrecord32Service s = new Rdrecord32Service();

            //raw data
            DataTable dt = s.GetRdrecord32(funcHeader, funcDetail,cmbAccountNo.Text);
            return dt;
        }

        private void TableStyle()
        {

            string[] coloums = { iQuantity.Name };
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.ThoundSeparate(dgvReport, coloums);
            style.FontBond(dgvReport, coloums);
            
        }

      
        private void 当前页导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dgvReport, this.Text);
        }

        private void 全部数据导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(GetData(), this.Text);
        }
    }
}
