using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFotos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.SystemTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            return View();
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