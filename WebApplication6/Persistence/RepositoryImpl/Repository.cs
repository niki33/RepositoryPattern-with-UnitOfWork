using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApplication6.Core.Repositories;

namespace WebApplication6.Persistence.RepositoryImpl
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ProductDBEntities Context;
        protected DbSet<TEntity> s;
        public Repository(ProductDBEntities context)
        {
            Context = context;
            s = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            s.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            s.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return s.Where(predicate);
        }

        public TEntity Get(int id)
        {
          
            return s.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return s.ToList();
        }

        public void Remove(TEntity Entity)
        {
            s.Remove(Entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            s.RemoveRange(entities);
        }
    }
}