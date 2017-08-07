using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    public class EmpPersonalDetails : IEmpPersonalDetails
    {
        public int GraduityEligibleCount { get; set; }

        private readonly EmployeeEntity _employeeEntity;

        public EmpPersonalDetails()
        {
            _employeeEntity = new EmployeeEntity();
        }


        public float GetEmployeeSalary(int empId)
        {
            //Get the Employee salary with the id passed
            var salary = (from e in _employeeEntity.EmployeesCollection
                where e.EmpId == empId
                select e.Salary).FirstOrDefault();

            //Return Salary
            return salary;
        }


        public void SaveEmployee(Employee employee)
        {
            //Save an Employee into the inmemory collection of List
            _employeeEntity.EmployeesCollection.Add(employee);
        }


        public void AddEmployeeDetails(List<Employee> employees)
        {
            //Saves all the employee into the collection, but will be destroyed 
            //once the execution is closed
            foreach (var employee in employees)
            {
                SaveEmployee(employee);
            }
        }




        public Employee GetEmployeeDetails(int empId)
        {
            return (from e in _employeeEntity.EmployeesCollection
                where e.EmpId == empId
                select e).FirstOrDefault();
        }


        public int GetDurationWorked(int empId)
        {
            var duration = (from e in _employeeEntity.EmployeesCollection
                where e.EmpId == empId
                select e.DurationWorked).FirstOrDefault();

            //Return duration
            return duration;
        }

        public float CalculateYearEndBonus(int empId, int noOfMonthsServed)
        {
            int fixedbonus = 0;
            //If less than 6 months, bonus is ZERO
            if (noOfMonthsServed >= 6)
                fixedbonus = 500;

            //Return Salary + fixedbonus
            return (GetEmployeeSalary(empId) + fixedbonus);
        }

        public bool CalculatePfEligibility(IEmpPfDetails pfDetails, int empId)
        {
            if (pfDetails.IsPfEligible(empId))
                return true;
            else
                return false;
        }

        //public bool CalculatePfEligibilityFromService(EmpPFService.IEmpPfDetails pfDetails, int empId)
        //{
        //    if (pfDetails.IsPfEligible(empId))
        //        return true;
        //    else
        //        return false;
        //}

        public int GetEmployeeGrade(int empId)
        {
            return (from e in _employeeEntity.EmployeesCollection
                where e.EmpId == empId
                select e.Grade).FirstOrDefault();
        }

        public bool IsValidEmail(string email)
        {
            if (email.Contains("executeautomation.com"))
                return true;
            else
                return false;
        }
    }
}
