namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemebershipTypes : DbMigration
    {
        public override void Up()
        {
            //Pay as you go
            Sql("INSERT INTO Memberships"
                + "(ID, SignUpFee, DurationInMonth, DiscountRate)"
                + "VALUES(1,0,0,0)");
            //Monthly
            Sql("INSERT INTO Memberships"
               + "(ID, SignUpFee, DurationInMonth, DiscountRate)"
               + "VALUES(2,10,1,10)");
            //Quarterly
            Sql("INSERT INTO Memberships"
               + "(ID, SignUpFee, DurationInMonth, DiscountRate)"
               + "VALUES(3,30,3,15)");
            //Annual
            Sql("INSERT INTO Memberships"
               + "(ID, SignUpFee, DurationInMonth, DiscountRate)"
               + "VALUES(4,100,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
