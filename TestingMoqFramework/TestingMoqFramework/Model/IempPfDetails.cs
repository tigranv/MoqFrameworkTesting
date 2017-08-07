using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    public interface IEmpPfDetails
    {
        bool IsPfEligible(int empId);

        float GetPfEmployerControlSofar(int empId);

        float GetPfEmployeeControlSofar(int empId);
    }
}
