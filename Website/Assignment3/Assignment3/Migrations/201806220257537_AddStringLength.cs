namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStringLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "BrandName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Phones", "PhoneName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String());
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String());
            AlterColumn("dbo.Phones", "PhoneName", c => c.String(nullable: false));
            AlterColumn("dbo.Brands", "BrandName", c => c.String(nullable: false));
        }
    }
}
