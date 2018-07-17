using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Green.Alunos.ViewModels
{
    public class NovoAlunoViewModel
    {
        [Required]
        [Display]
        [EmailAddress]
        [Range]
        public string Nome { get; set; }
    }
}