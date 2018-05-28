using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Core.Shared
{
    public class Person
    {
        public Person()
        {

        }
        
        public long Code { get; set; }

        public int IdentificationTypeCode { get; set; }
        
        public string Identification { get; set; }
        
        public string Name { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public long? Mobile { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }

        public virtual ICollection<Vehicle> VehiclesAsOwner { get; set; }

        public virtual ICollection<Vehicle> VehiclesAsAdministrator { get; set; }

        public virtual IdentificationType IdentificationType { get; set; }
        
    }
}
