using System.Collections.Generic;
using System.Linq;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Shared;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Infrastructure.Persistence.Repositories
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {

        public DriverRepository(TransportationAssetsContext context) : base(context)
        {
        }

        public IEnumerable<Driver> GetDriverByAdministrator(int administratorId)
        {
            return TransportationAssetsContext.Driver.Where(c => c.Vehicles.Where(v => v.AdministratorCode == administratorId).Any()).ToList();
        }

        public Driver GetDriverByPhoneNumber(long phoneNumber)
        {
            return TransportationAssetsContext.Driver.Where(d => d.Person.Mobile == phoneNumber).FirstOrDefault();
        }

        public Person GetAdministratorByDriver(int driverId)
        {
            var driver = TransportationAssetsContext.Driver.Where(d => d.PersonCode == driverId).FirstOrDefault();
            
            Vehicle vehicle = TransportationAssetsContext.Vehicle.Where(v => v.DriverCode == driver.Code).FirstOrDefault();

            Person fleetManager = TransportationAssetsContext.Person.Where(p => p.Code == vehicle.AdministratorCode).FirstOrDefault();

            return fleetManager;
        }

        public TransportationAssetsContext TransportationAssetsContext
        {
            get { return Context as TransportationAssetsContext; }
        }
    }
}
