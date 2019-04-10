using System;
using System.Collections.Generic;

namespace WebTodos
{
    public partial class Todos
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Done { get; set; }
        public string Categoria { get; set; }
    }
}
