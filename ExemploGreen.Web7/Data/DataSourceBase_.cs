using ExemploGreen.Web.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGreen.Web.Data
{
    public abstract class DataSourceBase<T>
        where T : class, IIdEntity
    {
        private List<T> _data = new List<T>();

        public DataSourceBase()
        {
            this.Seed();
        }

        protected virtual void Seed()
        { }

        public virtual T Add(T entity)
        {
            entity.Id = _data.Count;
            _data.Add(entity);
            return entity;
        }

        public virtual void AddRange(params T[] entityColl)
        {
            foreach (T entity in entityColl)
            {
                Add(entity);
            }
        }

        public virtual void Delete(T entity)
        {
            int index = _data.FindIndex(x => x.Id == entity.Id);
            _data[index] = null;
        }

        public virtual T Edit(T entity)
        {
            int index = _data.FindIndex(x => x.Id == entity.Id);
            _data[index] = entity;
            return entity;
        }

        public virtual T Get(int id)
        {
            return _data[id];
        }

        public virtual IEnumerable<T> Get()
        {
            return _data.Where(x => x != null).ToArray();
        }
    }
}
