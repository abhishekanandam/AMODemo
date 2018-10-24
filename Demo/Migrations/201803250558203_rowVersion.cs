namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rowVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblArtist", "RowVersions", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblArtist", "RowVersions");
        }
    }
}
