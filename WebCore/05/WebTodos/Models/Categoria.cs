using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebTodos.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public virtual Collection<Todo> Todos { get; set; }
    }
}
