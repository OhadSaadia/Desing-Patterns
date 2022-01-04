using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.ChainOfResponsibility
{
    class ExpertFix : GarageFix
    {
        public override void FixRequest(CarProblemsEnum carProblem)
        {

            if (carProblem == CarProblemsEnum.ExpertProblem)
            {
                Console.WriteLine("Car Has Fixed By Expert");
            }
            else
            {
                Console.WriteLine("Car Is Total Lost");
            }
        }
    }
}
