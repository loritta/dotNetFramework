namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMediaTypesAndGenre : DbMigration
    {
        public override void Up()
        {
            //
            Sql("INSERT INTO MediaTypes"
                + "(Name)"
                + "VALUES('Movie')");
            //
            Sql("INSERT INTO MediaTypes"
                + "(Name)"
                + "VALUES('TVSeries')");
            //
            Sql("INSERT INTO MediaTypes"
                 + "(Name)"
                 + "VALUES('TVShow')");
           
            Sql("INSERT INTO MediaTypes"
                 + "(Name)"
                 + "VALUES('Documentary')");
            //
            Sql("INSERT INTO Genres"
                + "(Name)"
                + "VALUES('Comedy')");
            //
            Sql("INSERT INTO Genres"
                + "(Name)"
                + "VALUES('Tragedy')");
            //
            Sql("INSERT INTO Genres"
                + "(Name)"
                + "VALUES('Action')");
            //
            Sql("INSERT INTO Genres"
                + "(Name)"
                + "VALUES('Drama')");
            //
            Sql("INSERT INTO Genres"
                + "(Name)"
                + "VALUES('Horror')");
            //
            Sql("INSERT INTO Genres"
                + "(Name)"
                + "VALUES('Cartoon')");


        }

        public override void Down()
        {
        }
    }
}
