using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Brand
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Required]
        [Display(Name = "Country of Origin")]
        public string CountryOfOrigin { get; set; }
    }
}
/*
ID
BrandName
CountryOfOrigin
*/
