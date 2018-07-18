using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult MyPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MyPartialPost(Foto foto)
        {
            return PartialView(foto);
        }

        public PartialViewResult GetPartialResult()
        {
            return PartialView("FotoPartailView");
        }
    }
}