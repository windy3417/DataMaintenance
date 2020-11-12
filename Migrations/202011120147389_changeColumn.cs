namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeColumn : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MenuModles");
            AlterColumn("dbo.MenuModles", "menuID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MenuModles", "menuID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MenuModles");
            AlterColumn("dbo.MenuModles", "menuID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.MenuModles", "menuID");
        }
    }
}
