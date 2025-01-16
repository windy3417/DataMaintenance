using Datamaintenance.UI.RefForm;
using DataMaintenance.DAL.U8services;
using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.RefForm;
using U8services.DAL.JoinTableServices.ProductInOutService;
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

namespace DataMaintenance.UI.U8.CheckInvetory
{
    public partial class FrmInferStockWithPurSubtractSale : Form
    {
        public FrmInferStockWithPurSubtractSale()

        {
            InitializeComponent();
            xmbtnInventoryClass.RefButton.Click += RefInvClass;
            //set default value of cmbAccountNo
            cmbAccountNo.Text = "018";
            InitialDataSource();


        }

        void InitialDataSource()
        {

            var listWarehouse = Utility.DAL.QueryService.GetListFromSingleTable<Warehouse>
            (Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text);
            cmbWarehouse.DataSource = listWarehouse;
            cmbWarehouse.ValueMember = "cWhCode";

            cmbWarehouse.DisplayMember = "cWhName";
            //display warehouse name and code in combobox text





        }

        private async void tsbInfer_Click(object sender, EventArgs e)
        {

            //clear datagridview
            dgv.Rows.Clear();

            this.Cursor = Cursors.WaitCursor;


            dgv.AllowUserToAddRows = false;
            GetInventoryInformation(xmbtnInventoryClass.Text);
            Task<bool> taskPurchseAmountQty = GetPurchseAmountQty(cmbAccountNo.Text);
            Task<bool> taskCurrentStock = GetComponentStockAsync(cmbAccountNo.Text);
            Task taskMaterialSaleOutAmount = GetMateriaSaleOutAmountAsync(cmbAccountNo.Text);
            Task taskScraptSaleOutAmount = GetScraptSaleOutAmountAsync(cmbAccountNo.Text,cmbWarehouse.SelectedValue.ToString());

            GetBomParentInvCode();
            //Task taskFinishedGoodAmount =   GetFinisedGoodAmountAsync(cmbAccountNo.Text);
            Task SaleOutAmount = GetSaleOutAmountAsync(cmbAccountNo.Text);

            Task taskFinishedGoodStock = GetFinshedGoodStockAsync(cmbAccountNo.Text);


            await Task.WhenAll(taskPurchseAmountQty, taskMaterialSaleOutAmount, taskCurrentStock,taskScraptSaleOutAmount,
             SaleOutAmount, taskFinishedGoodStock);
            CaculateActualConsumedQty();



            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DataGridViewColumnHeaderStyle(dgv);
            this.Cursor = Cursors.Default;
            MessageBox.Show("计算完成");

        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DisplayRowNo(e, dgv, false);
        }


        void RefInvClass(object sender, EventArgs e)
        {
            var frm = new FrmRefInvClassTree();

            frm.ActionInvClassDate = (s) =>
            {
                xmbtnInventoryClass.Text = s.cInvCCode;

            };
            frm.ShowDialog();
        }

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
            decimal? _componetOfScraptSaledQty;

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
                _componetOfScraptSaledQty = unitConsumingQty * _scraptSaledQty;


                dgv.Rows[i].Cells[this.componentOfFinishedProductStock.Name].Value = _componentOfFinishedProductStock;
                dgv.Rows[i].Cells[this.componetOfScraptSaledQty.Name].Value = _componetOfScraptSaledQty;
                dgv.Rows[i].Cells[this.componentOfSaledProduct.Name].Value = _componentOfSaledProduct;
                dgv.Rows[i].Cells[this.componenteSaledQty.Name].Value = _componenteSaledQty;

                dgv.Rows[i].Cells[this.inShopQty.Name].Value = purchaseQty - _componentOfSaledProduct - _componenteSaledQty -
                    _componentOfFinishedProductStock - _componetOfScraptSaledQty- _currentQty;
            }
        }

        #region GetData

        private void GetInventoryInformation(string invClassCode)
        {
            List<Inventory> ls = new List<Inventory>();
            using (var db = new U8Context(cmbAccountNo.Text))
            {
                ls = db.Inventory.Where(s => s.cInvCCode.StartsWith(invClassCode)).ToList();
            }
            //add rows to datagridview from the count of ls

            if (ls.Count > 0)
                dgv.Rows.Add(ls.Count);
            else return
                    ;


            for (int i = 0; i < ls.Count; i++)
            {
                dgv.Rows[i].Cells["cInvCode"].Value = ls[i].cInvCode;
                dgv.Rows[i].Cells["cInvName"].Value = ls[i].cInvName;
                dgv.Rows[i].Cells["cInvStd"].Value = ls[i].cInvStd;
            }
        }

        private async Task<Boolean> GetComponentStockAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (var db = new U8Context(accountNo))
                    {
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();
                            dgv.Rows[i].Cells["currentQty"].Value = db.CurrentStock.
                                Where(s => s.cInvCode == invCode).
                                Select(s => s.iQuantity).Sum();
                        }

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
                    using (var db = new U8Context(accountNo))
                    {
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            var invCode = dgv.Rows[i].Cells[this.bomParentInvCode.Name].Value.ToString();
                            dgv.Rows[i].Cells[this.finishedProductStock.Name].Value = db.CurrentStock.
                                Where(s => s.cInvCode == invCode).
                                Select(s => s.iQuantity).Sum();
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            });



        }

        private async Task<Boolean> GetPurchseAmountQty(string accountNo)
        {
            //Func<RdRecord01, bool> funcHeader = d => { return d.dDate <= dtpEnd.Value.Date; };
            //Func<rdrecords01, bool> funcBody = s =>
            //{
            //    return s.cInvCode == dgv.CurrentRow.Cells["cInvCode"].Value.ToString();
            //};

            await Task.Run(() =>
            {

                try
                {

                    DAL.U8services.PruchaseInService rs = new DAL.U8services.PruchaseInService();
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


                        dgv.Rows[i].Cells[this.saledQty.Name].Value =
                           rs.GetSaleOutAmount(dtpEnd.Value, invCode);

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

        private async Task GetScraptSaleOutAmountAsync(string accountNo,string warehouse)
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
                           rs.GetSaleOutAmount(dtpEnd.Value, invCode,warehouse);

                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            });







        }

        private void GetBomParentInvCode()
        {
            string invCode;
            decimal? unitConsumingQty;
            BomService bomService = new BomService();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();
                dgv.Rows[i].Cells["bomParentInvCode"].Value =
                   bomService.GetBomParent(invCode, cmbAccountNo.Text,
                  out unitConsumingQty);
                dgv.Rows[i].Cells["unitConsumingQty"].Value = unitConsumingQty;
            }

        }

        private async Task GetFinisedGoodAmountAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    U8services.DAL.JoinTableServices.FinishedGoodInService rs = new U8services.DAL.JoinTableServices.FinishedGoodInService();
                    string parentInvCode;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        parentInvCode = dgv.Rows[i].Cells["bomParentInvCode"].Value.ToString();


                        dgv.Rows[i].Cells["finishedGoodQty"].Value =
                           rs.GetFinishedGoodAmount(dtpEnd.Value, parentInvCode, accountNo);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            });

        }




        #endregion

        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dgv, this.Text);
        }
    }
}
