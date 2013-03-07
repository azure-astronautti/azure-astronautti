namespace MvcApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWriterMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Writer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Writer");
        }
    }
}
