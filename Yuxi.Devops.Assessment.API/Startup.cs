using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.HealthChecks;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Infrastructure.Persistence;

namespace Yuxi.Devops.Assessment.API
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
            var unitOfWorkConfig = new AppConfiguration(Configuration);

            services.AddMvc();
            services.AddSingleton<IUnitOfWorkConfiguration, AppConfiguration>(context => unitOfWorkConfig);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddHealthChecks(checks =>
            {
                checks.AddSqlCheck("TransportationAssetsDb", unitOfWorkConfig.DatabaseConnectionString);
                checks.AddValueTaskCheck("HTTP Endpoint", () => new
                    ValueTask<IHealthCheckResult>(HealthCheckResult.Healthy("Ok")));
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
