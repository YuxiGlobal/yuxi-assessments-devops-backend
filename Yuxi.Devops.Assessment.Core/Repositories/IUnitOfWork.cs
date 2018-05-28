using System;

namespace Yuxi.Devops.Assessment.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IDriverRepository Drivers { get; }
        IFleetManagerRepository FleetManagers { get; }
        ICompanyRepository Companies { get; }
        IVehicleRepository Vehicles { get; }
        int Complete();
    }
}
