using Yuxi.Devops.Assessment.Core.Companies;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Core.Shared
{
    public class CompanyVehicle
    {
        public CompanyVehicle()
        {

        }
        
        public long Code { get; set; }

        public long CompanyCode { get; set; }

        public long VehicleCode { get; set; }

        public int CategoryCode { get; set; }

        public virtual Category Category { get; set; }

        public virtual Company Company { get; set; }

        public virtual Vehicle Vehicle { get; set; }

    }
}
