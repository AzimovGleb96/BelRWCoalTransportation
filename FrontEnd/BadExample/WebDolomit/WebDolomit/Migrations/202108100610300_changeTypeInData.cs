namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTypeInData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Data", "PVDeclaredWagons", c => c.Int());
            AlterColumn("dbo.Data", "PVLoadedWagons", c => c.Int());
            AlterColumn("dbo.Data", "PVDifferenceWagons", c => c.Double());
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.Double());
            AlterColumn("dbo.Data", "PVAverageDailyWagons", c => c.Double());
            AlterColumn("dbo.Data", "HPCoordinatedWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPLoadedWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.Double());
            AlterColumn("dbo.Data", "HPAverageDailyWagons", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Data", "HPAverageDailyWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "HPLoadedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPCoordinatedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVAverageDailyWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "PVDifferenceWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "PVLoadedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVDeclaredWagons", c => c.Int(nullable: false));
        }
    }
}
