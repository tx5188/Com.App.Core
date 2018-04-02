using Com.App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace Com.App.Data.Repository
{
    public class EfCoreRepositoryBase<TDbContext, TEntity, TPrimaryKey> 
         where TEntity : class, IEntity<TPrimaryKey>
         where TDbContext : DbContext
    {
        /// <summary>
        /// Gets EF DbContext object.
        /// </summary>
        public virtual TDbContext Context => _dbContextProvider.GetDbContext();
        /// <summary>
        /// Gets DbSet for given entity.
        /// </summary>
        public virtual DbSet<TEntity> Table => Context.Set<TEntity>();
       
        private readonly IDbContextProvider<TDbContext> _dbContextProvider;
        public EfCoreRepositoryBase(IDbContextProvider<TDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

  
    }
}
