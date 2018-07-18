using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Samples.Controllers
{
    public abstract class AppControllerBase : Controller
    {
        public ActionResult Ok()
        {
            return View();
        }
    }
}