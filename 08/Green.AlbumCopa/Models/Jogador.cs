using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green.AlbumCopa.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Pais { get; set; }

        public int? Numero { get; set; }

        public DateTime? DataCriacao { get; set; }
    }
}
