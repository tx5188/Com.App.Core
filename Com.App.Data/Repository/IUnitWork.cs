using Com.App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Com.App.Data.Repository
{
  public   interface IUnitWork<TDbConext, T, Tkey> where T : class, IEntity<Tkey>,new() where TDbConext : DbContext
    {
        T FindSingle(Expression<Func<T, bool>> exp = null);
        U FindSingle<U>(Expression<Func<U, bool>> exp = null) where U : class;
        bool IsExist(Expression<Func<T, bool>> exp);
        IQueryable<T> Find(Expression<Func<T, bool>> exp = null);
        IQueryable<U> Find<U>(Expression<Func<U, bool>> exp = null) where U:class;
        IQueryable<T> Find(int pageindex = 1, int pagesize = 10, string orderby = "",
            Expression<Func<T, bool>> exp = null) ;

        int GetCount(Expression<Func<T, bool>> exp = null);

        void Add(T entity);

        void BatchAdd(T[] entities);

        /// <summary>
        /// 更新一个实体的所有属性
        /// </summary>
        void Update(T entity);

        void Delete(T entity);


        /// <summary>
        /// 实现按需要只更新部分更新
        /// <para>如：Update<T>(u =>u.Id==1,u =>new User{Name="ok"}) where T:class;</para>
        /// </summary>
        /// <param name="where">更新条件</param>
        /// <param name="entity">更新后的实体</param>
        void Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity);
        /// <summary>
        /// 批量删除
        /// </summary>
        void Delete(Expression<Func<T, bool>> exp);

        void Save();

        void ExecuteSql(string sql);
    }
}
