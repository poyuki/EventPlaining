﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlaining.Models;
using EventPlaining.Models.Session;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace EventPlaining
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<EventPlainingDBContext>( // replace "YourDbContext" with the class name of your DbContext
                options =>
                {
                    ConfigModel myConfig;
                    using (System.IO.StreamReader r = new System.IO.StreamReader("MyProjConfige.json"))
                    {
                        string json = r.ReadToEnd();
                        myConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(json);
                    }
                    options.UseMySql(
                        $"Server={myConfig.dbSetings.server};Database={myConfig.dbSetings.database};User={myConfig.dbSetings.user};Password={myConfig.dbSetings.password};", // replace with your Connection String
                        mysqlOptions =>
                        {
                            mysqlOptions.ServerVersion(
                                new Version(myConfig.dbSetings.getMajorVersion(), myConfig.dbSetings.getMinorVersion(), myConfig.dbSetings.getPatchVersion()),
                                ServerType.MySql); // replace with your Server Version and Type
                        }
                    );
                });

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".EventPlaining.Session";
                options.IdleTimeout=TimeSpan.FromMinutes(30);      
                options.Cookie.HttpOnly = true;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            

            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseSession();
            app.Use(async (context, next) =>
            {
                if (!context.Session.Keys.Contains("userInSession"))
                {
                    UserSession userInSession = new UserSession();
                    context.Session.Set<UserSession>("userInSession", userInSession);
                }
                await next();
            });
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
