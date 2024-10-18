namespace DataMaintenance.Model.U8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GL_mend
    {
        [Key]
        [Column(Order = 0)]
        public byte iperiod { get; set; }

        public bool bflag { get; set; }

        public bool? bcheck { get; set; }

        public DateTime? dpri_check { get; set; }

        public bool? bpri_check { get; set; }

        public bool? bflag_AP { get; set; }

        public bool? bflag_AR { get; set; }

        public bool? bflag_CA { get; set; }

        public bool? bflag_FA { get; set; }

        public bool? bflag_FD { get; set; }

        public bool? bflag_IA { get; set; }

        [StringLength(50)]
        public string bflag_PP { get; set; }

        public bool? bflag_PU { get; set; }

        public bool? bflag_WA { get; set; }

        public bool? bflag_ST { get; set; }

        public bool? bflag_SA { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        public bool bflag_GS { get; set; }

        public bool bflag_WH { get; set; }

        public bool? bflag_NB { get; set; }

        public bool bflag_PM { get; set; }

        public bool? bflag_CP { get; set; }

        public bool bflag_OM { get; set; }

        public bool bflag_WM { get; set; }

        public bool bflag_FM { get; set; }

        public bool? bFlag_RP { get; set; }

        public bool? bflag_GLGZ { get; set; }

        public bool? bflag_SC { get; set; }

        public bool bflag_HY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short iyear { get; set; }

        public int? iYPeriod { get; set; }
    }
}
