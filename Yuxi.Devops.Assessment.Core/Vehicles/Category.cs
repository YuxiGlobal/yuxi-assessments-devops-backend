using System.Collections.Generic;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.Core.Vehicles
{
    public class Category
    {
        public Category()
        {

        }

        public int Code { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CompanyVehicle> CompanyVehicles { get; set; }

    }
}
