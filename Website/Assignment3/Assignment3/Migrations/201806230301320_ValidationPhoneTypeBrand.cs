namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationPhoneTypeBrand : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "CountryOfOrigin", c => c.String());
            AlterColumn("dbo.Phones", "PhoneName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Phones", "PhoneName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Brands", "CountryOfOrigin", c => c.String(nullable: false));
        }
    }
}
