using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Wanglet.Mvc.Mis.AppStart
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            string[] namespaces = new string[] { "Wanglet.Mvc.Mis.Controlers" };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Login", id = UrlParameter.Optional },
                namespaces: namespaces
            );
        }
    }
}
