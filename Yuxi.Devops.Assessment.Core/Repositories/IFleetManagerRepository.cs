using Yuxi.Devops.Assessment.Core.FleetManagers;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.Core.Repositories
{
    public interface IFleetManagerRepository : IRepository<Person>
    {
        FleetManager GetFleetManagerByPhoneNumber(long phoneNumber);
    }
}
