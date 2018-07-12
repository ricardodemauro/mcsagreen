using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{4,5}-\d{4}$", ErrorMessage = "{0} inválido")]
        public string Telefone { get; set; }

        [EmailAddress]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}