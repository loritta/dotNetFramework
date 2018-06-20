namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixbuginDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Media", "Genre_ID", "dbo.Genres");
            DropForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes");
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            DropColumn("dbo.Media", "MediaTypeID");
            DropColumn("dbo.Media", "GenreID");
            DropColumn("dbo.Media", "Genre_ID");
            DropColumn("dbo.Media", "MediaType_ID");
            DropTable("dbo.Genres");
            DropTable("dbo.MediaTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Media", "MediaType_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Media", "Genre_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Media", "GenreID", c => c.String());
            AddColumn("dbo.Media", "MediaTypeID", c => c.String());
            CreateIndex("dbo.Media", "MediaType_ID");
            CreateIndex("dbo.Media", "Genre_ID");
            AddForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Media", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
        }
    }
}
