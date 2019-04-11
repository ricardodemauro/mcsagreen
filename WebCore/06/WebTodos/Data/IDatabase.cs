using System.Collections.Generic;
using WebTodos.Infra;
using WebTodos.Models;

namespace WebTodos.Data
{
    public interface IDatabase<T, TKey>
        where T : class, IDbEntity, new()
    {
        List<T> GetAll();

        T GetById(TKey id);

        void Add(T todo);

        void Update(TKey id, T todo);

        void Remove(TKey id);
    }
}
