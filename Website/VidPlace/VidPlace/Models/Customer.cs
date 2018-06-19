using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Customer
    {

        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public bool IsSubscribedToNewsletter { get; set; }

        public Membership Membership { get; set; }
        public byte MembershipID { get; set; }
    }
}