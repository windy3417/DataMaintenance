using DataMaintenance.UI.Ref;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataMaintenance.UI.U8Attachment
{
    public partial class FrmArchiveAttachment : Form
    {
        public FrmArchiveAttachment()
        {
            InitializeComponent();
            InitializeControlsData();
            InitializeControlsState();
        }

       void InitializeControlsState()
        {
            this.FormClosed += FrmArchiveAttachment_FormClosed;
        }

        void InitializeControlsData()
        {
            cmbArchiveType.Text = "客户";
        }

        private void FrmArchiveAttachment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            switch (cmbArchiveType.Text)
            {
                case "客户":
                    FrmRefCustomer f = new FrmRefCustomer();
                    f.Show();
                    break;
            }
        }
    }
}
