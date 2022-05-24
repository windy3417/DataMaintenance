using DataMaintenance.Model.IT;
using DataMaintenance.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataMaintenance.UI
{
    public partial class FrmImport : Form
    {

        public FrmImport()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
        }

        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        #region 变量
        //保存前数据存储
        DataTable dataTable = new DataTable();

        #endregion

        private void TsbImport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ImportFromExcel importFromExcel = new Utility.Excel.ImportFromExcel();
          
            importFromExcel.ReadExcelWithNPOI(DgvImport, this.dataTable);

        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
          try  {
                var itdb = new ItContext();
                int maxID = 1000000;
                //待变更实体的最大PK值
                var maxIDloader = itdb.MaxKeys.Where(s => s.VoucherName == "外发需返资产登记表").FirstOrDefault();

                maxID = maxIDloader.CurrentKeyValue;
                using (var db = new U8Context())
                {
                    //外键PK
                    var fpkLoader = db.U8CUSTDEF_0058_E001.Select(s => s.U8CUSTDEF_0058_E001_PK).Max();
                    var exitData = db.U8CUSTDEF_0058_E002.Where(s => s.U8CUSTDEF_0058_E001_PK == fpkLoader).Count();

                    if (exitData>0)
                    {
                        MessageBox.Show("ERP系统单据已经存在数据，请在ERP系统中填制无表体数据的单据再导入数据！");
                        return;
                    }

                    for (int i = 0; i < DgvImport.Rows.Count - 1; i++)
                    {
                        U8CUSTDEF_0058_E002 m = new U8CUSTDEF_0058_E002();

                        m.U8CUSTDEF_0058_E002_F001 = DgvImport.Rows[i].Cells[0].Value.ToString();
                        m.U8CUSTDEF_0058_E002_F002 = Convert.ToDecimal(DgvImport.Rows[i].Cells[2].Value);
                        //m.U8CUSTDEF_0058_E002_F003 = Convert.ToDecimal(DgvImport.Rows[i].Cells[3].Value);
                        //m.U8CUSTDEF_0058_E002_F004 = Convert.ToDecimal(DgvImport.Rows[i].Cells[4].Value);

                        m.U8CUSTDEF_0058_E001_PK = fpkLoader;
                        m.UAPRuntime_RowNO = i + 1;

                        m.U8CUSTDEF_0058_E002_PK = maxID + i + 1;

                        db.U8CUSTDEF_0058_E002.Add(m);

                        maxIDloader.CurrentKeyValue = maxID + i+1;
                    }

                    db.SaveChanges();
                    itdb.SaveChanges();
                    MessageBox.Show("数据保存成功");


                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        private void tsbImportTemplate_Click(object sender, EventArgs e)
        {
           
            string myUrl = Environment.CurrentDirectory + "\\" + "resources\\template\\外发需返资产清单导入模板.xlsx";
            string saveDir;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            //指定存储的路径
            if (result == DialogResult.OK)
            {
                saveDir = fbd.SelectedPath + "\\外发需返资产清单导入模板.xlsx";
                if (File.Exists(myUrl))//必须判断要复制的文件是否存在
                {
                    File.Copy(myUrl, saveDir, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                    MessageBox.Show("文件保存成功", "文件下载提示");
                }
            }





        }
    }
}
