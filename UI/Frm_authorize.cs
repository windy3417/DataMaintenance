using DataMaintenance.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataMaintenance.UI
{
    public partial class Frm_authorize : Form
    {
        public Frm_authorize()
        {
            InitializeComponent();
            menuList();
            
        }

        private void menuList()
        {
            foreach (var item in new MenuService().getList())
            {
                tv_menu.Nodes.Add(item.menuName);
            }
           

        }
    }
}
