using ExemploGreen.Web.App_LocalResources;
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

        [Required(ErrorMessageResourceName = "Obrigatorio", ErrorMessageResourceType = typeof(ValidationResources))]
        [MaxLength(10, ErrorMessageResourceName = "CampoTamanhoMaximo", ErrorMessageResourceType = typeof(ValidationResources))]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceName = "CampoObrigatorio", ErrorMessageResourceType = typeof(ValidationResources))]
        [MaxLength(10, ErrorMessageResourceName = "CampoTamanhoMaximo", ErrorMessageResourceType = typeof(ValidationResources))]
        public string Sobrenome { get; set; }

        [DataType(DataType.PhoneNumber)]
        //[PhoneValidation(ErrorMessage = "Telefone é inválido")]
        [Remote("CheckTelefone", "BackOffice")]
        public string Telefone { get; set; }

        [Remote("CheckValidEmail", "BackOffice")]
        //[EmailDomainValidator("@gmail.com")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public Endereco Endereco { get; set; }

        [UIHint("_Idade")]
        [Required(ErrorMessageResourceName = "CampoObrigatorio", ErrorMessageResourceType = typeof(ValidationResources))]
        [Range(10, 90, ErrorMessageResourceName = "CampoObrigatorio", ErrorMessageResourceType = typeof(ValidationResources))]
        public int Idade { get; set; }
    }
}