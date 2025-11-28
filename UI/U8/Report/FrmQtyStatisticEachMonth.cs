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
    public partial class FrmQtyStatisticEachMonth : Form
    {
        public FrmQtyStatisticEachMonth()
        {
            InitializeComponent();
            xmTxtInvClass.RefButton.Click += tsbInventoryClass_Click;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbAccountNo.Text))
            {
                MessageBox.Show("账套不能为空");
                return;
            }

            DataTable reportData =new DataTable();
            List<string> productCodes;
            U8service.DAL.MasterData.InventoryRepo inventory = new U8service.DAL.MasterData.InventoryRepo(cmbAccountNo.Text);
            productCodes=inventory.GetInvCodeListByCategory(xmTxtInvClass.Text);

            if (cmbVoucherType.Text=="采购入库单")
            {
                PurchaseInService processor = new PurchaseInService(cmbAccountNo.Text);

                 reportData = processor.GetPurchasingQtyEachMonth();
            }

            if (cmbVoucherType.Text == "销售出库单")
            {
                U8service.DAL.Stock.DeliveryNote deliveryNote  = new U8service.DAL.Stock.DeliveryNote(cmbAccountNo.Text);
                reportData = deliveryNote.GetSaleOutQtyEachMonth(productCodes);
            }
            

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

        private void tsbInventoryClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAccountNo.Text))
            {
                MessageBox.Show("账套不能为空");
                return;
            }

            U8service.UI.FrmRef.FrmRefInvClassTree f = new U8service.UI.FrmRef.FrmRefInvClassTree(cmbAccountNo.Text);
            f.ActionInvClassDate += (s) => xmTxtInvClass.Text = s.cInvCCode;
            
            f.Show();
            
        }

        //validate input
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAccountNo.Text))
            {
                MessageBox.Show("账套不能为空");
                return;
            }
            if (string.IsNullOrEmpty(cmbVoucherType.Text))
            {
                MessageBox.Show("单据类型不能为空");
                return;
            }
            if (string.IsNullOrEmpty(xmTxtInvClass.Text))
            {
                MessageBox.Show("存货分类不能为空");
                return;
            }
            MessageBox.Show("验证通过");
        }
    }
}
