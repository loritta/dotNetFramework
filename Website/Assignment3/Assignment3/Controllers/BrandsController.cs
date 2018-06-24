using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;
using Assignment3.ViewModels;

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
            var brands = _context.Brands.ToList();
            return View(brands);
        }


        //GET: Details
        /*
         to get list of phones with the specified brand*/
        public ActionResult AvailablePhones(int ID)
        {
            var viewModel = new PhoneBrandViewModel()
            {
                Brand = _context.Brands.Where(b => b.ID == ID).SingleOrDefault(),
                Phones = _context.Phones.Where(c => c.BrandID == ID).ToList()
            };
            ViewBag.MyQSVal = Request.QueryString["id"];
            return View("AvailablePhones", viewModel);
        }
        public ActionResult New()
        {
            var model =new Brand(); 

            return View("Edit", model);
        }

        //Saving action into DB
        //Post action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Brand brand)
        {
            //Server side validation
            if (!ModelState.IsValid)
            {
                //The form is not valid => return same form to the user
                var model = _context.Brands.SingleOrDefault();
                return View("Edit", model);
            }

            if (brand.ID == 0)
            {
                _context.Brands.Add(brand);
            }
            else
            {
                var brandInDB = _context.Brands.Single(c => c.ID == brand.ID);
                TryUpdateModel(brandInDB);

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Brands");
        }
        [Authorize]
        public ActionResult Edit(int ID)
        {
            var brandInDB = _context.Brands.SingleOrDefault(c => c.ID == ID);
            if (brandInDB == null)
                return HttpNotFound();
            return View("Edit", brandInDB);
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            var brand = _context.Brands.SingleOrDefault(m => m.ID == id);

            if (brand == null)
                return HttpNotFound();

            return View(brand);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var brandInDB = _context.Brands.Find(id);

            _context.Brands.Remove(brandInDB);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
