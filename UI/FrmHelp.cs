using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace DataMaintenance.UI
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
         
            InitializeUI();
        }

        private void InitializeUI()
        {
            // 设置窗体标题
            this.Text = "软件信息";

            // 添加 Label 控件
            Label lblSoftwareName = new Label
            {
                Text = "软件名称: " + Application.ProductName,
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };
            Controls.Add(lblSoftwareName);

            Label lblVersion = new Label
            {
                Text = "版本号: " + Application.ProductVersion,
                
                //Text = "版本号: " + GetInformationalVersion(),
                Location = new System.Drawing.Point(20, 50),
                AutoSize = true
            };
            Controls.Add(lblVersion);

            Label lblBuildDate = new Label
            {
                Text = "构建日期: " + GetBuildDate(),
                Location = new System.Drawing.Point(20, 80),
                AutoSize = true
            };
            Controls.Add(lblBuildDate);

            Label lblCopyright = new Label
            {
                Text = "版权所有 ©" + Application.CompanyName,
                
                Location = new System.Drawing.Point(20, 110),
                AutoSize = true
            };
            Controls.Add(lblCopyright);

            Label lblDescription = new Label
            {
                Text = "问题反馈请发送邮件至：jing.luo@csximai.com",
                Location = new System.Drawing.Point(20, 140),
                AutoSize = true
            };
            Controls.Add(lblDescription);

            // 设置窗体大小以适应所有控件
            this.ClientSize = new System.Drawing.Size(Math.Max(300, lblDescription.Right + 20), lblDescription.Bottom + 20);
        }

        private string GetBuildDate()
        {
            // 获取编译时间
            var assembly = Assembly.GetExecutingAssembly();
            var location = assembly.Location;
            var fileInfo = new FileInfo(location);
            var creationTime = fileInfo.CreationTimeUtc;

            return creationTime.ToString("yyyy-MM-dd");

        }

        private string GetInformationalVersion()
        {
            // 获取发布版本
            var assembly = Assembly.GetExecutingAssembly();
            var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
            if (customAttributes.Length > 0)
            {
                var attribute = (AssemblyInformationalVersionAttribute)customAttributes[0];
                return attribute.InformationalVersion;
            }
            return "未知";
        }

    }
}