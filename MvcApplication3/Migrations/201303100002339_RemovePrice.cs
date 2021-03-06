namespace MvcApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
