using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeTracker.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [StringLength (100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string Department { get; set; }
        public List<Timecard> timeCards { get; set; }
        [Required]
        [StringLength(100)]
        public string Role { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        [Required]
        public DateTime DateOfHire { get; set; }

    }
}