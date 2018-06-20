namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MediaTypeAndMediaGenreFKToMedia : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            DropColumn("dbo.Media", "GenreID");
            DropColumn("dbo.Media", "MediaTypeID");
            RenameColumn(table: "dbo.Media", name: "Genre_ID", newName: "GenreID");
            RenameColumn(table: "dbo.Media", name: "MediaType_ID", newName: "MediaTypeID");
            AlterColumn("dbo.Media", "MediaTypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Media", "GenreID", c => c.Int(nullable: false));
            CreateIndex("dbo.Media", "MediaTypeID");
            CreateIndex("dbo.Media", "GenreID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Media", new[] { "GenreID" });
            DropIndex("dbo.Media", new[] { "MediaTypeID" });
            AlterColumn("dbo.Media", "GenreID", c => c.String());
            AlterColumn("dbo.Media", "MediaTypeID", c => c.String());
            RenameColumn(table: "dbo.Media", name: "MediaTypeID", newName: "MediaType_ID");
            RenameColumn(table: "dbo.Media", name: "GenreID", newName: "Genre_ID");
            AddColumn("dbo.Media", "MediaTypeID", c => c.String());
            AddColumn("dbo.Media", "GenreID", c => c.String());
            CreateIndex("dbo.Media", "MediaType_ID");
            CreateIndex("dbo.Media", "Genre_ID");
        }
    }
}
