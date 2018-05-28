using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        
        public long Code { get; set; }
        
        public string Plate { get; set; }
        
        public string Brand { get; set; }
        
        public string Line { get; set; }
        
        public decimal Model { get; set; }

        public long? OwnerCode { get; set; }

        public long? AdministratorCode { get; set; }

        public long? DriverCode { get; set; }

        public int DesignationCode { get; set; }
        
        public string TrailerPlate { get; set; }
        
        public string TrailerBrand { get; set; }
        
        public string BodyworkLine { get; set; }
        
        public string BodyworkModel { get; set; }

        public int BodyworkTypeCode { get; set; }

        public int LoadTypeCode { get; set; }

        public decimal LoadCapacity { get; set; }

        public decimal VolumetricCapacity { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public virtual ICollection<VehicleAccessory> VehicleAccessories { get; set; }

        public virtual ICollection<CompanyVehicle> CompanyVehicles { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Designation Designation { get; set; }
           
        public virtual Person Owner { get; set; }

        public virtual Person Administrator { get; set; }

        public virtual LoadType LoadType { get; set; }

        public virtual BodyworkType BodyworkType { get; set; }

    }
}
