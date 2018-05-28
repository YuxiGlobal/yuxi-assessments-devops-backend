using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class BodyworkType
    {
        public BodyworkType()
        {

        }
        
        public int Code { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}
