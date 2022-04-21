using Akvelon_Internship_Test_Task.Models;
using Akvelon_Internship_Test_Task.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = Akvelon_Internship_Test_Task.Models.Task;

namespace Akvelon_Internship_Test_Task
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

            services.AddControllers().AddNewtonsoftJson(
                options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Akvelon Intership Test Task",
                    Description = "An ASP.NET Core Web API managing projects and task related to those projects.",
                    TermsOfService = new Uri("https://github.com/VulilnM/Milan-Vulin-Akvelon/tree/Test_Task_Project"),
                    Contact = new OpenApiContact
                    {
                        Name = "Contact - Developers LinkedIn profile",
                        Url = new Uri("https://www.linkedin.com/in/vulin-milan-dev/")
                    },

                    License = new OpenApiLicense
                    {
                        Name = "License - GNU General Public License v2.0",
                        Url = new Uri("https://github.com/VulilnM/Milan-Vulin-Akvelon/blob/master/LICENSE")
                    }
                });
            });
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConStr")));
            
            // Registering repository services and mapping them to our models
            #region Repositories
            // Whenever these interfaces are requested - return the mapped class
            services.AddScoped<IGenericRepository<Project>, GenericRepository<Project>>();
            services.AddScoped<IGenericRepository<Task>, GenericRepository<Task>>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Akvelon_Internship_Test_Task v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
