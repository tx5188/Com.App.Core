using Com.App.Data.Repository;
using Com.App.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.App.Data
{
    public class BaseApp<TDbConext, T, Tkey> where T : class, IEntity<Tkey>, new() where TDbConext : DbContext
    {
        TDbConext  dbconext;
        IDbContextProvider<TDbConext> dbContextProvider;
        public BaseApp(IDbContextProvider<TDbConext> _dbContextProvider)
        {
            dbconext = _dbContextProvider.GetDbContext();
            dbContextProvider = _dbContextProvider;
        }
        /// <summary>
        /// 用于事务操作
        /// </summary>
        /// <value>The unit work.</value>
        public IUnitWork<TDbConext, T, Tkey> UnitWork
        {
            get { return new UnitWork<TDbConext, T, Tkey>(dbContextProvider); }
        }
        /// <summary>
        /// 用于普通的数据库操作
        /// </summary>
        /// <value>The repository.</value>
        public IRepository<TDbConext, T, Tkey> Repository { get { return new Repository<TDbConext, T, Tkey>(dbconext); }  }

     
        /// <summary>
        /// 如果一个类有层级结构（树状），则修改该节点时，要修改该节点的所有子节点
        /// //修改对象的级联ID，生成类似XXX.XXX.X.XX
        /// </summary>
        /// <typeparam name="U">U必须是一个继承TreeEntity的结构</typeparam>
        /// <param name="entity"></param>

        public void ChangeModuleCascade<U>(U entity) where U : TreeEntity
        {
            string cascadeId;
            int currentCascadeId = 1;  //当前结点的级联节点最后一位
            var sameLevels = UnitWork.Find<U>(o => o.ParentId == entity.ParentId && o.Id != entity.Id);
            foreach (var obj in sameLevels)
            {
                int objCascadeId = int.Parse(obj.CascadeId.TrimEnd('.').Split('.').Last());
                if (currentCascadeId <= objCascadeId) currentCascadeId = objCascadeId + 1;
            }

            if (!string.IsNullOrEmpty(entity.ParentId.ToString()))
            {
                var parentOrg = UnitWork.FindSingle<U>(o => o.Id == entity.ParentId);
                if (parentOrg != null)
                {
                    cascadeId = parentOrg.CascadeId + currentCascadeId + ".";
                    entity.ParentName = parentOrg.Name;
                }
                else
                {
                    throw new Exception("未能找到该组织的父节点信息");
                }
            }
            else
            {
                cascadeId = ".0." + currentCascadeId + ".";
                entity.ParentName = "根节点";
            }

            entity.CascadeId = cascadeId;
        }
    }
}
