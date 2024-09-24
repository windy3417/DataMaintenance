namespace DataMaintenance.Model.Maintenance
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataMaintenance.Model;

    public partial class ITContext : DbContext
    {
        public ITContext()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business), true)
        {
        }

        public virtual DbSet<MaxKeys> MaxKeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
           
        }
    }
}
