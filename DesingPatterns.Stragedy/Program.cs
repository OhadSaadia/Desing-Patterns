using System;

namespace DesingPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLightManager trafficLightManager = new TrafficLightManager();
            DateTime time = DateTime.Now;
            trafficLightManager.Operator(time);
        }

     
    }
}
