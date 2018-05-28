using System.Collections.Generic;
using System.Linq;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Shared;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Infrastructure.Persistence.Repositories
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(TransportationAssetsContext context) : base(context)
        {
        }

        public IEnumerable<Vehicle> GetVehicleByAdministrator(int administratorId)
        {
            return TransportationAssetsContext.Vehicle.Where(v => v.AdministratorCode == administratorId).ToList();
        }

        public Vehicle GetVehicleByPlate(string plate)
        {
            return TransportationAssetsContext.Vehicle.Where(v => v.Plate == plate).ToList().FirstOrDefault();
        }

        public CompanyVehicle GetCompanyVehicle(long vehicleCode)
        {
            return TransportationAssetsContext.CompanyVehicle.Where(vo => vo.VehicleCode == vehicleCode).ToList().FirstOrDefault();
        }

        public TransportationAssetsContext TransportationAssetsContext
        {
            get { return Context as TransportationAssetsContext; }
        }
    }
}