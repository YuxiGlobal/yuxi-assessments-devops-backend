using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.Core.Repositories
{
    public interface IDriverRepository : IRepository<Driver>
    {
        IEnumerable<Driver> GetDriverByAdministrator(int administratorId);

        Person GetAdministratorByDriver(int driverId);

        Driver GetDriverByPhoneNumber(long phoneNumber);
    }
}
