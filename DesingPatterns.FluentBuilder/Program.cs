using System;

namespace DesingPatterns.FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentVacationBuilder vacationBuilder = new FluentVacationBuilder();
            Vacation vacation = vacationBuilder.DreamFlight()
                                                .DreamTransportations()
                                                .DreamSleepingArrangements()
                                                .Builde();

            Console.WriteLine("Dream Vacation: \n" + vacation);
        }
    }
}
