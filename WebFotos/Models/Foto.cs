using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFotos.Models
{
    public class Foto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Titulo { get; set; }

        public string Imagem { get; set; }

        public DateTime DataPublicacao { get; set; }
    }
}