namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bom_parent
    {
        [Key]
        public Guid AutoId { get; set; }

        public int BomId { get; set; }

        public int ParentId { get; set; }

        public decimal? ParentScrap { get; set; }

        public int? SharingPartId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ufts { get; set; }
    }
}
