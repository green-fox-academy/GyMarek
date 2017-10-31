using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ListingTodos.Repositories;
using ListingTodos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingTodos
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";
            services.AddMvc();
            services.AddScoped<TodoRepository>();
            services.AddDbContext<TodoContext>(options => options.UseSqlServer(connectionString));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
