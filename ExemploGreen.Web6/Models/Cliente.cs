using ExemploGreen.Web.Infraestrutura;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Models
{
    public class Cliente : IIdEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        public string Nome { get; set; }

        [Remote("CheckLastName", "BackOffice", ErrorMessage = "Nao gostei")]
        public string Sobrenome { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{4,5}-\d{4}$", ErrorMessage = "{0} inválido. Formator deverá ser {1}")]
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}