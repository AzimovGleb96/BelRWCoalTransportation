namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeFieldsInTableData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "PVDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "CementDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "CementActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "CementDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBchDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBchActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBchDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPUzDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "HPUzActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPUzDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPRfDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "HPRfActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPRfDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "PVCoordinatedWagons", c => c.String());
            AlterColumn("dbo.Data", "PVLoadedWagons", c => c.String());
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.String());
            AlterColumn("dbo.Data", "PVAverageDailyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPCoordinatedWagons", c => c.String());
            AlterColumn("dbo.Data", "HPLoadedWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPAverageDailyWagons", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Data", "HPAverageDailyWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPLoadedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPCoordinatedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVAverageDailyWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVLoadedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "PVCoordinatedWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPRfDifferenceWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPRfActuallyWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPRfDeclaredWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPUzDifferenceWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPUzActuallyWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPUzDeclaredWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPBchDifferenceWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPBchActuallyWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "HPBchDeclaredWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "CementDifferenceWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "CementActuallyWagons", c => c.Int(nullable: false));
            AlterColumn("dbo.Data", "CementDeclaredWagons", c => c.Int(nullable: false));
            DropColumn("dbo.Data", "PVDeclaredWagons");
        }
    }
}
