using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFotos.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            return View();
        }
    }
}