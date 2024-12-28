namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bom_opcomponentopt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionsId { get; set; }

        public short? Offset { get; set; }

        public byte? WIPType { get; set; }

        public bool? AccuCostFlag { get; set; }

        [StringLength(12)]
        public string DrawDeptCode { get; set; }

        [StringLength(10)]
        public string Whcode { get; set; }

        public bool? OptionalFlag { get; set; }

        public byte? MutexRule { get; set; }

        public decimal? PlanFactor { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ufts { get; set; }

        public bool? CostWIPRel { get; set; }

        public bool? FeatureRel { get; set; }
    }
}
