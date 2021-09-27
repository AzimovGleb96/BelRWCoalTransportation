namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypesInData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "PVDifferenceWagons", c => c.Double(nullable: true));
            AlterColumn("dbo.Data", "PVDeclaredWagons", c => c.Int(nullable: true));
            AlterColumn("dbo.Data", "PVLoadedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "PVAverageDailyWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "HPCoordinatedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPLoadedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.Double(nullable: false));
            AlterColumn("dbo.Data", "HPAverageDailyWagons", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Data", "HPAverageDailyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPLoadedWagons", c => c.String());
            AlterColumn("dbo.Data", "HPCoordinatedWagons", c => c.String());
            AlterColumn("dbo.Data", "PVAverageDailyWagons", c => c.String());
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.String());
            AlterColumn("dbo.Data", "PVLoadedWagons", c => c.String());
            AlterColumn("dbo.Data", "PVDeclaredWagons", c => c.String());
            DropColumn("dbo.Data", "PVDifferenceWagons");
        }
    }
}
