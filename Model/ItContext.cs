namespace DataMaintenance.Model.Maintenance
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataMaintenance.Model;

    public partial class ItContext : DbContext
    {
        public ItContext()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.it), true)
        {
        }

        public virtual DbSet<MaxKeys> MaxKeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
           
        }
    }
}
