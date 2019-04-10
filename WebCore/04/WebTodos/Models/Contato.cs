using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Infra;
using WebTodos.Infra.Validations;

namespace WebTodos.Models
{
    public class Contato : IDbEntity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Deu erro. Ok?")]
        [AllLettersValidation(ErrorMessage = "Somente letras. Ok?")]
        [Display(Name = "Nombre", ShortName = "Nom")]
        public string Nome { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        public decimal Peso { get; set; }

        public GeoLocation Location { get; set; }
    }
}
