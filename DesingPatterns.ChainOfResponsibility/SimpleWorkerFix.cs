using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.ChainOfResponsibility
{
    class SimpleWorkerFix : GarageFix
    {
        public override void FixRequest(CarProblemsEnum carProblem)
        {
            if (carProblem == CarProblemsEnum.EasyDamage)
            {
                Console.WriteLine("Car Has Fixed By Simple Worker");
            }
            else
            {
                next.FixRequest(carProblem);
            }
        }
    }
}
