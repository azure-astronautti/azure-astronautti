namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kissas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nimi = c.String(),
                        Ika = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kissas");
        }
    }
}
