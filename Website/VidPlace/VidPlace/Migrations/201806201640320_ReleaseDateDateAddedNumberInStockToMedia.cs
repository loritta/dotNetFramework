namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReleaseDateDateAddedNumberInStockToMedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Media", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Media", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Media", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Media", "Name", c => c.String());
            DropColumn("dbo.Media", "NumberInStock");
            DropColumn("dbo.Media", "DateAdded");
            DropColumn("dbo.Media", "ReleaseDate");
        }
    }
}
