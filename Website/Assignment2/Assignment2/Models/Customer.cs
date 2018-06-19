using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
     
        public List<RentalRecord> ListOfRentalRecords { get; set; }

        /*ID
         * First Name
        Last Name
        Address
        Phone number
        List of rental records*/
    }
}