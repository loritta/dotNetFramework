namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferenceToTheMediaOfTYPEandGENRE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Media", "Genre_ID", c => c.Int());
            AddColumn("dbo.Media", "MediaType_ID", c => c.Int());
            CreateIndex("dbo.Media", "Genre_ID");
            CreateIndex("dbo.Media", "MediaType_ID");
            AddForeignKey("dbo.Media", "Genre_ID", "dbo.Genres", "ID");
            AddForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes");
            DropForeignKey("dbo.Media", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            DropColumn("dbo.Media", "MediaType_ID");
            DropColumn("dbo.Media", "Genre_ID");
            DropTable("dbo.MediaTypes");
            DropTable("dbo.Genres");
        }
    }
}
