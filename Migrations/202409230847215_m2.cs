namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnitProductionCosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Month = c.String(),
                        AccountNo = c.String(),
                        InvCode = c.String(),
                        InvName = c.String(),
                        InvStd = c.String(),
                        UnitCost = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnitProductionCosts");
        }
    }
}
