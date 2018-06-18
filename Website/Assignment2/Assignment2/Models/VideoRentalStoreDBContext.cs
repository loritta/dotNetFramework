using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class VideoRentalStoreDBContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<RentalRecord> RentalRecords { get; set; }
    }
    
}