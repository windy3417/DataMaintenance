﻿using DataMaintenance.Model.Maintenance;
using DataMaintenance.Model.U8;
using DataMaintenance.Properties;
using DataMaintenance.UI.Ref;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        //ToolStripButton tsbSaveEdit = new ToolStripButton();
        private bool isDeletingEmptyRow = false; // Flag to track row deletion
        private bool isMouseClick = false; // Flag to track if the edit mode ended due to a mouse click
        private bool isEditing = false;


        // when edit the record , record the initial data
        private List<UnitProductionCost> initialData;
     

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

            //disabal all the button of the toolstrip except the tsbadd

       
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item.Name != "tsbAdd")
                {
                    item.Enabled = false;
                }
            }


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

            //tsbSaveEdit.Text = "保存";
            //tsbSaveEdit.Image = Resources.save;
            //tsbSaveEdit.Visible= false;
            //toolStrip1.Items.Insert(toolStrip1.Items.IndexOf(tsbSave), tsbSaveEdit);


        }


        #region refer other windows
       

      

        #endregion

            

        #region add

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                if (DialogResult.OK== MessageBox.Show("是否保存当前编辑行", "提示", MessageBoxButtons.YesNo))
                {
                   tsbSave.PerformClick();
                    return;
                }  
                else
                {
                    dgvDetail.Rows.Clear();
                    ActiveControlForAdding();
                }
                
            }

            else
            {
                ActiveControlForAdding();
            }

        }

        private void ActiveControlForAdding()
        {
            isEditing = false;

            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;

            tsbSave.Enabled = true;
            tsbSave.Visible = true;
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
        private bool GetInventoryManually()
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

                        return true;            
                        
                                                                                          

                    }

                    else
                    {
                        MessageBox.Show("未找到匹配的存货信息");
                      
                        return false;
                    }   
                }
                else
                {
                    MessageBox.Show("请输入存货编码");
                    
                                  return false;
                 
                }



            }

            return false;
        }

        /// <summary>
        /// input manually
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //avoid triggering this event when deleting empty row or mouse click
            if (this.isDeletingEmptyRow)
            {
                return;
            }
            if (this.isMouseClick)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                if (GetInventoryManually())
                {
                    FocusCell(e.RowIndex, "unitCost");
                    btnRef.Visible = false;
                }

                else
                {
                    dgvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value=null;
                    
                }
               
            }

            else if ( !String.IsNullOrEmpty(dgvDetail.Rows[e.RowIndex].Cells["unitCost"].Value?.ToString()))
            {
                FocusCell(e.RowIndex, "cInvCode");
            }
          
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
            dgvDetail.EndEdit();
            DeleteEmptyRows();

            if (!this.ValidatingBeforeSaving())
            {
                return;
            }

            if (isEditing)
            {
                if (SaveEditing())
                {
                    MessageBox.Show("Record updated successfully!");

                    initialData.Clear();
                    isEditing = false;
                    SetControlsStateAfterSaving();
                }



            }

            else
            {
                if (SaveAdding())
                {
                    SetControlsStateAfterSaving();
                }
            }

           

            this.Cursor = Cursors.Default;

        }

        private void SetControlsStateAfterSaving()
        {

            foreach (ToolStripButton item in toolStrip1.Items)
            {
                item.Enabled = false;
            }
       
            tsbAdd.Enabled=true;
            tsbEdit.Enabled = true;
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;

            cmbAccountNo.Enabled = false;
            cmbYear.Enabled = false;
            cmbMonth.Enabled = false;

            dgvDetail.Enabled = false;
        }

        private bool SaveAdding()
        {
            try
            {
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
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存出错"+ ex.Message+ex.InnerException, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
        }

        private void DeleteEmptyRows()
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
                isDeletingEmptyRow = true; // Set the flag
                this.btnRef.Visible = false;
                dgvDetail.Rows.RemoveAt(rowIndex);

            }

            //restore to the editing staus
            isDeletingEmptyRow = false;

            #endregion
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
            //add 0 character to the month if it is less than 10
            cmbMonth.Text = previousMonth < 10 ? "0" + previousMonth.ToString() : previousMonth.ToString();

           
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
            //enable all the button of toolstrip except the tsbsave button

           SetControlsStatusAfterQuery();

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
                m.Id = Convert.ToInt32(sqlDataReader["ID"]);
                list.Add(m);


            }

            sqlDataReader.Close();

            dgvDetail.DataSource = list;
        }

     

        /// <summary>
        /// get invetory item from u8
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

                    foreach (ToolStripItem item in toolStrip1.Items)
                    {
                        if (item.Name != "tsbAdd")
                        {
                            item.Enabled = false;
                        }
                    }
                    dgvDetail.DataSource = null;
                    dgvDetail.Rows.Clear();
                 

                    //clear the data of header
                    cmbYear.Text = "";
                    cmbMonth.Text = "";
                    cmbAccountNo.Text = "";
                    this.Cursor = Cursors.Default;

                }
            }


        }

        #endregion

  
        #region update


        private void tsbEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            isEditing = true;

            tsbGiveUp.Enabled = true;
            tsbSave.Enabled = true;
            tsbDeleteRow.Enabled = true;
            tsbAddRow.Enabled = true;

            tsbEdit.Enabled = false;
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;


            //tsbSaveEdit.Visible = true;
            //tsbSaveEdit.Enabled = true;


            dgvDetail.ReadOnly = false;
            dgvDetail.Enabled = true;
            //dgvDetail.AllowUserToAddRows = true;
            dgvDetail.AllowUserToDeleteRows = true;
            dgvDetail.AllowUserToOrderColumns = true;
            dgvDetail.AllowUserToResizeColumns = true;
            dgvDetail.AllowUserToResizeRows = true;




            var y = Convert.ToInt32(cmbYear.Text);
            using (DataMaintenanceContext db = new DataMaintenanceContext())
            {
                var query = from u in db.UnitProductionCost
                            where u.iYear == y && u.cMonth == cmbMonth.Text && u.AccountNo == cmbAccountNo.Text
                            select u;
                this.initialData = query.ToList();
            }

          
            InputFromInitialData();

            this.Cursor = Cursors.Default;


        }

        private void InputFromInitialData()
        {
            dgvDetail.DataSource = null;
            //delete all rows of data grid view
            dgvDetail.Rows.Clear();
            dgvDetail.Refresh();
            dgvDetail.Rows.Add(initialData.Count);

            //set each column value from intialData without binding data source

            for (int i = 0; i < initialData.Count; i++)
            {
                dgvDetail.Rows[i].Cells["cInvcode"].Value = this.initialData[i].cInvCode;
                dgvDetail.Rows[i].Cells["cInvName"].Value = this.initialData[i].cInvName;
                dgvDetail.Rows[i].Cells["UnitCost"].Value = this.initialData[i].UnitCost;
                dgvDetail.Rows[i].Cells["cInvStd"].Value = this.initialData[i].cInvStd;
                dgvDetail.Rows[i].Cells["unitCost"].Value = this.initialData[i].UnitCost;

                dgvDetail.Rows[i].Cells["ID"].Value = this.initialData[i].Id;

            }
        }

        private bool SaveEditing()
        
        {
            //add new record to database and update the current record edited in the datagridview to database and delete the record deleted in datagridview from database

            try
            {
                using (DataMaintenanceContext db = new DataMaintenanceContext())
                {
                 
                    List<UnitProductionCost> addList = new List<UnitProductionCost>();
                    List<UnitProductionCost> updateList = new List<UnitProductionCost>();
                    List<UnitProductionCost> deleteList = new List<UnitProductionCost>();

                    List<UnitProductionCost> dgvlist =GetRowsDateFromDataGridView();

                    //the list of  datagridview left join initial data to get the list of records to be added


                    addList = dgvlist.Except(this.initialData).ToList();

                    //the list of  datagridview right join initial data to get the list of records to be deleted
                    deleteList = this.initialData.Except(dgvlist).ToList();
                    updateList= dgvlist.Intersect(this.initialData).ToList();
                  
                    db.UnitProductionCost.AddRange(addList);
                     foreach (var item in deleteList)
                    {
                        // Attach the entity to the context
                        db.UnitProductionCost.Attach(item);
                        // Mark the entity for deletion
                        db.UnitProductionCost.Remove(item);
                    }

                    foreach (var item in updateList)
                    {
                        // Attach the entity to the context
                        db.UnitProductionCost.Attach(item);
                        // Mark the entity for update
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    return true;



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+ex.InnerException);
                return false;
            }

         
            
        }

        private List<UnitProductionCost> GetRowsDateFromDataGridView()
        {
            List<UnitProductionCost> dgvlist = new List<UnitProductionCost>();
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                UnitProductionCost m = new UnitProductionCost();
                m.Id = Convert.ToInt32(row.Cells["Id"].Value);
                m.cInvCode = row.Cells["cInvCode"].Value.ToString();
                m.cInvName = row.Cells["cInvName"].Value.ToString();
                m.cInvStd = row.Cells["cInvStd"].Value.ToString();
                m.UnitCost = Convert.ToDecimal(row.Cells["UnitCost"].Value);
                m.iYear = Convert.ToInt32(cmbYear.Text);
                m.cMonth = cmbMonth.Text;
                m.AccountNo = cmbAccountNo.Text;
                dgvlist.Add(m);

            }

            return dgvlist;
        }

        private void tsbUpdateU8Cost_Click(object sender, EventArgs e)
        {

            //check closed flag of ST module of U8 
            if (IsSTModuleClosed())
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


        #endregion

        #region valitate

        bool ValidatingBeforeSaving()
        {
            
            // 检查 DataGridView 是否为空
            if (dgvDetail.Rows.Count == 0)
            {
                MessageBox.Show("表体数据不能为空", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 检查所有文本框和组合框是否为空
            else if (!CheckTextBoxesAndComboBoxes())
            {
                MessageBox.Show("表头数据不能为空", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {

                // add list from cinvcode column of dgvDetail
                Dictionary < string, string>  keyValuePairs = new Dictionary<string, string>();

                List<string> cinvCodeList = new List<string>();
                foreach (DataGridViewRow row in dgvDetail.Rows)
                {
                   
                    keyValuePairs.Add(row.Cells["cInvCode"].Value.ToString(), row.Cells["ID"].Value is null ? "" : row.Cells["ID"].Value.ToString());
                }

                //check duplicate from datagridview

                foreach (var item in keyValuePairs)
                {
                    if (keyValuePairs.Count(x => x.Key == item.Key) > 1)
                    {
                        MessageBox.Show($"存货 '{cinvCode}'在表体行中重复", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                    //check duplicate from database
                    //if the ID is empty, it is new record

                    if (String.IsNullOrEmpty(item.Value))
                    {
                        if (CheckDuplicate(cmbYear.Text, cmbMonth.Text, cmbAccountNo.Text, item.Key))
                        {


                            // 如果存在，则显示错误消息

                            MessageBox.Show($"存货 '{cinvCode}'的单位成本 在 {cmbAccountNo.Text}账套的{cmbYear.Text} - {cmbMonth.Text}会计期间" +
                                $"已经存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                        }

                    }

                }

                return true;

            }




        }
        // 检查行是否为空的方法
        private bool IsRowEmpty(DataGridViewRow row)
        {

            // 检查所有列是否为空或空白
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.ColumnIndex!=4)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        return true;
                    }
                }
              
            }
            return false;
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

        #region exclusive relationship between toolstrip buttons

        private void SetControlsStatusAfterQuery()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
               
                    item.Enabled = true;
                
            }
            tsbSave.Enabled = false;
            tsbAddRow.Enabled = false;
            tsbDeleteRow.Enabled = false;
            tsbGiveUp.Enabled = false;
        }
        #endregion


        #region UI operation

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

                //if there erroor pops up, focus currenter cell

              
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
            try
            {
                btnRef.Visible = false;
                dgvDetail.Rows.RemoveAt(dgvDetail.CurrentRow.Index);
            }
            catch (Exception)
            {
                MessageBox.Show("此行不能被删除");
                
            }
           
        }


        #endregion


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
        private bool IsSTModuleClosed()
        {

            bool? flag = QueryService.GetItemFromSingleTable<GL_mend>(new SqlParameter[] { new SqlParameter(@"iYPeriod", cmbYear.Text + cmbMonth.Text) },
                Sqlhelper.DataSourceType.u8, cmbAccountNo.Text).bflag_ST;
            return flag.Value;
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            isMouseClick = false;
        }

        private void dgvDetail_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right) return; 
            else if (dgvDetail.CurrentCell.ColumnIndex == 0)
            {   
                isMouseClick=false;
                return;
            }
            isMouseClick = true;
        }

        private void tsbGiveUp_Click(object sender, EventArgs e)
        {
            try
            {
                InputFromInitialData();
                initialData.Clear();
                btnRef.Visible = false;
                SetControlsStatusAfterQuery();
              
            }
            catch (Exception)
            {

                MessageBox.Show("放弃出错");
            } 
          
        }
    }
}
