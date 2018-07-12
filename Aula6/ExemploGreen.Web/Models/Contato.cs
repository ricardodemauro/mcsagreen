using ExemploGreen.Web.Infraestrutura;
using ExemploGreen.Web.Infraestrutura.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Models
{
    public class Contato : IIdEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [DataType(DataType.PhoneNumber)]
        [PhoneValidation(ErrorMessage = "Telefone é inválido")]
        public string Telefone { get; set; }

        [Remote("CheckValidEmail", "BackOffice", ErrorMessage = "Email remote inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}