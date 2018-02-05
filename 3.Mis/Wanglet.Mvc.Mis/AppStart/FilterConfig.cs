using System;
 
using System.Web.Mvc;

namespace Wanglet.Mvc.Mis.AppStart
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
