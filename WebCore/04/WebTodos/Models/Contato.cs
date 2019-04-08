using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Infra;

namespace WebTodos.Models
{
    public class Contato : IDbEntity
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public GeoLocation Location { get; set; }
    }
}
