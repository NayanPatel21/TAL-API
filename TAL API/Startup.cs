using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TAL_API.Extensions;
using Microsoft.EntityFrameworkCore;
using System.IO;
using NLog;
using TAL.DAL.Models;
using TAL.LoggerService;
using TAL.DAL.Repository;
using TAL.Common.Models;

namespace TAL_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), Constants.TAL_API_nlog));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TALDBContext>(opts =>
                opts.UseSqlServer(Configuration.GetConnectionString(Constants.TAL_API_SqlConnection),
                    options => options.MigrationsAssembly(Constants.TAL_API_TAL_API_Assembly)));
            services.AddSingleton<ILoggerManager, LoggerManager>();
            services.AddScoped<ITALRepository, TALRepository>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = Constants.TAL_API_Swagger_Title, Version = Constants.TAL_API_Swagger_Version });
            });

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint(Constants.TAL_API_Swagger_Endpoint, Constants.TAL_API_TAL_API_Assembly + " " + Constants.TAL_API_Swagger_Version));
            }
            app.ConfigureCustomExceptionMiddleware();

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
