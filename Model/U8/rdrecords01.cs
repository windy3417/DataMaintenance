namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rdrecords01
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AutoID { get; set; }

        public long ID { get; set; }

        [Required]
        [StringLength(60)]
        public string cInvCode { get; set; }

        public decimal? iNum { get; set; }

        public decimal? iQuantity { get; set; }

        public decimal? iUnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? iPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? iAPrice { get; set; }

        public decimal? iPUnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? iPPrice { get; set; }

        [StringLength(60)]
        public string cBatch { get; set; }

        public long? cVouchCode { get; set; }

        [StringLength(30)]
        public string cInVouchCode { get; set; }

        [StringLength(2)]
        public string cinvouchtype { get; set; }

        public decimal? iSOutQuantity { get; set; }

        public decimal? iSOutNum { get; set; }

        [StringLength(20)]
        public string cFree1 { get; set; }

        [StringLength(20)]
        public string cFree2 { get; set; }

        public byte iFlag { get; set; }

        public DateTime? dSDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? iTax { get; set; }

        public decimal? iSQuantity { get; set; }

        public decimal? iSNum { get; set; }

        [Column(TypeName = "money")]
        public decimal? iMoney { get; set; }

        public decimal? iFNum { get; set; }

        public decimal? iFQuantity { get; set; }

        public DateTime? dVDate { get; set; }

        [StringLength(20)]
        public string cPosition { get; set; }

        [StringLength(60)]
        public string cDefine22 { get; set; }

        [StringLength(60)]
        public string cDefine23 { get; set; }

        [StringLength(60)]
        public string cDefine24 { get; set; }

        [StringLength(60)]
        public string cDefine25 { get; set; }

        public double? cDefine26 { get; set; }

        public double? cDefine27 { get; set; }

        [StringLength(10)]
        public string cItem_class { get; set; }

        [StringLength(60)]
        public string cItemCode { get; set; }

        public long? iPOsID { get; set; }

        public decimal? fACost { get; set; }

        [StringLength(255)]
        public string cName { get; set; }

        [StringLength(20)]
        public string cItemCName { get; set; }

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

        [StringLength(200)]
        public string cBarCode { get; set; }

        public decimal? iNQuantity { get; set; }

        public decimal? iNNum { get; set; }

        [StringLength(35)]
        public string cAssUnit { get; set; }

        public DateTime? dMadeDate { get; set; }

        public int? iMassDate { get; set; }

        [StringLength(120)]
        public string cDefine28 { get; set; }

        [StringLength(120)]
        public string cDefine29 { get; set; }

        [StringLength(120)]
        public string cDefine30 { get; set; }

        [StringLength(120)]
        public string cDefine31 { get; set; }

        [StringLength(120)]
        public string cDefine32 { get; set; }

        [StringLength(120)]
        public string cDefine33 { get; set; }

        public int? cDefine34 { get; set; }

        public int? cDefine35 { get; set; }

        public DateTime? cDefine36 { get; set; }

        public DateTime? cDefine37 { get; set; }

        public long? iCheckIds { get; set; }

        [StringLength(20)]
        public string cBVencode { get; set; }

        [StringLength(20)]
        public string chVencode { get; set; }

        public bool? bGsp { get; set; }

        [StringLength(20)]
        public string cGspState { get; set; }

        public long? iArrsId { get; set; }

        [StringLength(30)]
        public string cCheckCode { get; set; }

        public long? iCheckIdBaks { get; set; }

        [StringLength(30)]
        public string cRejectCode { get; set; }

        public long? iRejectIds { get; set; }

        [StringLength(20)]
        public string cCheckPersonCode { get; set; }

        public DateTime? dCheckDate { get; set; }

        public decimal? iOriTaxCost { get; set; }

        public decimal? iOriCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? iOriMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? iOriTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? ioriSum { get; set; }

        public decimal? iTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? iTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? iSum { get; set; }

        public bool? bTaxCost { get; set; }

        [StringLength(30)]
        public string cPOID { get; set; }

        public short? cMassUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? iMaterialFee { get; set; }

        public decimal? iProcessCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? iProcessFee { get; set; }

        public DateTime? dMSDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? iSMaterialFee { get; set; }

        [Column(TypeName = "money")]
        public decimal? iSProcessFee { get; set; }

        public int? iOMoDID { get; set; }

        [StringLength(64)]
        public string strContractId { get; set; }

        [StringLength(150)]
        public string strCode { get; set; }

        public bool? bChecked { get; set; }

        public bool? bRelated { get; set; }

        public long? iOMoMID { get; set; }

        public int iMatSettleState { get; set; }

        public int iBillSettleCount { get; set; }

        public bool? bLPUseFree { get; set; }

        public long? iOriTrackID { get; set; }

        [StringLength(2)]
        public string coritracktype { get; set; }

        [StringLength(30)]
        public string cbaccounter { get; set; }

        public DateTime? dbKeepDate { get; set; }

        public bool? bCosting { get; set; }

        public decimal? iSumBillQuantity { get; set; }

        public bool? bVMIUsed { get; set; }

        public decimal? iVMISettleQuantity { get; set; }

        public decimal? iVMISettleNum { get; set; }

        [StringLength(20)]
        public string cvmivencode { get; set; }

        public int? iInvSNCount { get; set; }

        [StringLength(20)]
        public string cwhpersoncode { get; set; }

        [StringLength(50)]
        public string cwhpersonname { get; set; }

        public decimal? impcost { get; set; }

        public int? iIMOSID { get; set; }

        public int? iIMBSID { get; set; }

        [StringLength(30)]
        public string cbarvcode { get; set; }

        [StringLength(30)]
        public string dbarvdate { get; set; }

        public decimal? iinvexchrate { get; set; }

        [StringLength(16)]
        public string corufts { get; set; }

        [StringLength(30)]
        public string comcode { get; set; }

        public Guid? strContractGUID { get; set; }

        public short? iExpiratDateCalcu { get; set; }

        [StringLength(10)]
        public string cExpirationdate { get; set; }

        public DateTime? dExpirationdate { get; set; }

        [StringLength(20)]
        public string cciqbookcode { get; set; }

        public decimal? iBondedSumQty { get; set; }

        public byte? iordertype { get; set; }

        public int? iorderdid { get; set; }

        [StringLength(30)]
        public string iordercode { get; set; }

        public int? iorderseq { get; set; }

        [StringLength(40)]
        public string isodid { get; set; }

        public byte? isotype { get; set; }

        [StringLength(40)]
        public string csocode { get; set; }

        public int? isoseq { get; set; }

        public decimal? cBatchProperty1 { get; set; }

        public decimal? cBatchProperty2 { get; set; }

        public decimal? cBatchProperty3 { get; set; }

        public decimal? cBatchProperty4 { get; set; }

        public decimal? cBatchProperty5 { get; set; }

        [StringLength(120)]
        public string cBatchProperty6 { get; set; }

        [StringLength(120)]
        public string cBatchProperty7 { get; set; }

        [StringLength(120)]
        public string cBatchProperty8 { get; set; }

        [StringLength(120)]
        public string cBatchProperty9 { get; set; }

        public DateTime? cBatchProperty10 { get; set; }

        [StringLength(255)]
        public string cbMemo { get; set; }

        public decimal? iFaQty { get; set; }

        public decimal? isTax { get; set; }

        public int? irowno { get; set; }

        public Guid? strowguid { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] rowufts { get; set; }

        public decimal? ipreuseqty { get; set; }

        public decimal? ipreuseinum { get; set; }

        public int? iDebitIDs { get; set; }

        public decimal? OutCopiedQuantity { get; set; }

        public int? iOldPartId { get; set; }

        public decimal? fOldQuantity { get; set; }

        [StringLength(80)]
        public string cbsysbarcode { get; set; }

        public bool? bmergecheck { get; set; }

        public int? iMergeCheckAutoId { get; set; }

        public byte? bnoitemused { get; set; }

        [StringLength(30)]
        public string cReworkMOCode { get; set; }

        public int? iReworkMODetailsid { get; set; }

        public int? iProductType { get; set; }

        [StringLength(30)]
        public string cMainInvCode { get; set; }

        public int? iMainMoDetailsID { get; set; }

        public decimal? iShareMaterialFee { get; set; }

        [StringLength(80)]
        public string cplanlotcode { get; set; }

        public short? bgift { get; set; }

        public short? iposflag { get; set; }
    }
}
