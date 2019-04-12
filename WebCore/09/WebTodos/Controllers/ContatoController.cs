using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTodos.Data;
using WebTodos.Models;

namespace WebTodos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IDatabase<Contato, Guid> _db;

        public ContatoController(IDatabase<Contato, Guid> db)
        {
            _db = db;
        }

        // GET: Contato
        public ActionResult Index()
        {
            return View(_db.GetAll());
        }

        // GET: Contato/Details/5
        public ActionResult Details(string id)
        {
            return View(_db.GetById(Guid.Parse(id)));
        }

        // GET: Contato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contato formData)
        {
            if (ModelState.IsValid)
            {
                _db.Add(formData);

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Contato/Edit/5
        public ActionResult Edit(string id)
        {
            return View(_db.GetById(Guid.Parse(id)));
        }

        // POST: Contato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Contato formData)
        {
            if (ModelState.IsValid)
            {
                _db.Update(Guid.Parse(id), formData);

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Contato/Delete/5
        public ActionResult Delete(string id)
        {
            return View(_db.GetById(Guid.Parse(id)));
        }

        // POST: Contato/Delete/5
        [HttpPost("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(string id)
        {
            _db.Remove(Guid.Parse(id));
            return RedirectToAction(nameof(Index));
        }
    }
}