﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTodos.Data;
using WebTodos.Infra;
using WebTodos.Models;

namespace WebTodos.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
        public TodoController()
        {

        }

        [LogActionFilter]
        public IActionResult Index([FromServices] IDatabase<Todo, Guid> database)
        {
            ViewBag.ServerTime = DateTime.Now;

            var todos = database.GetAll();
            return View(todos);
        }

        public IActionResult Edit(string id, [FromServices] IDatabase<Todo, Guid> database)
        {
            var todo = database.GetById(Guid.Parse(id));
            return View(todo);
        }

        [HttpPost]
        public IActionResult Edit(string id, Todo item, [FromServices] IDatabase<Todo, Guid> database)
        {
            database.Update(Guid.Parse(id), item);
            return RedirectToAction("Index");
        }

        public IActionResult Create([FromServices] WebTodosDbContext dbContext)
        {
            BuildView(dbContext);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Todo item, [FromServices] IDatabase<Todo, Guid> database)
        {
            database.Add(item);
            return RedirectToAction("Index");
        }

        private void BuildView(WebTodosDbContext dbContext)
        {
            var categorias = dbContext.Categorias.ToList();

            var options = new List<SelectListItem>();
            foreach (var cat in categorias)
            {
                options.Add(new SelectListItem(cat.Descricao, cat.Descricao));
            }
            ViewBag.CategoriaOptions = options;
        }
    }
}