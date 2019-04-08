using System.Collections.Generic;
using WebTodos.EF.SQlite.Infra;
using WebTodos.EF.SQlite.Models;

namespace WebTodos.EF.SQlite.Data
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
