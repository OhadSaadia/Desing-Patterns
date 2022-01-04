using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.ChainOfResponsibility
{
    class ElectricianFix : GarageFix
    {
        public override void FixRequest(CarProblemsEnum carProblem)
        {

            if (carProblem == CarProblemsEnum.ElectricityProblem)
            {
                Console.WriteLine("Car Has Fixed By Electrician");
            }
            else
            {
                next.FixRequest(carProblem);
            }
        }
    }
}
