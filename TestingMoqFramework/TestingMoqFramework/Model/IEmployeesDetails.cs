using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    public interface IEmployeesDetails
    {
        int GetHigherGradeEmployee(List<Employee> employee);

        int GetPfEligibleCandidatesCount(List<Employee> employees);

        string GetEmployeeValidEmailAddress(Employee employee);
    }
}
