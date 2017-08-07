using System;
using Moq;
using NUnit.Framework;
using TestingMoqFramework.Model;

namespace EmployeeTest
{
    [TestFixture]
    class UnitTestReturnValue
    {
        [Test]
        public void TestMethodReturnValue()
        {
            //Arrange
            var moqPersonalDetails = new Mock<IEmpPersonalDetails>();

            moqPersonalDetails.Setup(x => x.GetEmployeeSalary(It.IsAny<int>())).Returns(() => 5000);

            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);

            //Act
            var isEligible = pfDetails.IsPfEligible(It.IsAny<int>());

            //Assert
            Assert.IsTrue(isEligible, "Should be true");


        }
    }
}
