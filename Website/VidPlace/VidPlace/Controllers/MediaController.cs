using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;
using System.Data.Entity;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        //DB Context Object
        private ApplicationDbContext _context;

        //class Constructor
        //ctor -short for constructor
        public MediaController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Media
        /*public ActionResult Index()
        {
            return View();
        }*/
        public ActionResult IndexGetMedia()
        {
            //return View(getMedias());
            return View(_context.Media.Include(m => m.Genre).ToList());
        }

        // GET: \Media/Detail
        public ActionResult Details(int ID)
        {
            //var customer = getCustomers().SingleOrDefault(c=>c.ID==ID);
            var media = _context.Media
                .Include(m => m.Genre)
                .Include(m =>m.MediaType)
                .SingleOrDefault(m => m.ID == ID);
            if (media == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(media);
            }

        }


        [Route("media/index/{pageIndex?}/{sortBy?}")]

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content("Page # " + pageIndex + " | Sort by: " + sortBy);
        }


        // GET: Random
        public ActionResult Random()
        {
            var media = new Media();
            media.ID = 1001;
            media.Name = "John";
            return View(media);
        }


        //GET: Edit
        public ActionResult Edit(int ID)
        {
            return Content("ProviderID = " + ID);
        }


        //GET: Released

        [Route("media/released/{year:range(1920, 2020)}/{month}")]
        public ActionResult Released(int year, int month)
        {
            return Content("Year = " + year + ", Month = " + month );
        }


        public ActionResult Rentals()
        {
            var media = new Media() { Name = "Avengers" };
            var customers = new List<Customer>
            {
                new Customer(){Name = "Thomas Edison"},
                new Customer(){Name = "Mickey Mouse"},
                new Customer(){Name = "Jimmy Poo"},
            };
            var viewModel = new RenatalsMediaViewModel()
            {
            Media =media,
            Customers = customers};
            return View(viewModel);
        }


        private IEnumerable<Media> getMedias()
        {
            var medias = new List<Media>
            {
                new Media(){ID=1,Name = "Dispicable me"},
                new Media(){ID=2,Name = "How to train the dragon"},
                new Media(){ID=3,Name = "Oriental Express"},
            };
            return medias;
        }

    }
}