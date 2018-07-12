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
                    Nome = "Contato 1"
                },
                new Cliente
                {
                    Nome = "Contato 2"
                }
            });
            base.Seed();
        }
    }
}
