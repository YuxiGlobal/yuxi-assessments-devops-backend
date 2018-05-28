namespace Yuxi.Devops.Assessment.Infrastructure.Persistence
{
    public interface IUnitOfWorkConfiguration
    {
        string DatabaseConnectionString { get; }
    }
}
