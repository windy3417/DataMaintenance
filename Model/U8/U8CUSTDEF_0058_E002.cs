namespace DataMaintenance.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class U8CUSTDEF_0058_E002
    {
        public decimal? U8CUSTDEF_0058_E002_F002 { get; set; }

        public decimal? U8CUSTDEF_0058_E002_F003 { get; set; }

        public decimal? U8CUSTDEF_0058_E002_F004 { get; set; }

        [StringLength(100)]
        public string U8CUSTDEF_0058_E002_F001 { get; set; }

        public DateTime? U8CUSTDEF_0058_E002_F007 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U8CUSTDEF_0058_E002_PK { get; set; }

        public int? U8CUSTDEF_0058_E001_PK { get; set; }

        public int? UAPRuntime_RowNO { get; set; }

        [StringLength(50)]
        public string UAP_VoucherTransform_Rowkey { get; set; }

        [StringLength(50)]
        public string RefMainID { get; set; }

        [StringLength(50)]
        public string RefRowID { get; set; }
    }
}
