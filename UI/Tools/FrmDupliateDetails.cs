using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataMaintenance.UI.Tools
{
    public partial class FrmDupliateDetails : Form
    {
        public FrmDupliateDetails()
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmDupliateDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
           
            //数据加载后才能根据内容调整列宽与行高
            //dataGridView1.AutoResizeColumn(2);
            //dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();

            //dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView styleDataGridView = new Utility.Style.StyleDataGridView();
            styleDataGridView.DisplayRowNo(e, dataGridView1);
        }
    }
}
