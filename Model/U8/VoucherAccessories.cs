namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VoucherAccessories
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string VoucherTypeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string VoucherID { get; set; }

        [Column(TypeName = "image")]
        public byte[] FileContent { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string Memo { get; set; }
    }
}
