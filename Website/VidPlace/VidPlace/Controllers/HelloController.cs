using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        //
        public ActionResult ActionResultDemo()
        {
            return HttpNotFound();
                //Content("Hello worl.. Germany lost yesterday... Yayy");
        }
        public ActionResult getCustomer()
        {
            Customer c = new Customer();
            c.ID = 1001;
            c.Name = "John";
            ViewData["customer"] = c;
            ViewBag.customer = c;
            return View();
            //Content("Hello worl.. Germany lost yesterday... Yayy");
        }
    }
}