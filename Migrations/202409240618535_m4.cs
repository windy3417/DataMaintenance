namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UnitProductionCost", "cInvCode", c => c.String());
            AddColumn("dbo.UnitProductionCost", "cInvName", c => c.String());
            AddColumn("dbo.UnitProductionCost", "cInvStd", c => c.String());
            DropColumn("dbo.UnitProductionCost", "InvCode");
            DropColumn("dbo.UnitProductionCost", "InvName");
            DropColumn("dbo.UnitProductionCost", "InvStd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnitProductionCost", "InvStd", c => c.String());
            AddColumn("dbo.UnitProductionCost", "InvName", c => c.String());
            AddColumn("dbo.UnitProductionCost", "InvCode", c => c.String());
            DropColumn("dbo.UnitProductionCost", "cInvStd");
            DropColumn("dbo.UnitProductionCost", "cInvName");
            DropColumn("dbo.UnitProductionCost", "cInvCode");
        }
    }
}
