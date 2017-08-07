using System;
using NUnit.Framework;
using TestingMoqFramework.Model;

namespace EmployeeTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            var pfDetails = new EmpPfDetails(new EmpPersonalDetails());

            //Act
            var contrib = pfDetails.GetPfEmployerControlSofar(1);

            //Assert

            Assert.That(contrib, Is.EqualTo(3456), "Its not as expected");
        }
    }
}
