using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Shared;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Core.Drivers
{
    public class Driver
    {
        public Driver()
        {

        }
        
        public long Code { get; set; }

        public long PersonCode { get; set; }

        public int DrivingLicenseCode { get; set; }

        public virtual DrivingLicense DrivingLicense { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}
