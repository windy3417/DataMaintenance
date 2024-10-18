using DataMaintenance.Model.Maintenance;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.Ref;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Utility.DAL;
using Utility.Sql;

namespace DataMaintenance.UI.U8
{
    public partial class FrmUnitCostInput : Form
    {
        public FrmUnitCostInput()
        {
            InitializeComponent();
            InitializeControlState();
            initializeControlsDataSource();
        }

        Button btnRef = new Button();

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        void initializeControlsDataSource()
        {
            //会计年度数据源
            int[] year = new int[] { DateTime.Now.Year - 1, DateTime.Now.Year, DateTime.Now.Year + 1 };
            cmbYear.DataSource = year;
            cmbYear.Text = DateTime.Now.Year.ToString();

            #region 会计月份默认值
            if (DateTime.Now.Month - 1 >= 10)
            {
                cmbMonth.Text = (DateTime.Now.Month - 1).ToString();
            }
            if (DateTime.Now.Month - 1 < 10 & DateTime.Now.Month > 0)
            {
                cmbMonth.Text = "0" + (DateTime.Now.Month - 1).ToString();
            }

            if (DateTime.Now.Month - 1 == 0)
            {
                cmbMonth.Text = "12";
                cmbMonth.Text = (DateTime.Now.Year - 1).ToString();

            }

            //create datasource for cmbMonth with 12 months added 0 in the beginning when the month is less than 10
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cmbMonth.Items.Add("0" + i.ToString());
                }
                else
                {
                    cmbMonth.Items.Add(i.ToString());
                }
            }





            #endregion
            //default value of accont number
            cmbAccountNo.Text = "018";

            dgvDetail.Enabled = false;


        }

        void InitializeControlState()
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DataGridViewColumnHeaderStyle(dgvDetail);
            tsbSave.Enabled = false;
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AutoGenerateColumns = false;
            //display row number


            //add one row in the gridview
            dgvDetail.Rows.Add();


            //TsbStyleInvoice.Enabled = false;
            btnRef.Image = Properties.Resources.button;

            //do not put this statement into other  process provided by event method
            //otherwise the click event of this button will raise up many times
            btnRef.Click += BtnRef_Click;


        }


        #region refer other windows
       

      

        #endregion


        #region CRUD

        #region add

        private void tsbAdd_Click(object sender, EventArgs e)
        {

            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;

            tsbSave.Enabled = true;
            tsbDeleteRow.Enabled = true;
            tsbAddRow.Enabled = true;

            cmbAccountNo.Enabled = true;
            cmbYear.Enabled = true;
            cmbMonth.Enabled = true;

            dgvDetail.Enabled = true;




            dgvDetail.ReadOnly = false;
            dgvDetail.DataSource = null;
            dgvDetail.Rows.Clear();
            dgvDetail.Rows.Add();
            dgvDetail.BeginEdit(true);
        }

        /// <summary>
        /// input from reference window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRef_Click(object sender, EventArgs e)
        {

            if (!CheckTextBoxesAndComboBoxes())
            {
                MessageBox.Show("表头数据不能为空", "空值提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmRefInventory f = new FrmRefInventory(cmbAccountNo.Text);

            f.ActionRefIventoryItem = InputInvntoryItem;
            //f.RefInitialize();
            f.ShowDialog();
            DataGridViewCell cell = dgvDetail.CurrentCell;
            FocusCell(cell.RowIndex, "unitCost");
        }

        /// <summary>
        /// input manually,this method will be triggered also when user input reference window  
        /// but it doesn't matter,because the result will be the same
        /// </summary>
        private void GetInventoryManually()
        {
            // 获取当前选中的单元格
            DataGridViewCell currentCell = dgvDetail.CurrentCell;

            if (currentCell.ColumnIndex == 0)
            {
                // 获取用户输入的存货编码
                string invCode = currentCell.Value?.ToString();

                // 验证输入是否为空或无效
                if (!string.IsNullOrEmpty(invCode))
                {
                    // 调用数据库查询方法
                    Inventory inventory = QueryDatabaseForInventory(invCode, cmbAccountNo.Text);

                    // 如果查询成功，则填充其他单元格
                    if (inventory != null)
                    {
                        dgvDetail.Rows[currentCell.RowIndex].Cells["cInvCode"].Value = inventory.cInvCode;
                        dgvDetail.Rows[currentCell.RowIndex].Cells["cInvName"].Value = inventory.cInvName;
                        dgvDetail.Rows[currentCell.RowIndex].Cells["cInvStd"].Value = inventory.cInvStd is null ? "" : inventory.cInvStd;
                                                          
                                           
                            FocusCell(currentCell.RowIndex, "unitCost");

                                              

                    }

                    else
                    {
                        MessageBox.Show("未找到匹配的存货信息");

                        return;
                    }   
                }
                else
                {
                    MessageBox.Show("请输入存货编码");

                    return;
                }


            }
        }

        /// <summary>
        /// input manually
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GetInventoryManually();
        }

        /// <summary>
        /// display the refered button from actived cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBody_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                try
                {
                    Rectangle rect = this.dgvDetail.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    btnRef.Size = new Size(rect.Height - 4, rect.Height - 4);


                    btnRef.Location = new Point(rect.Location.X + rect.Width - 25, rect.Location.Y + 2);

                    btnRef.Parent = dgvDetail;
                    btnRef.Visible = true;


                }
                catch (Exception) { }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            #region delete empty row

            // 创建一个列表来存储需要删除的空白行索引
            List<int> rowsToDelete = new List<int>();

            // 遍历 DataGridView 中的所有行
            for (int i = dgvDetail.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvDetail.Rows[i];

                // 检查当前行是否为空
                if (IsRowEmpty(row))
                {
                    // 添加到删除列表
                    rowsToDelete.Add(i);
                }
            }

            // 删除空白行
            foreach (int rowIndex in rowsToDelete)
            {
                dgvDetail.Rows.RemoveAt(rowIndex);
            }

            #endregion

            #region validation
            // 检查 DataGridView 是否为空
            if (dgvDetail.Rows.Count == 0)
            {
                MessageBox.Show("表体数据不能为空", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 检查所有文本框和组合框是否为空
            if (!CheckTextBoxesAndComboBoxes())
            {
                MessageBox.Show("表头数据不能为空", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // add list from cinvcode column of dgvDetail
            List<string> cinvCodeList = new List<string>();
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                cinvCodeList.Add(row.Cells["cInvCode"].Value.ToString());
            }

            //check duplicate from datagridview
            foreach (string cinvCode in cinvCodeList)
            {
                if (cinvCodeList.Count(x => x == cinvCode) > 1)
                {
                    MessageBox.Show($"存货 '{cinvCode}'在表体行中重复", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //check duplicate from database
                if (CheckDuplicate(cmbYear.Text, cmbMonth.Text, cmbAccountNo.Text, cinvCode))
                {


                    // 如果存在，则显示错误消息

                    MessageBox.Show($"存货 '{cinvCode}'的单位成本 在 {cmbAccountNo.Text}账套的{cmbYear.Text} - {cmbMonth.Text}会计期间" +
                        $"已经存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

            }



            #endregion

            List<UnitProductionCost> list = new List<UnitProductionCost>();
            SaveService saveService = new SaveService();
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                UnitProductionCost unitProductionCost = new UnitProductionCost();
                unitProductionCost.cInvCode = row.Cells["cInvCode"].Value.ToString();
                unitProductionCost.cInvName = row.Cells["cInvName"].Value.ToString();
                unitProductionCost.cInvStd = row.Cells["cInvStd"].Value.ToString();
                unitProductionCost.UnitCost = Convert.ToDecimal(row.Cells["unitCost"].Value);
                unitProductionCost.iYear = Convert.ToInt32(cmbYear.Text);
                unitProductionCost.cMonth = cmbMonth.Text;
                unitProductionCost.AccountNo = cmbAccountNo.Text;

                list.Add(unitProductionCost);


            }
            this.Cursor = Cursors.WaitCursor;
            saveService.SaveRows<UnitProductionCost, DataMaintenanceContext>(list);
            tsbSave.Enabled = false;
            tsbDeleteRow.Enabled = false;
            tsbAddRow.Enabled = false;

            tsbDelete.Enabled = false;

            cmbAccountNo.Enabled = false;
            cmbYear.Enabled = false;
            cmbMonth.Enabled = false;


            this.Cursor = Cursors.Default;

        }

        void InputInvntoryItem(Inventory m)
        {

            dgvDetail.CurrentRow.Cells["cInvCode"].Value = m.cInvCode;
            dgvDetail.CurrentRow.Cells["cInvName"].Value = m.cInvName;
            dgvDetail.CurrentRow.Cells["cInvStd"].Value = m.cInvStd;
            //repalace the value of cell inputed in advance
            dgvDetail.RefreshEdit();
            
        }

        #endregion


        #region query 

        private void tsbFirst_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT uc.*
            FROM UnitProductionCost uc
            JOIN (
                SELECT MIN(iYear) AS MinYear, MIN(cMonth) AS MinMonth
                FROM UnitProductionCost
            ) subquery
            ON uc.iYear = subquery.MinYear AND uc.cMonth = subquery.MinMonth 
            where AccountNo=@AccountNo";
            QueryVoucher(sql);

        }


        private void tsbLast_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT uc.*
            FROM UnitProductionCost uc
            JOIN (
                SELECT max(iYear) AS MinYear, max(cMonth) AS MinMonth
                FROM UnitProductionCost
            ) subquery
            ON uc.iYear = subquery.MinYear AND uc.cMonth = subquery.MinMonth 
			where AccountNo=@AccountNo";
                QueryVoucher(sql);

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void tsbPrevious_Click(object sender, EventArgs e)
        {

            // 获取当前年份
            int currentYear = int.Parse(cmbYear.Text);


            // 计算上一个记录的年份和月份
            int previousMonth = int.Parse(cmbMonth.Text) - 1;

            int previousYear = currentYear;


            if (previousMonth == 0)
            {
                previousMonth = 12;


                previousYear--;

            }
            cmbMonth.Text = previousMonth.ToString();
            cmbYear.Text = previousYear.ToString();

            string sql = @"select  * 
                     from UnitProductionCost
                    where AccountNo=@AccountNo and iYear=@iYear and cMonth=@cMonth ";
            SqlParameter[] sqlParameters = { new SqlParameter("@AccountNo", cmbAccountNo.Text),
                new SqlParameter("@iYear", previousYear),
                new SqlParameter("@cMonth", previousMonth) };
            QueryVoucher(sql, sqlParameters);

        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            // 获取当前年份
            int currentYear = int.Parse(cmbYear.Text);

            // 计算下一个记录的年份和月份
            int nextMonth = int.Parse(cmbMonth.Text) + 1;
            int nextYear = currentYear;

            if (nextMonth == 13)
            {
                nextMonth = 1;
                nextYear++;
            }
            cmbMonth.Text = nextMonth.ToString();
            cmbYear.Text = nextYear.ToString();
            string sql = @"select  * 
                     from UnitProductionCost
                    where AccountNo=@AccountNo and iYear=@iYear and cMonth=@cMonth ";
            SqlParameter[] sqlParameters = { new SqlParameter("@AccountNo", cmbAccountNo.Text),
                new SqlParameter("@iYear", nextYear),
                new SqlParameter("@cMonth", nextMonth) };
            QueryVoucher(sql, sqlParameters);

        }

        /// <summary>
        /// get data triggered by query button inner class or outside class
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        public void QueryVoucher(string sql, SqlParameter[] parameters = null)
        {
            tsbAddRow.Enabled = false;
            tsbDeleteRow.Enabled = false;
            tsbSave.Enabled = false;

            cmbAccountNo.Enabled = false;
            cmbYear.Enabled = false;
            cmbMonth.Enabled = false;

            dgvDetail.DataSource = null;
            dgvDetail.Rows.Clear();
            //disable edit feature of datagridview
            dgvDetail.ReadOnly = true;
            SqlDataReader sqlDataReader;
            if (parameters != null)
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql, parameters, Sqlhelper.DataSourceType.business);
            }
            else
            {
                SqlParameter[] sqlParameters = { new SqlParameter("@AccountNo", cmbAccountNo.Text) };


                sqlDataReader = Sqlhelper.GetSqlDataReader(sql, sqlParameters, Sqlhelper.DataSourceType.business);


            }


            List<UnitProductionCost> list = new List<UnitProductionCost>();

            //fetch the first batch record with same year and month and accountNo
            while (sqlDataReader.Read())
            {


                UnitProductionCost m = new UnitProductionCost();
                cmbYear.Text = sqlDataReader["iYear"].ToString();
                cmbMonth.Text = sqlDataReader["cMonth"].ToString();
                cmbAccountNo.Text = sqlDataReader["AccountNo"].ToString();
                m.cInvCode = sqlDataReader["cInvCode"].ToString();
                m.cInvName = sqlDataReader["cInvName"].ToString();
                m.cInvStd = sqlDataReader["cInvStd"].ToString();
                m.UnitCost = Convert.ToDecimal(sqlDataReader["UnitCost"]);
                list.Add(m);

            }

            sqlDataReader.Close();
            dgvDetail.DataSource = list;
        }
        #endregion


        #region delete

        private void tsbDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delete record with same year and month and accountNo from database
                using (DataMaintenanceContext db = new DataMaintenanceContext())
                {
                    this.Cursor = Cursors.WaitCursor;
                    var y = Convert.ToInt32(cmbYear.Text);
                    var query = from u in db.UnitProductionCost
                                where u.iYear == y && u.cMonth == cmbMonth.Text && u.AccountNo == cmbAccountNo.Text
                                select u;

                    db.UnitProductionCost.RemoveRange(query);
                    db.SaveChanges();
                    MessageBox.Show("Record deleted successfully!");
                    dgvDetail.DataSource = null;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbUpdate.Enabled = false;

                    //clear the data of header
                    cmbYear.Text = "";
                    cmbMonth.Text = "";
                    cmbAccountNo.Text = "";
                    this.Cursor = Cursors.Default;

                }
            }


        }

        #endregion

        /// <summary>
        /// input inventory item by manual
        /// </summary>
        /// <param name="invCode"></param>
        /// <returns></returns>
        private Inventory QueryDatabaseForInventory(string invCode, String u8AccountNo)
        {
            // 假设这里是你的数据库查询逻辑
            // 使用实际的数据库查询代码替换下面的示例
            Inventory m = new Inventory();
            SqlParameter[] sqlParameters = { new SqlParameter("@cInvCode", invCode) };

            // 调用查询服务
            var item = QueryService.GetItemFromSingleTable<Inventory>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8, u8AccountNo);

            return item;
        }


        #endregion


        #region validate 
        // 检查行是否为空的方法
        private bool IsRowEmpty(DataGridViewRow row)
        {
            // 检查所有列是否为空或空白
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        // 检查所有文本框和组合框是否为空
        private bool CheckTextBoxesAndComboBoxes()
        {
            // 假设你有多个文本框和组合框
            if (string.IsNullOrWhiteSpace(cmbYear.Text) ||
                string.IsNullOrWhiteSpace(cmbMonth.Text) ||
                string.IsNullOrWhiteSpace(cmbAccountNo.Text))
            {
                return false;
            }



            return true;
        }

        //check identity  in database with year and month and accountNo and invcode before save
        private bool CheckDuplicate(string year, string month, string accountNo, string invCode)
        {
            using (DataMaintenanceContext db = new DataMaintenanceContext())
            {
                var y = Convert.ToInt32(year);
                var query = from u in db.UnitProductionCost
                            where u.iYear == y && u.cMonth == month && u.AccountNo == accountNo && u.cInvCode == invCode
                            select u;

                return query.Any();
            }

        }


        #endregion

        #region UI logic

        private void FocusCell(int rowIndex, string columnName)
        {
            // 获取当前选中的行
            DataGridViewRow currentRow = dgvDetail.Rows[rowIndex];

            // 设置焦点到 "unitCost" 列所在的单元格
            DataGridViewCell unitCostCell = currentRow.Cells[columnName];
            if (columnName == "unitCost")
            {
                dgvDetail.CurrentCell = unitCostCell;
                dgvDetail.BeginEdit(true); // 开始编辑该单元格
            }
            else if (columnName == "cInvCode")
            {
                dgvDetail.Rows.Add();
                // 设置焦点到 "cinvcode" 列所在的单元格
                DataGridViewCell invCodeCell = dgvDetail.Rows[rowIndex + 1].Cells[columnName];

                dgvDetail.CurrentCell = invCodeCell;
                dgvDetail.BeginEdit(true); // 开始编辑该单元格


            }
        }

        private void dgvDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dgvDetail, false);
        }


        private void tsbAddRow_Click(object sender, EventArgs e)
        {
            dgvDetail.Rows.Add();
        }

        /// <summary>
        /// delete row selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDeleteRow_Click(object sender, EventArgs e)
        {
            //delete row selected
            dgvDetail.Rows.RemoveAt(dgvDetail.CurrentRow.Index);
        }


        #endregion


        private void tsbUpdateU8Cost_Click(object sender, EventArgs e)
        {

            //check closed flag of ST module of U8 
            if (CheckSTModuleClosed())
            {
                MessageBox.Show($"U8的【库存成本】模块{cmbYear.Text}-{cmbMonth.Text}期间已经结账，不能更新单价！");
                return;
            }
            //check input of cmbCostType
            if (cmbCostType.SelectedIndex == -1)
            {
                MessageBox.Show("请选择成本类型!");
                return;
            }

            //update record with defferent costType of cmbCostType
            switch (cmbCostType.SelectedItem.ToString())
            {
                case "生产单位成本":
                    if (DialogResult.OK == MessageBox.Show($"你确认要修改{cmbAccountNo.Text}账套{cmbYear.Text}年{cmbMonth.Text}月的【生产单位成本吗？】", "更新确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    {
                        UpdateCostRecored(1); break;
                    }
                    else
                    {
                        return;
                    }

                case "销售单位成本":
                    if (DialogResult.OK == MessageBox.Show($"你确认要修改{cmbAccountNo.Text}账套{cmbYear.Text}年{cmbMonth.Text}月的【销售单位成本吗？】", "更新确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    {
                        UpdateCostRecored(2); break;
                    }
                    else
                    {
                        return;
                    }


            }

        }

        private void UpdateCostRecored(int costType)
        {

            if (dgvDetail.Rows.Count == 0 || tsbSave.Enabled == true)
            {
                MessageBox.Show("请先输入明细数据!");
                return;
            }

            var firstDay = GetFirstDayOfMonth(Int32.Parse(cmbYear.Text), Int32.Parse(cmbMonth.Text));
            var lastDay = GetLastDayOfMonth(Int32.Parse(cmbYear.Text), Int32.Parse(cmbMonth.Text));
            //generate sql statement
            SqlParameter[] sqlParameters = {
                                               new SqlParameter("@endDate", lastDay),
                        new SqlParameter("@startDate", firstDay)
                    };

            Decimal dUntiCost;
            String invCode;
            StringBuilder stringbuilder = new StringBuilder();

            #region update product unit cost

            if (costType == 1)

            {
                this.Cursor = Cursors.WaitCursor;
                foreach (DataGridViewRow item in dgvDetail.Rows)
                {
                    dUntiCost = Convert.ToDecimal(item.Cells["unitCost"].Value);
                    invCode = item.Cells["cInvCode"].Value.ToString();
                    string sql = $"update  rdrecords10 set iUnitCost ={dUntiCost}, iprice ={dUntiCost}  * iQuantity  from  rdrecord10 r10 inner join  rdrecords10 rd10"
                        + $" on r10.id=rd10 .id"

                       + $" where cInvCode='{invCode}' " +
                       $"and dDate between @startDate and @endDate; ";


                    stringbuilder.Append(sql);


                };
                Utility.Sql.Sqlhelper.ExecuteSqlTransaction(stringbuilder.ToString(), sqlParameters, Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);
                stringbuilder.Clear();
                MessageBox.Show("更新成功！", "更新提示");
                this.Cursor = Cursors.Default;

            }

            #endregion

            #region update sales unit cost
            else if (costType == 2)
            {
                using (var db = new DataMaintenance.Model.U8Context(cmbAccountNo.Text))
                {
                    this.Cursor = Cursors.WaitCursor;

                    foreach (DataGridViewRow item in dgvDetail.Rows)
                    {
                        dUntiCost = Convert.ToDecimal(item.Cells["unitCost"].Value);
                        invCode = item.Cells["cInvCode"].Value.ToString();

                        var recordsToUpdate = from rd32 in db.rdrecords32
                                              join r32 in db.rdrecord32
                                              on rd32.ID equals r32.ID
                                              where rd32.cInvCode == invCode && r32.dDate >= firstDay && r32.dDate <= lastDay
                                              select rd32;


                        foreach (var record in recordsToUpdate.ToList())
                        {
                            record.iUnitCost = dUntiCost;
                            record.iPrice = dUntiCost * (record.iQuantity ?? 0);
                        }
                    }

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("更新成功！", "更新提示");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"更新失败: {ex.Message}", "错误");
                    }
                }


                this.Cursor = Cursors.Default;

            }
            #endregion



        }

        #region get datatime
        private DateTime GetFirstDayOfMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }

        private DateTime GetLastDayOfMonth(int year, int month)
        {
            DateTime firstDayOfNextMonth = new DateTime(year, month, 1).AddMonths(1);
            return firstDayOfNextMonth.AddDays(-1);
        }

        #endregion

        //check closed flag of ST Module in U8
        private bool CheckSTModuleClosed()
        {

            bool? flag = QueryService.GetItemFromSingleTable<GL_mend>(new SqlParameter[] { new SqlParameter(@"iYPeriod", cmbYear.Text + cmbMonth.Text) }, Sqlhelper.DataSourceType.u8, cmbAccountNo.Text).bflag_ST;
            return flag.Value;
        }

    }
}
