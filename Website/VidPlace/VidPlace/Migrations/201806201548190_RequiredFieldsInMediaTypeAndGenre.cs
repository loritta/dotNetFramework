namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredFieldsInMediaTypeAndGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Media", "Genre_ID", "dbo.Genres");
            DropForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes");
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            AlterColumn("dbo.Media", "Genre_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Media", "MediaType_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.MediaTypes", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Media", "Genre_ID");
            CreateIndex("dbo.Media", "MediaType_ID");
            AddForeignKey("dbo.Media", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes");
            DropForeignKey("dbo.Media", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            AlterColumn("dbo.MediaTypes", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Media", "MediaType_ID", c => c.Int());
            AlterColumn("dbo.Media", "Genre_ID", c => c.Int());
            CreateIndex("dbo.Media", "MediaType_ID");
            CreateIndex("dbo.Media", "Genre_ID");
            AddForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes", "ID");
            AddForeignKey("dbo.Media", "Genre_ID", "dbo.Genres", "ID");
        }
    }
}
