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
    public partial class Frm_PO : Form
    {
        public Frm_PO()
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

        /// <summary>
        /// 更新ERP数据库中的模板参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mend_Click(object sender, EventArgs e)
        {
            int editAble;
            List<SqlParameter> sqlParameterList = new List<SqlParameter>();
            SqlParameter sqlParameter1 = new SqlParameter("@VT_ID", "8173");
            SqlParameter sqlParameter2 = new SqlParameter("@FieldName", "itaxprice");

            SqlParameter sqlParameter3 = new SqlParameter("@vt_cardnumber", "88");
            SqlParameter sqlParameter4 = new SqlParameter("@VT_TemplateMode", "0");

            string sql = "update voucheritems_base set CanModify = @editAble where VT_ID = @VT_ID and FieldName =@FieldName; ";
            string sql2 = "update vouchertemplates_base set VT_TemplateMode=@VT_TemplateMode where vt_cardnumber =@vt_cardnumber and vt_id = @VT_ID ";

            if (rb_noEedit.Checked)

            {
                editAble = 0;
                SqlParameter sqlParameterEditAble = new SqlParameter("@editAble", editAble);
                sqlParameterList.Add(sqlParameterEditAble);

            };
            if (rb_edit.Checked)
            {
                editAble = 1;
                SqlParameter sqlParameterEditAble = new SqlParameter("@editAble", editAble);
                sqlParameterList.Add(sqlParameterEditAble);
            }

            sqlParameterList.Add(sqlParameter1);
            sqlParameterList.Add(sqlParameter2);
            sqlParameterList.Add(sqlParameter3);
            sqlParameterList.Add(sqlParameter4);


            try
            {
                int influnceRows1 = Sqlhelper.UpdateWithparameters(sql+sql2, sqlParameterList.ToArray());
                //int influnceRows2=Sqlhelper.UpdateWithparameters(sql2, sqlParameterList.ToArray());
                MessageBox.Show("更新" + influnceRows1 + "条记录", "数据修改提示");
            }
            catch (Exception ex)
            {

                
                MessageBox.Show("更新属性出错"+ex.Message+ex.InnerException, "数据修改提示");
            }

            

        }

        void authorizationLog()
        {

        }




    }
}

