using Com.App.Interface.bll;
using Com.App.Interface.dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Com.App.Bll
{
    public class BllService<T> : IBllService<T> where T : class, new()
    {
        /// <summary>
        /// 数据库服务
        /// </summary>
        protected IRepository<T> DBService;
     

        public BllService(IRepository<T> dalService)
        {
            this.DBService = dalService;
            
        }

        public DbContext GetDbContext()
        {
            return DBService.GetDbContext();
        }
        public void Add(T entity)
        {
            DBService.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            var query = DBService.GetAll(includes);
            return query;
        }
     
        public IQueryable<T> GetRange(int start, int count)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetRange(int start, int count, Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
