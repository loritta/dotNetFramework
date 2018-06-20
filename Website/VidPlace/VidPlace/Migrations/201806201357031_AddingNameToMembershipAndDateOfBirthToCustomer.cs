namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNameToMembershipAndDateOfBirthToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            AddColumn("dbo.Memberships", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memberships", "Name");
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
