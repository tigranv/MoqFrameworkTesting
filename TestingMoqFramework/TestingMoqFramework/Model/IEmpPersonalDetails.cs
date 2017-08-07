using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    public interface  IEmpPersonalDetails
    {
        int GraduityEligibleCount { get; set; }

        bool IsValidEmail(string email);

        void SaveEmployee(Employee employee);

        void AddEmployeeDetails(List<Employee> employees);

        Employee GetEmployeeDetails(int empId);

        int GetEmployeeGrade(int empId);

        float GetEmployeeSalary(int empId);

        float CalculateYearEndBonus(int empId, int noOfMonthsServed);

        bool CalculatePfEligibility(IEmpPfDetails pfDetails, int empId);

        int GetDurationWorked(int empId);
    }
}
