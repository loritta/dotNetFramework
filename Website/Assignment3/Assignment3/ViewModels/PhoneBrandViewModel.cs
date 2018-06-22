using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment3.Models;

namespace Assignment3.ViewModels
{
    public class PhoneBrandViewModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public Brand Brand { get; set; }
    }
}