namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AuthorizoationModles", newName: "authorization");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.authorization", newName: "AuthorizoationModles");
        }
    }
}
