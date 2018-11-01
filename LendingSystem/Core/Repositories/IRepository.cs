using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace LendingSystem.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Int64 id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        DbRawSqlQuery<T> SqlQuery<T>(string sql, params object[] parameters);
        // This method was not in the videos, but I thought it would be useful to add.

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);


    }
}