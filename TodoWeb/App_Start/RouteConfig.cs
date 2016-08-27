using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TodoWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Usuario", action = "Index", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
>>>>>>> 2a23c790ec42b50c3cdcc01fb0e519edbcd320be
            );
        }
    }
}
