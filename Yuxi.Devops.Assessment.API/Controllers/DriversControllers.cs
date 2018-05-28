using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.API.Controllers
{
    [Route("api/drivers")]
    public class DriversController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DriversController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            return _unitOfWork.Drivers.GetAll();
        }

        [HttpGet("admin/{id}")]
        public IEnumerable<Driver> GetAdminVehicles(int adminId)
        {
            return _unitOfWork.Drivers.GetDriverByAdministrator(adminId);
        }

        // GET api/drivers/5
        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            return _unitOfWork.Drivers.Get(id);
        }
    }
}