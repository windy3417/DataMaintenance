namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.authorization",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.user", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.authorization", "userID", "dbo.user");
            DropIndex("dbo.authorization", new[] { "userID" });
            DropTable("dbo.user");
            DropTable("dbo.authorization");
        }
    }
}
