using Autofac;
using Autofac.Extensions.DependencyInjection;
using Com.App.Bll.Sys;
using Com.App.Data.Repository;
using Com.App.IBll.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic; 
using System.Reflection;
using System.Text;

namespace Com.App.Bll
{

    public static class AutofacExt
    {
        private static IContainer _container;
        public static IContainer InitAutofac(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            if (services != null)
            {
                builder.Populate(services);
            }

   
            // 配置一个依赖注入映射关系 
            builder.RegisterType(typeof(Bll_SysUser)).As( typeof(IBll_SysUser));
            builder.RegisterType(typeof(Bll_SysMenu)).As(typeof(IBll_SysMenu));
            //注册数据库基础操作和工作单元
           builder.RegisterGeneric(typeof(Repository<,,>)).As(typeof(IRepository<,,>));
           builder.RegisterGeneric(typeof(UnitWork<,,>)).As(typeof(IUnitWork<,,>));
            //注册app层
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();


           builder.RegisterGeneric(typeof(SimpleDbContextProvider<>)).As(typeof(IDbContextProvider<>));

            _container = builder.Build();
            return _container;

        }

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetFromFac<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
