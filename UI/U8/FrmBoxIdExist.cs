using DataMaintenance.DAL.TableServices.U8services;
using DataMaintenance.DAL.ViewServices.U8services;
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
    public partial class FrmBoxIdExist : Form


    {
        public FrmBoxIdExist()


        {
            InitializeComponent();
            InitialCotrolsData();
            InitialControlsStyle();
        }


       void InitialCotrolsData()
        {
            txtInvcode.RefButton.Click += RefInventory;
            txtWarehouseCode.RefButton.Click += RefForm;

            txtWarehouseCode.Text = "101";
            dtpStartDate.Value = DateTime.Now.AddMonths(-DateTime.Now.Month + 1).AddDays(-DateTime.Now.Day + 1);


            cwhcode.DataPropertyName = "cwhcode";
            cwhname.DataPropertyName = "cwhname";
          
            cinvCode.DataPropertyName = "cInvCode";
            cinvName.DataPropertyName = "cInvName";
            cinvStd.DataPropertyName = "cinvStd";
            iQuantity.DataPropertyName = "iquantity";

          
            //iQuantity.copytodatatable
           
        }

        void InitialControlsStyle()
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle(dgvReport);
            
        }



        private void RefForm(object sender, EventArgs e)
        {
            FrmRefWarehouse f = new FrmRefWarehouse();
            f.ActionRefWarehouseCode = s => txtWarehouseCode.Text = s;
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
            Func<CurrentStock, bool> funcHeader = d =>
            {
                bool result = d.iQuantity!=0;
                if (txtWarehouseCode.Text != "")
                {
                    result &= d.cWhCode == txtWarehouseCode.Text;
                }

                if (txtInvcode.Text != "")
                {
                    result &= d.cInvCode == txtInvcode.Text;
                }

              

                return result;
            };

            Func<rdrecord10, bool> funcDetail = t =>
            {
                bool result = true;


                if (dtpStartDate.Value != null )
                {
                    result &= t.dDate >= dtpStartDate.Value.Date.Date ;
                }


                return result;
            };

            BoxIDExistService  s = new BoxIDExistService();

            //raw data
            DataTable dt = s.GetCurrentStock(funcHeader, funcDetail);
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

        private void tsmQueryBoxId_Click(object sender, EventArgs e)
        {
            FrmBoxIdDetail f = new FrmBoxIdDetail();
            f.GetBoxId(dgvReport.CurrentRow.Cells[cinvCode.Name].Value.ToString(),dtpStartDate.Value.Date);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
