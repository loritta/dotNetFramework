namespace TimeTracker.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TimeTracker.Models;
    

    internal sealed class Configuration : DbMigrationsConfiguration<TimeTracker.Models.TimwTrackerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeTracker.Models.TimwTrackerDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.TimeCards.RemoveRange(context.TimeCards);
            context.Employees.RemoveRange(context.Employees);
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee()
            {
                //ID = 1,
                FirstName = "Alex",
                LastName = "Sam",
                Department = "IT",
                Role = "Employee",
                Location = "Montreal",
                DateOfHire = DateTime.Now,
                timeCards = new List<Timecard>
                {
                    new Timecard
                    {
                        //ID=1,
                        SubmissionDate =DateTime.Now,
                        MondayHours = 8,
                        TuesdayHours = 6,
                        WednesdayHours = 7,
                        ThursdayHours = 3,
                        FridayHours = 7,
                        SaturdayHours = 0,
                        SundayHours = 0
                    },
                    new Timecard
                    {
                        //ID=2,
                        SubmissionDate =DateTime.Now,
                        MondayHours = 7,
                        TuesdayHours = 6,
                        WednesdayHours = 8,
                        ThursdayHours = 5,
                        FridayHours = 8,
                        SaturdayHours = 0,
                        SundayHours = 0
                    }
                }
            });

            employees.Add(new Employee()
            {
                //ID = 2,
                FirstName = "Larisa",
                LastName = "Sab",
                Department = "IT",
                Role="Manager",
                Location="Toronto",
                DateOfHire = DateTime.Now,
                timeCards = new List<Timecard>
                {
                    new Timecard
                    {
                        //ID=3,
                        SubmissionDate =DateTime.Now,
                        MondayHours = 7,
                        TuesdayHours = 7,
                        WednesdayHours = 8,
                        ThursdayHours = 4,
                        FridayHours = 9,
                        SaturdayHours = 0,
                        SundayHours = 0
                    },
                    new Timecard
                    {
                        //ID=4,
                        SubmissionDate =DateTime.Now,
                        MondayHours = 7,
                        TuesdayHours = 6,
                        WednesdayHours = 8,
                        ThursdayHours = 3,
                        FridayHours = 7,
                        SaturdayHours = 0,
                        SundayHours = 0
                    }
                }
            });

            context.Employees.AddRange(employees);
            base.Seed(context);
        }
    }
}
