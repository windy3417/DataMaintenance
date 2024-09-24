namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UnitProductionCost", "iYear", c => c.Int(nullable: false));
            AddColumn("dbo.UnitProductionCost", "cMonth", c => c.String());
            DropColumn("dbo.UnitProductionCost", "Year");
            DropColumn("dbo.UnitProductionCost", "Month");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnitProductionCost", "Month", c => c.String());
            AddColumn("dbo.UnitProductionCost", "Year", c => c.Int(nullable: false));
            DropColumn("dbo.UnitProductionCost", "cMonth");
            DropColumn("dbo.UnitProductionCost", "iYear");
        }
    }
}
