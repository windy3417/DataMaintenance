using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMaintenance.Modle
{   [Table("user")]
   public class UserModle

    {
        [Key]
        public int userID { get; set; }
        public string name { get; set; }
        public virtual ICollection<AuthorizationModle> AuthorizoationModles { get; set; }
    }
}
