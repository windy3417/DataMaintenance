using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMaintenance.Model;
using Utility.Sql;
using System.Data.SqlClient;
using System.Data;

namespace DataMaintenance.UI.ClearLocker
{
    public partial class FrmClearU8Task : Form
    {
        public FrmClearU8Task()
        {
            InitializeComponent();
            cmbAccountNo.Text = "017";
            this.FormClosed += closeParentForm;
         
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

    

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle styleDataGridView = new Utility.Style.DataGridViewStyle();
            styleDataGridView.DisplayRowNo(e, dataGridView1,false);
        }

        private void tsbDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("强行清除正在执行的任务，有可能会使正在执行的数据出错！！！建议通知任务人员主动退出！是否要清除任务?", "任务清除警告"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    string sql = "delete from ua_task";
                    Sqlhelper.ExecuteWithNoneParameter(sql, Sqlhelper.DataSourceType.ufsystem);
                    MessageBox.Show("任务删除成功");
                    dataGridView1.DataSource = null;
                }
                
                

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            } 
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                //SqlConnection sqlConnection = Sqlhelper.sqlConnection(Sqlhelper.DataSourceType.ufsystem);

                StringBuilder sql = new StringBuilder();
                sql.Append("select aa.cacc_id as 账套编号, aa.cUser_Id as 用户编号, dd.cUser_Name as 用户名, aa.cTaskId as 任务编号, bb.cAuth_Name as 正在执行操作 , cc.dInTime as 进入时间, ");
                sql.Append("case cc.TaskState when 0 then '正常'  when 1 then '正常'  when 12 then '正常'  end as 任务状态 ");
                sql.Append("from ua_task aa  left join ua_auth bb on aa.cauth_id = bb.cauth_id ");
                sql.Append("left join ua_tasklog cc on cc.ctaskid = aa.ctaskid left join ua_user as dd on aa.cUser_Id = dd.cUser_Id ");
                sql.Append($"where aa.cacc_id ={cmbAccountNo.Text} ");




                dataGridView1.DataSource = Sqlhelper.GetDataTable(sql.ToString(), Sqlhelper.DataSourceType.ufsystem);
                Utility.Style.DataGridViewStyle styleDataGridView = new Utility.Style.DataGridViewStyle();
                styleDataGridView.DataGridViewColumnHeaderStyle(dataGridView1);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;



                ;
            }
            catch (Exception ex)
            {

                MessageBox.Show("任务查询出错！" + ex.Message + ex.InnerException);
            }
        }
    }
}
