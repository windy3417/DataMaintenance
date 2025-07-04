﻿
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using DataMaintenance;
using DataMaintenance.Model;
using System.Collections.Generic;
using System.Configuration;
using Utility;
using DataMaintenance.Model.Maintenance;
using Utility.Encrypt;

namespace DataMaintenance.UI
{
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
            this.initialize();

        }

        #region 变量
        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<UserModle> mList = new List<UserModle>();
        //最大客户编号
        //int maxCusCode;
        //dataGridView控件的数据来源，true为查询时绑定，
        //false为新增档案时的绑定


        enum saveOrChangeOrQueryMolde
        {
            save,
            change,
            query
        }

        //修改与新增的dbContext标记,true为新增dbContext，false为修改dbContext

        //bool saveOrChangeFlag = true;
        string saveOrModifQueryFlag;
        #endregion


        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initialize()
        {
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            tsb_modify.Enabled = false;
            this.tsb_save.Enabled = false;
            this.tsb_modify.Enabled = false;
            this.tsb_delete.Enabled = false;
            tsb_abandon.Enabled = false;
            this.dgvDetail.AutoGenerateColumns = false;
            this.tableLayoutPanel1.Enabled = false;
            lbl_voucherStatus.Visible = false;


        }

        #region 增删改查

        /// <summary>
        /// 新增档案并自动生成客户编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_add_Click(object sender, EventArgs e)
        {
            
            lbl_voucherStatus.Text = "档案状态：新增";
            lbl_voucherStatus.Visible = true;

            //先清空查询时绑定的数据
            clearDate();
            //故增加数据源判定,否则连续增加时就无法在DataGridView中显示增加的记录
            if (saveOrModifQueryFlag != saveOrChangeOrQueryMolde.save.ToString())
            {
                saveOrModifQueryFlag = saveOrChangeOrQueryMolde.save.ToString();
                this.dgvDetail.DataSource = null;
            }

            this.tsb_save.Enabled = true;
            tsb_abandon.Enabled = true;

            //新增与查询功能中的dataGridView数据源不同，且该数据源标记通过功能键触发选择
            //tsb_query.Enabled = false;
            tsb_modify.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
           
                        
            //给自定义日期控件赋值，其中的textBox控件为显示值
            //日期控件的文本为将需要存储的值
            this.tbd_effect.Controls[2].Text = DateTime.Now.ToString().Substring(0,10);
            tbd_effect.Text = DateTime.Now.ToString().Substring(0, 10);

            ////取最大编号时速度太慢，三秒左右，同时最大号算法有误，取到第10号则不向上递增了???。
            //using (var db = new DataMaitenanceContext())
            //{
            //    UserModle customer = new UserModle();

            //    var custQuery = from cust in db.Users.AsNoTracking()

            //                    select cust.userID;
            //    if (custQuery.Count()==0)
            //    {
            //        maxCusCode = 1;
            //    }
            //    else
            //    {
            //        maxCusCode = Convert.ToInt32(custQuery.Max()) + 1;
            //    }
               


            //}
            //this.txt_cusCode.Text = maxCusCode.ToString();

            this.txt_cusCode.Focus();
            //表明当前dataGridView的数据源是内存集合数据

        }

        
        /// <summary>
        /// 删除选择定行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {

            if (dgvDetail.Rows.Count > 0)
            {
               string selected = this.dgvDetail.SelectedRows[0].Cells[0].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    DataMaintenanceContext db = new DataMaintenanceContext();

                    List<UserModle> d = (from del in db.Users
                                                  where del.userID ==selected
                                                  select del).ToList<UserModle>();
                    //移除数据库的数据
                    
                    db.Users.Remove(d[0]);
                    db.SaveChanges();
                    clearDate();

                    //如果是在新增界面状态使用删除功能，则同时删除内存中的集合数据
                    //数据库中的条件实体delCustomer不能成为内存中的待删除实体
                    //即：customerList.Remove(delCustomer[0])返回false,故无法实现
                    //内存当中的数据集记录删除;
                    if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                    {

                        List<UserModle> customer = mList.Where(c => c.userID == selected).ToList<UserModle>();
                        mList.Remove(customer[0]);

                    }
                    bind_gv_dateSource();
                }
            }

            return;

        }

        /// <summary>
        /// 保存客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {

            saveOrChang();

        }

        /// <summary>
        /// 数据保存与修改
        /// </summary>
        private void saveOrChang()
        {

            if (inputVlidate())
            {
                //新增后保存
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
                {
                    using (var db = new DataMaintenanceContext())
                    {

                        UserModle m = new UserModle();
                        m.userID = txt_cusCode.Text;
                        m.UserName = this.txt_cusName.Text;
                        m.pwd =Encrypt.Encode( txt_pwd.Text);
                        m.RegistrationDate = Convert.ToDateTime(this.tbd_effect.Text);
                        if (this.tbd_failure.Text != null & tbd_failure.Text != "")
                        {
                            m.DateOfCancellation = Convert.ToDateTime(this.tbd_failure.Text);
                        }


                        db.Users.Add(m);
                        try
                        {
                            db.SaveChanges();
                        }
                        catch (Exception e)
                        {

                            MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                            return;
                        }

                        mList.Add(m);
                       
                        this.bind_gv_dateSource();

                        //清空填制记录
                        //this.txt_cusCode.Text = null;
                        //this.txt_cusName.Text = null;
                        clearDate();

                        //再次调用新增事件

                        this.tsb_add.PerformClick();
                    }
                }

                //查询之后修改并保存
                if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.query.ToString())
                {
                    using (var db = new DataMaintenanceContext())
                    {
                        UserModle m = db.Users.Where(c => c.userID.ToString() == txt_cusCode.Text).FirstOrDefault();

                        m.userID = txt_cusCode.Text;

                        m.UserName = this.txt_cusName.Text;
                        m.pwd = Encrypt.Encode(txt_pwd.Text);
                        m.RegistrationDate = Convert.ToDateTime(this.tbd_effect.Text);

                        //customer.EffectDate = Convert.ToDateTime(this.tbd_effect.Text);
                        //if (this.tbd_failure.Text != null & this.tbd_failure.Text != "")
                        //{
                        //    customer.FailuerDate = Convert.ToDateTime(this.tbd_failure.Text);
                        //}
                        db.SaveChanges();
                        this.bind_gv_dateSource();

                        //清空修改记录
                        clearDate();
                    }
                }
            };




        }

        /// <summary>
        /// 修改客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_modify_Click(object sender, EventArgs e)
        {
            lbl_voucherStatus.Text = "档案状态：修改";
            lbl_voucherStatus.Visible = true;
            tsb_add.Enabled = false;

            tableLayoutPanel1.Enabled = true;
            //编码不能被修改
            txt_cusCode.Enabled = false;
            tsb_save.Enabled = true;

        }

        /// <summary>
        /// 查询客户档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            clearDate();
            lbl_voucherStatus.Text = "档案状态：查询";
            lbl_voucherStatus.Visible = true;
            
            saveOrModifQueryFlag = saveOrChangeOrQueryMolde.query.ToString();
            this.tsb_save.Enabled = false;
            this.bind_gv_dateSource();
            this.tsb_modify.Enabled = true;

            this.tsb_delete.Enabled = true;
            if (dgvDetail.Rows.Count>0)
            {
                this.dgvDetail.Rows[0].Selected = true;
            }


        }


        #endregion

        #region 输入校验

        /// <summary>
        /// 正则校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regValidating(object sender, CancelEventArgs e)
        {
            string pattern = "^-?[1-9]\\d*$";
            Regex regex = new Regex(pattern);
            if (!regex.Match(txt_cusCode.Text).Success)
            {

                //为空时不做正则判断
                if (this.txt_cusCode.TextLength == 0)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("请输入数字作为编码", "输入验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_cusCode.Text = "";
                    this.txt_cusCode.Focus();
                }


            };

        }

        /// <summary>
        /// 为空校验
        /// </summary>
        private bool inputVlidate()
        {

            for (int i = 0; i < this.tableLayoutPanel1.Controls.Count;)
            {
                //if (this.tableLayoutPanel1.Controls[i].Name.Substring(0, 3) == "txt" & this.tableLayoutPanel1.Controls[i].Text == "")
                if (this.tableLayoutPanel1.Controls[i].Name != tbd_failure.Name)
                {
                    if (this.tableLayoutPanel1.Controls[i].Text == "" || this.tableLayoutPanel1.Controls[i].Text == null)
                    {
                        MessageBox.Show(this.tableLayoutPanel1.Controls[i].Tag + "不能为空", "输入校验");
                        return false;
                    }
                }

                i++;


            }
            return true;


        }
        #endregion

               
        #region 窗体操作
        /// <summary>
        /// 关闭嵌入式窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        #endregion


        #region 数据处理与绑定
        /// <summary>
        /// 绑定dataGridView的数据源
        /// </summary>
        private void bind_gv_dateSource()
        {
            this.dgvDetail.DataSource = null;
            //使用EF速度很慢,不使用默认的DBContext连接字符串后，效率有提升???
            //查询状态的数据源
            if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.query.ToString())
            {
                this.dgvDetail.DataSource = new DataMaintenanceContext().Users.ToList<UserModle>();
            }
            //新增状态的数据源
            else
            {
                this.dgvDetail.DataSource = mList;
            }


            //以下为直接使用ADO.NET 连接
            // CustomerService customerService = new CustomerService();
            //customerList= customerService.getCustomerList();
            // this.dataGridView1.DataSource = null;
            // this.dataGridView1.DataSource = customerList;

        }

        /// <summary>
        /// 清除录入或查询出的数据
        /// </summary>
        private void clearDate()
        {
            foreach (Control item in this.tableLayoutPanel1.Controls)
            {

                //if (item.Name.Substring(0, 3) != "lbl")
                if (item.GetType() != typeof(Label))
                {
                    item.Text ="" ;
                }



            }
        }

     

        /// <summary>
        /// 选择当前行数据进行处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            clearDate();
            if (e.RowIndex > -1)
            {
                this.txt_cusCode.Text = this.dgvDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txt_cusName.Text = this.dgvDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }




        }

        #endregion


        #region 快捷键
        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }

        /// <summary>
        /// 删除功能快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_customer_KeyDown(object sender, KeyEventArgs e)
        {
            // if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            if (e.KeyCode == Keys.S && e.Control)
            {
                tsb_save.PerformClick(); //执行单击button1的动作      
            }
            if (e.KeyCode == Keys.Delete)
            {
                tsb_delete.PerformClick();
            }

        }







        #endregion

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tsb_delete.Enabled = true;
        }

        /// <summary>
        /// 放弃新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_abandon_Click(object sender, EventArgs e)
        {
            tsb_save.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_query.Enabled = true;
            tsb_add.Enabled = true;
            tsb_abandon.Enabled = false;
            clearDate();
            tableLayoutPanel1.Enabled = false;

        }
    }
}