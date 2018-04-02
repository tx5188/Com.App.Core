using Com.App.Data.EntityFramework;
using Com.App.Data.Repository;
using Com.App.IBll.Sys;
using Com.App.Interface.dal;
using Com.App.Model.Sys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Com.App.Bll.Sys
{
    public class BLL_SysUser : Repository<MyDbContext, SysUser, int>, IBll_SysUser
    {
        private MyDbContext context;
        private EfDbContext context2;
        public BLL_SysUser(IDbContextProvider<MyDbContext> dbContextProvider, IDbContextProvider<EfDbContext> dbContextProvider2)
             : base(dbContextProvider)
        {
            context = dbContextProvider.GetDbContext();
            context2 = dbContextProvider2.GetDbContext();
        }

        public List<SysUser> GetList()
        {
            // List<SysUser> list = AllIncluding(x=>x.BaseDeparment).ToList();

            List<SysUser> list = context2.SysUser.ToList();
            //List<SysUser> list2= context.SysUser.ToList();
            return list;
        }
 
    }
}
