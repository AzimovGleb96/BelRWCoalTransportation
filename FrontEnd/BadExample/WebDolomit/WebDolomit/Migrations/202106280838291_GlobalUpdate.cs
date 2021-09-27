namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GlobalUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Requests", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Requests", "TypeWagonID", "dbo.TypeWagons");
            DropForeignKey("dbo.Wagons", "TypeWagonID", "dbo.TypeWagons");
            DropIndex("dbo.Requests", new[] { "TypeWagonID" });
            DropIndex("dbo.Requests", new[] { "CountryID" });
            DropIndex("dbo.Wagons", new[] { "TypeWagonID" });
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        cementDeclaredWagons = c.Int(nullable: false),
                        cementActuallyWagons = c.Int(nullable: false),
                        cementDifferenceWagons = c.Int(nullable: false),
                        HPBchDeclaredWagons = c.Int(nullable: false),
                        HPBchActuallyWagons = c.Int(nullable: false),
                        HPBchDifferenceWagons = c.Int(nullable: false),
                        HPUzDeclaredWagons = c.Int(nullable: false),
                        HPUzActuallyWagons = c.Int(nullable: false),
                        HPUzDifferenceWagons = c.Int(nullable: false),
                        HPRfDeclaredWagons = c.Int(nullable: false),
                        HPRfActuallyWagons = c.Int(nullable: false),
                        HPRfDifferenceWagons = c.Int(nullable: false),
                        PVCoordinatedWagons = c.Int(nullable: false),
                        PVLoadedWagons = c.Int(nullable: false),
                        PVBalanceWagons = c.Int(nullable: false),
                        PVAverageDailyWagons = c.Int(nullable: false),
                        HPCoordinatedWagons = c.Int(nullable: false),
                        HPLoadedWagons = c.Int(nullable: false),
                        HPBalanceWagons = c.Int(nullable: false),
                        HPAverageDailyWagons = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Users", "Role");
            DropTable("dbo.Countries");
            DropTable("dbo.Requests");
            DropTable("dbo.TypeWagons");
            DropTable("dbo.Wagons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Wagons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CoordinatedWagons = c.Int(nullable: false),
                        LoadedWagons = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        AverageDaily = c.Int(nullable: false),
                        TypeWagonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TypeWagons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StatedWagons = c.Int(nullable: false),
                        ActualWagons = c.Int(nullable: false),
                        Difference = c.Int(nullable: false),
                        TypeWagonID = c.Int(nullable: false),
                        CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Users", "Role", c => c.String(nullable: false));
            DropTable("dbo.Data");
            CreateIndex("dbo.Wagons", "TypeWagonID");
            CreateIndex("dbo.Requests", "CountryID");
            CreateIndex("dbo.Requests", "TypeWagonID");
            AddForeignKey("dbo.Wagons", "TypeWagonID", "dbo.TypeWagons", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Requests", "TypeWagonID", "dbo.TypeWagons", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Requests", "CountryID", "dbo.Countries", "ID");
        }
    }
}
