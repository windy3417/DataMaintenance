namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rdrecords32
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

        public long? coutvouchid { get; set; }

        [StringLength(2)]
        public string coutvouchtype { get; set; }

        public decimal? iSRedOutQuantity { get; set; }

        public decimal? iSRedOutNum { get; set; }

        [StringLength(20)]
        public string cFree1 { get; set; }

        [StringLength(20)]
        public string cFree2 { get; set; }

        public byte iFlag { get; set; }

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

        public long? iDLsID { get; set; }

        public long? iSBsID { get; set; }

        public decimal? iSendQuantity { get; set; }

        public decimal? iSendNum { get; set; }

        public int? iEnsID { get; set; }

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

        public bool? bGsp { get; set; }

        [StringLength(20)]
        public string cGspState { get; set; }

        [StringLength(30)]
        public string cCheckCode { get; set; }

        public long? iCheckIdBaks { get; set; }

        [StringLength(30)]
        public string cRejectCode { get; set; }

        public long? iRejectIds { get; set; }

        [StringLength(20)]
        public string cCheckPersonCode { get; set; }

        public DateTime? dCheckDate { get; set; }

        public short? cMassUnit { get; set; }

        public byte? iRefundInspectFlag { get; set; }

        [StringLength(64)]
        public string strContractId { get; set; }

        [StringLength(150)]
        public string strCode { get; set; }

        public bool? bChecked { get; set; }

        public int? iEqDID { get; set; }

        public bool? bLPUseFree { get; set; }

        public int? iRSRowNO { get; set; }

        public long? iOriTrackID { get; set; }

        [StringLength(2)]
        public string coritracktype { get; set; }

        [StringLength(30)]
        public string cbaccounter { get; set; }

        public DateTime? dbKeepDate { get; set; }

        public bool? bCosting { get; set; }

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

        [StringLength(38)]
        public string cserviceoid { get; set; }

        [StringLength(38)]
        public string cbserviceoid { get; set; }

        public decimal? iinvexchrate { get; set; }

        [StringLength(30)]
        public string cbdlcode { get; set; }

        [StringLength(16)]
        public string corufts { get; set; }

        public Guid? strContractGUID { get; set; }

        public short? iExpiratDateCalcu { get; set; }

        [StringLength(10)]
        public string cExpirationdate { get; set; }

        public DateTime? dExpirationdate { get; set; }

        [StringLength(20)]
        public string cciqbookcode { get; set; }

        public decimal? iBondedSumQty { get; set; }

        [StringLength(40)]
        public string ccusinvcode { get; set; }

        [StringLength(100)]
        public string ccusinvname { get; set; }

        public int? iorderdid { get; set; }

        public byte? iordertype { get; set; }

        [StringLength(30)]
        public string iordercode { get; set; }

        public int? iorderseq { get; set; }

        [StringLength(40)]
        public string ipesodid { get; set; }

        public byte? ipesotype { get; set; }

        [StringLength(40)]
        public string cpesocode { get; set; }

        public int? ipesoseq { get; set; }

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

        public int? irowno { get; set; }

        public Guid? strowguid { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] rowufts { get; set; }

        public decimal? ipreuseqty { get; set; }

        public decimal? ipreuseinum { get; set; }

        public int? iDebitIDs { get; set; }

        public decimal? fsettleqty { get; set; }

        public decimal? fretqtywkp { get; set; }

        public decimal? fretqtyykp { get; set; }

        [StringLength(80)]
        public string cbsysbarcode { get; set; }

        public bool? bIAcreatebill { get; set; }

        public bool? bsaleoutcreatebill { get; set; }

        public long? isaleoutid { get; set; }

        public bool? bneedbill { get; set; }

        public short? iposflag { get; set; }

        public Guid? body_outid { get; set; }
    }
}
