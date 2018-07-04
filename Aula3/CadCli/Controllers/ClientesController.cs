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
        private static List<Cliente> _clientes = new List<Cliente>()
        {
            new Cliente(){ Id=1, Nome="Priscila", Idade=39},
            new Cliente(){ Id=2, Nome="Raphael", Idade=18},
            new Cliente(){ Id=3, Nome="Fabiano", Idade=38},
            new Cliente(){ Id=4, Nome="Daniel", Idade=40},
        };

        public ActionResult Index()
        {
            return View(_clientes);
        }

        public ActionResult JsonClientes()
        {
            return Json(_clientes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PostCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
            return Json(cliente, JsonRequestBehavior.DenyGet);
        }
    }
}
