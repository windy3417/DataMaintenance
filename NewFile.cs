private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
{
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

// 查询数据库的方法
private Inventory QueryDatabaseForInventory(string invCode)
{
    // 假设这里是你的数据库查询逻辑
    // 使用实际的数据库查询代码替换下面的示例
    Inventory m = new Inventory();
    SqlParameter[] sqlParameters = { new SqlParameter("@cInvCode", invCode) };

    // 调用查询服务
    var item = QueryService.GetItemFromSingleTable<Inventory>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8);
    
    return item;
}