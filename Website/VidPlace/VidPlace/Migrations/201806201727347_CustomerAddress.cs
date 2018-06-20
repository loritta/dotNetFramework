namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}
