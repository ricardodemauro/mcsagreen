using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Models
{
    public class Todo
    {
        public Guid Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        public bool Done { get; set; }

        public string Categoria { get; set; }
    }
}
