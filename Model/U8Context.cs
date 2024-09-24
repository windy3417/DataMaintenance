namespace DataMaintenance.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
 
    using DataMaintenance.Model.U8;


    public partial class U8Context : DbContext
    {
        public U8Context(string accountNo)
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8,accountNo), true)
        {
        }

        //外发需返主表
        public virtual DbSet<U8CUSTDEF_0058_E002> U8CUSTDEF_0058_E002 { get; set; }
        //外发需返子表
        public virtual DbSet<U8CUSTDEF_0058_E001> U8CUSTDEF_0058_E001 { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<Attachfile> Attachfile { get; set; }
        public virtual DbSet<rdrecord32> rdrecord32 { get; set; }
        public virtual DbSet<rdrecords32> rdrecords32 { get; set; }
        public virtual DbSet<rdrecord10> rdrecord10 { get; set; }
        public virtual DbSet<rdrecords10> rdrecords10 { get; set; }
        public virtual DbSet<CurrentStock> CurrentStock { get; set; }
        public virtual DbSet<InventoryClass> InventoryClasse { get; set; }



    }
}
