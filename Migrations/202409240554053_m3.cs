﻿namespace DataMaintenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UnitProductionCosts", newName: "UnitProductionCost");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UnitProductionCost", newName: "UnitProductionCosts");
        }
    }
}
