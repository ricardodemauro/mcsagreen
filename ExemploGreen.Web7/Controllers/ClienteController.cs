using ExemploGreen.Web.Data;
using ExemploGreen.Web.Infraestrutura.Filters;
using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    //[Authorize]
    [AuditFilter]
    public class ClienteController : Controller
    {
        private readonly IDataSource<Cliente> dataSource;

        public ClienteController()
            : this(ClienteDataSource.GetInstance())
        {

        }

        public ClienteController(IDataSource<Cliente> dataSource)
        {
            this.dataSource = dataSource;
        }

        // GET: Cliente
        [AllowAnonymous]
        //[OutputCache(Duration = 30)]
        public ActionResult Index()
        {
            return View(dataSource.Get());
        }

        // GET: Cliente/Details/5
        [OutputCache(CacheProfile = "CP2")]
        public ActionResult Details(int id)
        {
            return View(dataSource.Get(id));
        }

        // GET: Cliente/Create
        //[RequireHttps]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome, Sobrenome, Telefone, Email, DataNascimento")] Cliente model)
        {
            if (ModelState.IsValid)
            {
                dataSource.Add(model);
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            LoadAdditionalData();
            return View(dataSource.Get(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "Id, Nome, Sobrenome, Telefone, Email, DataNascimento, HiddendField")] Cliente model)
        {
            if (ModelState.IsValid)
            {
                dataSource.Edit(model);
                return RedirectToAction("Index");
            }
            LoadAdditionalData();
            return View(model);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View(dataSource.Get(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cliente model)
        {
            if (ModelState.IsValid)
            {
                dataSource.Delete(model);
                return RedirectToAction("Index");
            }

            return View();
        }

        private void LoadAdditionalData()
        {
            // chamada no banco de dados
            ViewData["QualquerCoisa2"] = "Qualquer coisa tb 2";
            ViewBag.QualquerCoisa = "Qualquer coisa tb";
            ViewBag.DropDownNomes = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Nome 1",
                    Value = "N1"
                },
                new SelectListItem()
                {
                    Text = "Nome 2",
                    Value = "N2",
                    Selected = true
                },
            };
        }
    }
}
