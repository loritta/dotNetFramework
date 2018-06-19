namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonth = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "MembershipID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipID");
            AddForeignKey("dbo.Customers", "MembershipID", "dbo.Memberships", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipID", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipID" });
            DropColumn("dbo.Customers", "MembershipID");
            DropTable("dbo.Memberships");
        }
    }
}
