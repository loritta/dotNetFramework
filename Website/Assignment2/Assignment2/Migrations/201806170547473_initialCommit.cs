namespace Assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 200),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RentalRecords",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RentalDate = c.DateTime(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        MType = c.String(nullable: false, maxLength: 20),
                        ProductionYear = c.DateTime(nullable: false),
                        RentalRecord_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RentalRecords", t => t.RentalRecord_ID)
                .Index(t => t.RentalRecord_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentalRecords", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Media", "RentalRecord_ID", "dbo.RentalRecords");
            DropIndex("dbo.Media", new[] { "RentalRecord_ID" });
            DropIndex("dbo.RentalRecords", new[] { "Customer_ID" });
            DropTable("dbo.Media");
            DropTable("dbo.RentalRecords");
            DropTable("dbo.Customers");
        }
    }
}
