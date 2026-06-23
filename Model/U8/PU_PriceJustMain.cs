namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PU_PriceJustMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PU_PriceJustMain()
        {
            PU_PriceJustDetail = new HashSet<PU_PriceJustDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public DateTime? ddate { get; set; }

        [StringLength(30)]
        public string ccode { get; set; }

        [StringLength(20)]
        public string cmaker { get; set; }

        [StringLength(20)]
        public string cpersoncode { get; set; }

        [StringLength(255)]
        public string cmainmemo { get; set; }

        [StringLength(20)]
        public string cverifier { get; set; }

        public DateTime? dverifydate { get; set; }

        [StringLength(12)]
        public string cdepcode { get; set; }

        public long? ivtid { get; set; }

        [StringLength(20)]
        public string cdefine1 { get; set; }

        [StringLength(20)]
        public string cdefine2 { get; set; }

        [StringLength(20)]
        public string cdefine3 { get; set; }

        public DateTime? cdefine4 { get; set; }

        public int? cdefine5 { get; set; }

        public DateTime? cdefine6 { get; set; }

        public double? cdefine7 { get; set; }

        [StringLength(4)]
        public string cdefine8 { get; set; }

        [StringLength(8)]
        public string cdefine9 { get; set; }

        [StringLength(60)]
        public string cdefine10 { get; set; }

        [StringLength(120)]
        public string cdefine11 { get; set; }

        [StringLength(120)]
        public string cdefine12 { get; set; }

        [StringLength(120)]
        public string cdefine13 { get; set; }

        [StringLength(120)]
        public string cdefine14 { get; set; }

        public int? cdefine15 { get; set; }

        public double? cdefine16 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] ufts { get; set; }

        public int? iverifystate { get; set; }

        public byte? ireturncount { get; set; }

        public bool? iswfcontrolled { get; set; }

        public int? bTaxCost { get; set; }

        public int? iSupplyType { get; set; }

        public DateTime? cMakeTime { get; set; }

        public DateTime? cModifyTime { get; set; }

        public DateTime? cAuditTime { get; set; }

        public DateTime? cModifyDate { get; set; }

        [StringLength(40)]
        public string cReviser { get; set; }

        public int? iPrintCount { get; set; }

        [StringLength(50)]
        public string ccleanver { get; set; }

        [StringLength(60)]
        public string csysbarcode { get; set; }

        [StringLength(200)]
        public string cCurrentAuditor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PU_PriceJustDetail> PU_PriceJustDetail { get; set; }
    }
}
