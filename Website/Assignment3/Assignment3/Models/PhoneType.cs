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

        [Required(ErrorMessage = "Please enter the phone's type.")]
        [StringLength(10)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Please enter the phone's OS type.")]
        [StringLength(10)]
        public string OS { get; set; }
    }
}
/*
 ID
Type
OS
*/
