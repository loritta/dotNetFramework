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

        public List<Membership> Memberships { get; private set; }

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
            return View(_context.Customers.Include(c => c.Membership).ToList());
        }

        // GET: Customers/Detail
        public ActionResult Details(int ID)
        {
            //var customer = getCustomers().SingleOrDefault(c=>c.ID==ID);
            var customer = _context.Customers.Include(c => c.Membership).SingleOrDefault(c => c.ID == ID);
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
                Customer = new Customer(),
                Memberships = _context.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        //Saving action into DB
        //Post action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            //Server side validation
            if (!ModelState.IsValid)
            {
                //The form is not valid => return same form to the user
                var viewModel = new CustomerFromViewModel
                {
                    Customer = customer,
                    Memberships = _context.Memberships.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.ID == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDB = _context.Customers.Single(c => c.ID == customer.ID);
                /*
                 * TryUpdateModel(customerInDB);
                 * This method has a security flow
                */
                //Mannually update the field
                customerInDB.Name = customer.Name;
                customerInDB.Address = customer.Address;
                customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                customerInDB.MembershipID = customer.MembershipID;
                customerInDB.BirthDate = customer.BirthDate;
                
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        public ActionResult Edit(int ID)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.ID == ID);
            if (customerInDB == null)
                return HttpNotFound();

            var viewModel = new CustomerFromViewModel
            {
                Customer = customerInDB,
                Memberships = _context.Memberships.ToList()
            };
            return View("CustomerForm", viewModel);
        }

       /* private IEnumerable<Customer> getCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer(){ID=1,Name = "Thomas Edison"},
                new Customer(){ID=2,Name = "Mickey Mouse"},
                new Customer(){ID=3,Name = "Jimmy Poo"},
            };
            return customers;
        }*/

    }
}