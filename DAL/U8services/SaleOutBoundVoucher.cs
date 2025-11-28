using DataMaintenance.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Sql;

namespace DataMaintenance.DAL.U8services
{
    public class SaleOutBoundVoucher
    {
        private readonly List<string> productCodes = new List<string>
    {
        "40400006", "40400007"
    };
        private string _accountNo;
        public SaleOutBoundVoucher(string accountNo)
        { this._accountNo = accountNo; }
        public List<MonthlyQuantityViewModel> GetPurchseAmountQty()
        {
            var rawDataList = new List<MonthlyQuantityViewModel>();

            string sqlQuery = @"
                   SELECT
                       ps.cinvcode AS ProductCode,
                       i.cInvName AS ProductName,
                       i.cInvStd AS ProductSpec,
                       CONVERT(VARCHAR(7), p.ddate, 120) AS Month,
                       ps.iQuantity AS Quantity
                   FROM
                       rdrecord32 p
                   INNER JOIN
                       rdrecords32 ps ON p.id = ps.id
                   INNER JOIN
                       inventory i ON ps.cinvcode = i.cinvcode
                   WHERE
                       ps.cinvcode IN (" + string.Join(",", productCodes.Select(c => $"'{c}'")) + @")
                   ORDER BY
                       ProductCode, Month;";

            using (var connection = Sqlhelper.sqlConnection(Sqlhelper.DataSourceType.u8, _accountNo))
            {
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rawDataList.Add(new MonthlyQuantityViewModel
                            {
                                ProductCode = reader["ProductCode"].ToString(),
                                ProductName = reader["ProductName"].ToString(),
                                ProductSpec = reader["ProductSpec"].ToString(),
                                Month = reader["Month"].ToString(),
                                Quantity = Convert.ToDecimal(reader["Quantity"])
                            });
                        }
                    }
                }
            }

            return rawDataList;
        }

        public DataTable GetSaleOutQtyEachMonth()
        {
            // 步骤 1: 从数据库中获取原始数据
            var rawData = GetPurchseAmountQty();
            if (!rawData.Any())
            {
                return null; // 如果没有数据，返回null
            }

            // 步骤 2: 动态创建 DataTable 的列
            var dataTable = new DataTable("InventoryReport");
            dataTable.Columns.Add("存货编码", typeof(string));
            dataTable.Columns.Add("存货名称", typeof(string));
            dataTable.Columns.Add("规格型号", typeof(string));

            var allMonths = rawData.Select(r => r.Month).Distinct().OrderBy(m => m).ToList();
            foreach (var month in allMonths)
            {
                // 为每个月份动态添加一列
                dataTable.Columns.Add(month, typeof(double));
            }

            // 步骤 3: 按产品分组并汇总每月数量
            var groupedData = rawData
                .GroupBy(r => new { r.ProductCode, r.ProductName, r.ProductSpec })
                .ToList();

            foreach (var group in groupedData)
            {
                var newRow = dataTable.NewRow();
                newRow["存货编码"] = group.Key.ProductCode;
                newRow["存货名称"] = group.Key.ProductName;
                newRow["规格型号"] = group.Key.ProductSpec;

                // 按月份汇总数量
                var monthSums = group
                    .GroupBy(x => x.Month)
                    .ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity));

                foreach (var month in allMonths)
                {
                    newRow[month] = monthSums.ContainsKey(month) ? (double)monthSums[month] : 0.0;
                }

                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }
    }
}
