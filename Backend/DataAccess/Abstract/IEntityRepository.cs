using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);
    }
}