using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Com.App.Data;
using Microsoft.EntityFrameworkCore;

using Com.App.Bll;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Autofac.Extensions.DependencyInjection;

namespace Com.App.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.IServiceProvider
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                //关闭GDPR规范
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
           // services.AddDbContext<Data.EntityFramework.MyDbContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b=>b.MigrationsAssembly("Com.App.Web")));
            services.AddDbContext<Data.EntityFramework.MyDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), c => c.UseRowNumberForPaging()));
            //  services.AddDbContext<Data.EntityFramework.EfDbContext>(options =>
            //            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Com.App.Web")));

            //依赖注入
            //DIBllRegister bllRegister = new DIBllRegister();
            // bllRegister.DIRegister(services);
            services.AddMemoryCache();
            services.Configure<IISOptions>(option =>
            {

            });
            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //使用AutoFac进行注入
            return new AutofacServiceProvider(AutofacExt.InitAutofac(services));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=home}/{action=login}/{id?}");
            });
        }
    }
}
