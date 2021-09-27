namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypesOnIntInTableData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Data", "CementDeclaredWagons", c => c.Int());
            AlterColumn("dbo.Data", "CementActuallyWagons", c => c.Int());
            AlterColumn("dbo.Data", "CementDifferenceWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPBchDeclaredWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPBchActuallyWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPBchDifferenceWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPUzDeclaredWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPUzActuallyWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPUzDifferenceWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPRfDeclaredWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPRfActuallyWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPRfDifferenceWagons", c => c.Int());
            AlterColumn("dbo.Data", "PVDifferenceWagons", c => c.Int());
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.Int());
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Data", "HPBalanceWagons", c => c.Double());
            AlterColumn("dbo.Data", "PVBalanceWagons", c => c.Double());
            AlterColumn("dbo.Data", "PVDifferenceWagons", c => c.Double());
            AlterColumn("dbo.Data", "HPRfDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPRfActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPRfDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "HPUzDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPUzActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPUzDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBchDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBchActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "HPBchDeclaredWagons", c => c.String());
            AlterColumn("dbo.Data", "CementDifferenceWagons", c => c.String());
            AlterColumn("dbo.Data", "CementActuallyWagons", c => c.String());
            AlterColumn("dbo.Data", "CementDeclaredWagons", c => c.String());
        }
    }
}
