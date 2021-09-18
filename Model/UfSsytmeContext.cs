using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataMaintenance.Model
{
    public partial class UfSsytmeContext : DbContext
    {
        public UfSsytmeContext()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.ufsystem), true)
        {
        }

        public virtual DbSet<UA_TaskLog> UA_TaskLog { get; set; }
        public virtual DbSet<UA_User> UA_User { get; set; }
        public virtual DbSet<UA_Auth> UA_Auth { get; set; }
        public virtual DbSet<ua_Task> ua_Task { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
