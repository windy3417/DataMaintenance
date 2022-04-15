namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [StringLength(20)]
        public string cCusCode { get; set; }

        [StringLength(98)]
        public string cCusName { get; set; }

        [Required]
        [StringLength(60)]
        public string cCusAbbName { get; set; }

        [StringLength(12)]
        public string cCCCode { get; set; }

        [StringLength(12)]
        public string cDCCode { get; set; }

        [StringLength(50)]
        public string cTrade { get; set; }

        [StringLength(255)]
        public string cCusAddress { get; set; }

        [StringLength(20)]
        public string cCusPostCode { get; set; }

        [StringLength(50)]
        public string cCusRegCode { get; set; }

        [StringLength(100)]
        public string cCusBank { get; set; }

        [StringLength(50)]
        public string cCusAccount { get; set; }

        public DateTime? dCusDevDate { get; set; }

        [StringLength(100)]
        public string cCusLPerson { get; set; }

        [StringLength(100)]
        public string cCusEmail { get; set; }

        [StringLength(50)]
        public string cCusPerson { get; set; }

        [StringLength(100)]
        public string cCusPhone { get; set; }

        [StringLength(100)]
        public string cCusFax { get; set; }

        [StringLength(20)]
        public string cCusBP { get; set; }

        [StringLength(100)]
        public string cCusHand { get; set; }

        [StringLength(20)]
        public string cCusPPerson { get; set; }

        public double? iCusDisRate { get; set; }

        [StringLength(6)]
        public string cCusCreGrade { get; set; }

        public double? iCusCreLine { get; set; }

        public int? iCusCreDate { get; set; }

        [StringLength(20)]
        public string cCusPayCond { get; set; }

        [StringLength(255)]
        public string cCusOAddress { get; set; }

        [StringLength(10)]
        public string cCusOType { get; set; }

        [StringLength(20)]
        public string cCusHeadCode { get; set; }

        [StringLength(10)]
        public string cCusWhCode { get; set; }

        [StringLength(12)]
        public string cCusDepart { get; set; }

        public double? iARMoney { get; set; }

        public DateTime? dLastDate { get; set; }

        public double? iLastMoney { get; set; }

        public DateTime? dLRDate { get; set; }

        public double? iLRMoney { get; set; }

        public DateTime? dEndDate { get; set; }

        public int? iFrequency { get; set; }

        [StringLength(20)]
        public string cCusDefine1 { get; set; }

        [StringLength(20)]
        public string cCusDefine2 { get; set; }

        [StringLength(20)]
        public string cCusDefine3 { get; set; }

        public short? iCostGrade { get; set; }

        [StringLength(20)]
        public string cCreatePerson { get; set; }

        [StringLength(20)]
        public string cModifyPerson { get; set; }

        public DateTime? dModifyDate { get; set; }

        [StringLength(20)]
        public string cRelVendor { get; set; }

        [StringLength(40)]
        public string iId { get; set; }

        [StringLength(20)]
        public string cPriceGroup { get; set; }

        [StringLength(20)]
        public string cOfferGrade { get; set; }

        public double? iOfferRate { get; set; }

        [StringLength(60)]
        public string cCusDefine4 { get; set; }

        [StringLength(60)]
        public string cCusDefine5 { get; set; }

        [StringLength(60)]
        public string cCusDefine6 { get; set; }

        [StringLength(120)]
        public string cCusDefine7 { get; set; }

        [StringLength(120)]
        public string cCusDefine8 { get; set; }

        [StringLength(120)]
        public string cCusDefine9 { get; set; }

        [StringLength(120)]
        public string cCusDefine10 { get; set; }

        public int? cCusDefine11 { get; set; }

        public int? cCusDefine12 { get; set; }

        public double? cCusDefine13 { get; set; }

        public double? cCusDefine14 { get; set; }

        public DateTime? cCusDefine15 { get; set; }

        public DateTime? cCusDefine16 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        [StringLength(60)]
        public string cInvoiceCompany { get; set; }

        public bool bCredit { get; set; }

        public bool bCreditDate { get; set; }

        public bool bCreditByHead { get; set; }

        public bool bLicenceDate { get; set; }

        public DateTime? dLicenceSDate { get; set; }

        public DateTime? dLicenceEDate { get; set; }

        public int? iLicenceADays { get; set; }

        public bool bBusinessDate { get; set; }

        public DateTime? dBusinessSDate { get; set; }

        public DateTime? dBusinessEDate { get; set; }

        public int? iBusinessADays { get; set; }

        public bool bProxy { get; set; }

        public DateTime? dProxySDate { get; set; }

        public DateTime? dProxyEDate { get; set; }

        public int? iProxyADays { get; set; }

        [StringLength(1000)]
        public string cMemo { get; set; }

        public bool bLimitSale { get; set; }

        public Guid? cCusContactCode { get; set; }

        [StringLength(10)]
        public string cCusCountryCode { get; set; }

        [StringLength(100)]
        public string cCusEnName { get; set; }

        [StringLength(60)]
        public string cCusEnAddr1 { get; set; }

        [StringLength(60)]
        public string cCusEnAddr2 { get; set; }

        [StringLength(60)]
        public string cCusEnAddr3 { get; set; }

        [StringLength(60)]
        public string cCusEnAddr4 { get; set; }

        [StringLength(10)]
        public string cCusPortCode { get; set; }

        [StringLength(20)]
        public string cPrimaryVen { get; set; }

        public double? fCommisionRate { get; set; }

        public double? fInsueRate { get; set; }

        public bool bHomeBranch { get; set; }

        [StringLength(255)]
        public string cBranchAddr { get; set; }

        [StringLength(100)]
        public string cBranchPhone { get; set; }

        [StringLength(50)]
        public string cBranchPerson { get; set; }

        [StringLength(12)]
        public string cCusTradeCCode { get; set; }

        [StringLength(4)]
        public string CustomerKCode { get; set; }

        public bool bCusState { get; set; }

        public short? bShop { get; set; }

        [StringLength(50)]
        public string cCusBankCode { get; set; }

        [StringLength(50)]
        public string cCusExch_name { get; set; }

        public short iCusGSPType { get; set; }

        public short? iCusGSPAuth { get; set; }

        [StringLength(120)]
        public string cCusGSPAuthNo { get; set; }

        [StringLength(120)]
        public string cCusBusinessNo { get; set; }

        [StringLength(20)]
        public string cCusLicenceNo { get; set; }

        public bool bCusDomestic { get; set; }

        public bool bCusOverseas { get; set; }

        [StringLength(20)]
        public string cCusCreditCompany { get; set; }

        [StringLength(20)]
        public string cCusSAProtocol { get; set; }

        [StringLength(20)]
        public string cCusExProtocol { get; set; }

        [StringLength(20)]
        public string cCusOtherProtocol { get; set; }

        public double? fCusDiscountRate { get; set; }

        [StringLength(20)]
        public string cCusSSCode { get; set; }

        [StringLength(20)]
        public string cCusCMProtocol { get; set; }

        public DateTime dCusCreateDatetime { get; set; }

        [StringLength(50)]
        public string cCusAppDocNo { get; set; }

        [StringLength(98)]
        public string cCusMnemCode { get; set; }

        public double? fAdvancePaymentRatio { get; set; }

        public bool bServiceAttribute { get; set; }

        public bool bRequestSign { get; set; }

        public bool? bOnGPinStore { get; set; }

        [StringLength(32)]
        public string cCusMngTypeCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? account_type { get; set; }

        [StringLength(20)]
        public string cCusImAgentProtocol { get; set; }

        public short? iSourceType { get; set; }

        [StringLength(20)]
        public string iSourceId { get; set; }

        public double? fExpense { get; set; }

        public double? fApprovedExpense { get; set; }

        public DateTime? dTouchedTime { get; set; }

        public DateTime? dRecentlyInvoiceTime { get; set; }

        public DateTime? dRecentlyQuoteTime { get; set; }

        public DateTime? dRecentlyActivityTime { get; set; }

        public DateTime? dRecentlyChanceTime { get; set; }

        public DateTime? dRecentlyContractTime { get; set; }

        [StringLength(100)]
        public string cLtcCustomerCode { get; set; }

        public bool? bTransFlag { get; set; }

        [StringLength(40)]
        public string cLtcPerson { get; set; }

        public DateTime? dLtcDate { get; set; }

        [StringLength(128)]
        public string cLocationSite { get; set; }

        public double? iCusTaxRate { get; set; }

        public DateTime? alloct_dept_time { get; set; }

        public DateTime? allot_user_time { get; set; }

        public DateTime? recyle_dept_time { get; set; }

        public DateTime? recyle_pub_time { get; set; }

        [StringLength(120)]
        public string cLicenceNo { get; set; }

        [StringLength(255)]
        public string cLicenceRange { get; set; }

        [StringLength(255)]
        public string cCusBusinessRange { get; set; }

        [StringLength(255)]
        public string cCusGSPAuthRange { get; set; }

        public DateTime? dCusGSPEDate { get; set; }

        public DateTime? dCusGSPSDate { get; set; }

        public int? iCusGSPADays { get; set; }

        public bool? bIsCusAttachFile { get; set; }

        public DateTime? dRecentContractDate { get; set; }

        public DateTime? dRecentDeliveryDate { get; set; }

        public DateTime? dRecentOutboundDate { get; set; }

        [StringLength(255)]
        public string cProvince { get; set; }

        [StringLength(255)]
        public string cCity { get; set; }

        [StringLength(255)]
        public string cCounty { get; set; }

        public Guid? cCusAddressGUID { get; set; }

        [StringLength(30)]
        public string cAddCode { get; set; }
    }
}
