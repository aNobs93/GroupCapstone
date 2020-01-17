namespace groupCapstoneMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
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
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            DropColumn("dbo.Musicians", "PriceRange");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musicians", "PriceRange", c => c.Int(nullable: false));
            DropForeignKey("dbo.Events", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "ApplicationId" });
            DropTable("dbo.Events");
        }
    }
}
