using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.ChainOfResponsibility
{
    class MechanicFix : GarageFix
    {
        public override void FixRequest(CarProblemsEnum carProblem)
        {

            if (carProblem == CarProblemsEnum.MechanicProblem)
            {
                Console.WriteLine("Car Has Fixed By Mechanic");
            }
            else
            {
                next.FixRequest(carProblem);
            }
        }
    }
}
