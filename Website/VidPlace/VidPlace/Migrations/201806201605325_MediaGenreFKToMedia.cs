namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MediaGenreFKToMedia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Media", "GenreID", c => c.String());
            AddColumn("dbo.Media", "Genre_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Media", "Genre_ID");
            AddForeignKey("dbo.Media", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            DropColumn("dbo.Media", "Genre_ID");
            DropColumn("dbo.Media", "GenreID");
            DropTable("dbo.Genres");
        }
    }
}
