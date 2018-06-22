﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Phone
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Phone Name")]
        public string PhoneName { get; set; }

        public Brand Brand { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public int BrandID { get; set; }

        [Display(Name = "Date Released")]
        public DateTime DateReleased { get; set; }

        [Required]
        [Display(Name = "Screen Size")]
        public int ScreenSize { get; set; }

     
        public PhoneType PhoneType { get; set; }
        [Required]
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
