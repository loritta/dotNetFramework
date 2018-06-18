using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidPlace
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
           /* routes.MapRoute(
                name: "media-released",
                url: "media/released/{year}/{month}",
                defaults: new { controller = "Media", action = "Released" },
                constraints: new { year = @"\d{4}", month = @"\d{2}" }
                //"^(0?[1-9]|1[012])$"
            );

            routes.MapRoute(
                name: "media-index",
                url: "media/index/{pageIndex}/{sortBy}",
                defaults: new { controller = "Media", action = "Index" }
            );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
