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
        [Required (ErrorMessage ="Please enter the customer's name")]
        [StringLength(255)]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        public bool IsSubscribedToNewsletter { get; set; }
        //this is the reference to the class Membership inside the Customer

        public Membership Membership { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipID { get; set; }
        [Min18YearsIfMember]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }
    }
}