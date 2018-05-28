using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class Designation
    {
        public Designation()
        {

        }
        
        public int Code { get; set; }
        
        public string Configuration { get; set; }

        public int SubClasificationCode { get; set; }
        
        public string Description { get; set; }

        public int AutomotiveAxles { get; set; }

        public int? NoAutomotiveAxles { get; set; }

        public decimal MaxWidth { get; set; }

        public decimal MaxHeight { get; set; }

        public decimal MaxLength { get; set; }
        
        public decimal GVWR { get; set; }
        
        public decimal Tolerance { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public virtual SubClasification SubClasification { get; set; }
        
    }
}
