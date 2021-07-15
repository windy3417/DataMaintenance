using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMaintenance.Model
{
    [Table("MenuAuthorization")]
   public class MenuAuthorizationModle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Key]
        [Column(Order =1)]
        //[ForeignKey("MenuModle")]
        public int menuID { get; set; }

        [Key][Column(Order =2)]
        //[ForeignKey("UserModle")]
        public string userID { get; set; }

        //public virtual MenuModle menuModle { get; set; }
        //public virtual UserModle userModle { get; set; }

    }
}
