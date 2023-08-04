using DataMaintenance.DAL.TableServices.U8services;
using DataMaintenance.Model.U8;
using DataMaintenance.UI.Ref;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaintenance.UI.U8
{
    public partial class FrmBoxIdDeliveryQuery : Form
    {
        public FrmBoxIdDeliveryQuery()
        {
            InitializeComponent();
            InitialCotrolsData();
        }

       void InitialCotrolsData()
        {
            txtInvcode.RefButton.Click += RefInventory;
            txtCustomerCode.RefButton.Click += RefCustomer;
        }

        private void RefCustomer(object sender, EventArgs e)
        {
            FrmRefCustomer f = new FrmRefCustomer();
            f.ActionRefCustomerCode = s => txtCustomerCode.Text = s;
            f.Show();
        }

        private void RefInventory(object sender, EventArgs e)
        {
            FrmRefInventory f = new FrmRefInventory();
            f.ActionRefInventoryCode = s => txtInvcode.Text = s;
            f.Show();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            //filter
            Func<rdrecord32, bool> funcHeader = d =>
            {
                bool result = true;
                if (txtCustomerCode.Text != "")
                {
                    result &= d.cCusCode == txtCustomerCode.Text;
                }

                //if (txtInvcode.Text != "")
                //{
                //    result &= d.PickUpHeaderId == txtDeclareNo.Text;
                //}

                if (dtpStartDate.Value != null & dtpEndDate.Value != null)
                {
                    result &= d.dDate >= dtpStartDate.Value & d.dDate <= dtpEndDate.Value;
                }

                return result;
            };

            Rdrecord32Service s = new Rdrecord32Service();

            DataTable dt = s.GetRdrecord32(funcHeader);

            int sum = dt.AsEnumerable().Sum(a => a.Field<int>("quantity"));
            //decimal sumForeign = dt.AsEnumerable().Sum(a => a.Field<decimal>(amount.DataPropertyName));

            dt.Rows.Add();
            int i = dt.Rows.Count;
            //dt.Rows[i - 1].SetField<string>(performaId.DataPropertyName, "合计");
            dt.Rows[i - 1].SetField<double>(quantity.Name, sum);
            //dt.Rows[i - 1].SetField<decimal>(amount.DataPropertyName, sumForeign);

            dgvReport.DataSource = dt;


            TableStyle();

            Cursor = Cursors.Default;

        }

        private void TableStyle()
        {


            string[] coloums = { quantity.Name };
            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
            style.ThoundSeparate(dgvReport, coloums);
            style.FontBond(dgvReport, coloums);
            style.DataGridViewColumnHeaderStyle(dgvReport);
        }
    }
}
