namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            AlterColumn("dbo.Albums", "ArtistId", c => c.Int(nullable: false));
            AlterColumn("dbo.Songs", "AlbumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Albums", "ArtistId");
            AddForeignKey("dbo.Albums", "ArtistId", "dbo.Artists", "ArtistId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            AlterColumn("dbo.Songs", "AlbumId", c => c.Int());
            AlterColumn("dbo.Albums", "ArtistId", c => c.Int());
            CreateIndex("dbo.Albums", "ArtistId");
            AddForeignKey("dbo.Albums", "ArtistId", "dbo.Artists", "ArtistId");
        }
    }
}
