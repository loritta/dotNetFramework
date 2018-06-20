namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreAndMediaType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "MediaTypeID", c => c.String());
            AddColumn("dbo.Media", "GenreID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Media", "GenreID");
            DropColumn("dbo.Media", "MediaTypeID");
        }
    }
}
