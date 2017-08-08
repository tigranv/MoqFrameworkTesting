using System;
using System;
using Moq;
using NUnit.Framework;
using TestingMoqFramework.Model;
using System.Collections.Generic;

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

        [Test]
        public void TestMethodTimes2()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmpId = 1,
                    Name = "Karthik",
                    Salary = 4000,
                    DurationWorked = 24,
                    Grade = 1,
                    Email = "karthik@executeautomation.com"
                },

                new Employee()
                {
                    EmpId = 2,
                    Name = "Prashanth",
                    Salary = 7000,
                    DurationWorked = 30,
                    Grade = 2,
                    Email = "prashanth@executeautomation.com"

                }
            };


            //Arrange
            var moqPersonaldetail = new Mock<IEmpPersonalDetails>();
            var empDetail = new EmployeesDetails(moqPersonaldetail.Object);

            //Act
            empDetail.GetHigherGradeEmployee(employees);

            //Assert

            moqPersonaldetail.Verify(x => x.GetEmployeeDetails(It.IsAny<int>()), Times.Exactly(2));
        }
    }
}
