namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FavoriteSongs",
                c => new
                    {
                        FavoriteSongId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SongId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FavoriteSongId)
                .ForeignKey("dbo.Songs", t => t.SongId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SongId);
            
            AddColumn("dbo.Albums", "Genre", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavoriteSongs", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteSongs", "SongId", "dbo.Songs");
            DropIndex("dbo.FavoriteSongs", new[] { "SongId" });
            DropIndex("dbo.FavoriteSongs", new[] { "UserId" });
            DropColumn("dbo.Albums", "Genre");
            DropTable("dbo.FavoriteSongs");
        }
    }
}
