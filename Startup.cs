﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FootballStarz.Data;
using Microsoft.EntityFrameworkCore;
using FootballStarz.Services;
using Microsoft.AspNetCore.Identity;
using FootballStarz.Models;
using FootballStarz.Interfaces;
using Microsoft.Extensions.Logging;
using FootballStarz.ViewModelServices;
using Microsoft.AspNetCore.Mvc;

namespace FootballStarz
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
            var _connection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_connection));

            services.AddTransient<IClubService, ClubService>();                         // Services
            services.AddTransient<IStadiumService, StadiumService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ILigaService, LigaService>();

            services.AddTransient<FBSContainerService>();                               // Azure FBS Blob service

            services.AddTransient<IPlayerViewModelService, PlayerViewModelService>();   // ViewModel Services
            services.AddTransient<IClubViewModelService, ClubViewModelService>();
            services.AddTransient<IStadiumViewModelService, StadiumViewModelService>();

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                //password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireUppercase = true;

                //user settings
                options.User.RequireUniqueEmail = true;

                //lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
            });
 
            services
                .AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddMvc(options =>
                options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AppDbContext context, ILoggerFactory loggerFactory)
        {
            ILogger _Logger = loggerFactory.CreateLogger("Information");

            context.Database.EnsureCreated();

            if (env.IsDevelopment())
            {
                _Logger.LogInformation(System.DateTime.Now.ToString() + ":Startup: *** Environment = Development");

                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Home/Error");
            }
            else if (env.IsProduction())
            {
                // Production environment
                _Logger.LogInformation(System.DateTime.Now.ToString() + ":Startup: *** Environment = Production");

                app.UseBrowserLink();
                app.UseExceptionHandler("/Home/Error");
            }
            else
            {
                _Logger.LogCritical(System.DateTime.Now.ToString() + ":<<<< HostingEnvironment specified neither Development nor Production! >>>");
            }


            _Logger.LogInformation(System.DateTime.Now.ToString() + ":Calling: app.UseStaticFiles();");
            app.UseStaticFiles();
            _Logger.LogInformation(System.DateTime.Now.ToString() + ":Calling: app.UseAuthentication();");
            app.UseAuthentication();

            _Logger.LogInformation(System.DateTime.Now.ToString() + "Calling: app.UseMvc();");

            app.UseRouting();

            app.UseAuthorization();

              _Logger.LogInformation(System.DateTime.Now.ToString() + "Calling: UseEndpoints();");

            app.UseMvc(routes =>                  // old 2.1 stuff,
                                                  // requires services.AddMvc(options => options.EnableEndPointRouting = false) to be set.
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}");
            });

            _Logger.LogInformation(System.DateTime.Now.ToString() + "End of Configure()");

        }
    }
}
