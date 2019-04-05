using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Models;

namespace WebTodos.Data
{
    public class InMemoryTodoDatabase : ITodoDatabase
    {
        private readonly List<Todo> _db;

        public InMemoryTodoDatabase()
        {
            _db = new List<Todo>();
        }

        public void AddTodo(Todo todo)
        {
            _db.Add(todo);
        }

        public List<Todo> GetAll()
        {
            return _db.ToList();
        }

        public Todo GetById(string id)
        {
            Guid otherId = Guid.Parse(id);
            return _db.FirstOrDefault(c => c.Id.CompareTo(otherId) == 0);
        }

        public void UpdateTodo(string id, Todo todo)
        {
            Guid otherId = Guid.Parse(id);
            var index = _db.FindIndex(x => x.Id.CompareTo(otherId) == 0);
            if (index >= 0)
            {
                _db[index] = todo;
            }
        }
    }
}
