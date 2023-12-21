namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VoucherBodyAccessories
    {
        public Guid? CellID { get; set; }

        [StringLength(50)]
        public string FileID { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        public int? nOrder { get; set; }

        public Guid ID { get; set; }

        [StringLength(50)]
        public string Cardnum { get; set; }
    }
}
