using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class CustomersController : Controller
    {
        //DB Context Object
        private ApplicationDbContext _context;

        //class Constructor
        //ctor -short for constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers/Index
        public ActionResult Index()
        {
            // return View(getCustomers());
            return View(_context.Customers.ToList());
        }

        // GET: Customers/Detail
        public ActionResult Details(int ID)
        {
            //var customer = getCustomers().SingleOrDefault(c=>c.ID==ID);
            var customer = _context.Customers.SingleOrDefault(c => c.ID == ID);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
            
        }

        private IEnumerable<Customer> getCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer(){ID=1,Name = "Thomas Edison"},
                new Customer(){ID=2,Name = "Mickey Mouse"},
                new Customer(){ID=3,Name = "Jimmy Poo"},
            };
            return customers;
        }
        
    }
}