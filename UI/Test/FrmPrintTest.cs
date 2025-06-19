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

namespace DataMaintenance.UI.Test
{
    public partial class FrmPrintTest : Form
    {
        public FrmPrintTest()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (DialogResult.OK == printDialog1.ShowDialog())
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define font and brush for drawing text
            Font headerFont = new Font("Arial", 12f, FontStyle.Bold);
            Font dataFont = new Font("Arial", 8f);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black);

          


            float pageWidth = e.PageBounds.Width;
            float pageHeight = e.PageBounds.Height;
            float margin = 50; // Adjust margin as needed

            e.Graphics.DrawLine(pen, margin, margin, pageWidth - margin, margin); // Top border
            e.Graphics.DrawLine(pen, margin, margin, margin, pageHeight - margin); // Left border
            e.Graphics.DrawLine(pen, margin, pageHeight - margin, pageWidth - margin, pageHeight - margin); // Bottom border
            e.Graphics.DrawLine(pen, pageWidth - margin, margin, pageWidth - margin, pageHeight - margin); // Right border

            // Draw title
            string title = "盘点表";
            SizeF titleSize = e.Graphics.MeasureString(title, headerFont);
            e.Graphics.DrawString(title, headerFont, brush, (pageWidth - titleSize.Width) / 2, margin + 10);

          
            float[] columnPositions = { margin + 10, margin + 80, margin + 160, margin + 300, margin + 450, margin + 500, margin + 550, margin + 600 };
            string[] columnHeaders = { "仓库名称", "存货编码", "存货名称", "规格型号", "现存数量", "盘点数量", "差异" };
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                e.Graphics.DrawString(columnHeaders[i], dataFont, brush, columnPositions[i], margin + 30);
            }
        }
    }
}
