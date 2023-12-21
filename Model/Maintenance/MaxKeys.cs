namespace DataMaintenance.Model.Maintenance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaxKeys
    {
        public int id { get; set; }

        public int VoucherCode { get; set; }

        public string VoucherName { get; set; }

        public int CurrentKeyValue { get; set; }
    }
}
