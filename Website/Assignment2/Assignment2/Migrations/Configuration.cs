namespace Assignment2.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Assignment2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Models.VideoRentalStoreDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment2.Models.VideoRentalStoreDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Medias.RemoveRange(context.Medias);
            context.RentalRecords.RemoveRange(context.RentalRecords);
            context.Customers.RemoveRange(context.Customers);
            
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer()
            {
                //ID = 1,
                FirstName = "Nicholas",
                LastName = "Boyen",
                Address = "123 Street Ave., Toronto, Ontario, Canada",
                PhoneNumber = "5141234567",

                ListOfRentalRecords = new List<RentalRecord>
                {
                     new RentalRecord
                    {
                        RentalDate = DateTime.Now,
                        ListOfRentedMedias = new List<Media>
                        {
                            new Media
                            {
                                Title = "Dispicable me",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2012")

                            },
                            new Media
                            {
                                Title = "Doctor House",
                                MType = "TV Series",
                                ProductionYear = DateTime.Parse("01/09/2008")

                            }

                        }
                    }

                }

            });

            customers.Add(new Customer()
            {
                //ID = 2,
                FirstName = "Larisa",
                LastName = "Sab",
                Address = "123 Street Ave., Montreal, Quebec, Canada",
                PhoneNumber = "4381234567",

                ListOfRentalRecords = new List<RentalRecord>
                {
                    new RentalRecord
                    {
                        RentalDate = DateTime.Now,
                        ListOfRentedMedias = new List<Media>
                        {
                            new Media
                            {
                                Title = "Avengers",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2017")

                            },
                            new Media
                            {
                                Title = "Mother",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2017")

                            },
                            new Media
                            {
                                Title = "Gladiator",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2006")

                            }

                        }
                    },
                    new RentalRecord
                    {
                        RentalDate = DateTime.Now,
                        ListOfRentedMedias = new List<Media>
                        {
                            new Media
                            {
                                Title = "Thor",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2017")

                            },
                            new Media
                            {
                                Title = "catch me if you can",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2017")

                            },
                            new Media
                            {
                                Title = "Apocalipsis",
                                MType = "Movie",
                                ProductionYear =  DateTime.Parse("01/09/2006")

                            }

                        }
                    }

                }

            });

            context.Customers.AddRange(customers);
            base.Seed(context);
        }
    }
}
