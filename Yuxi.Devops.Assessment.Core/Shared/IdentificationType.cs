using System.Collections.Generic;

namespace Yuxi.Devops.Assessment.Core.Shared
{
    public class IdentificationType
    {
        public IdentificationType()
        {

        }
        
        public int Code { get; set; }
        
        public string Name { get; set; }
        
        public string Acronym { get; set; }

        public virtual ICollection<Person> Persons { get; set; }

    }
}
