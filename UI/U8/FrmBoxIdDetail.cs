using DataMaintenance.DAL.ViewServices.U8services;
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
    public partial class FrmBoxIdDetail : Form
    {
        public FrmBoxIdDetail()
        {
            InitializeComponent();
            InitialControlsState();
        }

        void InitialControlsState()
        {
            ddate.DataPropertyName = "ddate";
            voucherId.DataPropertyName = "ccode";
            cInvCode.DataPropertyName = "cinvcode";
            boxId.DataPropertyName = "cdefine31";
            iquantity.DataPropertyName = "iquantity";

            

            dgvDetail.AutoGenerateColumns = false;


        }

        public void GetBoxId(string invCode,DateTime stockInDate)
        {

            DataTable dt = new BoxIDExistService().GetBoxIdExist(invCode,stockInDate);

            #region create datasource for paging


            xmPagingReader1.ColumnsForSum = new string[] { iquantity.DataPropertyName};
          
            xmPagingReader1.PageSize = 10;
            xmPagingReader1.TotalPages = Math.Ceiling(dt.Rows.Count / xmPagingReader1.PageSize);

            xmPagingReader1.DataSource = dt.AsEnumerable();
            xmPagingReader1.TableBody = dgvDetail;

            if (dt.Rows.Count>0)
            {
                var q = xmPagingReader1.GetPagedData(dt.AsEnumerable(), 1).CopyToDataTable();
                dgvDetail.DataSource = q;


                #region add sum row
                decimal sum = q.AsEnumerable().Sum(a => a.Field<decimal>("iquantity"));


                q.Rows.Add();
                int i = q.Rows.Count;



                q.Rows[i - 1].SetField<decimal>("iquantity", sum);

                #endregion

            }




            #endregion



            Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle(dgvDetail);
        }
    }
}
