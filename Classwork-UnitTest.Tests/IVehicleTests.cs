using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_UnitTest.Tests
{
    public class IVehicleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_IVehicle_ReturnsExpectedResultCar()
        {
            IVehicle vehicle = new Car();

            Assert.AreEqual("The car is driving", vehicle.Driving());
        }

        [Test]
        public void Test_IVehicle_ReturnsExpectedResultBicycle()
        {
            IVehicle vehicle = new Bicycle();

            Assert.AreEqual("The bicycle is driving", vehicle.Driving());
        }
    }
}
