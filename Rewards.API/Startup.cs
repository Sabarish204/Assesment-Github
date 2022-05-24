using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Rewards.API.Filters;
using Rewards.Business;
using Serilog;
using Serilog.Enrichers;
using Serilog.Events;
using System;
using System.IO;

namespace Rewards.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {

            #region Logging configuration
            string path = env.ContentRootPath;
            const string loggerTemplate = @"{Timestamp:yyyy-MM-dd HH:mm:ss}|[{Level:u4}]|<{ThreadId}>|{Message:lj}{NewLine}{Exception}";
            var logfile = Path.Combine(path + "\\" + "Logs\\", "log-.txt");
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.With(new ThreadIdEnricher())
                .Enrich.FromLogContext()
                .WriteTo.File(logfile, LogEventLevel.Information, loggerTemplate, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 1000)
                .CreateLogger();
            #endregion



            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.AddMvc(config => { config.Filters.Add(typeof(GlobalExceptionFilter)); })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            services.AddScoped<IBal, Bal>();

            services.AddControllersWithViews();

            services.AddHealthChecks()
                    .AddUrlGroup(new Uri("https://localhost:44391/api/Rewards/CalculateRewardPoints/20"),
                    "CalculateRewardPoints",
                    HealthStatus.Degraded);




            services.AddHealthChecksUI(opt =>
            {
                opt.SetEvaluationTimeInSeconds(10); //time in seconds between check    
                opt.MaximumHistoryEntriesPerEndpoint(60); //maximum history of checks    
                opt.SetApiMaxActiveRequests(1); //api requests concurrency    
                opt.AddHealthCheckEndpoint("API", "/api/health"); //map health check api    
            })
           .AddInMemoryStorage();



        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });




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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHealthChecks("/api/health",
                                                new HealthCheckOptions()
                                                {
                                                    Predicate = _ => true,
                                                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                                                });
            });

            app.UseHealthChecksUI(options =>
            {
                options.UIPath = "/healthchecks-ui";
                options.ApiPath = "/health-ui-api";
            });
        }
    }
}
