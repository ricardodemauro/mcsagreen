using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Samples.Controllers
{
    public class HomeController : AppControllerBase
    {
        public ActionResult Index()
        {
            return Ok();
        }
    }
}