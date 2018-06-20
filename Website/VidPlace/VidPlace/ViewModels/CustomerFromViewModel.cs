using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class CustomerFromViewModel
    {
        public Customer Customers { get; set; }
        public IEnumerable< Membership> Memberships { get; set; }
    }
}