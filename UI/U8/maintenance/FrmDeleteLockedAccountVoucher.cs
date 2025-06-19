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

            try
            {
                Sqlhelper.ExecuteQuery(sql, Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);
                MessageBox.Show("删除成功");
            }
            catch (Exception)
            {

                throw;
            } 
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            string sql = "select * from GL_mvcontrol";

            dataGridView1.DataSource = Sqlhelper.GetDataTable(sql, Sqlhelper.DataSourceType.u8,cmbAccountNo.Text);

        }
    }
}
