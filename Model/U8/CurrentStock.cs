namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CurrentStock")]
    public partial class CurrentStock
    {
        [Key]
        [Column(Order = 0)]
        public int AutoID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cWhCode { get; set; }

        [StringLength(60)]
        public string cInvCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string cBatch { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string cVMIVenCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iSoType { get; set; }

        [StringLength(40)]
        public string iSodid { get; set; }

        public decimal? iQuantity { get; set; }

        public decimal? iNum { get; set; }

        [StringLength(20)]
        public string cFree1 { get; set; }

        [StringLength(20)]
        public string cFree2 { get; set; }

        public decimal? fOutQuantity { get; set; }

        public decimal? fOutNum { get; set; }

        public decimal? fInQuantity { get; set; }

        public decimal? fInNum { get; set; }

        [StringLength(20)]
        public string cFree3 { get; set; }

        [StringLength(20)]
        public string cFree4 { get; set; }

        [StringLength(20)]
        public string cFree5 { get; set; }

        [StringLength(20)]
        public string cFree6 { get; set; }

        [StringLength(20)]
        public string cFree7 { get; set; }

        [StringLength(20)]
        public string cFree8 { get; set; }

        [StringLength(20)]
        public string cFree9 { get; set; }

        [StringLength(20)]
        public string cFree10 { get; set; }

        public DateTime? dVDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool bStopFlag { get; set; }

        public decimal? fTransInQuantity { get; set; }

        public DateTime? dMdate { get; set; }

        public decimal? fTransInNum { get; set; }

        public decimal? fTransOutQuantity { get; set; }

        public decimal? fTransOutNum { get; set; }

        public decimal? fPlanQuantity { get; set; }

        public decimal? fPlanNum { get; set; }

        public decimal? fDisableQuantity { get; set; }

        public decimal? fDisableNum { get; set; }

        public decimal? fAvaQuantity { get; set; }

        public decimal? fAvaNum { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] ufts { get; set; }

        public int? iMassDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool BGSPSTOP { get; set; }

        public short? cMassUnit { get; set; }

        public decimal? fStopQuantity { get; set; }

        public decimal? fStopNum { get; set; }

        public DateTime? dLastCheckDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(4)]
        public string cCheckState { get; set; }

        public DateTime? dLastYearCheckDate { get; set; }

        public short? iExpiratDateCalcu { get; set; }

        [StringLength(10)]
        public string cExpirationdate { get; set; }

        public DateTime? dExpirationdate { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ipeqty { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal ipenum { get; set; }
    }
}
