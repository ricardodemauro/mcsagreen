using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Infra;

namespace WebTodos.Data.Repositories
{
    public class EFGenericRepository<T, TKey> : IDatabase<T, TKey>
        where T : class, IDbEntity, new()
    {
        private readonly WebTodosDbContext _db;

        public EFGenericRepository(WebTodosDbContext db)
        {
            _db = db;
        }

        public void Add(T todo)
        {
            _db.Set<T>().Add(todo);
            _db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(TKey id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Remove(TKey id)
        {
            var itemToRemove = GetById(id);
            if (itemToRemove != null)
            {
                _db.Set<T>().Remove(itemToRemove);
                _db.SaveChanges();
            }
        }

        public void Update(TKey id, T todo)
        {
            _db.Set<T>().Update(todo);
            _db.SaveChanges();
        }
    }
}
