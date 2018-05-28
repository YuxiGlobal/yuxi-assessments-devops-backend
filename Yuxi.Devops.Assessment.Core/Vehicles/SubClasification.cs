using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class SubClasification
    {
        public SubClasification()
        {

        }
        
        public int Code { get; set; }

        public int ClasificationCode { get; set; }
        
        public string Name { get; set; }

        public virtual Clasification Clasification { get; set; }

        public virtual ICollection<Designation> Designations { get; set; }

    }
}
