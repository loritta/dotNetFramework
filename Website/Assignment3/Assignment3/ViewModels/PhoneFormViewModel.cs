using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment3.Models;

namespace Assignment3.ViewModels
{
    public class PhoneFormViewModel
    {
        public Phone Phone { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<PhoneType> PhoneTypes { get; set; }
    }
}