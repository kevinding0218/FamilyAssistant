using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FamilyAssistant.Persistence;
using FamilyAssistant.Persistence.IRespository;
using FamilyAssistant.Persistence.IRespository.Meal;
using FamilyAssistant.Persistence.IRespository.User;
using FamilyAssistant.Persistence.Repository;
using FamilyAssistant.Persistence.Repository.Meal;
using FamilyAssistant.Persistence.Repository.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FamilyAssistant {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddScoped<IUserRepository, UserRepository> ();
            services.AddScoped<IVegetableRepository, VegetableRepository> ();
            services.AddScoped<IMeatRepository, MeatRepository> ();
            services.AddScoped<IEntreeRepository, EntreeRepository> ();


            services.AddScoped<IUnitOfWork, UnitOfWork> ();

            services.AddAutoMapper ();

            services.AddDbContext<FaDbContext> (options => options.UseSqlServer (Configuration.GetConnectionString ("Default")));

            services.AddMvc ();

            // ********************
            // Setup CORS
            // ********************
            var corsBuilder = new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder ();
            corsBuilder.AllowAnyHeader ();
            corsBuilder.AllowAnyMethod ();
            corsBuilder.AllowAnyOrigin (); // For anyone access.
            corsBuilder.WithOrigins("http://localhost:4200"); // for a specific url. Don't add a forward slash on the end!
            corsBuilder.AllowCredentials ();

            services.AddCors (options => {
                options.AddPolicy ("SiteCorsPolicy", corsBuilder.Build ());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            app.UseDefaultFiles ();
            app.UseStaticFiles ();

            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseMvc ();

            // ********************
            // USE CORS - might not be required.
            // ********************
            app.UseCors("SiteCorsPolicy");
        }
    }
}