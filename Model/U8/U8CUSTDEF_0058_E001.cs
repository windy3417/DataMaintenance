namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class U8CUSTDEF_0058_E001
    {
        [StringLength(40)]
        public string cNo { get; set; }

        [StringLength(30)]
        public string cMaker { get; set; }

        public DateTime? dMakeDateEx { get; set; }

        public DateTime? dMakeDate { get; set; }

        [StringLength(30)]
        public string cMender { get; set; }

        public DateTime? dModifyDateEx { get; set; }

        public DateTime? dModifyDate { get; set; }

        [StringLength(30)]
        public string cAuditor { get; set; }

        public DateTime? dAuditDateEx { get; set; }

        public DateTime? dAuditDate { get; set; }

        [StringLength(40)]
        public string cMemo { get; set; }

        [StringLength(40)]
        public string U8CUSTDEF_0058_E001_F014 { get; set; }

        [StringLength(40)]
        public string U8CUSTDEF_0058_E001_F015 { get; set; }

        [StringLength(100)]
        public string U8CUSTDEF_0058_E001_F016 { get; set; }

        [StringLength(40)]
        public string U8CUSTDEF_0058_E001_F018 { get; set; }

        [StringLength(40)]
        public string U8CUSTDEF_0058_E001_F019 { get; set; }

        [StringLength(100)]
        public string U8CUSTDEF_0058_E001_F020 { get; set; }

        [StringLength(32)]
        public string U8CUSTDEF_0058_E001_F021 { get; set; }

        [StringLength(100)]
        public string U8CUSTDEF_0058_E001_F023 { get; set; }

        [StringLength(100)]
        public string U8CUSTDEF_0058_E001_F024 { get; set; }

        public DateTime? U8CUSTDEF_0058_E001_F025 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U8CUSTDEF_0058_E001_PK { get; set; }

        public int? iswfcontrolled { get; set; }

        public int? iverifystate { get; set; }

        public int? ireturncount { get; set; }

        public int? UAPRuntime_RowNO { get; set; }

        [StringLength(50)]
        public string UAP_VoucherTransform_Rowkey { get; set; }
    }
}
