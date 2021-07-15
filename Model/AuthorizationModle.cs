using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMaintenance.Model
{
    [Table("authorization")]
   public class AuthorizationModle
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("UserModle")]
        public string userID { get; set; }
        //授权时间
        public DateTime dateTime { get; set; }
        public virtual UserModle UserModle { get; set; }
    }
}
