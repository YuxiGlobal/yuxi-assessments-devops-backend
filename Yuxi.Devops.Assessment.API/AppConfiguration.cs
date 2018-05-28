using Microsoft.Extensions.Configuration;
using Yuxi.Devops.Assessment.Infrastructure.Persistence;

namespace Yuxi.Devops.Assessment.API
{
    public class AppConfiguration : IUnitOfWorkConfiguration
    {
        private readonly IConfiguration _config;

        public AppConfiguration(IConfiguration config)
        {
            _config = config;
        }

        public string DatabaseConnectionString => this._config.GetConnectionString("DatabaseConnectionString");
    }
}
