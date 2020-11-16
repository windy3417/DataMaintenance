using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMaintenance.Modle
{
    [Table("menus")]
    public  class MenuModle
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int menuID { get; set; }
        public string menuName { get; set; }
    }
}
