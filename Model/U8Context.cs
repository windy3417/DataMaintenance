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

        #region MasterData

        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }

        public virtual DbSet<InventoryClass> InventoryClasse { get; set; }

        #endregion


        #region stock in and out
        //puchase record
        public virtual DbSet<RdRecord01> RdRecord01 { get; set; }
        public virtual DbSet<rdrecords01> rdrecords01 { get; set; }
        //finished good record
        public virtual DbSet<rdrecord10> rdrecord10 { get; set; }
        public virtual DbSet<rdrecords10> rdrecords10 { get; set; }
        
       
        //Material out record
        public virtual DbSet<rdrecord11> rdrecord11 { get; set; }
        public virtual DbSet<rdrecords11> rdrecords11 { get; set; }
        public virtual DbSet<rdrecord32> rdrecord32 { get; set; }
        public virtual DbSet<rdrecords32> rdrecords32 { get; set; }


        #endregion

        #region BOM

        public virtual DbSet<bas_part> bas_part { get; set; }
        public virtual DbSet<bom_bom> bom_bom { get; set; }
        public virtual DbSet<bom_opcomponent> bom_opcomponent { get; set; }
        public virtual DbSet<bom_opcomponentopt> bom_opcomponentopt { get; set; }
        public virtual DbSet<bom_opcomponentsub> bom_opcomponentsub { get; set; }
        public virtual DbSet<bom_parent> bom_parent { get; set; }
        #endregion



        public virtual DbSet<CurrentStock> CurrentStock { get; set; }
     
        public virtual DbSet<GL_mend> GL_mend { get; set; }
        public virtual DbSet<Attachfile> Attachfile { get; set; }




    }
}
