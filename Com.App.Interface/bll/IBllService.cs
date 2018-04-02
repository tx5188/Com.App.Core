using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Com.App.Interface.bll
{
    public interface IBllService<TEntity> where TEntity : class, new()
    {
        TEntity Get(int id);

        DbContext GetDbContext();

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);
        //Task<IQueryable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TEntity> GetRange(int start, int count);
        IQueryable<TEntity> GetRange(int start, int count, Expression<Func<TEntity, bool>> predicate);

        int Count();
        void Save();
        void Add(TEntity entity);
        void Remove(int id);
        void Update(int id, TEntity entity);
    }

    
}
