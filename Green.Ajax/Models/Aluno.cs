using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Green.Ajax.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        [Range(4, 14)]
        public int Idade { get; set; }
    }
}