using System.Linq;
using Yuxi.Devops.Assessment.Core.FleetManagers;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.Infrastructure.Persistence.Repositories
{
    public class FleetManagerRepository : Repository<Person>, IFleetManagerRepository
    {
        public FleetManagerRepository(TransportationAssetsContext context) : base(context)
        {
        }

        public TransportationAssetsContext TransportationAssetsContext
        {
            get { return Context as TransportationAssetsContext; }
        }

        public FleetManager GetFleetManagerByPhoneNumber(long phoneNumber)
        {
            Person person = TransportationAssetsContext.Person.Where(p => p.Mobile == phoneNumber).ToList().FirstOrDefault();

            if (person != null)
            {
                FleetManager fleetManager = new FleetManager()
                {
                    CellphoneNumber = person.Mobile.ToString(),
                    Code = person.Code,
                    Email = person.Email,
                    FirstName = person.Name,
                    LastName = person.LastName,
                    Id = person.Identification,
                    IdentificationType = person.IdentificationTypeCode.ToString()
                };

                return fleetManager;
            }

            return null;
            
        }
    }
}
