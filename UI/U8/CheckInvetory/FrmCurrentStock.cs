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
        int rowsPerPage=30;
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

            //set last column  of datagridview as double 
         
                    dgvBody.Columns["iQuantity"].ValueType = typeof(double);
                
            
          

            dgvBody.ReadOnly = true;

            //display row number in datagridview
            for (int i = 0; i < dgvBody.Rows.Count; i++)
            {
                dgvBody.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

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
            Font titleFont = new Font("Arial", 16f, FontStyle.Bold);
            Font tableHeaderFont = new Font("Arial", 10f, FontStyle.Bold);
            Font headerFont = new Font("Arial", 8f, FontStyle.Bold);
            Font dataFont = new Font("Arial", 8f);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black);

            // Define the layout dimensions 

            float pageWidth = e.PageBounds.Width;
            float pageHeight = e.PageBounds.Height;
         
            float usedTotalHeight = 0;
            float margin = 20; // Adjust margin as needed



            #region logo and title and table header
            // Set logo position and size
            int logoX = (int)margin + 10;
            int logoY = (int)margin + 10;
            int logoWidth = 150;
            int logoHeight = 40;

            // Draw the logo at the top-left
            e.Graphics.DrawImage(Resources.CZ_LOGO, new Rectangle(logoX, logoY, logoWidth, logoHeight));

            // Calculate the height used by the logo
            usedTotalHeight += logoY+ logoHeight;
            #endregion

            #region draw title

            // Set the vertical position for the title below the logo
            float titleY = logoY + logoHeight / 2+10; // 10 units padding below logo

            // Draw the title centered horizontally, below the logo
            string title = "盘点表";
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, brush, (pageWidth - titleSize.Width) / 2, titleY);

            // Calculate the height used by the title


            #endregion


            #region draw table header
            // Draw the check date and account deadline below the title

            usedTotalHeight += 25;
            float headerPosY = usedTotalHeight;
            string checkDate = "盘点日期:";
            SizeF checkDateSize = e.Graphics.MeasureString(checkDate, tableHeaderFont);

            // place the check date in the right and it's height is the same as deadline date and left some space to write actual check date
            e.Graphics.DrawString(checkDate, tableHeaderFont, brush, pageWidth - margin - checkDateSize.Width -100,
               headerPosY);

          
            string deadline =$"截止日期:{dtpDeadLine.Value.ToString("yyyy-MM-dd")}";
          
            SizeF deadlineDateSize = e.Graphics.MeasureString(deadline, tableHeaderFont);
            e.Graphics.DrawString(deadline, tableHeaderFont, brush, (pageWidth - deadlineDateSize.Width) / 2,
                headerPosY);

          


            //calculate usedtotalheight
            usedTotalHeight +=deadlineDateSize.Height;
            #endregion

                              

            #region draw column headers


            // Draw column headers (adjust column positions and widths)

            usedTotalHeight += 20;
            float columnHeaderY = usedTotalHeight ;

            float[] columnWidths = {30, 90, 100, 140, 180, 80, 80, 80 };
            float[] columnPositions = new float[columnWidths.Length];
            columnPositions[0] = margin + 10;
            for (int i = 1; i < columnWidths.Length; i++)
            {
                columnPositions[i] = columnPositions[i - 1] + columnWidths[i - 1];
            }
            string[] columnHeaders = {"行号", "仓库名称", "存货编码", "存货名称", "规格型号", "现存数量", "盘点数量", "差异" };
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                e.Graphics.DrawString(columnHeaders[i], dataFont, brush, columnPositions[i], columnHeaderY );
            }

            //usedTotalHeight +=dataFont.Height;


            #endregion


            #region draw table frame

            // Calculate table top-left and bottom-right
            float tableX = margin ;
            float tableY = usedTotalHeight -10;
            float rowHeight = 30f;
            int rowCount = Math.Min(rowsPerPage, dgvBody.Rows.Count - printRowCount); // or set a fixed number for preview


            // Calculate table width (sum of column widths)
            float tableWidth = columnWidths.Sum();
            // Calculate table height (header + data rows)
            float tableHeight = rowHeight * (rowCount + 1); // +1 for header

            // Draw outer border
            e.Graphics.DrawRectangle(pen, tableX, tableY, tableWidth, tableHeight);

            // Draw vertical lines (columns)
            float x = tableX;
            for (int i = 0; i < columnWidths.Length; i++)
            {
                e.Graphics.DrawLine(pen, x, tableY, x, tableY + tableHeight);
                x += columnWidths[i];
            }
            // Draw last vertical line at the end
            e.Graphics.DrawLine(pen, tableX + tableWidth, tableY, tableX + tableWidth, tableY + tableHeight);

            // Draw horizontal lines (rows)
            for (int i = 0; i <= rowCount + 1; i++) // +1 for header
            {
                float y = tableY + i * rowHeight;
                e.Graphics.DrawLine(pen, tableX, y, tableX + tableWidth, y);
            }

            #endregion

            #region draw table data

            // Loop through the DataGridView rows

            float dataPosY = usedTotalHeight + 30;

            while (usedTotalHeight < pageHeight - margin && printRowCount < dgvBody.Rows.Count)
            {
                // Draw the row
                for (int j = 1; j < dgvBody.Columns.Count; j++)
                {
                    string cellValue = dgvBody.Rows[printRowCount].Cells[j].Value?.ToString() ?? "";
                    float a = columnPositions[j - 1];
                    e.Graphics.DrawString(cellValue, dataFont, brush, a, dataPosY);
                }
                printRowCount++;

                dataPosY += 30;
            }


            #endregion


            #region footer
            float footerPosY = pageHeight - margin-50;
            float footPosX = margin + 10;

            string makeBy = "制表人:";
            SizeF makeBySize = e.Graphics.MeasureString(makeBy, tableHeaderFont);
            e.Graphics.DrawString(makeBy, tableHeaderFont, brush, footPosX, footerPosY);

            string checkBy = "盘点人:";
            SizeF checkBySize = e.Graphics.MeasureString(checkBy, tableHeaderFont);
            e.Graphics.DrawString(checkBy, tableHeaderFont, brush, (pageWidth-makeBySize.Width)/2 , footerPosY);

            string auditBy = "稽核人:";
            SizeF auditBySize = e.Graphics.MeasureString(auditBy, tableHeaderFont);
            e.Graphics.DrawString(auditBy, tableHeaderFont, brush, pageWidth-margin-auditBySize.Width-100 , footerPosY);


            usedTotalHeight += makeBySize.Height;
            #endregion


            #region draw page number
            float pageNumberPosY = pageHeight - margin - 30;

            // Draw the footer line
            e.Graphics.DrawLine(pen, margin + 10, pageNumberPosY, pageWidth - margin - 10, pageNumberPosY-10);
            e.Graphics.DrawString("第" + _currentPage + "页 共" + this._totalPages + "页",
             new Font("宋体", 10, FontStyle.Regular), Brushes.Black,
             pageWidth / 2 - 30
             , pageNumberPosY);//底边距太小，则无法打印出来

            #endregion

            #region has more pages

            // Calculate the total number of pages
            //float tableHeight = pageHeight - usedHeadFooterHeight ;
            if (_currentPage == 1)
            {
                rowsPerPage = printRowCount;
            }
            _totalPages = (int)Math.Ceiling((double)dgvBody.Rows.Count / rowsPerPage);

            if (this.printRowCount < dgvBody.Rows.Count - 1)
            {
                //Has more pages??  
                //只HasMorePages属性为true,printPage事件方法就会反复执行，相当于反复触发了printPage事件
                _currentPage += 1;
                e.HasMorePages = true;

            }


            #endregion


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



