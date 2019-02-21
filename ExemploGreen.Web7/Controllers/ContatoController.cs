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
        private readonly IDataSource<Contato> dataSource;

        public ContatoController()
            : this(ContatoDataSource.GetInstance())
        {

        }

        public ContatoController(IDataSource<Contato> dataSource)
        {
            this.dataSource = dataSource;
        }

        // GET: Contato
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            return View(dataSource.Get());
        }

        public ActionResult Detalhe(int id)
        {
            Contato model = dataSource.Get(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Contato model = dataSource.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(int id, Contato model)
        {
            dataSource.Edit(model);
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

            dataSource.Add(model);
            return RedirectToAction("Index");
        }

    }
}