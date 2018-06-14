using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    public class TimwTrackerDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Timecard> TimeCards { get; set; }
    }
}