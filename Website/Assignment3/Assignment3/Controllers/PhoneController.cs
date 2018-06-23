using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Assignment3.Models;
using Assignment3.ViewModels;

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
            var phone = _context.Phones.Include(p => p.Brand).ToList();
            return View(phone);
        }

        // GET: Details
        /* to get the list of available phones and send it to the view*/
        public ActionResult Details(int ID)
        {
            var details = _context.Phones
                .Include(p => p.Brand)
                .Include(p => p.PhoneType)
                .SingleOrDefault(p => p.ID == ID);
            if (details == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(details);
            }
        }

        public ActionResult New()
        {
            var viewModel = new PhoneFormViewModel()
            {
                Phone = new Phone(),
                PhoneTypes = _context.PhoneTypes.ToList(),
                Brands = _context.Brands.ToList()
            };

            return View("New", viewModel);
        }

        //Saving action into DB
        //Post action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Phone phone)
        {
            //Server side validation
            if (!ModelState.IsValid)
            {
                //The form is not valid => return same form to the user
                var viewModel = new PhoneFormViewModel()
                {
                    Phone = new Phone(),
                    PhoneTypes = _context.PhoneTypes.ToList(),
                    Brands = _context.Brands.ToList()
                };
                return View("New", viewModel);
            }

            if (phone.ID == 0)
            {
                _context.Phones.Add(phone);
            }
            else
            {
                var phoneInDB = _context.Phones.Single(c => c.ID == phone.ID);
                TryUpdateModel(phoneInDB);
                 

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Phone");
        }
        [Authorize]
        public ActionResult Edit(int ID)
        {
            var phoneInDB = _context.Phones.SingleOrDefault(c => c.ID == ID);
            if (phoneInDB == null)
                return HttpNotFound();

            var viewModel = new PhoneFormViewModel
            {

                Phone =phoneInDB,
                PhoneTypes = _context.PhoneTypes.ToList(),
                Brands = _context.Brands.ToList()
            };
            return View("New", viewModel);
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            var phone = _context.Phones.Include(m => m.PhoneType).SingleOrDefault(m => m.ID == id);

            if (phone == null)
                return HttpNotFound();

            return View(phone);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var phoneInDB = _context.Phones.Find(id);

            _context.Phones.Remove(phoneInDB);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}