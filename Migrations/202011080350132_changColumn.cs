namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.user", "pwd", c => c.String());
            DropColumn("dbo.user", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.user", "password", c => c.String());
            DropColumn("dbo.user", "pwd");
        }
    }
}
