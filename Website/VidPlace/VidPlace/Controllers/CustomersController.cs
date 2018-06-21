using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using System.Data.Entity;
using VidPlace.ViewModels;

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
            return View(_context.Customers.Include(c=>c.Membership).ToList());
        }

        // GET: Customers/Detail
        public ActionResult Details(int ID)
        {
            //var customer = getCustomers().SingleOrDefault(c=>c.ID==ID);
            var customer = _context.Customers.Include(c=>c.Membership).SingleOrDefault(c => c.ID == ID);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
            
        }


        public ActionResult New()
        {
            //var customer = new Customer();
            var viewModel = new CustomerFromViewModel()
            {
                Memberships = _context.Memberships.ToList()
               
            };

            return View("CustomerForm", viewModel);
        }

        //Saving action into DB
        //Post action
        [HttpPost]
        public ActionResult Save(Customer customer )
        {
            //var customer = new Customer();
            var viewModel = new CustomerFromViewModel()
            {
                Memberships = _context.Memberships.ToList()

            };

            return View("CustomerForm", viewModel);
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