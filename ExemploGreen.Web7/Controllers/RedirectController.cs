using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            TempData["Info"] = DateTime.Now.ToString();

            TempData["InfoDeNovo"] = DateTime.Now.ToString();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Index2()
        {
            return RedirectToAction("Detalhe", "Contato", new { id = 0 });
        }
    }
}
