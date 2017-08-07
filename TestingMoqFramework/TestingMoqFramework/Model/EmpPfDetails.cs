using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    public class EmpPfDetails : IEmpPfDetails
    {
        private IEmpPersonalDetails _empPersonalDetails;

        public EmpPfDetails(IEmpPersonalDetails empPersonalDetails)
        {
            _empPersonalDetails = empPersonalDetails;
        }

        public bool IsPfEligible(int empId)
        {
            // If salary is greater than 4000 only then employee is eligible
            if (_empPersonalDetails.GetEmployeeSalary(empId) >= 4000)
                return true;
            else
                return false;
        }



        public float GetPfEmployerControlSofar(int empId)
        {
            //Duration Worked
            int totalDuration = _empPersonalDetails.GetDurationWorked(empId);

            //Salary
            float salary = _empPersonalDetails.GetEmployeeSalary(empId);

            //Salary * 12% of basic (considering basic as 30% of salary)

            //Basic salary
            var basic = (salary * 30) / 100;

            //12% of basic
            var contribution = (basic * 12) / 100;

            return (contribution * totalDuration);
        }

        public float GetPfEmployeeControlSofar(int empId)
        {
            //Duration Worked
            int totalDuration = _empPersonalDetails.GetDurationWorked(empId);

            //Salary
            float salary = _empPersonalDetails.GetEmployeeSalary(empId);

            //Salary * 18% of basic (considering basic as 30% of salary)

            //Basic salary
            var basic = (salary * 30) / 100;

            //18% of basic
            var contribution = (basic * 18) / 100;

            return (contribution * totalDuration);
        }
    }
}
