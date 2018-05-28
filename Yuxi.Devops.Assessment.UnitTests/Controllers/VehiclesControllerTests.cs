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
    public class VehiclesControllerTests
    {
        private IVehicleRepository _repositoryMock;
        private IUnitOfWork _unitOfWorkMock;


        [TestInitialize]
        public void TestSetup()
        {
            _repositoryMock = Substitute.For<IVehicleRepository>();
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
        }

        [TestMethod]
        public void SearchVehicle()
        {
            var existingVehicle = GetEmptyVehicle();

            _repositoryMock.Get(Arg.Any<int>()).Returns(existingVehicle);
            _unitOfWorkMock.Vehicles.Returns(_repositoryMock);


            var controller = new VehiclesController(_unitOfWorkMock);

            var response = controller.GetById(1);

            Assert.AreEqual(existingVehicle.Code, response.Code);
        }

        [TestMethod]
        public void ListVehiclesByAdmin()
        {
            var existingVehicle = GetEmptyVehicle();
            var vehicles = new List<Vehicle>()
            {
                existingVehicle
            };

            _unitOfWorkMock.Vehicles.Returns(_repositoryMock);
            _repositoryMock.GetVehicleByAdministrator(Arg.Any<int>()).Returns(vehicles);

            var controller = new VehiclesController(_unitOfWorkMock);

            IEnumerable<Vehicle> output = controller.GetAdminVehicles(1);

            CollectionAssert.AreEquivalent(vehicles, output.ToList());
        }

        private static Vehicle GetEmptyVehicle()
        {
            var vehicle = new Vehicle()
            {
                Code = default(long),
                Designation = new Designation() { Configuration = string.Empty },
                BodyworkType = new BodyworkType() { Name = string.Empty },
                Administrator = new Person()
                {
                    Code = default(long),
                    IdentificationType = new IdentificationType()
                },
                Driver = new Driver()
                {
                    Person = new Person()
                    {
                        IdentificationType = new IdentificationType()
                    },
                    DrivingLicense = new DrivingLicense()
                }
            };

            return vehicle;
        }

    }
}
