namespace WelpApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ratings", "BusinessID", "dbo.Businesses");
            DropIndex("dbo.Ratings", new[] { "BusinessID" });
            AddColumn("dbo.Businesses", "RatingID", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "Rating_RatingID", c => c.Int());
            AddColumn("dbo.Ratings", "Business_BusinessID", c => c.Int());
            AddColumn("dbo.Ratings", "Business_BusinessID1", c => c.Int());
            CreateIndex("dbo.Businesses", "Rating_RatingID");
            CreateIndex("dbo.Ratings", "Business_BusinessID");
            CreateIndex("dbo.Ratings", "Business_BusinessID1");
            AddForeignKey("dbo.Businesses", "Rating_RatingID", "dbo.Ratings", "RatingID");
            AddForeignKey("dbo.Ratings", "Business_BusinessID1", "dbo.Businesses", "BusinessID");
            AddForeignKey("dbo.Ratings", "Business_BusinessID", "dbo.Businesses", "BusinessID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "Business_BusinessID", "dbo.Businesses");
            DropForeignKey("dbo.Ratings", "Business_BusinessID1", "dbo.Businesses");
            DropForeignKey("dbo.Businesses", "Rating_RatingID", "dbo.Ratings");
            DropIndex("dbo.Ratings", new[] { "Business_BusinessID1" });
            DropIndex("dbo.Ratings", new[] { "Business_BusinessID" });
            DropIndex("dbo.Businesses", new[] { "Rating_RatingID" });
            DropColumn("dbo.Ratings", "Business_BusinessID1");
            DropColumn("dbo.Ratings", "Business_BusinessID");
            DropColumn("dbo.Businesses", "Rating_RatingID");
            DropColumn("dbo.Businesses", "RatingID");
            CreateIndex("dbo.Ratings", "BusinessID");
            AddForeignKey("dbo.Ratings", "BusinessID", "dbo.Businesses", "BusinessID", cascadeDelete: true);
        }
    }
}
