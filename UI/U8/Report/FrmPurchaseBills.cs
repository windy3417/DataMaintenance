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
using U8services.DAL.Purchase;

namespace DataMaintenance.UI.U8.Report
{
    public partial class FrmPurchaseBills : Form
    {
        SqlConnection _sqlConnection;
        private  PurchaseBillRepository _repository;
        private int _currentPage = 1;          // 当前页码
        private const int PageSize = 100;       // 每页显示条数
        private int _totalRecords = 0;         // 总记录数
        private int _totalPages = 0;           // 总页数

        // 保存当前查询条件，用于分页时复用
        private string _currentWhereClause;
        private List<SqlParameter> _currentParameters;
        public FrmPurchaseBills()
        {
            InitializeComponent();

            //set start date to first day of this year
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            cmbAccountNo.SelectedIndex = 1;
            dgvBody.RowHeadersWidth = 60;

            _sqlConnection = Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);
            _repository = new PurchaseBillRepository(_sqlConnection);

            InitPaginationEvents();


           


        }

        private void InitPaginationEvents()
        {
            tsbFirstPage.Click += (s, e) => GoToPage(1);
            tsbPrePage.Click += (s, e) => GoToPage(_currentPage - 1);
            tsbNextPage.Click += (s, e) => GoToPage(_currentPage + 1);
            tsbLastPage.Click += (s, e) => GoToPage(_totalPages);
            tsbGo.Click += (s, e) =>
            {
                if (int.TryParse(txtPageNum.Text, out int page))
                {
                    GoToPage(page);
                }
                else
                {
                    MessageBox.Show("请输入有效的页码");
                }
            };
        }

        /// <summary>
        /// 执行查询并分页显示
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 获取查询条件（根据实际界面控件调整）
            var (whereClause, parameters) = GetQueryConditions();

            // 保存当前查询条件
            _currentWhereClause = whereClause;
            _currentParameters = parameters;

            // 重新开始第一页查询
            _currentPage = 1;
            LoadDataByPage();
        }

        /// <summary>
        /// 按页码加载数据
        /// </summary>
        /// <param name="pageNumber">页码</param>
        private void GoToPage(int pageNumber)
        {
            // 验证页码有效性
            if (pageNumber < 1 || pageNumber > _totalPages)
                return;

            _currentPage = pageNumber;
            LoadDataByPage();
        }

        /// <summary>
        /// 加载指定页的数据
        /// </summary>
        private void LoadDataByPage()
        {
            try
            {
                // 1. 获取总记录数（用于计算总页数）
                _totalRecords = _repository.GetPurchaseBillCount(_currentWhereClause, _currentParameters);
                _totalPages = (int)Math.Ceiling((double)_totalRecords / PageSize);

                // 2. 获取当前页数据
                var bills = _repository.GetPurchaseBillsByPage(
                    _currentWhereClause,
                    _currentParameters,
                    _currentPage,
                    PageSize);

                // 3. 绑定到DataGridView
                dgvBody.DataSource = bills;

                // 4. 更新分页信息
                UpdatePaginationInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载数据失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 更新分页信息显示
        /// </summary>
        private void UpdatePaginationInfo()
        {
            lblPageInfo.Text = $"共 {_totalRecords} 条记录，共 {_totalPages} 页，当前第 {_currentPage} 页";
            txtPageNum.Text = _currentPage.ToString();

            // 控制分页按钮状态
            tsbFirstPage.Enabled = _currentPage > 1;
            tsbPrePage.Enabled = _currentPage > 1;
            tsbNextPage.Enabled = _currentPage < _totalPages;
            tsbLastPage.Enabled = _currentPage < _totalPages;
        }

        /// <summary>
        /// 获取查询条件（根据实际界面控件实现）
        /// </summary>
        private (string whereClause, List<SqlParameter> parameters) GetQueryConditions()
        {
            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            // 示例：按日期范围查询
            if (dtpStartDate.Value != DateTime.MinValue && dtpEndDate.Value != DateTime.MinValue)
            {
                conditions.Add("p.dpbvdate BETWEEN @StartDate AND @EndDate");
                parameters.Add(new SqlParameter("@StartDate", dtpStartDate.Value));
                parameters.Add(new SqlParameter("@EndDate", dtpEndDate.Value));
            }

            // 示例：按供应商查询
            if (!string.IsNullOrEmpty(xmTxtSupplier.Text))
            {
                conditions.Add("p.cVenCode = @SupplierCode");
                parameters.Add(new SqlParameter("@SupplierCode", xmTxtSupplier.Text));
            }

            // 其他查询条件...

            return (conditions.Count > 0 ? string.Join(" AND ", conditions) : null, parameters);
        }

    
        private void tsbQuery_Click(object sender, EventArgs e)
        {

            
            dgvBody.DataSource = _repository.GetPurchaseBillsByDateRange(dtpStartDate.Value, dtpEndDate.Value);
            //display row number in row header
            for (int i = 0; i < dgvBody.Rows.Count; i++)
            {
                dgvBody.Rows[i].HeaderCell.Value = (i + 1).ToString();
                //set the value alignment to center
                dgvBody.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            //export to excel
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dgvBody, this.Name);
        }

        private void cmbAccountNo_SelectedValueChanged(object sender, EventArgs e)
        {
            _sqlConnection = Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);
            _repository = new PurchaseBillRepository(_sqlConnection);
        }
    }
}
