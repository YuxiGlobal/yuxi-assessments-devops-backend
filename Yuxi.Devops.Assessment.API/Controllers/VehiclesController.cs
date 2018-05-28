using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.API.Controllers
{
    [Produces("application/json")]
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("plate/{plate}")]
        public Vehicle GetByPlate(string plate)
        {
            return _unitOfWork.Vehicles.GetVehicleByPlate(plate);
        }

        [HttpGet("admin/{id}")]
        public IEnumerable<Vehicle> GetAdminVehicles(int adminId)
        {
            return _unitOfWork.Vehicles.GetVehicleByAdministrator(adminId);
        }

        [HttpGet("{id}")]
        public Vehicle GetById(int id)
        {
            return _unitOfWork.Vehicles.Get(id);
        }
    }
}