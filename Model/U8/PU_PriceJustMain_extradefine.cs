namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PU_PriceJustMain_extradefine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
    }
}
