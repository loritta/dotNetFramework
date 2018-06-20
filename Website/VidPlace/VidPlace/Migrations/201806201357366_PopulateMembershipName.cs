namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("update Memberships set Name = "
               + "'Pay as you go' where ID=1");
            //Monthly
            Sql("update Memberships set Name ="
               + "'Monthly'where ID=2");
            //Quarterly
            Sql("update Memberships set Name ="
               + "'Quarterly' where ID=3");
            //Annual
            Sql("update Memberships set Name ="
               + "'Annual' where ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
