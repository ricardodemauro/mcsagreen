using ExemploGreen.Web.Models;
using System;

namespace ExemploGreen.Web.Data
{
    public class ContatoDataSource : DataSourceBase<Contato>, IDataSource<Contato>
    {
        protected override void Seed()
        {
            AddRange(new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "11 2222-4444",
                    Sobrenome = "Sobrenome teste",
                    DataNascimento = DateTime.Now.AddYears(-8),
                    Email = "email@gree.com",
                    Endereco = new Endereco
                    {
                        Cidade = "Sao Paulo",
                        Pais = "Brasil",
                        Rua = "Rua teste"
                    }
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "11 1111-333",
                    Sobrenome = "Sobrenome teste 2",
                    DataNascimento = DateTime.Now.AddYears(-18),
                    Email = "email2@gree.com",
                    Endereco = new Endereco
                    {
                        Cidade = "Sao Paulo",
                        Pais = "Brasil",
                        Rua = "Rua teste"
                    }
                }
            });
            base.Seed();
        }

        private ContatoDataSource() { }

        private static readonly ContatoDataSource _instance = new ContatoDataSource();

        public static IDataSource<Contato> GetInstance() { return _instance; }
    }
}