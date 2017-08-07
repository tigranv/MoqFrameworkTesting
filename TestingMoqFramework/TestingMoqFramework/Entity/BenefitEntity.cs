using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    class BenefitEntity
    {
        public List<Benefits> BenefitCollection = new List<Benefits>()
        {
            new Benefits()
            {
                BenefitGrade = 1,
                BasicBenefits = new List<string> { "Hospital", "Gym", "Dental" },
                AdditionalBenefits = new List<string> {"Car", "DriverHire", "HolidayClaim"}
            },

            new Benefits()
            {
                BenefitGrade = 2,
                BasicBenefits = new List<string> {"Hospital", "Gym", "Dental"},
                AdditionalBenefits = new List<string> {"Car", "DriverHire"}
            },

            new Benefits()
            {
                BenefitGrade = 3,
                BasicBenefits = new List<string> {"Hospital", "Dental"},
                AdditionalBenefits = new List<string> {"Car"}
            },

            new Benefits()
            {
                BenefitGrade = 4,
                BasicBenefits = new List<string> {"Hospital"},
                AdditionalBenefits = new List<string> {"Bike"}
            }
        };
    }
}
