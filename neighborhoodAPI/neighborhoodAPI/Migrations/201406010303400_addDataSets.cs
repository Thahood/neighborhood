namespace neighborhoodAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ActivityType_Id = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivityTypes", t => t.ActivityType_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.ActivityType_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ActivityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ServiceType_Id = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceType_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.ServiceType_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Longitude", c => c.Single(nullable: false));
            AddColumn("dbo.AspNetUsers", "Latitude", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Services", "ServiceType_Id", "dbo.ServiceTypes");
            DropForeignKey("dbo.Activities", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Activities", "ActivityType_Id", "dbo.ActivityTypes");
            DropIndex("dbo.Services", new[] { "User_Id" });
            DropIndex("dbo.Services", new[] { "ServiceType_Id" });
            DropIndex("dbo.Activities", new[] { "User_Id" });
            DropIndex("dbo.Activities", new[] { "ActivityType_Id" });
            DropColumn("dbo.AspNetUsers", "Latitude");
            DropColumn("dbo.AspNetUsers", "Longitude");
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.Services");
            DropTable("dbo.ActivityTypes");
            DropTable("dbo.Activities");
        }
    }
}
