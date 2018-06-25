using Com.App.Data.EntityFramework;
using Com.App.Data.Repository;
using Com.App.IBll.Sys;
using Com.App.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.App.Data;
namespace Com.App.Bll.Sys
{
   public class Bll_SysMenu: BaseApp<MyDbContext, SysMenu, int>, IBll_SysMenu
    {
        private readonly MyDbContext context;
 
        public Bll_SysMenu(IDbContextProvider<MyDbContext> dbContextProvider )
             : base(dbContextProvider)
        {
            context = dbContextProvider.GetDbContext(); 
        }


        public List<SysMenu> GetListMenu()
        {
            List<SysMenu> list = Repository.All.ToList();
            return list;
        }
    }
}
