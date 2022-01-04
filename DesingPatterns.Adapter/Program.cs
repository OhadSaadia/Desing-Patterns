using System;

namespace DesingPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = new Random().Next(1000) + new Random().NextDouble();

            IPayingWithDollars payingWithDollars = new PayingWithDollars();
            IPayingWithDollars payingWithEuros = new AdapterEurosToDollars();
            
            Pay(payingWithDollars, amount);
            Pay(payingWithEuros, amount);

        }

        public static void Pay(IPayingWithDollars paying , double amount)
        {
            paying.Pay(amount);
        }
    }
}
