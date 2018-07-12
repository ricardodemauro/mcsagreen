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

        public ActionResult Detalhe(int id)
        {
            Contato model = DataSource.Contatos[id];
            return View(model);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Contato model = DataSource.Contatos[id];
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(int id, Contato model)
        {
            DataSource.Contatos[0] = model;
            return RedirectToAction("Index");
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Contato model)
        {
            if (!ModelState.IsValid)
                return View(model);

            DataSource.Contatos.Add(model);
            return RedirectToAction("Index");
        }

    }
}