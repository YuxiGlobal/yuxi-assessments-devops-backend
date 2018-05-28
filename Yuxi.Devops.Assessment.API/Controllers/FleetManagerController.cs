using Microsoft.AspNetCore.Mvc;
using Yuxi.Devops.Assessment.Core.FleetManagers;
using Yuxi.Devops.Assessment.Core.Repositories;

namespace Yuxi.Devops.Assessment.API.Controllers
{
    [Produces("application/json")]
    [Route("api/fleet/manager")]
    public class FleetManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FleetManagerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/drivers/5
        [HttpGet("phone/{phoneNumber}")]
        public FleetManager GetByPhoneNumber(long phoneNumber)
        {
            return _unitOfWork.FleetManagers.GetFleetManagerByPhoneNumber(phoneNumber);
        }
    }
}