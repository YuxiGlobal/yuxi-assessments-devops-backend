using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Yuxi.Devops.Assessment.Core.Companies;
using Yuxi.Devops.Assessment.Core.Repositories;

namespace Yuxi.Devops.Assessment.API.Controllers
{
    [Route("api/companies")]
    public class CompaniesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _unitOfWork.Companies.GetAll();
        }

        // GET api/companies/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return _unitOfWork.Companies.Get(id);
        }
    }
}