using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTodos.Models;

namespace WebTodos.Data
{
    public class EFDatabase : IDatabase<WebTodos.Models.Todo>
    {
        private readonly WebTodosDbContext _db;

        public EFDatabase(WebTodosDbContext db)
        {
            _db = db;
        }

        public void Add(Todo todo)
        {
            _db.Todos.Add(todo);
            _db.SaveChanges();
        }

        public List<Todo> GetAll()
        {
            return _db.Todos.ToList();
        }

        public Todo GetById(string id)
        {
            return _db.Todos.Find(Guid.Parse(id));
        }

        public void Remove(string id)
        {
            var todoRemove = _db.Todos.Find(Guid.Parse(id));
            if (todoRemove != null)
            {
                _db.Todos.Remove(todoRemove);
                _db.SaveChanges();
            }
        }

        public void Update(string id, Todo todo)
        {
            _db.Todos.Update(todo);
            _db.SaveChanges();
        }
    }
}
