using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Phone
    {
        public int ID { get; set; }

        
        [StringLength(255)]
        [Required(ErrorMessage = "Please enter the phone's name.")]
        [Display(Name = "Phone Name")]
        public string PhoneName { get; set; }

        public Brand Brand { get; set; }

        [Required(ErrorMessage = "Please enter the phone's brand.")]
        [Display(Name = "Brand")]
        public int BrandID { get; set; }

        [Display(Name = "Date Released")]
        public DateTime DateReleased { get; set; }
        
        [Display(Name = "Screen Size")]
        [Range(2,7,ErrorMessage ="Screen size should be between 2 and 7.")]
        public int ScreenSize { get; set; }

     
        public PhoneType PhoneType { get; set; }
        [Required(ErrorMessage = "Please enter the phone's type.")]
        [Display(Name = "Phone Type")]
        public int PhoneTypeID { get; set; }
    }
}
/*
PhoneName
Brand
DateReleased
ScreenSize
PhoneType*/
