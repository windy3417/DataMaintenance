namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bom_opcomponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bom_opcomponent()
        {
            bom_opcomponentsub = new HashSet<bom_opcomponentsub>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OpComponentId { get; set; }

        public int BomId { get; set; }

        public int SortSeq { get; set; }

        [StringLength(4)]
        public string OpSeq { get; set; }

        public int ComponentId { get; set; }

        public DateTime? EffBegDate { get; set; }

        public DateTime? EffEndDate { get; set; }

        public byte? FVFlag { get; set; }

        public decimal? BaseQtyN { get; set; }

        public decimal? BaseQtyD { get; set; }

        public decimal? CompScrap { get; set; }

        public bool? ByproductFlag { get; set; }

        public int? OptionsId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ufts { get; set; }

        [StringLength(35)]
        public string AuxUnitCode { get; set; }

        public decimal? ChangeRate { get; set; }

        public decimal? AuxBaseQtyN { get; set; }

        public byte? ProductType { get; set; }

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

        [StringLength(255)]
        public string Remark { get; set; }

        public bool? RecursiveFlag { get; set; }

        [StringLength(20)]
        public string Free1 { get; set; }

        [StringLength(20)]
        public string Free2 { get; set; }

        [StringLength(20)]
        public string Free3 { get; set; }

        [StringLength(20)]
        public string Free4 { get; set; }

        [StringLength(20)]
        public string Free5 { get; set; }

        [StringLength(20)]
        public string Free6 { get; set; }

        [StringLength(20)]
        public string Free7 { get; set; }

        [StringLength(20)]
        public string Free8 { get; set; }

        [StringLength(20)]
        public string Free9 { get; set; }

        [StringLength(20)]
        public string Free10 { get; set; }

        public bool? bProcessProduct { get; set; }

        public bool? bProcessMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bom_opcomponentsub> bom_opcomponentsub { get; set; }
    }
}
