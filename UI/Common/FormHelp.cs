using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataMaintenance.UI.Common
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }




        private async void FormHelp_Load(object sender, EventArgs e)
        {
            string mdPath = Path.Combine(Application.StartupPath, "Help", "Help.md");


            if (!File.Exists(mdPath))
            {
                MessageBox.Show("Help.md not found!");
                return;
            }

            string markdown = File.ReadAllText(mdPath);

            // Convert Markdown to HTML
            string html = Markdown.ToHtml(markdown);

            // Full HTML document
            string finalHtml = $@"
                        <html>
                        <head>
                        <meta charset='UTF-8'>
                        <style>
                        body {{
                            font-family: Arial;
                            margin: 20px;
                            line-height: 1.6;
                        }}
                        pre {{
                            background: #f0f0f0;
                            padding: 10px;
                            border-radius: 5px;
                        }}
                        code {{
                            background: #eee;
                            padding: 2px 4px;
                            border-radius: 4px;
                        }}
                        </style>
                        </head>
                        <body>
                        {html}
                        </body>
                        </html>";

            await webView21.EnsureCoreWebView2Async(null);
            webView21.NavigateToString(finalHtml);
            
        }
    }
}



