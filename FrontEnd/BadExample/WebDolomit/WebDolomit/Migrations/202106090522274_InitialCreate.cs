namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
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
                    CountryID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.TypeWagons", t => t.TypeWagonID, cascadeDelete: true)
                .Index(t => t.TypeWagonID)
                .Index(t => t.CountryID);

            CreateTable(
                "dbo.TypeWagons",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Type = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Login = c.String(),
                    Password = c.String(),
                    FullName = c.String(),
                    Role = c.String(),
                })
                .PrimaryKey(t => t.ID);

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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeWagons", t => t.TypeWagonID, cascadeDelete: true)
                .Index(t => t.TypeWagonID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Wagons", "TypeWagonID", "dbo.TypeWagons");
            DropForeignKey("dbo.Requests", "TypeWagonID", "dbo.TypeWagons");
            DropForeignKey("dbo.Requests", "CountryID", "dbo.Countries");
            DropIndex("dbo.Wagons", new[] { "TypeWagonID" });
            DropIndex("dbo.Requests", new[] { "CountryID" });
            DropIndex("dbo.Requests", new[] { "TypeWagonID" });
            DropTable("dbo.Wagons");
            DropTable("dbo.Users");
            DropTable("dbo.TypeWagons");
            DropTable("dbo.Requests");
            DropTable("dbo.Countries");
        }
    }
}
