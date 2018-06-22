using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class PhoneController : Controller
    {
        private ApplicationDbContext _context;
        public List<PhoneType> PhoneTypes { get; private set; }
        public List<Brand> Brands{ get; private set; }

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
            var phone = _context.Phones.Include(p => p.Brand).Include(p => p.PhoneType).ToList();
            return View(phone);
        }

        // GET: Details
        /* to get the list of available phones and send it to the view*/
        public ActionResult Details(int ID)
        {
            var details = _context.Phones.Include(p => p.Brand).Include(p => p.PhoneType).SingleOrDefault(c => c.ID == ID);
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