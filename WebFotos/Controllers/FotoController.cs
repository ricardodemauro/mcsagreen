using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFotos.Controllers
{
    public class FotoController : Controller
    {
        // GET: Foto
        public ActionResult Listar()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }
    }
}