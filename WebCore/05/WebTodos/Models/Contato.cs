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

        [Required(ErrorMessage = "Nome é obrigatório. Certo?")]
        [AllLettersValidation(ErrorMessage = "Somente letras. Ok?")]
        [Display(Name = "Nombre", ShortName = "Nom")]
        public string Nome { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        public GeoLocation Location { get; set; }
    }
}
