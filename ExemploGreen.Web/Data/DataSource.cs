using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Data
{
    public static class DataSource
    {
        public static List<Contato> Contatos = new List<Contato>
        {
            new Contato
            {
                Id = 1,
                Nome = "Contato Teste",
                Telefone = "1234"
            },
            new Contato
            {
                Id = 2,
                Nome = "Contato Teste 2",
                Telefone = "4321"
            }
        };
    }
}