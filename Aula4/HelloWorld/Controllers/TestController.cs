using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class TestController : Controller
    {
        public string Xpto()
        {
            return "Bateu no método XPTO";
        }

        public ViewResult Xyz()
        {
            //acesso a dados

            //obter info webservice

            return View();
        }
    }
}
