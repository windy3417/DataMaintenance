namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        [StringLength(60)]
        public string cInvCode { get; set; }

        [StringLength(255)]
        public string cInvAddCode { get; set; }

        [StringLength(255)]
        public string cInvName { get; set; }

        [StringLength(255)]
        public string cInvStd { get; set; }

        [StringLength(12)]
        public string cInvCCode { get; set; }

        [StringLength(20)]
        public string cVenCode { get; set; }

        [StringLength(60)]
        public string cReplaceItem { get; set; }

        [StringLength(20)]
        public string cPosition { get; set; }

        public bool bSale { get; set; }

        public bool bPurchase { get; set; }

        public bool bSelf { get; set; }

        public bool bComsume { get; set; }

        public bool bProducing { get; set; }

        public bool bService { get; set; }

        public bool bAccessary { get; set; }

        public double? iTaxRate { get; set; }

        public double? iInvWeight { get; set; }

        public double? iVolume { get; set; }

        public double? iInvRCost { get; set; }

        public double? iInvSPrice { get; set; }

        public double? iInvSCost { get; set; }

        public double? iInvLSCost { get; set; }

        public double? iInvNCost { get; set; }

        public double? iInvAdvance { get; set; }

        public double? iInvBatch { get; set; }

        public double? iSafeNum { get; set; }

        public double? iTopSum { get; set; }

        public double? iLowSum { get; set; }

        public double? iOverStock { get; set; }

        [StringLength(1)]
        public string cInvABC { get; set; }

        public bool bInvQuality { get; set; }

        public bool bInvBatch { get; set; }

        public bool bInvEntrust { get; set; }

        public bool bInvOverStock { get; set; }

        public DateTime? dSDate { get; set; }

        public DateTime? dEDate { get; set; }

        public bool bFree1 { get; set; }

        public bool bFree2 { get; set; }

        [StringLength(20)]
        public string cInvDefine1 { get; set; }

        [StringLength(20)]
        public string cInvDefine2 { get; set; }

        [StringLength(20)]
        public string cInvDefine3 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int I_id { get; set; }

        public bool? bInvType { get; set; }

        public double? iInvMPCost { get; set; }

        [StringLength(100)]
        public string cQuality { get; set; }

        public double? iInvSaleCost { get; set; }

        public double? iInvSCost1 { get; set; }

        public double? iInvSCost2 { get; set; }

        public double? iInvSCost3 { get; set; }

        public bool bFree3 { get; set; }

        public bool bFree4 { get; set; }

        public bool bFree5 { get; set; }

        public bool bFree6 { get; set; }

        public bool bFree7 { get; set; }

        public bool bFree8 { get; set; }

        public bool bFree9 { get; set; }

        public bool bFree10 { get; set; }

        [StringLength(20)]
        public string cCreatePerson { get; set; }

        [StringLength(20)]
        public string cModifyPerson { get; set; }

        public DateTime? dModifyDate { get; set; }

        public double? fSubscribePoint { get; set; }

        public double? fVagQuantity { get; set; }

        [StringLength(20)]
        public string cValueType { get; set; }

        public bool bFixExch { get; set; }

        public double? fOutExcess { get; set; }

        public double? fInExcess { get; set; }

        public short? iMassDate { get; set; }

        public short? iWarnDays { get; set; }

        public double? fExpensesExch { get; set; }

        public bool bTrack { get; set; }

        public bool bSerial { get; set; }

        public bool bBarCode { get; set; }

        public int? iId { get; set; }

        [StringLength(30)]
        public string cBarCode { get; set; }

        [StringLength(60)]
        public string cInvDefine4 { get; set; }

        [StringLength(60)]
        public string cInvDefine5 { get; set; }

        [StringLength(60)]
        public string cInvDefine6 { get; set; }

        [StringLength(120)]
        public string cInvDefine7 { get; set; }

        [StringLength(120)]
        public string cInvDefine8 { get; set; }

        [StringLength(120)]
        public string cInvDefine9 { get; set; }

        [StringLength(120)]
        public string cInvDefine10 { get; set; }

        public int? cInvDefine11 { get; set; }

        public int? cInvDefine12 { get; set; }

        public double? cInvDefine13 { get; set; }

        public double? cInvDefine14 { get; set; }

        public DateTime? cInvDefine15 { get; set; }

        public DateTime? cInvDefine16 { get; set; }

        public byte iGroupType { get; set; }

        [StringLength(35)]
        public string cGroupCode { get; set; }

        [StringLength(35)]
        public string cComUnitCode { get; set; }

        [StringLength(35)]
        public string cAssComUnitCode { get; set; }

        [StringLength(35)]
        public string cSAComUnitCode { get; set; }

        [StringLength(35)]
        public string cPUComUnitCode { get; set; }

        [StringLength(35)]
        public string cSTComUnitCode { get; set; }

        [StringLength(35)]
        public string cCAComUnitCode { get; set; }

        [StringLength(10)]
        public string cFrequency { get; set; }

        public short? iFrequency { get; set; }

        public short? iDays { get; set; }

        public DateTime? dLastDate { get; set; }

        public double? iWastage { get; set; }

        public bool bSolitude { get; set; }

        [StringLength(100)]
        public string cEnterprise { get; set; }

        [StringLength(255)]
        public string cAddress { get; set; }

        [StringLength(40)]
        public string cFile { get; set; }

        [StringLength(30)]
        public string cLabel { get; set; }

        [StringLength(30)]
        public string cCheckOut { get; set; }

        [StringLength(30)]
        public string cLicence { get; set; }

        public bool bSpecialties { get; set; }

        [StringLength(10)]
        public string cDefWareHouse { get; set; }

        public double? iHighPrice { get; set; }

        public double? iExpSaleRate { get; set; }

        [StringLength(20)]
        public string cPriceGroup { get; set; }

        [StringLength(20)]
        public string cOfferGrade { get; set; }

        public double? iOfferRate { get; set; }

        [StringLength(6)]
        public string cMonth { get; set; }

        public short? iAdvanceDate { get; set; }

        [StringLength(60)]
        public string cCurrencyName { get; set; }

        [StringLength(255)]
        public string cProduceAddress { get; set; }

        [StringLength(60)]
        public string cProduceNation { get; set; }

        [StringLength(60)]
        public string cRegisterNo { get; set; }

        [StringLength(60)]
        public string cEnterNo { get; set; }

        [StringLength(60)]
        public string cPackingType { get; set; }

        [StringLength(100)]
        public string cEnglishName { get; set; }

        public bool bPropertyCheck { get; set; }

        [StringLength(30)]
        public string cPreparationType { get; set; }

        [StringLength(60)]
        public string cCommodity { get; set; }

        public byte iRecipeBatch { get; set; }

        [StringLength(30)]
        public string cNotPatentName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        public bool bPromotSales { get; set; }

        public short? iPlanPolicy { get; set; }

        public short? iROPMethod { get; set; }

        public short? iBatchRule { get; set; }

        public double? fBatchIncrement { get; set; }

        public int? iAssureProvideDays { get; set; }

        public short? iTestStyle { get; set; }

        public short? iDTMethod { get; set; }

        public double? fDTRate { get; set; }

        public double? fDTNum { get; set; }

        [StringLength(35)]
        public string cDTUnit { get; set; }

        public short? iDTStyle { get; set; }

        public int? iQTMethod { get; set; }

        public Guid? PictureGUID { get; set; }

        public bool bPlanInv { get; set; }

        public bool bProxyForeign { get; set; }

        public bool bATOModel { get; set; }

        public bool bCheckItem { get; set; }

        public bool bPTOModel { get; set; }

        public bool bEquipment { get; set; }

        [StringLength(35)]
        public string cProductUnit { get; set; }

        public double? fOrderUpLimit { get; set; }

        public short? cMassUnit { get; set; }

        public double? fRetailPrice { get; set; }

        [StringLength(12)]
        public string cInvDepCode { get; set; }

        public int? iAlterAdvance { get; set; }

        public double? fAlterBaseNum { get; set; }

        [StringLength(1)]
        public string cPlanMethod { get; set; }

        public bool bMPS { get; set; }

        public bool bROP { get; set; }

        public bool bRePlan { get; set; }

        [StringLength(2)]
        public string cSRPolicy { get; set; }

        public bool bBillUnite { get; set; }

        public int? iSupplyDay { get; set; }

        public double? fSupplyMulti { get; set; }

        public double? fMinSupply { get; set; }

        public bool bCutMantissa { get; set; }

        [StringLength(20)]
        public string cInvPersonCode { get; set; }

        public int? iInvTfId { get; set; }

        [StringLength(60)]
        public string cEngineerFigNo { get; set; }

        public bool bInTotalCost { get; set; }

        public short iSupplyType { get; set; }

        public bool bConfigFree1 { get; set; }

        public bool bConfigFree2 { get; set; }

        public bool bConfigFree3 { get; set; }

        public bool bConfigFree4 { get; set; }

        public bool bConfigFree5 { get; set; }

        public bool bConfigFree6 { get; set; }

        public bool bConfigFree7 { get; set; }

        public bool bConfigFree8 { get; set; }

        public bool bConfigFree9 { get; set; }

        public bool bConfigFree10 { get; set; }

        public short? iDTLevel { get; set; }

        [StringLength(20)]
        public string cDTAQL { get; set; }

        public bool bPeriodDT { get; set; }

        [StringLength(30)]
        public string cDTPeriod { get; set; }

        public int? iBigMonth { get; set; }

        public int? iBigDay { get; set; }

        public int? iSmallMonth { get; set; }

        public int? iSmallDay { get; set; }

        public bool bOutInvDT { get; set; }

        public bool bBackInvDT { get; set; }

        public short? iEndDTStyle { get; set; }

        public bool? bDTWarnInv { get; set; }

        public double? fBackTaxRate { get; set; }

        [StringLength(30)]
        public string cCIQCode { get; set; }

        [StringLength(35)]
        public string cWGroupCode { get; set; }

        [StringLength(35)]
        public string cWUnit { get; set; }

        public double? fGrossW { get; set; }

        [StringLength(35)]
        public string cVGroupCode { get; set; }

        [StringLength(35)]
        public string cVUnit { get; set; }

        public double? fLength { get; set; }

        public double? fWidth { get; set; }

        public double? fHeight { get; set; }

        public int? iDTUCounter { get; set; }

        public int? iDTDCounter { get; set; }

        public int? iBatchCounter { get; set; }

        [StringLength(35)]
        public string cShopUnit { get; set; }

        [StringLength(20)]
        public string cPurPersonCode { get; set; }

        public bool bImportMedicine { get; set; }

        public bool bFirstBusiMedicine { get; set; }

        public bool bForeExpland { get; set; }

        [StringLength(20)]
        public string cInvPlanCode { get; set; }

        public double fConvertRate { get; set; }

        public DateTime? dReplaceDate { get; set; }

        public bool bInvModel { get; set; }

        public bool bKCCutMantissa { get; set; }

        public bool bReceiptByDT { get; set; }

        public double? iImpTaxRate { get; set; }

        public double? iExpTaxRate { get; set; }

        public bool bExpSale { get; set; }

        public double? iDrawBatch { get; set; }

        public bool bCheckBSATP { get; set; }

        [StringLength(16)]
        public string cInvProjectCode { get; set; }

        public short? iTestRule { get; set; }

        [StringLength(20)]
        public string cRuleCode { get; set; }

        public bool bCheckFree1 { get; set; }

        public bool bCheckFree2 { get; set; }

        public bool bCheckFree3 { get; set; }

        public bool bCheckFree4 { get; set; }

        public bool bCheckFree5 { get; set; }

        public bool bCheckFree6 { get; set; }

        public bool bCheckFree7 { get; set; }

        public bool bCheckFree8 { get; set; }

        public bool bCheckFree9 { get; set; }

        public bool bCheckFree10 { get; set; }

        public bool bBomMain { get; set; }

        public bool bBomSub { get; set; }

        public bool bProductBill { get; set; }

        public short iCheckATP { get; set; }

        public int? iInvATPId { get; set; }

        public int? iPlanTfDay { get; set; }

        public int? iOverlapDay { get; set; }

        public bool bPiece { get; set; }

        public bool bSrvItem { get; set; }

        public bool bSrvFittings { get; set; }

        public double? fMaxSupply { get; set; }

        public double? fMinSplit { get; set; }

        public bool bSpecialOrder { get; set; }

        public bool bTrackSaleBill { get; set; }

        [StringLength(40)]
        public string cInvMnemCode { get; set; }

        public short? iPlanDefault { get; set; }

        public double? iPFBatchQty { get; set; }

        public int? iAllocatePrintDgt { get; set; }

        public bool bCheckBatch { get; set; }

        public bool bMngOldpart { get; set; }

        public short? iOldpartMngRule { get; set; }
    }
}
