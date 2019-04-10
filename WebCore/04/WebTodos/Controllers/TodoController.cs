using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTodos.Data;
using WebTodos.Infra;
using WebTodos.Models;

namespace WebTodos.Controllers
{
    public class TodoController : Controller
    {
        private IDatabase<Todo> database;

        public TodoController(IDatabase<Todo> database)
        {
            this.database = database;
        }

        [LogActionFilter]
        public IActionResult Index()
        {
            ViewBag.ServerTime = DateTime.Now;

            var todos = database.GetAll();
            return View(todos);
        }

        public IActionResult Edit(string id)
        {
            var todo = database.GetById(id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Edit(string id, Todo item)
        {
            database.Update(id, item);
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
            ModelState.AddModelError("Categoria", "Deu ruim aqui hein");


            if (ModelState.IsValid == false)
            {
                BuildView();
                return View(item);
            }
            database.Add(item);
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