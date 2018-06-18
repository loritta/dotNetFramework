using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        /*public ActionResult Index()
        {
            return View();
        }*/
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
    }
}