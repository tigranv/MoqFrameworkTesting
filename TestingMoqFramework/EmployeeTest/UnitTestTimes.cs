using System;
using System;
using Moq;
using NUnit.Framework;
using TestingMoqFramework.Model;

namespace EmployeeTest
{
    [TestFixture]
    class UnitTestTimes
    {
        [Test]
        public void TestMethodTimes()
        {
            //Arrange
            var moqPersonaldetail = new Mock<IEmpPersonalDetails>();
            var pfDetail = new EmpPfDetails(moqPersonaldetail.Object);

            //Act
            pfDetail.IsPfEligible(It.IsAny<int>());

            //Assert
            moqPersonaldetail.Verify(x => x.GetEmployeeSalary(It.IsAny<int>()), Times.Exactly(1));
        }
    }
}
