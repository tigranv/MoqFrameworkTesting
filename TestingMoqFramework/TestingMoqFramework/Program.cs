using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingMoqFramework.Model;

namespace TestingMoqFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            int empId = 1;

            //Employee Personal Details 
            EmpPersonalDetails personalDetails = new EmpPersonalDetails();

            Console.WriteLine("Year End bonus for Employee {0} is {1}",
                personalDetails.GetEmployeeDetails(empId).Name, personalDetails.CalculateYearEndBonus(empId, 12));

            Console.WriteLine("Duration Worked by Employee {0} is {1}",
                personalDetails.GetEmployeeDetails(empId).Name, personalDetails.GetDurationWorked(empId));

            //Employee PF
            EmpPfDetails pfDetails = new EmpPfDetails(new EmpPersonalDetails());

            Console.WriteLine("Employer Contribution for Employee {0} is {1}",
                personalDetails.GetEmployeeDetails(empId).Name, pfDetails.GetPfEmployerControlSofar(empId));


            //Employee Benefits
            EmpBenefits empBenefits = new EmpBenefits(new EmpPersonalDetails());
            Console.WriteLine("Benefits of Employee with grade {0} are:",
                personalDetails.GetEmployeeDetails(empId).Grade);

            foreach (var benefit in empBenefits.GetBasicBenefits(empId))
            {
                Console.Write(benefit + "  ");
            }



            Console.Read();
        }
    }
}
