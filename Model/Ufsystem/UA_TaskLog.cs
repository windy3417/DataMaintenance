namespace DataMaintenance.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UA_TaskLog
    {
        [StringLength(2)]
        public string cSub_Id { get; set; }

        [StringLength(40)]
        public string cSub_Name { get; set; }

        [StringLength(255)]
        public string cStation { get; set; }

        public DateTime? dInTime { get; set; }

        [Key]
        [StringLength(20)]
        public string cTaskId { get; set; }

        [StringLength(40)]
        public string TaskState { get; set; }

        [StringLength(80)]
        public string cAppServer { get; set; }

        [StringLength(40)]
        public string uuid { get; set; }

        [StringLength(4)]
        public string cLSSubId { get; set; }

        [StringLength(255)]
        public string cStationSerial { get; set; }
    }
}
