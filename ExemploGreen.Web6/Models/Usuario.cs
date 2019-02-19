using ExemploGreen.Web.Infraestrutura.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Models
{
    public class Usuario
    {
        [NomeValidator("ricardo", "ricardo2", NomeEspecial = "ricardo3", ErrorMessage = "Nome invalido")]
        public string Nome { get; set; }

        public bool Autenticado { get; set; }
    }
}