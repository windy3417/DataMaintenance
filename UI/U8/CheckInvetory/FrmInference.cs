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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U8service.DAL.JoinTableSvc;

namespace DataMaintenance.UI.U8.CheckInvetory
{
    public partial class FrmInference : Form
    {
        public FrmInference()
        {
            InitializeComponent();
            xmbtnInventoryClass.RefButton.Click += RefInvClass;
            SetDefaultValue();
          


        }

        void InitialDataSource()
        {
            using (var db = new U8Context("018"))
            {
                var listWarehouse = db.Warehouse.ToList();
                cmbWarehouse.DataSource = listWarehouse;
                cmbWarehouse.ValueMember = "cWhCode";

                cmbWarehouse.DisplayMember = "cWhName";

            }
        }

        //set default value of all controls
        void SetDefaultValue()

        {  
            xmbtnInventoryClass.Text="1140";
            //set default value of cmbAccountNo
            cmbAccountNo.Text = "018";

        }

        private async  void tsbInfer_Click(object sender, EventArgs e)
        {
           
            //clear datagridview
            dgv.Rows.Clear();
            
            this.Cursor = Cursors.WaitCursor;
          

            dgv.AllowUserToAddRows = false;
            GetInventoryInformation(xmbtnInventoryClass.Text);
        Task<bool> taskPurchseAmountQty =  GetPurchseAmountQty(cmbAccountNo.Text);
        Task<bool> taskCurrentStock=   GetCurrentStockAsync(cmbAccountNo.Text);
        Task<bool> taskMaterialOutAmount =    GetMaterialOutAmountAsync(cmbAccountNo.Text);
            GetBomParentInvCode();
        Task taskFinishedGoodAmount =   GetFinisedGoodAmountAsync(cmbAccountNo.Text);
          

            await Task.WhenAll(taskPurchseAmountQty,taskCurrentStock, 
                taskMaterialOutAmount,taskFinishedGoodAmount);
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

        #region data handle

        void CaculateActualConsumedQty()
        {
            decimal? requestQty;
            decimal? unitConsumingQty;
            decimal? finishedGoodQty;
            decimal? actualConsumedQty;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                unitConsumingQty = Convert.ToDecimal(dgv.Rows[i].Cells["unitConsumingQty"].Value);
                finishedGoodQty = Convert.ToDecimal(dgv.Rows[i].Cells["finishedGoodQty"].Value);
                requestQty = Convert.ToDecimal(dgv.Rows[i].Cells["requestQty"].Value);
                actualConsumedQty = unitConsumingQty * finishedGoodQty;
                dgv.Rows[i].Cells["actualConsumedQty"].Value = actualConsumedQty;
                dgv.Rows[i].Cells["inShopQty"].Value = requestQty - actualConsumedQty;
            }
        }


        private void tsbExport_Click(object sender, EventArgs e)
        {
            Utility.Excel.ExportExcel exportExcel = new Utility.Excel.ExportExcel();
            exportExcel.ExportExcelWithNPOI(dgv, this.Text);
        }
        #endregion


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


        private void GetBomParentInvCode()
        {
            string invCode;
            //becauce a child component may have many bomParent
            List<string> listParentInvCode;
            StringBuilder sbParentName =new StringBuilder();
            StringBuilder sbParentCode = new StringBuilder();
            List< decimal?> ListUnitConsumingQty;
            BomSvc bomService = new BomSvc(cmbAccountNo.Text);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();

              listParentInvCode  = bomService.GetBomParent(invCode,
                  out ListUnitConsumingQty);

                if (listParentInvCode.Count() > 0)
                {
                    for (int j = 0; j < listParentInvCode.Count; j++)
                    {
                        string parentName;
                        parentName = Utility.DAL.QueryService.GetItemFromSingleTable<Inventory>(new SqlParameter[] { new SqlParameter(@"cInvcode", listParentInvCode[j]) },
                       Utility.Sql.Sqlhelper.DataSourceType.u8, cmbAccountNo.Text).cInvName;
                        sbParentName.Append(parentName);

                        if (j>=1 & j<listParentInvCode.Count-1)
                        {
                            sbParentName.Append(",");
                        }

                    }
                        
                    
               
                    dgv.Rows[i].Cells["parentName"].Value = parentName;
                }

                for (int k = 0; k < listParentInvCode.Count; k++)
                {
                    sbParentCode.Append(listParentInvCode[k]);
                    if (k >= 1 & k < listParentInvCode.Count - 1)
                    {
                        sbParentCode.Append(",");
                    }
                }
                dgv.Rows[i].Cells["bomParentInvCode"].Value=sbParentCode;
                dgv.Rows[i].Cells["unitConsumingQty"].Value = ListUnitConsumingQty.Sum();
            

            }

        }

        private async  Task<Boolean> GetCurrentStockAsync(string accountNo)
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

        private async Task<Boolean> GetPurchseAmountQty(string accountNo)
        {
            //Func<RdRecord01, bool> funcHeader = d => { return d.dDate <= dtpEnd.Value.Date; };
            //Func<rdrecords01, bool> funcBody = s =>
            //{
            //    return s.cInvCode == dgv.CurrentRow.Cells["cInvCode"].Value.ToString();
            //};

            await Task.Run(() => {

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

        private  async Task<Boolean> GetMaterialOutAmountAsync(string accountNo)
        {
            await Task.Run(() =>
            {
               try
               {
                    DAL.U8services.MateriaOutService rs = new DAL.U8services.MateriaOutService();
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();


                        dgv.Rows[i].Cells["requestQty"].Value =
                           rs.GetMateriaOutAmount(dtpEnd.Value, invCode, accountNo);

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


        private  async Task GetFinisedGoodAmountAsync(string accountNo)
        {
            await Task.Run(() =>
            {
                try
                {
                    DAL.U8services.FinishedGoodService rs = new DAL.U8services.FinishedGoodService();
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

    }
}
