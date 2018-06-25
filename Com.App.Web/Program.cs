using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Com.App.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // var host = BuildWebHost(args);
            CreateWebHostBuilder(args).Build().Run();
            //执行初始化数据代码，可以吧基层数据初始化到数据库中
            // using (var scope = host.Services.CreateScope())
            // {
            //     var services = scope.ServiceProvider;
            //     try
            //     {
            //         var context = services.GetRequiredService<SchoolContext>();
            //         DbInitializer.Initialize(context);
            //     }
            //     catch (Exception ex)
            //     {
            //         var logger = services.GetRequiredService<ILogger<Program>>();
            //         logger.LogError(ex, "An error occurred while seeding the database.");
            //     }
            // }
         
            //   host.Run();
            // BuildWebHost(args).Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>();

        public static IWebHost BuildWebHost(string[] args) => 
            WebHost.CreateDefaultBuilder(args) 
                .UseStartup<Startup>()
                .Build();
    }
}
