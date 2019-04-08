using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.EF.SQlite.Models;

namespace WebTodos.EF.SQlite.Data
{
    public class EFContatoRepository : IDatabase<Contato>
    {
        
        public void Add(Contato todo)
        {
            throw new NotImplementedException();
        }

        public List<Contato> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contato GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, Contato todo)
        {
            throw new NotImplementedException();
        }
    }
}
