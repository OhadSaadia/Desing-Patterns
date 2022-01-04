using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    class AdapterEurosToDollars : IPayingWithDollars
    {
        private IPayingWithEuros _withEuros = new PayingWithEuros();
        public void Pay(double amount)
        {
            _withEuros.Pay(amount);
        }
    }
}
