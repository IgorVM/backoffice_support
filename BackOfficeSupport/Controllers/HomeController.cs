using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "О нас";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Где нас найти";

            return View();
        }

        public ActionResult LeaveMessage()
        {
            ViewBag.Message = "Оставить заявку о неисправности или пожелание";

            return View();
        }
    }
}
