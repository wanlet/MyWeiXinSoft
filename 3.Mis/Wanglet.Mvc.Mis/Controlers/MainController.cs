using System.Web;
using System.Web.Mvc;

namespace Wanglet.Mvc.Mis.Controlers
{
    public class MainController : Wanglet.Mvc.Common.MisBaseController
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            ViewData["SystemName"] = "系统名称";
            return View();
        }
    }
}
