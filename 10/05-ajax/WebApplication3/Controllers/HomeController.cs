using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private static List<Aluno> alunos = new List<Aluno>();

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
        public PartialViewResult MyPartialPost()
        {
            return PartialView();
        }
    }
}