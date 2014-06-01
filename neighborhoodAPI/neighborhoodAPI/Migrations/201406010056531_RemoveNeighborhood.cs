namespace neighborhoodAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNeighborhood : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "Neighborhood_Id", "dbo.Neighborhoods");
            DropForeignKey("dbo.AspNetUsers", "Neighborhood_Id", "dbo.Neighborhoods");
            DropIndex("dbo.Services", new[] { "Neighborhood_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "Neighborhood_Id" });
            DropColumn("dbo.AspNetUsers", "Neighborhood_Id");
            DropTable("dbo.Neighborhoods");
            DropTable("dbo.Services");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        Longitude = c.Single(nullable: false),
                        Latitude = c.Single(nullable: false),
                        Neighborhood_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Neighborhoods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Neighborhood_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Neighborhood_Id");
            CreateIndex("dbo.Services", "Neighborhood_Id");
            AddForeignKey("dbo.AspNetUsers", "Neighborhood_Id", "dbo.Neighborhoods", "Id");
            AddForeignKey("dbo.Services", "Neighborhood_Id", "dbo.Neighborhoods", "Id");
        }
    }
}
