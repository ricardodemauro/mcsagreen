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
        public TodoController()
        {

        }

        [LogActionFilter]
        public IActionResult Index([FromServices] IDatabase<Todo> database)
        {
            ViewBag.ServerTime = DateTime.Now;

            var todos = database.GetAll();
            return View(todos);
        }

        public IActionResult Edit(string id, [FromServices] IDatabase<Todo> database)
        {
            var todo = database.GetById(id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Edit(string id, Todo item, [FromServices] IDatabase<Todo> database)
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
        public IActionResult Create(Todo item, [FromServices] IDatabase<Todo> database)
        {
            database.Add(item);
            return RedirectToAction("Index");
        }

        private void BuildView()
        {
            using (WebTodosDbContext dbContext = new WebTodosDbContext())
            {
                var categorias = dbContext.Categorias.ToList();

                var options = new List<SelectListItem>();
                foreach (var cat in categorias)
                {
                    options.Add(new SelectListItem(cat.Descricao, cat.Id.ToString()));
                }
                ViewBag.CategoriaOptions = options;
            }
        }
    }
}