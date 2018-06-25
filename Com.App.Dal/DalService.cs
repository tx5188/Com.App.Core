using Com.App.Data.EntityFramework;
using Com.App.Interface.dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Com.App.Dal
{
    /// <summary>
    /// 数据访问层：DAL
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DalService<T> : IRepository<T> where T : class, new()
    {

        public MyDbContext dbcontext;
        private readonly DbSet<T> entities;

        /// <summary>
        /// 获得数据库上下文
        /// </summary>
        /// <param name="dbContext">数据库上下文类，各自更改成自己的</param>
        public DalService(MyDbContext _dbcontext)
        {
            dbcontext = _dbcontext;
            this.entities = _dbcontext.Set<T>();
        }

        public MyDbContext GetDbContext()
        {
            return dbcontext;
        }

        public T AddEntity(T entity)
        {
            dbcontext.Set<T>().Add(entity);
            return entity;
        }
        public T Get(int id)
        {
            return this.entities.Find(id);
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            var query = this.entities.AsQueryable();
            foreach (var include in includes)
                query = query.Include(include);

            return query;
        }

        public IQueryable<T> GetRange(int start, int count)
        {
            return this.entities.Skip(start).Take(count);
        }

        public IQueryable<T> GetRange(int start, int count, Expression<Func<T, bool>> predicate)
        {
            return this.entities.Where(predicate).Skip(start).Take(count);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this.entities.Where(predicate);
        }

        public int Count()
        {
            return this.entities.Count();
        }

        public  void  Add(T entity)
        {
            this.entities.Add(entity);
        }

        public void Remove(int id)
        {
            var entity = this.Get(id);
            this.dbcontext.Set<T>().Remove(entity);
            this.Save();
        }

        public void Update(int id, T entity)
        {
            this.dbcontext.Set<T>().Update(entity);
            this.Save();
        }

        public void Save()
        {
            this.dbcontext.SaveChanges();
        }

    }
 
}
