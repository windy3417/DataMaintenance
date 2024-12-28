namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RdRecord01
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public byte bRdFlag { get; set; }

        [Required]
        [StringLength(2)]
        public string cVouchType { get; set; }

        [StringLength(12)]
        public string cBusType { get; set; }

        [Required]
        [StringLength(50)]
        public string cSource { get; set; }

        [StringLength(30)]
        public string cBusCode { get; set; }

        [Required]
        [StringLength(10)]
        public string cWhCode { get; set; }

        public DateTime dDate { get; set; }

        [Required]
        [StringLength(30)]
        public string cCode { get; set; }

        [StringLength(5)]
        public string cRdCode { get; set; }

        [StringLength(12)]
        public string cDepCode { get; set; }

        [StringLength(20)]
        public string cPersonCode { get; set; }

        [StringLength(2)]
        public string cPTCode { get; set; }

        [StringLength(2)]
        public string cSTCode { get; set; }

        [StringLength(20)]
        public string cCusCode { get; set; }

        [StringLength(20)]
        public string cVenCode { get; set; }

        [StringLength(30)]
        public string cOrderCode { get; set; }

        [StringLength(30)]
        public string cARVCode { get; set; }

        public long? cBillCode { get; set; }

        public long? cDLCode { get; set; }

        [StringLength(60)]
        public string cProBatch { get; set; }

        [StringLength(20)]
        public string cHandler { get; set; }

        [StringLength(255)]
        public string cMemo { get; set; }

        public bool bTransFlag { get; set; }

        [StringLength(20)]
        public string cAccounter { get; set; }

        [StringLength(20)]
        public string cMaker { get; set; }

        [StringLength(20)]
        public string cDefine1 { get; set; }

        [StringLength(20)]
        public string cDefine2 { get; set; }

        [StringLength(20)]
        public string cDefine3 { get; set; }

        public DateTime? cDefine4 { get; set; }

        public int? cDefine5 { get; set; }

        public DateTime? cDefine6 { get; set; }

        public double? cDefine7 { get; set; }

        [StringLength(4)]
        public string cDefine8 { get; set; }

        [StringLength(8)]
        public string cDefine9 { get; set; }

        [StringLength(60)]
        public string cDefine10 { get; set; }

        [StringLength(5)]
        public string dKeepDate { get; set; }

        public DateTime? dVeriDate { get; set; }

        public bool? bpufirst { get; set; }

        public bool? biafirst { get; set; }

        public double? iMQuantity { get; set; }

        public DateTime? dARVDate { get; set; }

        [StringLength(30)]
        public string cChkCode { get; set; }

        public DateTime? dChkDate { get; set; }

        [StringLength(40)]
        public string cChkPerson { get; set; }

        public int? VT_ID { get; set; }

        public bool bIsSTQc { get; set; }

        [StringLength(120)]
        public string cDefine11 { get; set; }

        [StringLength(120)]
        public string cDefine12 { get; set; }

        [StringLength(120)]
        public string cDefine13 { get; set; }

        [StringLength(120)]
        public string cDefine14 { get; set; }

        public int? cDefine15 { get; set; }

        public double? cDefine16 { get; set; }

        [StringLength(10)]
        public string gspcheck { get; set; }

        public long? ipurorderid { get; set; }

        public long? ipurarriveid { get; set; }

        [StringLength(30)]
        public string iarriveid { get; set; }

        [StringLength(30)]
        public string isalebillid { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] ufts { get; set; }

        public decimal? iTaxRate { get; set; }

        public double? iExchRate { get; set; }

        [StringLength(8)]
        public string cExch_Name { get; set; }

        public bool? bOMFirst { get; set; }

        public bool? bFromPreYear { get; set; }

        public bool? bIsLsQuery { get; set; }

        public short? bIsComplement { get; set; }

        public byte? iDiscountTaxType { get; set; }

        public int? ireturncount { get; set; }

        public int? iverifystate { get; set; }

        public int? iswfcontrolled { get; set; }

        [StringLength(50)]
        public string cModifyPerson { get; set; }

        public DateTime? dModifyDate { get; set; }

        public DateTime? dnmaketime { get; set; }

        public DateTime? dnmodifytime { get; set; }

        public DateTime? dnverifytime { get; set; }

        public int? bredvouch { get; set; }

        [StringLength(20)]
        public string cVenPUOMProtocol { get; set; }

        public DateTime? dCreditStart { get; set; }

        public int? iCreditPeriod { get; set; }

        public DateTime? dGatheringDate { get; set; }

        public byte? bCredit { get; set; }

        public int? iFlowId { get; set; }

        [StringLength(30)]
        public string cPZID { get; set; }

        [StringLength(4)]
        public string cSourceLs { get; set; }

        [StringLength(20)]
        public string cSourceCodeLs { get; set; }

        public int? iPrintCount { get; set; }

        [StringLength(60)]
        public string csysbarcode { get; set; }

        [StringLength(200)]
        public string cCurrentAuditor { get; set; }
    }
}
