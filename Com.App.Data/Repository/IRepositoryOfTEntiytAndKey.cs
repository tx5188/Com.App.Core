﻿using Com.App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Com.App.Data.Repository
{ 
    public interface IRepository<TDbConext,T,Tkey> : IRepository where T : class, IEntity<Tkey>, new() where TDbConext : DbContext
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);

        int Count();
        Task<int> CountAsync();
        T GetSingle(Tkey id);
        Task<T> GetSingleAsync(Tkey id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        void AddRange(IEnumerable<T> entities);
        void DeleteRange(IEnumerable<T> entities);
        void Attach(T entity);
        void AttachRange(IEnumerable<T> entities);
        void Detach(T entity);
        void DetachRange(IEnumerable<T> entities);
        void AttachAsModified(T entity);


    }
}
