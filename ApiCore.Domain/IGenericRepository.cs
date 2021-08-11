using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiCore.Domain
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
