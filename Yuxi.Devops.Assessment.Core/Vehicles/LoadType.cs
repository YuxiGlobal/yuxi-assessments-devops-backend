using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class LoadType
    {
        public LoadType()
        {

        }
        
        public int Code { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}
