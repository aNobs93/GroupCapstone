namespace groupCapstoneMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodeFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        ApplicationId = c.String(maxLength: 128),
                        Venue = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Genre = c.String(),
                        Audience = c.String(),
                        EventDate = c.String(),
                        EventTime = c.String(),
                        Lat = c.String(),
                        Lng = c.String(),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.ApplicationId)
                .Index(t => t.Customer_CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Events", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Events", new[] { "ApplicationId" });
            DropTable("dbo.Events");
        }
    }
}
