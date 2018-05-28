using System;
using Microsoft.EntityFrameworkCore;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Infrastructure.Persistence.Repositories;

namespace Yuxi.Devops.Assessment.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TransportationAssetsContext _context;

        public ICompanyRepository Companies { get; private set; }
        public IDriverRepository Drivers { get; private set; }
        public IVehicleRepository Vehicles { get; private set; }
        public IFleetManagerRepository FleetManagers { get; private set; }

        public UnitOfWork(TransportationAssetsContext context)
        {
            _context = context;
            Companies = new CompanyRepository(_context);
            Drivers = new DriverRepository(_context);
            Vehicles = new VehicleRepository(_context);
            FleetManagers = new FleetManagerRepository(_context);
        }

        public UnitOfWork(IUnitOfWorkConfiguration config) : this(
            new TransportationAssetsContext(config.DatabaseConnectionString)) { }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _context != null)
            {
                _context.Dispose();
            }
        }
    }
}
