namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "BrandName", c => c.String(nullable: false));
            AlterColumn("dbo.Brands", "CountryOfOrigin", c => c.String(nullable: false));
            AlterColumn("dbo.Phones", "PhoneName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "PhoneName", c => c.String());
            AlterColumn("dbo.Brands", "CountryOfOrigin", c => c.String());
            AlterColumn("dbo.Brands", "BrandName", c => c.String());
        }
    }
}
