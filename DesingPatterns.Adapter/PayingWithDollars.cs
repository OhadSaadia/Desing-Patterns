using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    class PayingWithDollars : IPayingWithDollars
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"{amount} Dollars Has Paid ");
        }
    }
}
