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


        }

        void InitializeControlState()
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DataGridViewColumnHeaderStyle(dgvDetail);

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


        /// <summary>
        /// show the wondows for inputing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRef_Click(object sender, EventArgs e)
        {
            FrmRefInventory f = new FrmRefInventory();
            f.ActionRefIventoryItem = InputInvntoryItem;
            //f.RefInitialize();
            f.ShowDialog();
        }


        #region CRUD



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


        /// <summary>
        /// display the inventory item after put down entery key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.btnRef.Visible = false;

            // 确保只对特定列进行处理


            if (e.ColumnIndex == 0)
            {
                // 获取用户输入的存货编码
                string invCode = dgvDetail.Rows[e.RowIndex].Cells[0].Value?.ToString();

                // 验证输入是否为空或无效
                if (!string.IsNullOrEmpty(invCode))
                {
                    // 调用数据库查询方法
                    Inventory inventory = QueryDatabaseForInventory(invCode);

                    // 如果查询成功，则填充其他单元格
                    if (inventory != null)
                    {
                        dgvDetail.Rows[e.RowIndex].Cells["cInvCode"].Value = inventory.cInvCode;
                        dgvDetail.Rows[e.RowIndex].Cells["cInvName"].Value = inventory.cInvName;
                        dgvDetail.Rows[e.RowIndex].Cells["cInvStd"].Value = inventory.cInvStd;

                        // 获取当前选中的行
                        DataGridViewRow currentRow = dgvDetail.Rows[e.RowIndex];

                        // 设置焦点到 "unitCost" 列所在的单元格
                        DataGridViewCell unitCostCell = currentRow.Cells["unitCost"];
                        if (unitCostCell != null)
                        {
                            dgvDetail.CurrentCell = unitCostCell;
                            dgvDetail.BeginEdit(true); // 开始编辑该单元格
                        }
                        else
                        {
                            // 如果没有找到对应的记录，则提示用户
                            MessageBox.Show("未找到对应的存货信息，请检查输入的编码是否正确。", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // 如果输入为空，则提示用户
                        MessageBox.Show("请输入有效的存货编码。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (e.ColumnIndex == 3)
            {
                dgvDetail.Rows.Add();
                // 设置焦点到 "cinvcode" 列所在的单元格
                DataGridViewCell invCodeCell = dgvDetail.Rows[e.RowIndex + 1].Cells["cInvCode"];
                if (invCodeCell != null)
                {
                    dgvDetail.CurrentCell = invCodeCell;
                    dgvDetail.BeginEdit(true); // 开始编辑该单元格
                }


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

                    saveService.SaveRow<UnitProductionCost, DataMaintenanceContext>(unitProductionCost);
                }

                tsbSave.Enabled = false;
            
        }

        #region query voucher

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

        private void QueryVoucher(string sql)
        {
            dgvDetail.DataSource = null;
            dgvDetail.Rows.Clear();
            //disable edit feature of datagridview
            dgvDetail.ReadOnly = true;


            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("@AccountNo",cmbAccountNo.Text)
            };
            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(
                 sql, sqlParameters, Sqlhelper.DataSourceType.business);

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


        /// <summary>
        /// input inventory item by manual
        /// </summary>
        /// <param name="invCode"></param>
        /// <returns></returns>
        private Inventory QueryDatabaseForInventory(string invCode)
        {
            // 假设这里是你的数据库查询逻辑
            // 使用实际的数据库查询代码替换下面的示例
            Inventory m = new Inventory();
            SqlParameter[] sqlParameters = { new SqlParameter("@cInvCode", invCode) };

            // 调用查询服务
            var item = QueryService.GetItemFromSingleTable<Inventory>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8, "017");

            return item;
        }



        private void tsbDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delete record with same year and month and accountNo from database
                using (DataMaintenanceContext db = new DataMaintenanceContext())
                {
                    var y = Convert.ToInt32(cmbYear.Text);
                    var query = from u in db.UnitProductionCost
                                where u.iYear == y && u.cMonth == cmbMonth.Text && u.AccountNo == cmbAccountNo.Text
                                select u;

                    db.UnitProductionCost.RemoveRange(query);
                }
            }


        }
        #endregion


        void InputInvntoryItem(Inventory m)
        {
            dgvDetail.CurrentRow.Cells["cInvCode"].Value = m.cInvCode;
            dgvDetail.CurrentRow.Cells["cInvName"].Value = m.cInvName;
            dgvDetail.CurrentRow.Cells["cInvStd"].Value = m.cInvStd;

            dgvDetail.EndEdit();


        }


        private void dgvDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dgvDetail, false);
        }


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

            // 如果有更多文本框或组合框，可以继续添加检查
            // 例如：
            // if (string.IsNullOrWhiteSpace(txtSomeTextBox.Text))
            // {
            //     return false;
            // }

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


        private void tsbAdd_Click(object sender, EventArgs e)
        {
            tsbSave.Enabled=true;
            dgvDetail.ReadOnly=false;
            dgvDetail.Rows.Clear();
            dgvDetail.Rows.Add();
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

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            string sql=@"select * 
                    AccountNo,cInvCode,UnitCost from UnitProductionCost
                    where AccountNo@AccountNo and iYear=@iYear and cMonth=@cMonth ";
        }
    }
} 
