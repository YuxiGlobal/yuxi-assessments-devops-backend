using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Yuxi.Devops.Assessment.API.Controllers;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Repositories;
using Yuxi.Devops.Assessment.Core.Shared;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.UnitTests.Controllers
{
    [TestClass]
    public class DriversControllerTests
    {
        private IDriverRepository _repositoryMock;
        private IUnitOfWork _unitOfWorkMock;


        [TestInitialize]
        public void TestSetup()
        {
            _repositoryMock = Substitute.For<IDriverRepository>();
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
        }

        [TestMethod]
        public void SearchDriverTest()
        {
            var id = 123;
            var driver = GetEmptyDriver(id);

            _repositoryMock.Get(Arg.Any<long>()).Returns(driver);
            _unitOfWorkMock.Drivers.Returns(_repositoryMock);

            var controller = new DriversController(_unitOfWorkMock);

            var response = controller.Get(id);

            Assert.AreEqual(driver.Code, response.Code);
        }

        [TestMethod]
        public void ListDriversByAdminTest()
        {
            var listResponse = new List<Driver>();
            var driver = GetEmptyDriver(123);
            listResponse.Add(driver);

            _repositoryMock.GetDriverByAdministrator(Arg.Any<long>()).Returns(listResponse);
            _unitOfWorkMock.Drivers.Returns(_repositoryMock);

            var controller = new DriversController(_unitOfWorkMock);

            var output = controller.GetAdminVehicles(123);

            CollectionAssert.AreEquivalent(listResponse, output.ToList());
        }

        private static Driver GetEmptyDriver(int id)
        {
            var driver = new Driver()
            {
                Code = id,
                DrivingLicense = new DrivingLicense() { Category = string.Empty, Code = 12, Description = string.Empty, Drivers = new List<Driver>() },
                DrivingLicenseCode = new int(),
                Person = new Person() { Code = 22, Drivers = new List<Driver>(), Email = string.Empty, Identification = string.Empty, IdentificationType = new IdentificationType() { Code = 333, Acronym = string.Empty, Name = string.Empty, Persons = new List<Person>() }, IdentificationTypeCode = new int(), LastName = string.Empty, Mobile = new long(), Name = string.Empty, VehiclesAsAdministrator = new List<Vehicle>(), VehiclesAsOwner = new List<Vehicle>() },
                PersonCode = new long(),
                Vehicles = new List<Vehicle>()
            };

            return driver;
        }

    }
}
