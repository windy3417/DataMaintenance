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
        private int printRowCount = 0;
        float pageHeight = 0;
        int rowsPerPage=30;
        private int _currentPage = 1;
        private int _totalPages=1;
        
        private List<Warehouse> selectedWarehouses = new List<Warehouse>();
        #endregion

        void InitializeControl()
        {
           
            dgvBody.AllowUserToAddRows = false;

        }

        void InitializeDataSource()
        {
            cmbAccountNo.DataSource = Utility.DAL.QueryService.GetListFromSingleTable<UA_Account>
                 (Utility.Sql.Sqlhelper.DataSourceType.ufsystem);
            cmbAccountNo.ValueMember = "cAcc_Id";
            cmbAccountNo.DisplayMember = "cAcc_Name";
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
            cmbAccountNo.SelectedIndex = 2;
        }

        private void btnSelectWarehouse_Click(object sender, EventArgs e)
        {
            if (cmbAccountNo.SelectedValue == null)
            {
                MessageBox.Show("请先选择账套", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var warehouses = Utility.DAL.QueryService.GetListFromSingleTable<Warehouse>
                (Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.SelectedValue.ToString()).OrderBy(s => s.cWhCode).ToList();

            using (Form selectForm = new Form())
            {
                selectForm.Text = "选择仓库";
                selectForm.Size = new Size(450, 400);
                selectForm.StartPosition = FormStartPosition.CenterParent;

                CheckedListBox chkList = new CheckedListBox();
                chkList.Dock = DockStyle.Fill;
                chkList.CheckOnClick = true;

                foreach (var warehouse in warehouses)
                {
                    bool isChecked = selectedWarehouses.Any(w => w.cWhCode == warehouse.cWhCode);
                    chkList.Items.Add(new WarehouseItem(warehouse), isChecked);
                }

                Button btnOK = new Button();
                btnOK.Text = "确定";
                btnOK.Dock = DockStyle.Bottom;
                btnOK.Click += (s, args) =>
                {
                    selectedWarehouses.Clear();
                    foreach (var item in chkList.CheckedItems)
                    {
                        WarehouseItem wi = item as WarehouseItem;
                        if (wi != null)
                        {
                            selectedWarehouses.Add(wi.Warehouse);
                        }
                    }
                    UpdateSelectedWarehousesText();
                    selectForm.Close();
                };

                selectForm.Controls.Add(chkList);
                selectForm.Controls.Add(btnOK);
                selectForm.ShowDialog(this);
            }
        }

        private void UpdateSelectedWarehousesText()
        {
            if (selectedWarehouses.Count == 0)
            {
                txtSelectedWarehouses.Text = "未选择仓库";
            }
            else if (selectedWarehouses.Count <= 3)
            {
                txtSelectedWarehouses.Text = string.Join(", ", selectedWarehouses.Select(w => $"{w.cWhCode} - {w.cWhName}"));
            }
            else
            {
                txtSelectedWarehouses.Text = $"已选择 {selectedWarehouses.Count} 个仓库";
            }
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dgvBody.DataSource = null;
            dgvBody.Rows.Clear();

            if (selectedWarehouses.Count == 0)
            {
                MessageBox.Show("请至少选择一个仓库", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                return;
            }

            DataTable resultTable = null;
            string accountNo = cmbAccountNo.SelectedValue.ToString();



            foreach (var warehouse in selectedWarehouses)
            {
                var service = new U8service.DAL.JoinTableSvc.CurrentStockService(accountNo);
                DataTable dt = service.GetCurrentStock(warehouse.cWhCode);
                
                if (resultTable == null)
                {
                    resultTable = dt.Copy();
                }
                else if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        resultTable.ImportRow(row);
                    }
                }
            }

            dgvBody.DataSource = resultTable;

            if (dgvBody.Columns.Contains("iQuantity"))
            {
                dgvBody.Columns["iQuantity"].ValueType = typeof(double);
                // set the format for the iQuantity column as N2
                dgvBody.Columns["iQuantity"].DefaultCellStyle.Format = "N2";
            }

            dgvBody.ReadOnly = true;

            for (int i = 0; i < dgvBody.Rows.Count; i++)
            {
                dgvBody.Rows[i].HeaderCell.Value = (i + 1).ToString();
                // set the row header width to fit the content
                dgvBody.RowHeadersWidth = 60;
            }

            this.Cursor = Cursors.Default;
        }

        private class WarehouseItem
        {
            public Warehouse Warehouse { get; }

            public WarehouseItem(Warehouse warehouse)
            {
                Warehouse = warehouse;
            }

            public override string ToString()
            {
                return $"{Warehouse.cWhCode} - {Warehouse.cWhName}";
            }
        }

        private void tspPrint_Click(object sender, EventArgs e)
        {
            printRowCount = 0;
            _currentPage = 1;
            _totalPages = 1;

            // Set the number of rows per page  according to the page height and row height
            rowsPerPage = 31;

            PrintDocument printDoc = new PrintDocument();
            pageHeight = printDoc.DefaultPageSettings.PaperSize.Height;

            _totalPages = (int)Math.Ceiling((double)dgvBody.Rows.Count / (double)rowsPerPage);

            printDoc.PrintPage += PrintPageEventHandler;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;

            ToolStripButton b = new ToolStripButton();
            b.Image = Properties.Resources.打印;
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            b.Tag = printDoc;
            b.Click += Print;

            ((ToolStrip)(previewDialog.Controls[1])).Items.RemoveAt(0);
            ((ToolStrip)(previewDialog.Controls[1])).Items.Insert(0, b);
            previewDialog.ShowDialog();
        }

        private void Print(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = ((ToolStripButton)sender).Tag as PrintDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printRowCount = 0;
                _currentPage = 1;
                rowsPerPage = 31;
                _totalPages = (int)Math.Ceiling((double)dgvBody.Rows.Count / (double)rowsPerPage);
                
                printDialog.Document.Print();
            }
        }

        private void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics == null)
                return;

            using (Font titleFont = new Font("Arial", 16f, FontStyle.Bold))
            using (Font tableHeaderFont = new Font("Arial", 10f, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 8f, FontStyle.Bold))
            using (Font dataFont = new Font("Arial", 8f))
            using (Pen pen = new Pen(Color.Black))
            {
                Brush brush = Brushes.Black;

                float pageWidth = e.PageBounds.Width;
                float pageHeight = e.PageBounds.Height;
                float usedTotalHeight = 0;
                float margin = 20;

                #region logo and title and table header
                int logoX = (int)margin + 10;
                int logoY = (int)margin + 10;
                int logoWidth = 150;
                int logoHeight = 40;

                if (Resources.CZ_LOGO != null)
                {
                    e.Graphics.DrawImage(Resources.CZ_LOGO, new Rectangle(logoX, logoY, logoWidth, logoHeight));
                }

                usedTotalHeight += logoY + logoHeight;
                #endregion

                #region draw title
                float titleY = logoY + logoHeight / 2 + 10;
                string title = "盘点表";
                SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
                float titleX = (pageWidth - titleSize.Width) / 2;

                if (titleX >= 0 && titleY >= 0 && titleSize.Width > 0 && titleSize.Height > 0)
                {
                    e.Graphics.DrawString(title, titleFont, brush, titleX, titleY);
                }
                #endregion

                #region draw table header
                usedTotalHeight += 25;
                float headerPosY = usedTotalHeight;
                string checkDate = "盘点日期:";
                SizeF checkDateSize = e.Graphics.MeasureString(checkDate, tableHeaderFont);

                e.Graphics.DrawString(checkDate, tableHeaderFont, brush, pageWidth - margin - checkDateSize.Width - 100, headerPosY);

                string deadline = $"截止日期:{dtpDeadLine.Value.ToString("yyyy-MM-dd")}";
                SizeF deadlineDateSize = e.Graphics.MeasureString(deadline, tableHeaderFont);
                e.Graphics.DrawString(deadline, tableHeaderFont, brush, (pageWidth - deadlineDateSize.Width) / 2, headerPosY);

                usedTotalHeight += deadlineDateSize.Height;
                #endregion

                #region draw column headers
                usedTotalHeight += 20;
                float columnHeaderY = usedTotalHeight;

                float[] columnWidths = { 35, 90, 90, 180, 180, 80, 70, 50 };
                float[] columnPositions = new float[columnWidths.Length];
                columnPositions[0] = margin + 5;
                for (int i = 1; i < columnWidths.Length; i++)
                {
                    columnPositions[i] = columnPositions[i - 1] + columnWidths[i - 1];
                }
                string[] columnHeaders = { "行号", "仓库名称", "存货编码", "存货名称", "规格型号", "现存数量", "盘点数量", "差异" };
                
                StringFormat centerFormat = new StringFormat();
                centerFormat.Alignment = StringAlignment.Center;
                centerFormat.LineAlignment = StringAlignment.Center;

                for (int i = 0; i < columnHeaders.Length; i++)
                {
                    RectangleF headerRect = new RectangleF(columnPositions[i], columnHeaderY, columnWidths[i], dataFont.Height + 4);
                    e.Graphics.DrawString(columnHeaders[i], dataFont, brush, headerRect, centerFormat);
                }
                #endregion

                #region draw table frame and data
                float rowHeight = 30f;
                float tableX = margin;
                float tableY = usedTotalHeight - 10;
                float tableWidth = columnWidths.Sum();
                float dataPosY = usedTotalHeight + 30;

                List<int> printedRows = new List<int>();

                while (dataPosY < pageHeight - margin - 80 && printRowCount < dgvBody.Rows.Count)
                {
                    printedRows.Add(printRowCount);
                    printRowCount++;
                    dataPosY += rowHeight;
                }

                int rowCount = printedRows.Count;
                float tableHeight = rowHeight * (rowCount + 1);

                if (tableHeight > 0)
                {
                    e.Graphics.DrawRectangle(pen, tableX, tableY, tableWidth, tableHeight);

                    float x = tableX;
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        e.Graphics.DrawLine(pen, x, tableY, x, tableY + tableHeight);
                        x += columnWidths[i];
                    }
                    e.Graphics.DrawLine(pen, tableX + tableWidth, tableY, tableX + tableWidth, tableY + tableHeight);

                    for (int i = 0; i <= rowCount + 1; i++)
                    {
                        float y = tableY + i * rowHeight;
                        e.Graphics.DrawLine(pen, tableX, y, tableX + tableWidth, y);
                    }
                }
                #endregion

                #region draw table data
                dataPosY = usedTotalHeight + 30;

                for (int i = 0; i < printedRows.Count; i++)
                {
                    int rowIndex = printedRows[i];

                    RectangleF rowNumRect = new RectangleF(columnPositions[0], dataPosY, columnWidths[0], rowHeight);
                    e.Graphics.DrawString((rowIndex + 1).ToString(), dataFont, brush, rowNumRect, centerFormat);

                    string whCode = dgvBody.Rows[rowIndex].Cells["cWhCode"].Value?.ToString() ?? "";
                    string whName = dgvBody.Rows[rowIndex].Cells["cWhName"].Value?.ToString() ?? "";
                    RectangleF warehouseRect = new RectangleF(columnPositions[1], dataPosY, columnWidths[1], rowHeight);
                    //e.Graphics.DrawString($"{whCode} - {whName}", dataFont, brush, warehouseRect, centerFormat);
                    e.Graphics.DrawString($"{whName}", dataFont, brush, warehouseRect, centerFormat);

                    int colIndex = 2;
                    for (int j = 0; j < dgvBody.Columns.Count; j++)
                    {
                        string colName = dgvBody.Columns[j].Name;
                        if (colName != "cWhCode" && colName != "cWhName")
                        {

                            string cellValue = dgvBody.Rows[rowIndex].Cells[j].Value?.ToString() ?? "";
                            // 针对iQuantity列格式化为N2（千位分隔+2位小数）
                            if (colName == "iQuantity")
                            {
                                if (decimal.TryParse(cellValue, out decimal num))
                                {
                                    // 正确格式化并覆盖cellValue，后面打印用格式化后的值
                                    cellValue = num.ToString("N2");
                                }
                            }

                            if (colIndex < columnPositions.Length)
                            {
                                RectangleF cellRect = new RectangleF(columnPositions[colIndex], dataPosY, columnWidths[colIndex], rowHeight);
                                e.Graphics.DrawString(cellValue, dataFont, brush, cellRect, centerFormat);
                            }
                            colIndex++;
                        }
                    }
                    dataPosY += rowHeight;
                }
                #endregion

                #region footer
                float footerPosY = pageHeight - margin - 50;
                float footPosX = margin + 10;

                string makeBy = "制表人:";
                SizeF makeBySize = e.Graphics.MeasureString(makeBy, tableHeaderFont);
                e.Graphics.DrawString(makeBy, tableHeaderFont, brush, footPosX, footerPosY);

                string checkBy = "盘点人:";
                SizeF checkBySize = e.Graphics.MeasureString(checkBy, tableHeaderFont);
                e.Graphics.DrawString(checkBy, tableHeaderFont, brush, (pageWidth - makeBySize.Width) / 2, footerPosY);

                string auditBy = "稽核人:";
                SizeF auditBySize = e.Graphics.MeasureString(auditBy, tableHeaderFont);
                e.Graphics.DrawString(auditBy, tableHeaderFont, brush, pageWidth - margin - auditBySize.Width - 100, footerPosY);

                usedTotalHeight += makeBySize.Height;
                #endregion

                #region draw page number
                float pageNumberPosY = pageHeight - margin - 30;

                e.Graphics.DrawLine(pen, margin + 10, pageNumberPosY, pageWidth - margin - 10, pageNumberPosY);
                using (Font pageFont = new Font("宋体", 10, FontStyle.Regular))
                {
                    e.Graphics.DrawString($"第{_currentPage}页 共{_totalPages}页", pageFont, Brushes.Black, pageWidth / 2 - 30, pageNumberPosY + 5);
                }
                #endregion

                #region has more pages
                if (printRowCount < dgvBody.Rows.Count)
                {
                    _currentPage++;
                    e.HasMorePages = true;
                }
                #endregion
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel export = new Utility.Excel.ExportExcel();
            export.ExportExcelWithNPOI(dgvBody, "盘点表");
        }
    }

}



