﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6.Core.Repositories
{
   public interface IRepository<TEntity> where TEntity:class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity Entity);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}