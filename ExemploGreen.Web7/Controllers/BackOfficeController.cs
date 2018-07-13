using ExemploGreen.Web.Infraestrutura.Filters;
using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    //[DumbAuditFilter]
    public class BackOfficeController : Controller
    {
        [DumbAuditFilter]
        public JsonResult CheckValidEmail(string email)
        {
            bool isValid = email.EndsWith("@green.com.br");
            return Json(isValid, JsonRequestBehavior.AllowGet);
        }
        private readonly Regex phoneRegex = new Regex(@"^\d{4,5}-\d{4}$", RegexOptions.Compiled);

        public JsonResult CheckTelefone(string telefone)
        {
            return Json(phoneRegex.IsMatch(telefone), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Autenticar()
        {
            Session["auth"] = true;
            return RedirectToActionPermanent("Index", "Contato");
        }

        public PartialViewResult AuthMenuPartial()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "Aluno";
            usuario.Autenticado = true;
            return PartialView("_MenuAuthenticated", usuario);
        }

        public ActionResult HtmlHelpers()
        {
            return View();
        }

        public string CurrentCulture()
        {
            return $"Culture {CultureInfo.CurrentCulture.Name} - CultureUI {CultureInfo.CurrentUICulture.Name}";
        }
    }
}