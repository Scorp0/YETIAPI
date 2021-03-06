﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YETIAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Person",
                url: "{Person}/{action}/{id}",
                defaults: new { controller = "Person", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Role",
                url: "{role}/{action}/{id}",
                defaults: new { controller = "Role", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Event",
                url: "event/{action}/{id}",
                defaults: new { controller = "Event", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
