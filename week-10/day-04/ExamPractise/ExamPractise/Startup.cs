using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ExamPractise.Entities;
using Microsoft.EntityFrameworkCore;
using ExamPractise.Repositories;

namespace ExamPractise
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=parctiseQuiz;Integrated Security=True;Connect Timeout=30;";

            services.AddMvc();
            services.AddDbContext<QuizContext>(options => options.UseSqlServer(connectionstring));
            services.AddScoped<QuizRepository>();
            services.AddSingleton<Models.RandomQuiz>();
            services.AddSingleton<Models.Quiz>();
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
