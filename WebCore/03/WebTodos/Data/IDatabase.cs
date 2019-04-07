using System.Collections.Generic;
using WebTodos.Infra;
using WebTodos.Models;

namespace WebTodos.Data
{
    public interface IDatabase<T>
        where T : IDbEntity
    {
        List<T> GetAll();

        T GetById(string id);

        void Add(T todo);

        void Update(string id, T todo);

        void Remove(string id);
    }
}
