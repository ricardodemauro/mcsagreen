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

        [Required(ErrorMessage = "Algo de errado")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Ultrapassou tamanho máximo")]
        public string Sobrenome { get; set; }

        [DataType(DataType.PhoneNumber)]
        //[PhoneValidation(ErrorMessage = "Telefone é inválido")]
        [Remote("CheckTelefone", "BackOffice")]
        public string Telefone { get; set; }

        //[Remote("CheckValidEmail", "BackOffice")]
        [EmailDomainValidator("@gmail.com")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public Endereco Endereco { get; set; }

        [UIHint("_Idade")]
        [Range(18, 64, ErrorMessage = "Fora do range. Range é entre {3} e {4} ")]
        public int Idade { get; set; }
    }
}