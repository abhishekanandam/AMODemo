namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manytomanyrelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblReviewer",
                c => new
                    {
                        ReviewerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ReviewerID);
            
            CreateTable(
                "dbo.ReviewerAlbums",
                c => new
                    {
                        Reviewer_ReviewerID = c.Int(nullable: false),
                        Album_AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reviewer_ReviewerID, t.Album_AlbumId })
                .ForeignKey("dbo.tblReviewer", t => t.Reviewer_ReviewerID, cascadeDelete: true)
                .ForeignKey("dbo.tblAlbum", t => t.Album_AlbumId, cascadeDelete: true)
                .Index(t => t.Reviewer_ReviewerID)
                .Index(t => t.Album_AlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewerAlbums", "Album_AlbumId", "dbo.tblAlbum");
            DropForeignKey("dbo.ReviewerAlbums", "Reviewer_ReviewerID", "dbo.tblReviewer");
            DropIndex("dbo.ReviewerAlbums", new[] { "Album_AlbumId" });
            DropIndex("dbo.ReviewerAlbums", new[] { "Reviewer_ReviewerID" });
            DropTable("dbo.ReviewerAlbums");
            DropTable("dbo.tblReviewer");
        }
    }
}
