using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Models;

namespace WebTodos.Data.Repositories
{
    public class ContatoRepository : IDatabase<Contato>
    {
        private readonly WebTodosDbContext _db;

        public ContatoRepository(WebTodosDbContext db)
        {
            _db = db;
        }

        public void Add(Contato todo)
        {
            _db.Contatos.Add(todo);
            _db.SaveChanges();
        }

        public List<Contato> GetAll()
        {
            return _db.Contatos.ToList();
        }

        public Contato GetById(string id)
        {
            return _db.Contatos.Find(Guid.Parse(id));
        }

        public void Remove(string id)
        {
            var itemRemove = _db.Contatos.Find(Guid.Parse(id));
            if (itemRemove != null)
            {
                _db.Contatos.Remove(itemRemove);
                _db.SaveChanges();
            }
        }

        public void Update(string id, Contato todo)
        {
            _db.Contatos.Update(todo);
            _db.SaveChanges();
        }
    }
}
