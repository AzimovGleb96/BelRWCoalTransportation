namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data", "Date");
        }
    }
}
