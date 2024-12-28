using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.Sql;

namespace DataMaintenance.UI.ClearLocker
{
    public partial class FrmDeleteLockedAccountVoucher : Form
    {
        public FrmDeleteLockedAccountVoucher()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
            InitializeContolsData();
        }

        void InitializeContolsData()
        {
            string sql = "select * from GL_mvcontrol";
           
            dataGridView1.DataSource = Sqlhelper.GetDataTable(sql, Sqlhelper.DataSourceType.u8);

        }

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = " delete  from GL_mvcontrol";

            dataGridView1.DataSource = Sqlhelper.ExecuteWithNoneParameter(sql,Sqlhelper.DataSourceType.u8);
        }
    }
}
