using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGreen.Web.Data
{
    public class ClienteDataSource : DataSourceBase<Cliente>, IDataSource<Cliente>
    {
        protected override void Seed()
        {
            AddRange(new Cliente[]
            {
                new Cliente
                {
                    Nome = "Contato 1",
                    Telefone = "11 2222-4444",
                    Sobrenome = "Sobrenome teste",
                    DataNascimento = DateTime.Now.AddYears(-8),
                    Email = "email@gree.com",
                    HiddendField = "Hidden value"
                },
                new Cliente
                {
                    Nome = "Contato 2",
                    Telefone = "11 1111-333",
                    Sobrenome = "Sobrenome teste 2",
                    DataNascimento = DateTime.Now.AddYears(-18),
                    Email = "email2@gree.com",
                    HiddendField = "Hidden value"
                }
            });
            base.Seed();
        }

        private static readonly ClienteDataSource _instance = new ClienteDataSource();

        public static IDataSource<Cliente> GetInstance() { return _instance; }
    }
}
