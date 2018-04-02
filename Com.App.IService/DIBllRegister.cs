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

            // 配置一个依赖注入映射关系 
            services.AddTransient(typeof(IBll_SysUser), typeof(BLL_SysUser));
        }
    }
}
