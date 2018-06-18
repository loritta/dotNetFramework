using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class RentalRecord
    {
        public int ID { get; set; }
        [Required]
        public DateTime RentalDate { get; set; }
        [Required]
        
        public List<Media> ListOfRentedMedias { get; set; }

        /*ID
        Rental Date
        List of rented Media
        */
    }

}