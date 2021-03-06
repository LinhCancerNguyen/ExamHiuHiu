﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ExamCore.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using ExamCore.Services;
using ExamCore.Repositories;

namespace ExamCore
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/Admin/Login";
                    option.LogoutPath = "/Admin/Logout";
                });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IAdmin, AdminRepository>();
            services.AddTransient<IOption, OptionRepository>();
            services.AddTransient<IQuestion, QuestionRepository>();
            services.AddTransient<IResult, ResultRepository>();
            services.AddTransient<IResultDetail, ResultDetailRepository>();
            services.AddTransient<ISubject, SubjectRepository>();
            services.AddTransient<IUser, UserRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connection = @"Server=V00288;Database=ExamEOSDBVersion5;Trusted_Connection=True;user id=sa;password=Cancer2306;";
            services.AddDbContext<ExamContext>
            (options => options.UseSqlServer(connection));
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

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Admin}/{action=Login}/{id?}");
            });
        }
    }
}
