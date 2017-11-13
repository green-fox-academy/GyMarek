using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AlpagaDictionary.Repositories;
using AlpagaDictionary.Entities;
using Microsoft.EntityFrameworkCore;
using AlpagaDictionary.Services;

namespace AlpagaDictionary
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = alpagadictionary; Integrated Security = True; Connect Timeout = 30;";
            
            services.AddMvc();
            services.AddScoped<DefinitionRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<UserService>();
            services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
            services.AddSingleton<Models.Definition>();
            services.AddSingleton<Models.User>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseMvc();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }                     

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
