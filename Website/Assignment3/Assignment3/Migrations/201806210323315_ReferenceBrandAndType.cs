namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReferenceBrandAndType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        OS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Phones", "BrandID");
            CreateIndex("dbo.Phones", "PhoneTypeID");
            AddForeignKey("dbo.Phones", "BrandID", "dbo.Brands", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Phones", "PhoneTypeID", "dbo.PhoneTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "PhoneTypeID", "dbo.PhoneTypes");
            DropForeignKey("dbo.Phones", "BrandID", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "PhoneTypeID" });
            DropIndex("dbo.Phones", new[] { "BrandID" });
            DropTable("dbo.PhoneTypes");
        }
    }
}
