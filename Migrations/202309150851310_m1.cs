namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.user", "UserName", c => c.String());
            DropColumn("dbo.user", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.user", "name", c => c.String());
            DropColumn("dbo.user", "UserName");
        }
    }
}
