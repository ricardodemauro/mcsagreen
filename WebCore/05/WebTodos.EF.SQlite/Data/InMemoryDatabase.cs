using System;
using System.Collections.Generic;
using System.Linq;
using WebTodos.EF.SQlite.Infra;
using WebTodos.EF.SQlite.Models;

namespace WebTodos.EF.SQlite.Data
{
    public class InMemoryDatabase<T> : IDatabase<T>
        where T : IDbEntity
    {
        private readonly List<T> _db = new List<T>();

        public void Add(T item)
        {
            item.Id = Guid.NewGuid();
            _db.Add(item);
        }

        public List<T> GetAll()
        {
            return _db.ToList();
        }

        public T GetById(string id)
        {
            Guid otherId = Guid.Parse(id);
            return _db.FirstOrDefault(c => c.Id.CompareTo(otherId) == 0);
        }

        public void Remove(string id)
        {
            Guid otherId = Guid.Parse(id);
            var index = _db.FindIndex(x => x.Id.CompareTo(otherId) == 0);
            if (index >= 0)
            {
                _db.RemoveAt(index);
            }
        }

        public void Update(string id, T todo)
        {
            Guid otherId = Guid.Parse(id);
            var index = _db.FindIndex(x => x.Id.CompareTo(otherId) == 0);
            if (index >= 0)
            {
                _db[index] = todo;
            }
        }
    }
}
