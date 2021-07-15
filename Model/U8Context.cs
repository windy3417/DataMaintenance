namespace DataMaintenance.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
 
    using DataMaintenance.Model.U8;
    using DataMaintenance.Model.U8;

    public partial class U8Context : DbContext
    {
        public U8Context()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8), true)
        {
        }

        //外发需返主表
        public virtual DbSet<U8CUSTDEF_0058_E002> U8CUSTDEF_0058_E002 { get; set; }
        //外发需返子表
        public virtual DbSet<U8CUSTDEF_0058_E001> U8CUSTDEF_0058_E001 { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }


    }
}
