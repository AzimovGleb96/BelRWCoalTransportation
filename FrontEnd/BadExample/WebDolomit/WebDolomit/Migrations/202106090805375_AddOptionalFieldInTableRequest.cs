namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOptionalFieldInTableRequest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Requests", "CountryID", "dbo.Countries");
            DropIndex("dbo.Requests", new[] { "CountryID" });
            AlterColumn("dbo.Requests", "CountryID", c => c.Int());
            CreateIndex("dbo.Requests", "CountryID");
            AddForeignKey("dbo.Requests", "CountryID", "dbo.Countries", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "CountryID", "dbo.Countries");
            DropIndex("dbo.Requests", new[] { "CountryID" });
            AlterColumn("dbo.Requests", "CountryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Requests", "CountryID");
            AddForeignKey("dbo.Requests", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
        }
    }
}
