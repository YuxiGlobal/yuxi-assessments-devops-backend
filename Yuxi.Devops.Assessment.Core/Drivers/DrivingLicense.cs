using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Drivers
{
    public class DrivingLicense
    {
        public DrivingLicense()
        {

        }
        
        public int Code { get; set; }
        
        public string Category { get; set; }
        
        public string Description { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }

    }
}
