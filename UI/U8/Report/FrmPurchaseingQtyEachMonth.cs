using DataMaintenance.DAL.U8services;
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
    public partial class FrmPurchaseingQtyEachMonth : Form
    {
        public FrmPurchaseingQtyEachMonth()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PurchaseInService processor = new PurchaseInService(cmbAccountNo.Text);
            DataTable reportData = processor.GetPurchasingQtyEachMonth();

            if (reportData != null)
            {
                // 将 DataTable 绑定到 DataGridView
                dataGridView1.DataSource = reportData;
                // keep double float number to decimal columns and set format as thound seperator "0,000.00"

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.ValueType == typeof(double) || column.ValueType == typeof(float) || column.ValueType == typeof(decimal))
                    {
                        column.DefaultCellStyle.Format = "0.00";
                    }
                }
            }
            else
            {
                MessageBox.Show("没有找到任何产品入库数据。");
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Utility.Excel.ExportExcel exporter = new Utility.Excel.ExportExcel();
                    exporter.ExportExcelWithNPOI(dataGridView1, this.Name);
                    
                    MessageBox.Show("导出成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出失败: " + ex.Message);
                }
            
        }
    }
}
