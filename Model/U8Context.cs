namespace DataMaintenance.Modle
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataMaintenance.Modle.U8;

    public partial class U8Context : DbContext
    {
        public U8Context()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8), true)
        {
        }

        //�ⷢ�践����
        public virtual DbSet<U8CUSTDEF_0058_E002> U8CUSTDEF_0058_E002 { get; set; }
        //�ⷢ�践�ӱ�
        public virtual DbSet<U8CUSTDEF_0058_E001> U8CUSTDEF_0058_E001 { get; set; }

    
    }
}