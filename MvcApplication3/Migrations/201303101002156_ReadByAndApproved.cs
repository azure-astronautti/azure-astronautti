namespace MvcApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReadByAndApproved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Approved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Books", "ReadBy", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "ReadBy");
            DropColumn("dbo.Books", "Approved");
        }
    }
}
