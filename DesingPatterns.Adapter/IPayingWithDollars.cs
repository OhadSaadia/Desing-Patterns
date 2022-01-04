using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    interface IPayingWithDollars 
    {
        void Pay(double amount);
    }
}
