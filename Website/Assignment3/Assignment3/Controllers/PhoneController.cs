using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class PhoneController : Controller
    {
        private ApplicationDbContext _context;

        //class Constructor
        //ctor -short for constructor
        public PhoneController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Phone
        /* to get the list of available phones and send it to the view*/
        public ActionResult Index()
        {
            var phone = _context.Phones.ToList();
            return View(phone);
        }

        // GET: Details
        /* to get the list of available phones and send it to the view*/
        public ActionResult Details(int ID)
        {
            var details = _context.Phones.SingleOrDefault(c => c.ID == ID);
            if (details == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(details);
            }
        }
    }
}