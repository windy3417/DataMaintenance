﻿using DataMaintenance.Model.Maintenance;
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
using Utility.Sql;
using static Utility.Sql.Sqlhelper;

namespace DataMaintenance.UI.U8.VoucherList
{
    public partial class FrmUnitProductionCostList : Form
    {
        public FrmUnitProductionCostList()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            dgvBody.AutoGenerateColumns = false;
            Utility.Style.DataGridViewStyle dgvStyle = new Utility.Style.DataGridViewStyle();
            dgvStyle.DataGridViewColumnHeaderStyle(dgvBody);
            
            // 初始化年份 ComboBox
            for (int year = DateTime.Now.Year - 1; year <= DateTime.Now.Year + 1; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }

            // 初始化月份 ComboBox
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month.ToString("D2")); // 格式化为两位数
            }
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            dgvBody.DataSource = null;
            dgvBody.Rows.Clear();
            //disable edit feature of datagridview
            dgvBody.ReadOnly = true;

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(cmbYear.Text))
            {
               
                parameters.Add(new SqlParameter("@iYear", int.Parse(cmbYear.Text)));
            }

            if (!string.IsNullOrEmpty(cmbMonth.Text))
            {
             
                parameters.Add(new SqlParameter("c@Month", cmbMonth.Text));
            }

            if (!string.IsNullOrEmpty(cmbAccountNo.Text))
            {
                          parameters.Add(new SqlParameter("@AccountNo", cmbAccountNo.Text));
            }

            SqlParameter[] sqlParameters = parameters.ToArray();

        

            List<UnitProductionCost> list = QueryService.GetListFromSingleTable<UnitProductionCost>(sqlParameters, DataSourceType.business, cmbAccountNo.Text);
            dgvBody.DataSource = list;
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
           
            Utility.Excel.ExportExcel export = new Utility.Excel.ExportExcel();
            export.ExportExcelWithNPOI(dgvBody, "单位成本表");
        }

        private void dgvBody_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dgvBody, false);
        }
        
    }
}
