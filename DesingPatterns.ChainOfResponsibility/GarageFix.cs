using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.ChainOfResponsibility
{
    abstract class GarageFix
    {
        protected GarageFix next;

        public void SetNext(GarageFix next)
        {
            this.next = next;
        }

        public abstract void FixRequest(CarProblemsEnum carProblem);

    }
}
