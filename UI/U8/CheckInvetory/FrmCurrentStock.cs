using DataMaintenance.Model;
using DataMaintenance.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U8service.Model;
using U8service.Model.AuxiliaryData;
using Utility.DAL;

namespace DataMaintenance.UI.U8.CheckInvetory
{
    public partial class FrmCurrentStock : Form
    {
        public FrmCurrentStock()
        {
            InitializeComponent();
            InitializeControl();
            InitializeDataSource();
        }

        #region vary
        //记录当前打印的行数，以决定是继续另起一页打印，dataGridView的首行索引为0
        private int printRowCount = 0;
        float pageHeight = 0;
        int rowsPerPage;
        //record current page
        private int _currentPage = 1;
        private int _totalPages=1;
        #endregion

        void InitializeControl()
        {
            foreach (Control item in tlpFilter.Controls)
            {
                item.Anchor = AnchorStyles.Left;
            }


        }

        void InitializeDataSource()
        {
            cmbAccountNo.DataSource = Utility.DAL.QueryService.GetListFromSingleTable<UA_Account>
                 (Utility.Sql.Sqlhelper.DataSourceType.ufsystem);
            cmbAccountNo.ValueMember = "cAcc_Id";
            cmbAccountNo.DisplayMember = "cAcc_Name";
            //set text of cmbAccountNo as value member plus display member
            cmbAccountNo.Format += (sender, e) =>
            {
                if (e.ListItem != null)
                {
                    var account = e.ListItem as UA_Account;
                    if (account != null)
                    {
                        e.Value = $"{account.cAcc_Id} - {account.cAcc_Name}";
                    }
                }
            };
            cmbAccountNo.SelectedIndex = -1;





        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvBody.DataSource = null;
            dgvBody.Rows.Clear();

            dgvBody.DataSource =
                 new U8service.DAL.JoinTableSvc.CurrentStockService(cmbAccountNo.SelectedValue.ToString())
                 .GetCurrentStock(cmbWarehouseNo.SelectedValue.ToString());

            dgvBody.ReadOnly = true;

            this.Cursor = Cursors.Default;
        }



        private void cmbWarehouseNo_DropDown(object sender, EventArgs e)
        {
            //set data source of cmbWarehouseNo
            var listWarehouse = Utility.DAL.QueryService.GetListFromSingleTable<Warehouse>
                (Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.SelectedValue.ToString()).OrderBy(s => s.cWhCode).ToList();
            cmbWarehouseNo.DataSource = listWarehouse;
            cmbWarehouseNo.ValueMember = "cWhCode";
            cmbWarehouseNo.DisplayMember = "cWhName";
            //display warehouse name and code in combobox text
            cmbWarehouseNo.Format += (sender1, e1) =>
            {
                if (e1.ListItem != null)
                {
                    var warehouse = e1.ListItem as Warehouse;
                    if (warehouse != null)
                    {
                        e1.Value = $"{warehouse.cWhCode} - {warehouse.cWhName}";
                    }
                }
            };
        }

        private void tspPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            pageHeight = printDoc.DefaultPageSettings.PaperSize.Height;

            printDoc.PrintPage += PrintPageEventHandler;



            // Create a PrintPreviewDialog instance
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;

            //替换打印按钮，实现打印机可选择
            ToolStripButton b = new ToolStripButton();
            b.Image = Properties.Resources.打印;
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;

            b.Tag = printDoc;
            b.Click += Print;

            ((ToolStrip)(previewDialog.Controls[1])).Items.RemoveAt(0);
            ((ToolStrip)(previewDialog.Controls[1])).Items.Insert(0, b);
            previewDialog.ShowDialog();


        }

        private static void Print(object sender, EventArgs e)
        {

            // Handle the Print event of the PrintPreviewDialog

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = ((ToolStripButton)sender).Tag as PrintDocument;
            printDialog.ShowDialog(); // Show the PrintDialog.

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }

        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            // Define font and brush for drawing text
            Font headerFont = new Font("Arial", 12f, FontStyle.Bold);
            Font dataFont = new Font("Arial", 8f);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black);

            // Define the layout dimensions 



            float pageWidth = e.PageBounds.Width;
            float pageHeight = e.PageBounds.Height;
            float usedHeadFooterHeight = 0;
            float usedTotalHeight = 0;
            float margin = 50; // Adjust margin as needed


            //logo
            e.Graphics.DrawImage(Resources.CZ_LOGO, new Rectangle(100, Convert.ToInt32(margin), 150, 40));
            usedHeadFooterHeight += 40;
            usedTotalHeight += 40;

            // Draw the layout elements (adjust as needed)
            e.Graphics.DrawLine(pen, margin, margin, pageWidth - margin, margin); // Top border
            e.Graphics.DrawLine(pen, margin, margin, margin, pageHeight - margin); // Left border
            e.Graphics.DrawLine(pen, margin, pageHeight - margin, pageWidth - margin, pageHeight - margin); // Bottom border
            e.Graphics.DrawLine(pen, pageWidth - margin, margin, pageWidth - margin, pageHeight - margin); // Right border


            // Draw title
            string title = "盘点表";
            SizeF titleSize = e.Graphics.MeasureString(title, headerFont);
            e.Graphics.DrawString(title, headerFont, brush, (pageWidth - titleSize.Width) / 2, margin + 10);


            // Draw column headers (adjust column positions and widths)
            float[] columnPositions = { margin + 10, margin + 80, margin + 160, margin + 300, margin + 450, margin + 500, margin + 550, margin + 600 };
            string[] columnHeaders = { "仓库名称", "存货编码", "存货名称", "规格型号", "现存数量", "盘点数量", "差异" };
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                e.Graphics.DrawString(columnHeaders[i], dataFont, brush, columnPositions[i], usedTotalHeight + 30);
            }

            usedTotalHeight += 30;

            // Calculate the starting position for drawing data
            float xStart = margin + 10;
            float yStart = usedTotalHeight;





            // Loop through the DataGridView rows

            while (usedTotalHeight < pageHeight - margin && printRowCount < dgvBody.Rows.Count)
            {
                // Draw the row
                for (int j = 0; j < dgvBody.Columns.Count; j++)
                {
                    string cellValue = dgvBody.Rows[printRowCount].Cells[j].Value?.ToString() ?? "";
                    float x = columnPositions[j];
                    e.Graphics.DrawString(cellValue, dataFont, brush, x, usedTotalHeight + 30);
                }
                printRowCount++;
                usedTotalHeight += 30;
            }

            //打印页码



            e.Graphics.DrawString("第" + _currentPage + "页 共" + this._totalPages + "页",
                new Font("宋体", 10, FontStyle.Regular), Brushes.Black,
                e.MarginBounds.Width / 2 - 30
                , e.MarginBounds.Height - 50);//底边距太小，则无法打印出来

            usedHeadFooterHeight += 50;


            // Calculate the total number of pages
            float tableHeight = pageHeight -usedHeadFooterHeight ;
            if (_currentPage==1)
            {
                rowsPerPage=printRowCount;
            }
            _totalPages = (int)Math.Ceiling((double)dgvBody.Rows.Count / rowsPerPage);

            if (this.printRowCount < dgvBody.Rows.Count - 1)
            {
                //Has more pages??  
                //只HasMorePages属性为true,printPage事件方法就会反复执行，相当于反复触发了printPage事件
                _currentPage += 1;
                e.HasMorePages = true;

            }

            // Dispose of objects
            headerFont.Dispose();
            dataFont.Dispose();
            brush.Dispose();
            pen.Dispose();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel export = new Utility.Excel.ExportExcel();
            export.ExportExcelWithNPOI(dgvBody, "盘点表");
        }
    }

}



