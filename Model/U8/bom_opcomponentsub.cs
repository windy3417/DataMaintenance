namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bom_opcomponentsub
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentSubId { get; set; }

        public int OpComponentId { get; set; }

        public int Sequence { get; set; }

        public int PartId { get; set; }

        public decimal? Factor { get; set; }

        public DateTime? EffBegDate { get; set; }

        public DateTime? EffEndDate { get; set; }

        public bool? ReplaceFlag { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ufts { get; set; }

        public int? VTid { get; set; }

        [StringLength(60)]
        public string Define22 { get; set; }

        [StringLength(60)]
        public string Define23 { get; set; }

        [StringLength(60)]
        public string Define24 { get; set; }

        [StringLength(60)]
        public string Define25 { get; set; }

        public double? Define26 { get; set; }

        public double? Define27 { get; set; }

        [StringLength(120)]
        public string Define28 { get; set; }

        [StringLength(120)]
        public string Define29 { get; set; }

        [StringLength(120)]
        public string Define30 { get; set; }

        [StringLength(120)]
        public string Define31 { get; set; }

        [StringLength(120)]
        public string Define32 { get; set; }

        [StringLength(120)]
        public string Define33 { get; set; }

        public int? Define34 { get; set; }

        public int? Define35 { get; set; }

        public DateTime? Define36 { get; set; }

        public DateTime? Define37 { get; set; }

        public virtual bom_opcomponent bom_opcomponent { get; set; }
    }
}
