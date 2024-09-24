
using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datamaintenance.UI.RefForm
{
    public partial class FrmRefInvClass : Form
    {
        public FrmRefInvClass()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitialContolsData();
        }


      public  Action<InventoryClass> ActionInvClassDate;
        void InitialContolsData()
        {
            using (var db=new U8Context("017"))
            {
                dataGridView1.DataSource = db.InventoryClasse.Where(s =>s.cInvCCode.StartsWith("4")).ToList();
            }
        }

        private void TsbCertain_Click(object sender, EventArgs e)
        {
            InventoryClass m = new InventoryClass();
            m.cInvCCode = dataGridView1.CurrentRow.Cells["cInvCCode"].Value.ToString();
            m.cInvCName= dataGridView1.CurrentRow.Cells["cInvCName"].Value.ToString();
            ActionInvClassDate?.Invoke(m);
            this.Close();
        }
    }
}
