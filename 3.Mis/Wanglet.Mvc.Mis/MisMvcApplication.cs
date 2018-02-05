using System.Web.Routing;
using System.Web.Optimization;
using System.Web;
using System.Web.Mvc;
using Wanglet.Mvc.Mis.AppStart;

namespace Wanglet.Mvc.Mis
{
    public class MisMvcApplication:Wanglet.Mvc.MisMvcApplicationBase
    {

        protected override void OnStart()
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(HttpContext.Current.Server.MapPath("~/log4net.cfg.xml")));

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

       
    }
}
