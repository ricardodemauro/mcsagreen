using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Infra;
using WebTodos.Infra.Models;

namespace WebTodos.Models
{
    public class Contato : IDbEntity
    {
        public Guid Id { get; set; }

        [Display(Name = "Nombre")]
        public string Nome { get; set; }

        [Display(Name = "Mobile")]
        public string Telefone { get; set; }

        //public decimal? Latitude { get; set; }

        //public decimal? Longitude { get; set; }

        public Location Location { get; set; }
    }
}
