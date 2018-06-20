namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteNameColumnInMembership : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Memberships DROP COLUMN Name");
        }
        
        public override void Down()
        {
        }
    }
}
