using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GreenFullFramework
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();





            //app.Map("/rota1", map =>
            //{
            //    map.Use(async (ctx, next) =>
            //    {
            //        await ctx.Response.WriteAsync("Hello from middleware map<br />");
            //        await next();
            //    });
            //    map.Run(async ctx =>
            //    {
            //        await ctx.Response.WriteAsync("Hello from Map");
            //    });
            //});




            //app.Map("/rota2", map =>
            //{

            //    map.Use(async (ctx, next) =>
            //    {
            //        await ctx.Response.WriteAsync("Ok From 1");
            //        await next();
            //    });

            //    map.Run(async ctx =>
            //    {
            //        await ctx.Response.WriteAsync("Hello world");
            //    });
            //});



            //app.Run(async ctx =>
            //{
            //    await ctx.Response.WriteAsync("Hello world");
            //});
        }
    }
}
