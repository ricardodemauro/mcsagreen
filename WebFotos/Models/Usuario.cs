using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFotos.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        [Required]
        [EmailAddress]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}