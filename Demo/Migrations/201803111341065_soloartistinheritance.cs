namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class soloartistinheritance : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.tblArtist",
            //    c => new
            //        {
            //            ArtistID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.tblSoloArtist",
                c => new
                    {
                        ArtistID = c.Int(nullable: false),
                        Instrument = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.tblArtist", t => t.ArtistID)
                .Index(t => t.ArtistID);
            
            //DropTable("dbo.tblArtist");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.tblArtist",
            //    c => new
            //        {
            //            ArtistID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.ArtistID);
            
            DropForeignKey("dbo.tblSoloArtist", "ArtistID", "dbo.tblArtist");
            DropIndex("dbo.tblSoloArtist", new[] { "ArtistID" });
            DropTable("dbo.tblSoloArtist");
            ///DropTable("dbo.tblArtist");
        }
    }
}
