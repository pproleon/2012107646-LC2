﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _2012107646_ENT.IRepositories;
namespace _2012107646_PER.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        void IRepository<TEntity>.Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<TEntity> IRepository<TEntity>.Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.UpdateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.DeleteRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
