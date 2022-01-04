using System;

namespace DesingPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageFix simpleWorkerFix = new SimpleWorkerFix();
            GarageFix mechanicFix = new MechanicFix();
            GarageFix electricianFix = new ElectricianFix();
            GarageFix expertFix = new ExpertFix();

            simpleWorkerFix.SetNext(mechanicFix);
            mechanicFix.SetNext(electricianFix);
            electricianFix.SetNext(expertFix);
            expertFix.SetNext(null);

            int numberOfProblem = new Random().Next(4);
            Console.WriteLine($"Problem Severity: {(CarProblemsEnum)numberOfProblem}\n\n");

            Console.WriteLine("Start Handling...\n\n");

            simpleWorkerFix.FixRequest((CarProblemsEnum)numberOfProblem);


        }
    }
}
