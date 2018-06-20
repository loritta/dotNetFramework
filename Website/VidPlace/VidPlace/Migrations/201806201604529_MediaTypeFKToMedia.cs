namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MediaTypeFKToMedia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Media", "MediaTypeID", c => c.String());
            AddColumn("dbo.Media", "MediaType_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Media", "MediaType_ID");
            AddForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes");
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            DropColumn("dbo.Media", "MediaType_ID");
            DropColumn("dbo.Media", "MediaTypeID");
            DropTable("dbo.MediaTypes");
        }
    }
}
