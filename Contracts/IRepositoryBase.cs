using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Contracts
{
    public interface IRepositoryBase<TEntity>
    {
        IQueryable<T> FindAll<T>();
        IQueryable<T> FindByCondition<T>(Expression<Func<T, bool>> expression);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
