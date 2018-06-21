using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class BrandsController : Controller
    {
        
        private ApplicationDbContext _context;

        //class Constructor
        //ctor -short for constructor
        public BrandsController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Brands
        /*to get the list of available brands */
        public ActionResult Index()
        {
            var brands = _context.Brand.ToList();
            return View(brands);
        }


        //GET: Details
        /*
         to get list of phones with the specified brand*/
        public ActionResult AvailablePhones(int ID)
        {
            var details = _context.Brand.SingleOrDefault(c => c.ID == ID);
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