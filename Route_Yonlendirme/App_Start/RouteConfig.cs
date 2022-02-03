using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Route_Yonlendirme
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{controller}/Index");
            routes.IgnoreRoute("u/{username}");
            routes.IgnoreRoute("{controller}/UserDetail");
            routes.MapRoute(
                name: "About",
                url: "About",
                defaults: new { controller = "Home", action = "About" }
            );
            routes.MapRoute(
                name: "Register",
                url: "Register",
                defaults: new { controller = "Account", action = "Register" }
            );
            routes.MapRoute(
                name: "Contact",
                url: "ContactUs",
                defaults: new { controller = "Home", action = "Contact" }
            );
            routes.MapRoute(
                name: "UserDetail",
                url: "u/{username}",
                defaults: new { controller = "Account", action = "UserDetail" }
            );
            routes.MapRoute(
                name: "Demo",
                url: "Demo",
                defaults: new { controller = "Account", action = "UserDetail" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
