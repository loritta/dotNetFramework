namespace TimeTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRoleAndLocationToEmployeeClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Role", c => c.String());
            AddColumn("dbo.Employees", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Location");
            DropColumn("dbo.Employees", "Role");
        }
    }
}
