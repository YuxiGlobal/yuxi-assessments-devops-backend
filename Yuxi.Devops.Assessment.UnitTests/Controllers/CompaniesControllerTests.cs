using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Yuxi.Devops.Assessment.API.Controllers;
using Yuxi.Devops.Assessment.Core.Companies;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Shared;

namespace Yuxi.Devops.Assessment.UnitTests.Controllers
{
    [TestClass]
    public class CompaniesControllerTests
    {
        private ICompanyRepository _repositoryMock;
        private IUnitOfWork _unitOfWorkMock;


        [TestInitialize]
        public void TestSetup()
        {
            _repositoryMock = Substitute.For<ICompanyRepository>();
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
        }

        [TestMethod]
        public void SearchCompany()
        {
            var existingCompany = GetEmptyCompany();

            _repositoryMock.Get(Arg.Any<long>()).Returns(existingCompany);
            _unitOfWorkMock.Companies.Returns(_repositoryMock);

            var controller = new CompaniesController(_unitOfWorkMock);

            var response = controller.Get(1);

            Assert.AreEqual(existingCompany.Code, response.Code);
        }

        [TestMethod]
        public void ListCompanies()
        {
            var testList = new List<Company>();

            var existingCompany = new Company()
            {
                Code = 123,
                Name = string.Empty,
                CompanyVehicles = new List<CompanyVehicle>()
            };

            testList.Add(existingCompany);
            
            _repositoryMock.GetAll().Returns(testList);
            _unitOfWorkMock.Companies.Returns(_repositoryMock);

            var controller = new CompaniesController(_unitOfWorkMock);
            var output = controller.Get();

            CollectionAssert.AreEquivalent(testList, output.ToList());
        }

        private static Company GetEmptyCompany()
        {
            var existingCompany = new Company()
            {
                Code = 123,
                Name = string.Empty,
                CompanyVehicles = new List<CompanyVehicle>()
            };


            return existingCompany;
        }

    }
}
