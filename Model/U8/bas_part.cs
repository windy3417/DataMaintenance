namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bas_part
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartId { get; set; }

        [Required]
        [StringLength(60)]
        public string InvCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Free1 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free2 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free3 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free4 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free5 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free6 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free7 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free8 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free9 { get; set; }

        [Required]
        [StringLength(20)]
        public string Free10 { get; set; }

        public decimal? SafeQty { get; set; }

        public decimal? MinQty { get; set; }

        public decimal? MulQty { get; set; }

        public decimal? FixQty { get; set; }

        public bool? bVirtual { get; set; }

        [StringLength(60)]
        public string DrawCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ufts { get; set; }

        public int? LLC { get; set; }

        [StringLength(60)]
        public string cBasEngineerFigNo { get; set; }

        public double? fBasMaxSupply { get; set; }

        public short iSurenessType { get; set; }

        public short? iDateType { get; set; }

        public int? iDateSum { get; set; }

        public short? iDynamicSurenessType { get; set; }

        public double? iBestrowSum { get; set; }

        public double? iPercentumSum { get; set; }

        public decimal? RoundingFactor { get; set; }

        public bool? FreeStockFlag { get; set; }

        public bool bFreeStop { get; set; }
    }
}
