using ApiCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiCore.Domain
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DBCustomerContext dbContext;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected DBCustomerContext DbContext
        {
            get { return dbContext ?? (dbContext = DbFactory.Init()); }
        }

        public GenericRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        public IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }
        public void Add(T entity)
        {
            DbContext.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbContext.Remove(entity);
            DbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            DbContext.Update(entity);
            DbContext.SaveChanges();
        }

    }
}
