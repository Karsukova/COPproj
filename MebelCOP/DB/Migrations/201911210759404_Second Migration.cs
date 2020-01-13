namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "ProviderId", "dbo.Providers");
            DropIndex("dbo.Orders", new[] { "ProviderId" });
            DropTable("dbo.Orders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProviderId = c.Int(nullable: false),
                        NameProvider = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Orders", "ProviderId");
            AddForeignKey("dbo.Orders", "ProviderId", "dbo.Providers", "Id", cascadeDelete: true);
        }
    }
}
