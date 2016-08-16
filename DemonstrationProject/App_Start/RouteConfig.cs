using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemonstrationProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CustomerBill",
                url: "CustomerBill",
                defaults: new { controller = "Bill", action = "Index"}
            );

            routes.MapRoute(
                name: "FilmShowTimes",
                url: "FilmShowTimes",
                defaults: new { controller = "FilmShowTime", action = "Index" }
            );

            routes.MapRoute(
                name: "ReactFilmShowTimes",
                url: "ReactFilmShowTimes",
                defaults: new { controller = "FilmShowTime", action = "Showtimes" }
            );
        }
    }
}