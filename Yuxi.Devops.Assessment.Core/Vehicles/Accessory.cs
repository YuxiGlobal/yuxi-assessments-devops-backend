using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class Accessory
    {
        public Accessory()
        {

        }
        
        public int Code { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<VehicleAccessory> VehicleAccessories { get; set; }

    }
}
