namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse")]
    public partial class Warehouse
    {
        [Key]
        [StringLength(10)]
        public string cWhCode { get; set; }

        [StringLength(20)]
        public string cWhName { get; set; }

        [StringLength(12)]
        public string cDepCode { get; set; }

        [StringLength(255)]
        public string cWhAddress { get; set; }

        [StringLength(100)]
        public string cWhPhone { get; set; }

        [StringLength(20)]
        public string cWhPerson { get; set; }

        [Required]
        [StringLength(12)]
        public string cWhValueStyle { get; set; }

        public bool bWhPos { get; set; }

        public double? iWhFundQuota { get; set; }

        [StringLength(6)]
        public string cMonth { get; set; }

        [StringLength(20)]
        public string cWhMemo { get; set; }

        public bool bFreeze { get; set; }

        [StringLength(30)]
        public string cBarCode { get; set; }

        public bool bMRP { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        public bool bROP { get; set; }

        public short? iFrequency { get; set; }

        [StringLength(10)]
        public string cFrequency { get; set; }

        public short? iDays { get; set; }

        public DateTime? dLastDate { get; set; }

        public short iWHProperty { get; set; }

        public bool bShop { get; set; }

        public bool bControlSerial { get; set; }

        public bool bInCost { get; set; }

        public bool bInAvailCalcu { get; set; }

        public bool bProxyWh { get; set; }

        public short iSAConMode { get; set; }

        public short iEXConMode { get; set; }

        public short iSTConMode { get; set; }

        public bool bBondedWh { get; set; }

        public bool bWhAsset { get; set; }

        public double? fWhQuota { get; set; }

        public DateTime? dWhEndDate { get; set; }

        public bool? bCheckSubitemCost { get; set; }

        [StringLength(40)]
        public string cPickPos { get; set; }

        public bool? bEB { get; set; }

        public DateTime? dModifyDate { get; set; }

        [StringLength(100)]
        public string cWareGroupCode { get; set; }

        [StringLength(100)]
        public string cProvince { get; set; }

        [StringLength(100)]
        public string cCity { get; set; }

        [StringLength(100)]
        public string cCounty { get; set; }
    }
}
