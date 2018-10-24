namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artistdetailsmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblArtistDetails",
                c => new
                    {
                        ArtistID = c.Int(nullable: false),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.tblArtist", t => t.ArtistID)
                .Index(t => t.ArtistID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblArtistDetails", "ArtistID", "dbo.tblArtist");
            DropIndex("dbo.tblArtistDetails", new[] { "ArtistID" });
            DropTable("dbo.tblArtistDetails");
        }
    }
}
