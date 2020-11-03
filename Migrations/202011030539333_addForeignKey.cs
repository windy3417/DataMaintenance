namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthorizoationModles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserModles", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuthorizoationModles", "userID", "dbo.UserModles");
            DropIndex("dbo.AuthorizoationModles", new[] { "userID" });
            DropTable("dbo.AuthorizoationModles");
        }
    }
}
