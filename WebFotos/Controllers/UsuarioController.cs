using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFotos.Models;

namespace WebFotos.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Usuario usuario)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            if (usuario.Login != "admin@admin.com")
            {
                //deu ruim
                ModelState.AddModelError("Login", "usuário inválido");
                return View();
            }
            if (usuario.Senha != "admin")
            {
                //deu ruim de novo
                ModelState.AddModelError("Senha", "usuário inválido");
                return View();
            }

            //return View();
            return RedirectToAction("Listar", "Foto");
        }

        public ActionResult LogOut()
        {
            return View();
        }
    }
}