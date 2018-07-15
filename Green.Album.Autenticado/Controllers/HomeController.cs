using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Green.Album.Autenticado.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Env = Environment.GetEnvironmentVariable("VAR_NAME");
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

        [Authorize]
        [HttpGet]
        public string Claims()
        {
            var identity = (ClaimsIdentity)User.Identity;

            StringBuilder sb = new StringBuilder();
            foreach (var claim in identity.Claims)
            {
                sb.Append($"{claim.Type} - {claim.Value} <br />");
            }
            return sb.ToString();
        }
    }
}