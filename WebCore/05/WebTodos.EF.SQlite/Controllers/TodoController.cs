using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTodos.EF.SQlite.Data;
using WebTodos.EF.SQlite.Infra;
using WebTodos.EF.SQlite.Models;

namespace WebTodos.EF.SQlite.Controllers
{
    public class TodoController : Controller
    {
        //private IDatabase<Todo> database;
        private readonly TodoDbContext _db;

        public TodoController(TodoDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.ServerTime = DateTime.Now;

            var todos = _db.Todos.ToList();
            return View(todos);
        }

        public IActionResult Edit(string id)
        {
            var todo = _db.Todos.Find(id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Edit(string id, Todo item)
        {
            _db.Todos.Update(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            BuildView();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Todo item)
        {
            _db.Todos.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        private void BuildView()
        {
            var options = new SelectListItem[]
            {
                new SelectListItem("familia", "familia"),
                new SelectListItem("trabalho", "trabalho"),
                new SelectListItem("estudo", "estudo")
            };

            ViewBag.CategoriaOptions = options;
        }
    }
}