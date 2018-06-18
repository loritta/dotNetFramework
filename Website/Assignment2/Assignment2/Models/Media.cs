using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Media
    {
        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(20)]
        public string MType { get; set; }
        [Required]
        public DateTime ProductionYear { get; set; }

        /*ID
        Title
        Type (Movies, TV Show,. Etc.)
        Production Year
         */
    }
}