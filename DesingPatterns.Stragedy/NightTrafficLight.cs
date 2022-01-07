using System;

namespace DesingPatterns.Strategy
{
    class NightTrafficLight : ITrafficLight
    {
        public void Operator()
        {
            Console.WriteLine("Traffic Light: Night\nYellow Light");
        }
    }

}
