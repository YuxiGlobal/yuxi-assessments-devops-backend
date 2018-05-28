using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class Clasification
    {
        public Clasification()
        {

        }
        
        public int Code { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<SubClasification> SubClasification { get; set; }

    }
}
