using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaizenDevops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                //if (context.HostingEnvironment.IsProduction())
                //{
                    var builtConfig = config.Build();

                    config.AddAzureKeyVault(
                        builtConfig["AzureKeyVault:Vault"],
                        builtConfig["AzureKeyVault:ClientId"],
                        builtConfig["AzureKeyVault:ClientSecret"]);
                //}
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
