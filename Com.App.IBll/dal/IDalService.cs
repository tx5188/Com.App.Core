using Com.App.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Com.App.Interface.dal
{
    public interface IRepository<T> where T : class, new()
    {

        MyDbContext GetDbContext();
        T Get(int id);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        IQueryable<T> GetRange(int start, int count);
        IQueryable<T> GetRange(int start, int count, Expression<Func<T, bool>> predicate);

        int Count();
        void Save();
        void Add(T entity);
        void Remove(int id);
        void Update(int id, T entity);

    }

}