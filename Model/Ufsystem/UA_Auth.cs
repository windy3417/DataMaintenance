namespace DataMaintenance.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UA_Auth
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string cAuth_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string cAuth_Name { get; set; }

        [StringLength(2)]
        public string cSub_Id { get; set; }

        public short? iGrade { get; set; }

        [StringLength(100)]
        public string cSupAuth_Id { get; set; }

        public bool? bEndGrade { get; set; }

        public int? iOrder { get; set; }

        [StringLength(3)]
        public string cAcc_Id { get; set; }

        [StringLength(10)]
        public string cAuthType { get; set; }

        [StringLength(1024)]
        public string cAllSupAuths { get; set; }
    }
}
