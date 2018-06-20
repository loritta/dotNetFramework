﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Genre
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Movie Genre")]
        public string Name { get; set; }
    }
}