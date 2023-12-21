using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMaintenance.Model
{   [Table("user")]

   public class UserModle

    {
        [Key]
        public string userID { get; set; }
        public string UserName { get; set; }
        public string pwd { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Nullable<DateTime> DateOfCancellation { get; set; }
        public virtual ICollection<AuthorizationModle> AuthorizoationModles { get; set; }
    }
}
