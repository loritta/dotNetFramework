using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    public class TimeTrackerRepository
    {
        TimwTrackerDBContext context = new TimwTrackerDBContext();
        //get all employees
        public List<Employee> GetEmployees()
        {
            return (from e in context.Employees select e).ToList();
        }

        //get all timecards
        public List<Timecard> GetTimecards(int emplID)
        {
            return (from e in context.Employees
                    where e.ID==emplID
                    select e.timeCards).SingleOrDefault();
        }
    }
}