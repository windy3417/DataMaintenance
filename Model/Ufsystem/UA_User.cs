namespace DataMaintenance.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UA_User
    {
        [Key]
        [StringLength(20)]
        public string cUser_Id { get; set; }

        [StringLength(20)]
        public string cUser_Name { get; set; }

        [StringLength(255)]
        public string cPassword { get; set; }

        public bool iAdmin { get; set; }

        [StringLength(255)]
        public string cDept { get; set; }

        [StringLength(255)]
        public string cBelongGrp { get; set; }

        public short? nState { get; set; }

        [StringLength(100)]
        public string cUserEmail { get; set; }

        [StringLength(100)]
        public string cUserHand { get; set; }

        public int? SaveMailCount { get; set; }

        public int? SaveSMSCount { get; set; }

        [Required]
        [StringLength(32)]
        public string localeid { get; set; }

        public short? iErrorCount { get; set; }

        public DateTime? dPasswordDate { get; set; }

        [StringLength(50)]
        public string cSysUserName { get; set; }

        [StringLength(50)]
        public string cSysUserPassword { get; set; }

        public bool? bLogined { get; set; }

        public int? authenMode { get; set; }

        public bool? bRefuseModifyLoginDate { get; set; }

        public byte? iUserType { get; set; }

        public bool? bAutoCloseException { get; set; }

        public bool? bDuaLoginException { get; set; }

        public DateTime? dCrDate { get; set; }

        public bool? bModifyPWFirstLogin { get; set; }

        public bool? bAllinOneUser { get; set; }

        public bool? bIMUser { get; set; }

        public bool? bCCUser { get; set; }
    }
}
