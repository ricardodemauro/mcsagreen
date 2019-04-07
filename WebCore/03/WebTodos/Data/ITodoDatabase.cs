using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Models;

namespace WebTodos.Data
{
    public interface ITodoDatabase
    {
        List<Todo> GetAll();

        Todo GetById(string id);

        void AddTodo(Todo todo);

        void UpdateTodo(string id, Todo todo);
    }
}
