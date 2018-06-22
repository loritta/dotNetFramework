using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class PhoneType
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Type { get; set; }

        [Required]
        [StringLength(100)]
        public string OS { get; set; }
    }
}
/*
 ID
Type
OS
*/
