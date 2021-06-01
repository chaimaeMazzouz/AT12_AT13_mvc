using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AT12_projet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Chauffeur", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Chauffeur",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Chauffeur", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                           name: "Vehicules",
                           url: "{controller}/{action}/{id}",
                           defaults: new { controller = "Vehicules", action = "Index", id = UrlParameter.Optional }
                       );

        }
    }
}
