using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    public class BackOfficeController : Controller
    {
        // GET: BackOffice/CheckValidEmail
        public JsonResult CheckValidEmail(string email)
        {
            bool isValid = email.EndsWith("@green.com.br");
            return Json(isValid, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Autenticar()
        {
            Session["auth"] = true;
            return RedirectToActionPermanent("Index", "Contato");
        }

        public PartialViewResult AuthMenuPartial()
        {
            return PartialView("_MenuAuthenticated", true);
        }
    }
}