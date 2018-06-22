namespace Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePhoneTypes : DbMigration
    {
        public override void Up()
        {
            //1- Smart, Android
            Sql("INSERT INTO PhoneTypes"
               + "(Type, OS)"
               + "VALUES('Smart', 'Android')");

            //2 - Smart, iOS
            Sql("INSERT INTO PhoneTypes"
               + "(Type, OS)"
               + "VALUES('Smart', 'iOS')");

            //3- Bar, NA (not available)
            Sql("INSERT INTO PhoneTypes"
                + "(Type, OS)"
                + "VALUES('Bar', 'NA')");

           // 4 - Flip, NA
            Sql("INSERT INTO PhoneTypes"
               + "(Type, OS)"
               + "VALUES('Flip', 'NA')");
        }
        
        public override void Down()
        {
        }
    }
}
