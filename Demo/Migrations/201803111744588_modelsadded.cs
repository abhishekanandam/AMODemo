namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblAlbum", "AlbumArtUrl", c => c.String());
            AddColumn("dbo.tblAlbum", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.tblAlbum", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblAlbum", "Price");
            DropColumn("dbo.tblAlbum", "GenreId");
            DropColumn("dbo.tblAlbum", "AlbumArtUrl");
        }
    }
}
