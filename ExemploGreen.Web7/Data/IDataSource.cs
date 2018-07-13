using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGreen.Web.Data
{
    public interface IDataSource<T>
    {
        T Add(T entity);

        void Delete(T entity);

        T Edit(T entity);

        T Get(int id);

        IEnumerable<T> Get();
    }
}
