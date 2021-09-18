namespace DataMaintenance.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ua_Task
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string cAcc_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short iYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string cUser_Id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string cAuth_Id { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string cStation { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string cTaskId { get; set; }

        public double? iLogId { get; set; }

        [StringLength(2)]
        public string cSub_id { get; set; }

        [StringLength(80)]
        public string cAppServer { get; set; }

        [StringLength(100)]
        public string cAuthClassCode { get; set; }

        public short? iBeginYear { get; set; }
    }
}
