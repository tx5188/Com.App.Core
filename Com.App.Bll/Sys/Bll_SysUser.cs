using Com.App.Data;
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
using System.Threading.Tasks;

namespace Com.App.Bll.Sys
{
    public class Bll_SysUser : BaseApp<MyDbContext, SysUser, int>, IBll_SysUser
    {
        private readonly MyDbContext context;
       
        public Bll_SysUser(IDbContextProvider<MyDbContext> dbContextProvider)
             : base(dbContextProvider)
        {
            context = dbContextProvider.GetDbContext();
       
        }
        
       
        public List<SysUser> GetList()
        {
            Expression<Func<SysUser, object>>[] includeProperties=new Expression<Func<SysUser, object>>[2];
           
            List<SysUser> list = Repository. AllIncluding(x=>x.BaseDeparment ,x=>x.BaseDeparment.BaseCompany).ToList();
            List<SysMenu> listmenu = UnitWork.Find<SysMenu>(null).ToList();
           // List<SysUser> list = context2.SysUser.ToList();
            //List<SysUser> list2= context.SysUser.ToList();
            return list;
        }
 
    }
}
