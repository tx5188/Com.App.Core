using Com.App.Bll.Sys;
using Com.App.Data.Repository;
using Com.App.IBll.Sys;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.App.Bll
{
   public class DIBllRegister
    {
        public void DIRegister(IServiceCollection services)
        {
            // 用于实例化DalService对象，获取上下文对象
            services.AddTransient(typeof(IDbContextProvider<>), typeof(SimpleDbContextProvider<>));
            //注册数据库基础操作和工作单元
         
            services.AddTransient(typeof(IUnitWork<,,>), typeof(UnitWork<,,>));
            // 配置一个依赖注入映射关系 
            services.AddTransient(typeof(IBll_SysUser), typeof(Bll_SysUser));
            services.AddTransient(typeof(IBll_SysMenu), typeof(Bll_SysMenu));
        }
    }
}
