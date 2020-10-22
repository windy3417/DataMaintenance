using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.Sql;


namespace DataMaintenance.UI
{
    public partial class Frm_toolProperty : Form
    {
        public Frm_toolProperty()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(closeParent);

        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void btn_mend_Click(object sender, EventArgs e)
        {
            int isAset;
            List<SqlParameter> sqlParameterList = new List<SqlParameter>();
            SqlParameter sqlParameterSqlString = new SqlParameter("@updateString", txt_invCode.Text.Trim());

            string sql = "update inventory_sub set binvasset = @isAset where cInvSubCode=@updateString";

            if (rb_aset.Checked)

            {
                isAset = 1;
                SqlParameter sqlParameterIsAset = new SqlParameter("@isAset", isAset);
                sqlParameterList.Add(sqlParameterIsAset);

            };
            if (rb_consume.Checked)
            {
                isAset = 0;
                SqlParameter sqlParameterIsAset = new SqlParameter("@isAset", isAset);
                sqlParameterList.Add(sqlParameterIsAset);
            }

            sqlParameterList.Add(sqlParameterSqlString);

            try
            {
                int influnceRows = Sqlhelper.UpdateWithparameters(sql, sqlParameterList.ToArray());
                MessageBox.Show("更新" + influnceRows + "条记录", "数据修改提示");
            }
            catch (Exception ex)
            {

                
                MessageBox.Show("更新属性出错"+ex.Message+ex.InnerException, "数据修改提示");
            }

            

        }





    }
}

