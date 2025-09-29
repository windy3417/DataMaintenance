using Datamaintenance.UI.RefForm;
using DataMaintenance.DAL.U8services;
using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.RefForm;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using U8service.DAL.JoinTableSvc;
using U8service.DAL.JoinTableSvc.ProductLogisticsSvc;
using Utility.Sql;

namespace DataMaintenance.UI.U8.CheckInvetory
{
    public partial class FrmInferStockWithPurSubtractSale : Form
    {
        public FrmInferStockWithPurSubtractSale()

        {
            InitializeComponent();
            xmbtnInventoryClass.RefButton.Click += RefInvClass;
            this.dgv.CellEndEdit += dgv_CellEndEdit;

            //set default value of cmbAccountNo
            cmbAccountNo.Text = "018";
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DataGridViewColumnHeaderStyle(dgv);

            //set the height of header in datagridview as double to a single line
            dgv.ColumnHeadersHeight = 40;


            InitialDataSource();

        }

        // Set the height of the header in DataGridView to a single line


        void InitialDataSource()
        {

            var listWarehouse = Utility.DAL.QueryService.GetListFromSingleTable<Warehouse>
            (Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);
            cmbWarehouse.DataSource = listWarehouse;
            cmbWarehouse.ValueMember = "cWhCode";

            cmbWarehouse.DisplayMember = "cWhName";

            SetDefaultValue();

        }

        //validate ui data
        private bool ValidateUI()
        {
            if (string.IsNullOrEmpty(xmbtnInventoryClass.Text))
            {
                MessageBox.Show("请选择库存分类");
                return false;
            }
            else if (string.IsNullOrEmpty(cmbAccountNo.Text))
            {
                MessageBox.Show("请选择U8账号");
                return false;
            }
            else if (string.IsNullOrEmpty(cmbWarehouse.Text))
            {
                MessageBox.Show("请选择仓库");
                return false;
            }
            else
            {
                return true;
            }

        }

        //set default value of all input data
        void SetDefaultValue()
        {
            xmbtnInventoryClass.Text = "1140";
            //set default value of cmbWarehouse as 自加工不良品仓
            cmbWarehouse.Text = "自加工不良品仓";



        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dgv, false);
        }
        #region data handle


        void CaculateActualConsumedQty()
        {
            decimal? purchaseQty;
            decimal? unitConsumingQty;
            decimal? _currentQty;
            decimal? _saledQty;
            decimal? _finishedProductStock;
            decimal? _scraptSaledQty;

            decimal? _componenteSaledQty;
            decimal? _componentOfSaledProduct;
            decimal? _componentOfFinishedProductStock;
            //decimal? _componetOfScraptSaledQty;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                purchaseQty = Convert.ToDecimal(dgv.Rows[i].Cells[this.purchaseQty.Name].Value);
                unitConsumingQty = Convert.ToDecimal(dgv.Rows[i].Cells["unitConsumingQty"].Value);
                _currentQty = Convert.ToDecimal(dgv.Rows[i].Cells[this.currentQty.Name].Value);

                _scraptSaledQty = Convert.ToDecimal(dgv.Rows[i].Cells[this.scrapSaledQty.Name].Value);
                _finishedProductStock = Convert.ToDecimal(dgv.Rows[i].Cells[this.finishedProductStock.Name].Value);
                _saledQty = Convert.ToDecimal(dgv.Rows[i].Cells[this.saledQty.Name].Value);
                _componenteSaledQty = Convert.ToDecimal(dgv.Rows[i].Cells[this.componenteSaledQty.Name].Value);



                _componentOfSaledProduct = unitConsumingQty * _saledQty;
                _componentOfFinishedProductStock = unitConsumingQty * _finishedProductStock;

                //// if the invcode begin with "11" , the scraptSaledQty is not zero
                //if (dgv.Rows[i].Cells[this.cInvCode.Name].Value.ToString().StartsWith("11"))
                //{
                //    _componetOfScraptSaledQty = unitConsumingQty * _scraptSaledQty;
                //    dgv.Rows[i].Cells[this.componetOfScraptSaledQty.Name].Value = _componetOfScraptSaledQty;
                //}
                //else
                //{
                //    _componetOfScraptSaledQty = 0;
                //    dgv.Rows[i].Cells[this.componetOfScraptSaledQty.Name].Value = _componetOfScraptSaledQty;
                //}





                dgv.Rows[i].Cells[this.componentOfFinishedProductStock.Name].Value = _componentOfFinishedProductStock;

                dgv.Rows[i].Cells[this.componentOfSaledProduct.Name].Value = _componentOfSaledProduct;
                dgv.Rows[i].Cells[this.componenteSaledQty.Name].Value = _componenteSaledQty;

                dgv.Rows[i].Cells[this.qtyInPlant.Name].Value = purchaseQty - _componentOfSaledProduct - _componenteSaledQty - _scraptSaledQty;
                dgv.Rows[i].Cells[this.inShopQty.Name].Value = purchaseQty - _componentOfSaledProduct - _componenteSaledQty - _scraptSaledQty -
                    _componentOfFinishedProductStock - _currentQty;
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dgv, this.Text);
        }

        //set value to qytDifference after inputing into qtyChecked
        private void SetValueToQytDifference(int rowIndex)
        {
            decimal? _qtyChecked = Convert.ToDecimal(dgv.Rows[rowIndex].Cells[this.qtyChecked.Name].Value);
            decimal? _qtyInPlant = Convert.ToDecimal(dgv.Rows[rowIndex].Cells[this.qtyInPlant.Name].Value);

            decimal? _qtyDifference = _qtyChecked - _qtyInPlant;

            dgv.Rows[rowIndex].Cells[this.qtyDifference.Name].Value = _qtyDifference;

            if (_qtyDifference < 0)
            {
                dgv.Rows[rowIndex].Cells[this.qtyDifference.Name].Style.ForeColor = Color.Red;
            }
            else
            {
                dgv.Rows[rowIndex].Cells[this.qtyDifference.Name].Style.ForeColor = Color.Black;
            }
        }

        //bind event of inputing data into qtyChecked
        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.qtyChecked.Index)
            {
                SetValueToQytDifference(e.RowIndex);

            }

        }

        #endregion


        #region GetData

        private async void tsbInfer_Click(object sender, EventArgs e)
        {

            if (!ValidateUI())
            {
                return;
            }
            //clear datagridview
            dgv.Rows.Clear();

            this.Cursor = Cursors.WaitCursor;


            dgv.AllowUserToAddRows = false;

            List<string> invClassCodeList = (xmbtnInventoryClass.Text.Split(new char[] { ',' })).ToList();
            foreach (var item in invClassCodeList)
            {
                GetInventoryInformation(item);
            }

            GetBomParentInvCode();

            Task<bool> taskPurchseAmountQty = GetPurchseAmountQty(cmbAccountNo.Text);
            Task<bool> taskCurrentStock = GetComponentStockAsync(cmbAccountNo.Text);
            Task taskMaterialSaleOutAmount = GetMateriaSaleOutAmountAsync(cmbAccountNo.Text);
            Task taskScraptSaleOutAmount = GetScraptSaleOutAmountAsync(cmbAccountNo.Text, cmbWarehouse.SelectedValue.ToString());



            Task SaleOutAmount = GetSaleOutAmountAsync(cmbAccountNo.Text);


            Task taskFinishedGoodStock = GetFinshedGoodStockAsync(cmbAccountNo.Text);


            await Task.WhenAll(taskPurchseAmountQty, taskMaterialSaleOutAmount, taskCurrentStock, taskScraptSaleOutAmount,
             SaleOutAmount, taskFinishedGoodStock);



            CaculateActualConsumedQty();




            this.Cursor = Cursors.Default;
            MessageBox.Show("计算完成");

        }
        private void GetInventoryInformation(string invClassCode)
        {
            List<Inventory> ls = new List<Inventory>();
            using (var db = new U8Context(cmbAccountNo.Text))
            {
                ls = db.Inventory.Where(s => s.cInvCCode.StartsWith(invClassCode)).ToList();
            }
            //add rows to datagridview from the count of ls

            var currentRows = dgv.Rows.Count;
            if (ls.Count > 0)
                dgv.Rows.Add(ls.Count);
            else return
                    ;


            for (int i = 0; i < ls.Count; i++)
            {
                dgv.Rows[i + currentRows].Cells["cInvCode"].Value = ls[i].cInvCode;
                dgv.Rows[i + currentRows].Cells["cInvName"].Value = ls[i].cInvName;
                dgv.Rows[i + currentRows].Cells["cInvStd"].Value = ls[i].cInvStd;
            }
        }

        private async Task<Boolean> GetPurchseAmountQty(string accountNo)
        {


            await Task.Run(() =>
            {

                try
                {

                    DAL.U8services.PurchaseInService rs = new DAL.U8services.PurchaseInService(accountNo);
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();


                        dgv.Rows[i].Cells["purchaseQty"].Value =
                           rs.GetPurchseAmountQty(dtpEnd.Value, invCode, accountNo);
                        //rs.GetPurchseAmountQty(funcHeader, funcBody, "018");

                    }
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }



            });

            return false;



        }



        private void GetBomParentInvCode()
        {
            string invCode;
            //becauce a child component may have many bomParent

            U8service.DAL.JoinTableSvc.BomSvc bomService = new BomSvc(cmbAccountNo.Text);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {

                List<string> listParentInvCode;
                StringBuilder sbParentName = new StringBuilder();
                StringBuilder sbParentCode = new StringBuilder();
                StringBuilder sbParentStd = new StringBuilder();
                List<decimal?> ListUnitConsumingQty;
                invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();

                listParentInvCode = bomService.GetBomParent(invCode,
                    out ListUnitConsumingQty);

                if (listParentInvCode != null)
                {
                    for (int j = 0; j < listParentInvCode.Count; j++)
                    {
                        string parentName;
                        string parentStd;
                        parentName = Utility.DAL.QueryService.GetItemFromSingleTable<Inventory>(new SqlParameter[] { new SqlParameter(@"cInvcode", listParentInvCode[j]) },
                       Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text).cInvName;
                        parentStd = Utility.DAL.QueryService.GetItemFromSingleTable<Inventory>(new SqlParameter[] { new SqlParameter(@"cInvcode", listParentInvCode[j]) },
                       Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text).cInvStd;


                        if (j >= 1 & j < listParentInvCode.Count)
                        {
                            sbParentName.Append(",");
                            sbParentStd.Append(",");
                        }

                        sbParentName.Append(parentName);
                        sbParentStd.Append(parentStd);

                    }


                    for (int k = 0; k < listParentInvCode.Count; k++)
                    {
                        if (k >= 1 & k < listParentInvCode.Count)
                        {
                            sbParentCode.Append(",");
                        }

                        sbParentCode.Append(listParentInvCode[k]);

                    }
                }


                dgv.Rows[i].Cells["bomParentInvCode"].Value = sbParentCode;
                dgv.Rows[i].Cells["parentName"].Value = sbParentName;
                dgv.Rows[i].Cells["parentStd"].Value = sbParentStd;
                //dgv.Rows[i].Cells["unitConsumingQty"].Value = ListUnitConsumingQty is null ? 0 : ListUnitConsumingQty.Sum();
                dgv.Rows[i].Cells["unitConsumingQty"].Value = ListUnitConsumingQty is null ? 0 : ListUnitConsumingQty.FirstOrDefault();

            }

        }

        private async Task GetSaleOutAmountAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    SaleOutService rs = new SaleOutService(accountNo);
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells[this.bomParentInvCode.Name].Value.ToString();
                        decimal? qtySaleOut = 0;
                        List<string> listParentCode = new List<string>();
                        if (invCode.Contains(","))
                        {
                            //split the invCode according to ","
                            listParentCode = invCode.Split(',').ToList();
                            for (int j = 0; j < listParentCode.Count; j++)
                            {
                                qtySaleOut += rs.GetSaleOutAmount(dtpEnd.Value, listParentCode[j]);

                            }

                            dgv.Rows[i].Cells[this.saledQty.Name].Value = qtySaleOut;

                        }
                        else
                        {
                            dgv.Rows[i].Cells[this.saledQty.Name].Value =
                          rs.GetSaleOutAmount(dtpEnd.Value, invCode);
                        }



                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            });







        }


        private async Task GetMateriaSaleOutAmountAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    SaleOutService rs = new SaleOutService(accountNo);
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells[this.cInvCode.Name].Value.ToString();


                        dgv.Rows[i].Cells[this.componenteSaledQty.Name].Value =
                           rs.GetSaleOutAmount(dtpEnd.Value, invCode);

                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            });







        }


        private async Task GetScraptSaleOutAmountAsync(string accountNo, string warehouse)
        {
            await Task.Run(() =>
            {
                try
                {
                    OtherOutService rs = new OtherOutService(accountNo);
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells[this.cInvCode.Name].Value.ToString();


                        dgv.Rows[i].Cells[this.scrapSaledQty.Name].Value =
                           rs.GetSaleOutAmount(dtpEnd.Value, invCode, warehouse);

                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            });







        }

        private async Task GetProductAsPresentAsync(string accountNo, string warehouse)

        {
            await Task.Run(() =>
            {
                try
                {
                    OtherOutService rs = new OtherOutService(accountNo);
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells[this.cInvCode.Name].Value.ToString();


                        dgv.Rows[i].Cells[this.scrapSaledQty.Name].Value =
                           rs.GetSaleOutAmount(dtpEnd.Value, invCode, warehouse);

                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            });







        }

        private async Task<Boolean> GetComponentStockAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    string conn = Utility.Sql.Sqlhelper.GetConnectionString(Sqlhelper.DataSourceType.u8, accountNo);
                    U8services.DAL.Reporter.RealTimeInventory realTimeInventory = new U8services.DAL.Reporter.RealTimeInventory(conn);

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();
                        //dgv.Rows[i].Cells["currentQty"].Value = db.CurrentStock.
                        //    Where(s => s.cInvCode == invCode).
                        //    Select(s => s.iQuantity).Sum();

                        //get the stock of the component in the specified date
                        dgv.Rows[i].Cells["currentQty"].Value = realTimeInventory.RetrieveStockAtSpecificTime(invCode, dtpEnd.Value);
                    }



                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            });

            return false;

        }
        private async Task GetFinshedGoodStockAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    string conn = Utility.Sql.Sqlhelper.GetConnectionString(Sqlhelper.DataSourceType.u8, accountNo);
                    U8services.DAL.Reporter.RealTimeInventory realTimeInventory = new U8services.DAL.Reporter.RealTimeInventory(conn);
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells[this.bomParentInvCode.Name].Value.ToString();
                        //U8service.DAL.JoinTableSvc.CurrentStockService currentStockService = new CurrentStockService(accountNo);

                        // separte the invCode according to ","
                        if (invCode.Contains(","))
                        {
                            //split the invCode according to ","
                            var listParentCode = invCode.Split(',').ToList();
                            double? qty = 0;
                            for (int j = 0; j < listParentCode.Count; j++)
                            {
                                //qty += currentStockService.GetSingleCurrentStock(listParentCode[j]);
                                qty += realTimeInventory.RetrieveStockAtSpecificTime(listParentCode[j],dtpEnd.Value);
                            }
                            dgv.Rows[i].Cells[this.finishedProductStock.Name].Value = qty;
                        }
                        else
                            dgv.Rows[i].Cells[this.finishedProductStock.Name].Value = realTimeInventory.RetrieveStockAtSpecificTime(invCode, dtpEnd.Value);
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            });



        }


        //private async Task GetFinisedGoodAmountAsync(string accountNo)
        //{
        //    await Task.Run(() =>
        //    {
        //        try
        //        {
        //            U8services.DAL.JoinTableServices.FinishedGoodInService rs = new U8services.DAL.JoinTableServices.FinishedGoodInService();
        //            string parentInvCode;
        //            for (int i = 0; i < dgv.Rows.Count; i++)
        //            {
        //                parentInvCode = dgv.Rows[i].Cells["bomParentInvCode"].Value.ToString();


        //                dgv.Rows[i].Cells["finishedGoodQty"].Value =
        //                   rs.GetFinishedGoodAmount(dtpEnd.Value, parentInvCode, accountNo);

        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //        }


        //    });

        //}




        #endregion

        void RefInvClass(object sender, EventArgs e)
        {
            var frm = new FrmRefInvClassTree();

            frm.ActionInvClassDate = (s) =>
            {
                xmbtnInventoryClass.Text = s.cInvCCode;

            };
            frm.ShowDialog();
        }






    }
}



