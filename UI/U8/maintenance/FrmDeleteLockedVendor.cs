using DataMaintenance.Model;
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
    public partial class FrmDeleteLockedVendor : Form
    {
        public FrmDeleteLockedVendor()
        {
            InitializeComponent();
            //set default value of cmbAccountNo
            cmbAccountNo.Text = "018";
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
            string sql = " delete  from LockVouch";
            using (var db = new U8Context(cmbAccountNo.Text))
            {
                db.Database.ExecuteSqlCommand(sql);
                dataGridView1.DataSource = null;
            }


        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            string sql = "select *  from LockVouch";

           var ds= Utility.Sql.Sqlhelper.GetDataTable(sql, Sqlhelper.DataSourceType.u8,cmbAccountNo.Text);
            dataGridView1.DataSource = ds;
        }
    }
}
