using Datamaintenance.UI.RefForm;
using DataMaintenance.DAL.U8services;
using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.RefForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaintenance.UI.U8.CheckInvetory
{
    public partial class FrmInference : Form
    {
        public FrmInference()
        {
            InitializeComponent();
            xmbtnInventoryClass.RefButton.Click += RefInvClass;
            //InitialDataSource();


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

        private void tsbInfer_Click(object sender, EventArgs e)
        {
           
            //clear datagridview
            dgv.Rows.Clear();
            
            this.Cursor = Cursors.WaitCursor;
          

            dgv.AllowUserToAddRows = false;
            GetInventoryInformation(xmbtnInventoryClass.Text);
            GetPurchseAmountQty();
            GetCurrentStock();
            GetMaterialOutAmount();
            GetBomParentInvCode();
            GetFinisedGoodAmount();
            CaculateActualConsumedQty();
           


            
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.DataGridViewColumnHeaderStyle(dgv);
            this.Cursor = Cursors.Default;

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
            decimal? requestQty;
            decimal? unitConsumingQty;
            decimal? finishedGoodQty;
            decimal? actualConsumedQty;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                 unitConsumingQty = Convert.ToDecimal(dgv.Rows[i].Cells["unitConsumingQty"].Value);
                 finishedGoodQty = Convert.ToDecimal(dgv.Rows[i].Cells["finishedGoodQty"].Value);
                 requestQty = Convert.ToDecimal(dgv.Rows[i].Cells["requestQty"].Value);
                 actualConsumedQty = unitConsumingQty * finishedGoodQty ;
                dgv.Rows[i].Cells["actualConsumedQty"].Value = actualConsumedQty;
                dgv.Rows[i].Cells["inShopQty"].Value =requestQty - actualConsumedQty;
            }
        }

        #region GetData

        private void GetInventoryInformation(string invClassCode)
        {
            List<Inventory> ls = new List<Inventory>();
            using (var db = new U8Context("018"))
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

        private void GetCurrentStock()
        {

            using (var db = new U8Context("018"))
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();
                    dgv.Rows[i].Cells["currentQty"].Value = db.CurrentStock.
                        Where(s => s.cInvCode == invCode).
                        Select(s => s.iQuantity).Sum();
                }
            }

        }

        private void GetPurchseAmountQty()
        {
            Func<RdRecord01, bool> funcHeader = d => { return d.dDate <= dtpEnd.Value.Date; };
            Func<rdrecords01, bool> funcBody = s =>
            {
                return s.cInvCode == dgv.CurrentRow.Cells["cInvCode"].Value.ToString();
            };
            DAL.U8services.PruchaseInService rs = new DAL.U8services.PruchaseInService();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();


                dgv.Rows[i].Cells["purchaseQty"].Value =
                   rs.GetPurchseAmountQty(dtpEnd.Value, invCode, "018");
                //rs.GetPurchseAmountQty(funcHeader, funcBody, "018");



            }



        }

        private void GetMaterialOutAmount()
        {
                    
            DAL.U8services.MateriaOutService rs = new DAL.U8services.MateriaOutService();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var invCode = dgv.Rows[i].Cells["cInvCode"].Value.ToString();


                dgv.Rows[i].Cells["requestQty"].Value =
                   rs.GetMateriaOutAmount(dtpEnd.Value, invCode, "018");
                
            }



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
                       bomService.GetBomParent(invCode, "018",
                      out unitConsumingQty);
                    dgv.Rows[i].Cells["unitConsumingQty"].Value = unitConsumingQty;
                }
            
        }

        private void GetFinisedGoodAmount()
        {
            DAL.U8services.FinishedGoodService rs = new DAL.U8services.FinishedGoodService();
            string parentInvCode;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                 parentInvCode = dgv.Rows[i].Cells["bomParentInvCode"].Value.ToString();


                dgv.Rows[i].Cells["finishedGoodQty"].Value =
                   rs.GetFinishedGoodAmount(dtpEnd.Value, parentInvCode, "018");

            }
        }

     

        #endregion


    }
}
