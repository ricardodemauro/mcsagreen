using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        public TodoController()
        {

        }

        [HttpGet()]
        public IActionResult Get([FromServices] IDatabase<Todo> database)
        {
            ViewBag.ServerTime = DateTime.Now;

            var todos = database.GetAll();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id, [FromServices] IDatabase<Todo> database)
        {
            var todo = database.GetById(id);

            if (todo == null)
                return NotFound();

            return Ok(todo);
        }


        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] string id, [FromBody] Todo item, [FromServices] IDatabase<Todo> database)
        {
            //var todo = database.GetById(id);
            //if (todo == null)
            //    return NotFound();

            database.Update(id, item);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] string id, [FromServices] IDatabase<Todo> database)
        {
            //var todo = database.GetById(id);
            //if (todo == null)
            //    return NotFound();

            database.Remove(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Todo item, [FromServices] IDatabase<Todo> database)
        {
            database.Add(item);
            return CreatedAtAction("Get", new { id = item.Id });
        }
    }
}