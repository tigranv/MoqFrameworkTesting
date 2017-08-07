using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    public class EmpBenefits : IEmpBenefits
    {
        private readonly IEmpPersonalDetails _empPersonalDetails;

        private readonly BenefitEntity _benefitEntity;


        public EmpBenefits(IEmpPersonalDetails empPersonalDetails)
        {
            _empPersonalDetails = empPersonalDetails;
            _benefitEntity = new BenefitEntity();
        }


        public List<string> GetBasicBenefits(int empId)
        {
            //Get the grade of employee
            var grade = _empPersonalDetails.GetEmployeeGrade(empId);

            //Get the basic benefits from the collection
            return _benefitEntity.BenefitCollection.Where(x => x.BenefitGrade == grade)
                .Select(x => x.BasicBenefits).FirstOrDefault().ToList();
        }

        public List<string> GetAdditionalBenefits(int empId)
        {
            //Get the grade of employee
            var grade = _empPersonalDetails.GetEmployeeGrade(empId);

            //Get the additional benefits from the collection
            return _benefitEntity.BenefitCollection.Where(x => x.BenefitGrade == grade)
                .Select(x => x.AdditionalBenefits).FirstOrDefault().ToList();
        }

        public int GetTotalBenefitsCount(int empId)
        {
            //Get the grade of employee
            var grade = _empPersonalDetails.GetEmployeeGrade(empId);

            var basicBenefits = _benefitEntity.BenefitCollection.Where(x => x.BenefitGrade == grade)
                .Select(x => x.BasicBenefits).FirstOrDefault().ToList();

            var additionalBenefits = _benefitEntity.BenefitCollection.Where(x => x.BenefitGrade == grade)
                .Select(x => x.AdditionalBenefits).FirstOrDefault().ToList();

            //Add both the Basic and Additional benefits and return the count
            return basicBenefits.Count + additionalBenefits.Count;
        }
    }
}
