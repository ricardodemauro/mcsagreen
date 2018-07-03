using CadCli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CadCli.Controllers
{
    public class ClientesController : Controller
    {
        public ActionResult Index()
        {
            //Acessar base de clientes
            var model = new List<Cliente>()
            {
                new Cliente(){ Id=1, Nome="Priscila", Idade=39},
                new Cliente(){ Id=2, Nome="Raphael", Idade=18},
                new Cliente(){ Id=3, Nome="Fabiano", Idade=38},
                new Cliente(){ Id=4, Nome="Daniel", Idade=40},
            };

            return View(model);
        }

        public ActionResult JsonClientes()
        {
            //Acessar base de clientes
            var model = new List<Cliente>()
            {
                new Cliente(){ Id=1, Nome="Priscila", Idade=39},
                new Cliente(){ Id=2, Nome="Raphael", Idade=18},
                new Cliente(){ Id=3, Nome="Fabiano", Idade=38},
                new Cliente(){ Id=4, Nome="Daniel", Idade=40},
            };

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
