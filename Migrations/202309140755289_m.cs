namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.authorization",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userID = c.String(maxLength: 128),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.user", t => t.userID)
                .Index(t => t.userID);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        userID = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        pwd = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        DateOfCancellation = c.DateTime(),
                    })
                .PrimaryKey(t => t.userID);
            
            CreateTable(
                "dbo.MenuAuthorization",
                c => new
                    {
                        menuID = c.Int(nullable: false),
                        userID = c.String(nullable: false, maxLength: 128),
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => new { t.menuID, t.userID });
            
            CreateTable(
                "dbo.menus",
                c => new
                    {
                        menuID = c.Int(nullable: false, identity: true),
                        menuName = c.String(),
                    })
                .PrimaryKey(t => t.menuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.authorization", "userID", "dbo.user");
            DropIndex("dbo.authorization", new[] { "userID" });
            DropTable("dbo.menus");
            DropTable("dbo.MenuAuthorization");
            DropTable("dbo.user");
            DropTable("dbo.authorization");
        }
    }
}
