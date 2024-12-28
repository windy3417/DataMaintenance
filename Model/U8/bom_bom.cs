namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bom_bom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BomId { get; set; }

        public byte BomType { get; set; }

        public int? Version { get; set; }

        [StringLength(60)]
        public string VersionDesc { get; set; }

        public DateTime? VersionEffDate { get; set; }

        public DateTime? VersionEndDate { get; set; }

        [StringLength(20)]
        public string IdentCode { get; set; }

        [StringLength(60)]
        public string IdentDesc { get; set; }

        public int? ApplyDId { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string CreateUser { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(20)]
        public string ModifyUser { get; set; }

        public int? UpdCount { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ufts { get; set; }

        [StringLength(20)]
        public string Define1 { get; set; }

        [StringLength(20)]
        public string Define2 { get; set; }

        [StringLength(20)]
        public string Define3 { get; set; }

        public DateTime? Define4 { get; set; }

        public int? Define5 { get; set; }

        public DateTime? Define6 { get; set; }

        public double? Define7 { get; set; }

        [StringLength(4)]
        public string Define8 { get; set; }

        [StringLength(8)]
        public string Define9 { get; set; }

        [StringLength(60)]
        public string Define10 { get; set; }

        [StringLength(120)]
        public string Define11 { get; set; }

        [StringLength(120)]
        public string Define12 { get; set; }

        [StringLength(120)]
        public string Define13 { get; set; }

        [StringLength(120)]
        public string Define14 { get; set; }

        public int? Define15 { get; set; }

        public double? Define16 { get; set; }

        public int? VTid { get; set; }

        public byte? Status { get; set; }

        public byte? OrgStatus { get; set; }

        public DateTime? RelsDate { get; set; }

        [StringLength(20)]
        public string RelsUser { get; set; }

        public DateTime? RelsTime { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? ModifyTime { get; set; }

        public DateTime? CloseDate { get; set; }

        [StringLength(20)]
        public string CloseUser { get; set; }

        public DateTime? CloseTime { get; set; }

        public int? iPrintCount { get; set; }

        public byte? IsWFControlled { get; set; }

        public int? iVerifyState { get; set; }

        public int? iReturnCount { get; set; }

        public int? AuditStatus { get; set; }

        [StringLength(40)]
        public string cCurrentAuditor { get; set; }

        public bool? bProcessProduct { get; set; }

        public bool? bProcessMaterial { get; set; }
    }
}
