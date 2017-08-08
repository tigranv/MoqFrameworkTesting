using System;
using System;
using Moq;
using NUnit.Framework;
using TestingMoqFramework.Model;
using System.Collections.Generic;

namespace EmployeeTest
{
    [TestFixture()]
    class UnitTestMatchingTracking
    {
        [Test]
        public void TestMethodMatchingTracking()
        {
            Employee employee = new Employee()
            {
                EmpId = 1,
                Name = "Karthik",
                Salary = 4000,
                DurationWorked = 24,
                Grade = 1,
                Email = "karthik@executeautomation.com"
            };


            //Arrange
            var moqPersonaldetail = new Mock<IEmpPersonalDetails>();

            moqPersonaldetail.Setup(x => x.IsValidEmail(It.IsAny<string>()));

            var empDetail = new EmployeesDetails(moqPersonaldetail.Object);

            //Act
            empDetail.GetEmployeeValidEmailAddress(employee);

            //Assert

            moqPersonaldetail.Verify(x => x.IsValidEmail(It.Is<string>(fu => fu.Equals(employee.Email, StringComparison.InvariantCultureIgnoreCase))));


        }
    }
}

