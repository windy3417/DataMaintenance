namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryClass")]
    public partial class InventoryClass
    {
        [Key]
        [StringLength(12)]
        public string cInvCCode { get; set; }

        [StringLength(100)]
        public string cInvCName { get; set; }

        public byte iInvCGrade { get; set; }

        public bool? bInvCEnd { get; set; }

        [StringLength(2)]
        public string cEcoCode { get; set; }

        [StringLength(30)]
        public string cBarCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }
    }
}
