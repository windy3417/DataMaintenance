namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attachfile")]
    public partial class Attachfile
    {
        [Key]
        [Column(Order = 0)]
        public Guid AttachFileGUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string cInvCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string cFileName { get; set; }

        [StringLength(80)]
        public string cTableName { get; set; }
    }
}
