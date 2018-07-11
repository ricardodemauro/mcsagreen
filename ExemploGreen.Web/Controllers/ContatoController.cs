using ExemploGreen.Web.Data;
using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            return View(DataSource.Contatos);
        }

        public ActionResult ListaContato()
        {
            return View();
        }

        public ActionResult Detalhe()
        {
            Contato model = new Contato
            {
                Id = 1,
                Nome = "Contato Teste",
                Telefone = "1234"
            };
            return View(model);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Contato model)
        {
            DataSource.Contatos.Add(model);
            return RedirectToAction("Index");
        }




        [HttpGet]
        public ActionResult Editar()
        {
            Contato model = DataSource.Contatos[0];
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(Contato model)
        {
            DataSource.Contatos[0] = model;
            return RedirectToAction("Index");
        }
    }
}