using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AwesomeMixVol.Repositories;
using AwesomeMixVol.Entities;
using Microsoft.EntityFrameworkCore;
using AwesomeMixVol.Services;

namespace AwesomeMixVol
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=awesomemixvol;Integrated Security=True;Connect Timeout=30;";

            services.AddMvc();
            services.AddDbContext<SongContext>(options => options.UseSqlServer(connectionstring));
            services.AddScoped<SongRepository>();
            services.AddScoped<SongService>();
            services.AddSingleton<Models.Song>();
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
