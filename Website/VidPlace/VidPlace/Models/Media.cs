using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Media
    {
        public int ID { get; set; }

        [Required]
        [StringLength (255)]
        public string Name { get; set; }
        
        [Required]
        public MediaType MediaType { get; set; }

        [Display(Name = "Media Type")]
        public int MediaTypeID { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public int GenreID { get; set; }

        [Required]
        [Display(Name = "Date of release")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "The date it was added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }
    }
}