using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.Core.Companies
{
    public class Company
    {
        public Company()
        {

        }
        
        public long Code { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<CompanyVehicle> CompanyVehicles { get; set; }

    }
}
