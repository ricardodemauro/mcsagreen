using ExemploGreen.Web.Data;
using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
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
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View(dataSource.Get(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente model)
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
            return View(dataSource.Get(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente model)
        {
            if (ModelState.IsValid)
            {
                dataSource.Edit(model);
                return RedirectToAction("Index");
            }

            return View();
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
    }
}
