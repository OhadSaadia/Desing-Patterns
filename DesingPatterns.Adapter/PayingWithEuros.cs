using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    class PayingWithEuros : IPayingWithEuros
    {
        public void Pay(double amountInDolars)
        {
            Console.WriteLine($"{amountInDolars * 0.89} Euros Has Paid ");
        }
    }
}
