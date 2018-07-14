using ExemploGreen.Web.App_LocalResources;
using ExemploGreen.Web.Infraestrutura;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Models
{
    public class Cliente : IIdEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "CampoInvalido", ErrorMessageResourceType = typeof(AppValidationResource))]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{4,5}-\d{4}$", ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public string HiddendField { get; set; }
    }
}