using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Shared;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Core.Repositories
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetVehicleByAdministrator(int administratorId);
        Vehicle GetVehicleByPlate(string plate);
        CompanyVehicle GetCompanyVehicle(long vehicleCode);
    }
}
