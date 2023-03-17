using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineShop.Controllers;
using OnlineShop.Interfaces;
using OnlineShop.Models;
using OnlineShop.Repositories;
using OnlineShop.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Wrapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;



namespace OnlineShop
{
    //public class Startup1
    //{
    //    public void Configure(IApplicationBuilder app)
    //    {
    //        app.UseStaticFiles();

    //        void ConfigureServices(IServiceCollection services)
    //        {
    //            services.AddDbContext<OnlineShopContext>(
    //                option => option.UseSqlServer(
    //                    "Server=DESKTOP-QTN9LC5;Database=OnlineShop;Integrated Security=true"));
    //            // Add the memory cache services
    //            services.AddMemoryCache();

    //            // Add a custom scoped service
    //            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    //            services.AddScoped<IUserRepository, UserRepository>()
    //        }
    //    }
    //}

    public class Program
    {
        public static void Main(string[] args)
        {
            void Configure(IApplicationBuilder app, IServiceCollection services)
            {
                app.UseDefaultFiles();
                services.AddDbContext<OnlineShopContext>(
                        option => option.UseSqlServer(
                            "Server=DESKTOP-QTN9LC5;Database=OnlineShop;Integrated Security=true"));
                // Add the memory cache services
                services.AddMemoryCache();

                // Add a custom scoped service
                services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
                services.AddScoped<IUserRepository, UserRepository>();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();   
                });
    }
}
