namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendor")]
    public partial class Vendor
    {
        [Key]
        [StringLength(20)]
        public string cVenCode { get; set; }

        [StringLength(98)]
        public string cVenName { get; set; }

        [Required]
        [StringLength(60)]
        public string cVenAbbName { get; set; }

        [StringLength(12)]
        public string cVCCode { get; set; }

        [StringLength(12)]
        public string cDCCode { get; set; }

        [StringLength(50)]
        public string cTrade { get; set; }

        [StringLength(255)]
        public string cVenAddress { get; set; }

        [StringLength(20)]
        public string cVenPostCode { get; set; }

        [StringLength(50)]
        public string cVenRegCode { get; set; }

        [StringLength(100)]
        public string cVenBank { get; set; }

        [StringLength(50)]
        public string cVenAccount { get; set; }

        public DateTime? dVenDevDate { get; set; }

        [StringLength(100)]
        public string cVenLPerson { get; set; }

        [StringLength(100)]
        public string cVenPhone { get; set; }

        [StringLength(100)]
        public string cVenFax { get; set; }

        [StringLength(100)]
        public string cVenEmail { get; set; }

        [StringLength(50)]
        public string cVenPerson { get; set; }

        [StringLength(20)]
        public string cVenBP { get; set; }

        [StringLength(20)]
        public string cVenHand { get; set; }

        [StringLength(20)]
        public string cVenPPerson { get; set; }

        public double? iVenDisRate { get; set; }

        [StringLength(6)]
        public string iVenCreGrade { get; set; }

        public double? iVenCreLine { get; set; }

        public int? iVenCreDate { get; set; }

        [StringLength(20)]
        public string cVenPayCond { get; set; }

        [StringLength(255)]
        public string cVenIAddress { get; set; }

        [StringLength(10)]
        public string cVenIType { get; set; }

        [StringLength(20)]
        public string cVenHeadCode { get; set; }

        [StringLength(10)]
        public string cVenWhCode { get; set; }

        [StringLength(12)]
        public string cVenDepart { get; set; }

        public double? iAPMoney { get; set; }

        public DateTime? dLastDate { get; set; }

        public double? iLastMoney { get; set; }

        public DateTime? dLRDate { get; set; }

        public double? iLRMoney { get; set; }

        public DateTime? dEndDate { get; set; }

        public int? iFrequency { get; set; }

        public bool bVenTax { get; set; }

        [StringLength(20)]
        public string cVenDefine1 { get; set; }

        [StringLength(20)]
        public string cVenDefine2 { get; set; }

        [StringLength(20)]
        public string cVenDefine3 { get; set; }

        [StringLength(20)]
        public string cCreatePerson { get; set; }

        [StringLength(20)]
        public string cModifyPerson { get; set; }

        public DateTime? dModifyDate { get; set; }

        [StringLength(20)]
        public string cRelCustomer { get; set; }

        public int? iId { get; set; }

        [StringLength(30)]
        public string cBarCode { get; set; }

        [StringLength(60)]
        public string cVenDefine4 { get; set; }

        [StringLength(60)]
        public string cVenDefine5 { get; set; }

        [StringLength(60)]
        public string cVenDefine6 { get; set; }

        [StringLength(120)]
        public string cVenDefine7 { get; set; }

        [StringLength(120)]
        public string cVenDefine8 { get; set; }

        [StringLength(120)]
        public string cVenDefine9 { get; set; }

        [StringLength(120)]
        public string cVenDefine10 { get; set; }

        public int? cVenDefine11 { get; set; }

        public int? cVenDefine12 { get; set; }

        public double? cVenDefine13 { get; set; }

        public double? cVenDefine14 { get; set; }

        public DateTime? cVenDefine15 { get; set; }

        public DateTime? cVenDefine16 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        public double? fRegistFund { get; set; }

        public int? iEmployeeNum { get; set; }

        public short? iGradeABC { get; set; }

        [StringLength(240)]
        public string cMemo { get; set; }

        public bool bLicenceDate { get; set; }

        public DateTime? dLicenceSDate { get; set; }

        public DateTime? dLicenceEDate { get; set; }

        public int? iLicenceADays { get; set; }

        public bool bBusinessDate { get; set; }

        public DateTime? dBusinessSDate { get; set; }

        public DateTime? dBusinessEDate { get; set; }

        public int? iBusinessADays { get; set; }

        public bool bProxyDate { get; set; }

        public DateTime? dProxySDate { get; set; }

        public DateTime? dProxyEDate { get; set; }

        public int? iProxyADays { get; set; }

        public bool bPassGMP { get; set; }

        public bool bVenCargo { get; set; }

        public bool bProxyForeign { get; set; }

        public bool bVenService { get; set; }

        [StringLength(12)]
        public string cVenTradeCCode { get; set; }

        [StringLength(5)]
        public string cVenBankCode { get; set; }

        [StringLength(50)]
        public string cVenExch_name { get; set; }

        public short iVenGSPType { get; set; }

        public short? iVenGSPAuth { get; set; }

        [StringLength(40)]
        public string cVenGSPAuthNo { get; set; }

        [StringLength(20)]
        public string cVenBusinessNo { get; set; }

        [StringLength(20)]
        public string cVenLicenceNo { get; set; }

        public bool bVenOverseas { get; set; }

        public bool bVenAccPeriodMng { get; set; }

        [StringLength(20)]
        public string cVenPUOMProtocol { get; set; }

        [StringLength(20)]
        public string cVenOtherProtocol { get; set; }

        [StringLength(10)]
        public string cVenCountryCode { get; set; }

        [StringLength(100)]
        public string cVenEnName { get; set; }

        [StringLength(60)]
        public string cVenEnAddr1 { get; set; }

        [StringLength(60)]
        public string cVenEnAddr2 { get; set; }

        [StringLength(60)]
        public string cVenEnAddr3 { get; set; }

        [StringLength(60)]
        public string cVenEnAddr4 { get; set; }

        [StringLength(10)]
        public string cVenPortCode { get; set; }

        [StringLength(20)]
        public string cVenPrimaryVen { get; set; }

        public double? fVenCommisionRate { get; set; }

        public double? fVenInsueRate { get; set; }

        public bool bVenHomeBranch { get; set; }

        [StringLength(200)]
        public string cVenBranchAddr { get; set; }

        [StringLength(100)]
        public string cVenBranchPhone { get; set; }

        [StringLength(50)]
        public string cVenBranchPerson { get; set; }

        [StringLength(20)]
        public string cVenSSCode { get; set; }

        [StringLength(20)]
        public string cOMWhCode { get; set; }

        [StringLength(20)]
        public string cVenCMProtocol { get; set; }

        [StringLength(20)]
        public string cVenIMProtocol { get; set; }

        public double? iVenTaxRate { get; set; }

        public DateTime dVenCreateDatetime { get; set; }

        [StringLength(98)]
        public string cVenMnemCode { get; set; }

        public Guid? cVenContactCode { get; set; }

        [StringLength(50)]
        public string cvenbankall { get; set; }

        public bool? bIsVenAttachFile { get; set; }

        [StringLength(255)]
        public string cLicenceRange { get; set; }

        [StringLength(255)]
        public string cBusinessRange { get; set; }

        [StringLength(255)]
        public string cVenGSPRange { get; set; }

        public DateTime? dVenGSPEDate { get; set; }

        public DateTime? dVenGSPSDate { get; set; }

        public int? iVenGSPADays { get; set; }
    }
}
