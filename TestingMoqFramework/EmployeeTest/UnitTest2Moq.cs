using System;
using Moq;
using NUnit.Framework;
using TestingMoqFramework.Model;

namespace EmployeeTest
{
    [TestFixture]
    public class UnitTest2Moq
    {
        [Test]
        public void TestMethodMoq()
        {
            //Arrange
            var moqPersonalDetails = new Mock<IEmpPersonalDetails>();

            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);

            //Act
            pfDetails.GetPfEmployerControlSofar(It.IsAny<int>());

            //Assert
            moqPersonalDetails.Verify();
        }
    }
}
