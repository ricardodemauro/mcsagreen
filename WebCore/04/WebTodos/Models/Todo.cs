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

    public class Todo : IDbEntity
    {
        public Guid Id { get; set; }

        //multiline text
        //150 chars maximo
        //obrigatorio
        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(150)]
        public string Descricao { get; set; }

        public bool Done { get; set; }

        //obrigatorio
        [Required]
        public string Categoria { get; set; }

        [CPFValidation(ErrorMessage = "Nao gostei de cpf.", EstadosPermitidos = "SP,RJ")]
        public string CPF { get; set; }
    }
}
