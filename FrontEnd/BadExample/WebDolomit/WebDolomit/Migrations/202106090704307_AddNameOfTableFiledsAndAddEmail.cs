namespace WebDolomit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameOfTableFiledsAndAddEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TypeWagons", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FullName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "FullName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Login", c => c.String());
            AlterColumn("dbo.TypeWagons", "Type", c => c.String());
            AlterColumn("dbo.Countries", "Name", c => c.String());
            DropColumn("dbo.Users", "Email");
        }
    }
}
