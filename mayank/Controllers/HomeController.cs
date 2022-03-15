using mayank.dbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mayank.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            MCAEntities obj = new MCAEntities();
            var res = obj.courses.ToList();
            return View(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}