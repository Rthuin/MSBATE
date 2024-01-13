namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "AlbumCover", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "AlbumCover");
        }
    }
}
