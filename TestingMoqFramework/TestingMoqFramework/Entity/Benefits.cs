using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMoqFramework.Model
{
    class Benefits
    {
        public int BenefitGrade { get; set; }

        public List<string> BasicBenefits { get; set; }

        public List<string> AdditionalBenefits { get; set; }
    }
}
