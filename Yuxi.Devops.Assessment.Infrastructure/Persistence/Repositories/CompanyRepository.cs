using Yuxi.Devops.Assessment.Core.Companies;
using Yuxi.Devops.Assessment.Core.Repositories;

namespace Yuxi.Devops.Assessment.Infrastructure.Persistence.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(TransportationAssetsContext context) : base(context)
        {
        }

        public TransportationAssetsContext TransportationAssetsContext
        {
            get { return Context as TransportationAssetsContext; }
        }
    }
}
