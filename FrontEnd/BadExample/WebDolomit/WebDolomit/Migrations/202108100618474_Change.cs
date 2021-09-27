namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Data", "PVCoordinatedWagons", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Data", "PVCoordinatedWagons", c => c.String());
        }
    }
}
