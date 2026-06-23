namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PU_PriceJustDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int autoid { get; set; }

        public long? id { get; set; }

        [StringLength(10)]
        public string operationtype { get; set; }

        public long? ipriceid { get; set; }

        [StringLength(20)]
        public string cvencode { get; set; }

        [Required]
        [StringLength(60)]
        public string cinvcode { get; set; }

        [StringLength(20)]
        public string cfree1 { get; set; }

        [StringLength(20)]
        public string cfree2 { get; set; }

        [StringLength(20)]
        public string cfree3 { get; set; }

        [StringLength(20)]
        public string cfree4 { get; set; }

        [StringLength(20)]
        public string cfree5 { get; set; }

        [StringLength(20)]
        public string cfree6 { get; set; }

        [StringLength(20)]
        public string cfree7 { get; set; }

        [StringLength(20)]
        public string cfree8 { get; set; }

        [StringLength(20)]
        public string cfree9 { get; set; }

        [StringLength(20)]
        public string cfree10 { get; set; }

        [StringLength(255)]
        public string cbodymemo { get; set; }

        public DateTime? dstartdate { get; set; }

        public DateTime? denddate { get; set; }

        [StringLength(60)]
        public string cdefine22 { get; set; }

        [StringLength(60)]
        public string cdefine23 { get; set; }

        [StringLength(60)]
        public string cdefine24 { get; set; }

        [StringLength(60)]
        public string cdefine25 { get; set; }

        public double? cdefine26 { get; set; }

        public double? cdefine27 { get; set; }

        [StringLength(120)]
        public string cdefine28 { get; set; }

        [StringLength(120)]
        public string cdefine29 { get; set; }

        [StringLength(120)]
        public string cdefine30 { get; set; }

        [StringLength(120)]
        public string cdefine31 { get; set; }

        [StringLength(120)]
        public string cdefine32 { get; set; }

        [StringLength(120)]
        public string cdefine33 { get; set; }

        public int? cdefine34 { get; set; }

        public int? cdefine35 { get; set; }

        public DateTime? cdefine36 { get; set; }

        public DateTime? cdefine37 { get; set; }

        public int? bsales { get; set; }

        public decimal? fminquantity { get; set; }

        public decimal? iUnitPrice { get; set; }

        public decimal? iTaxRate { get; set; }

        public decimal? iTaxUnitPrice { get; set; }

        [StringLength(8)]
        public string cexch_name { get; set; }

        [StringLength(20)]
        public string cTermCode { get; set; }

        public int? ivouchrowno { get; set; }

        public decimal? ijusttaxprice { get; set; }

        [StringLength(80)]
        public string cbsysbarcode { get; set; }

        public int? bEndPriceList { get; set; }

        public virtual PU_PriceJustMain PU_PriceJustMain { get; set; }
    }
}
