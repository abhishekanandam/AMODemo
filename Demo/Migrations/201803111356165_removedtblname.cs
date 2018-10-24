namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedtblname : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblSoloArtist", "ArtistID", "dbo.tblArtist");
            DropIndex("dbo.tblSoloArtist", new[] { "ArtistID" });
            AddColumn("dbo.tblArtist", "Instrument", c => c.String());
            AddColumn("dbo.tblArtist", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.tblSoloArtist");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblSoloArtist",
                c => new
                    {
                        ArtistID = c.Int(nullable: false),
                        Instrument = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            DropColumn("dbo.tblArtist", "Discriminator");
            DropColumn("dbo.tblArtist", "Instrument");
            CreateIndex("dbo.tblSoloArtist", "ArtistID");
            AddForeignKey("dbo.tblSoloArtist", "ArtistID", "dbo.tblArtist", "ArtistID");
        }
    }
}
