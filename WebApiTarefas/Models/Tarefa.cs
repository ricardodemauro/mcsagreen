using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Finalizado { get; set; }
    }
}