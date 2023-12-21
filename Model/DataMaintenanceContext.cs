namespace DataMaintenance.Model.Maintenance
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataMaintenance.Model;


    public partial class DataMaintenanceContext  : DbContext
    {
        public DataMaintenanceContext()

            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business), true)
        {
        }

        public virtual DbSet<UserModle> Users { get; set; }
        public virtual DbSet<AuthorizationModle> Authorizoations { get; set; }
        public virtual DbSet<MenuModle> Menus { get; set; }
        public virtual DbSet<MenuAuthorizationModle> MenuAuthorization { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
           
        }
    }
}
