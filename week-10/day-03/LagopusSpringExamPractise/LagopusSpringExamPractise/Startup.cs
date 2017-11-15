using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using LagopusSpringExamPractise.Entities;
using LagopusSpringExamPractise.Repositories;

namespace LagopusSpringExamPractise
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=qAndA;Integrated Security=True;Connect Timeout=30;";

            services.AddMvc();
            services.AddDbContext<QAContext>(options => options.UseSqlServer(connectionstring));
            services.AddScoped<QARepository>();
            services.AddSingleton<Models.QandA>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseMvcWithDefaultRoute();

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
