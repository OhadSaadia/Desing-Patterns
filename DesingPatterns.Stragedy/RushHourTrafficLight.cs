using System;

namespace DesingPatterns.Strategy
{
    class RushHourTrafficLight : ITrafficLight
    {
        public void Operator()
        {
            Console.WriteLine("Traffic Light: Rush Hour\nChanged Every Half Minute");
        }
    }

}
