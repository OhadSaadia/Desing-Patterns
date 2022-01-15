using System;

namespace DesingPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VacationBuilder lowCostVacationBuilder = new LowCostVacation();
            lowCostVacationBuilder.ConstructVacation();
            Vacation lowCostVacation = lowCostVacationBuilder.GetVacation();

            VacationBuilder dreamVacationBuilder = new DreamVacation();
            dreamVacationBuilder.ConstructVacation();
            Vacation dreamVacation = dreamVacationBuilder.GetVacation();

            Console.WriteLine("Low Cost " + lowCostVacation );
            Console.WriteLine("Dream " + dreamVacation);
        }
    }
}
